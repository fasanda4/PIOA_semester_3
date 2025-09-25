using System;
using System.Collections.Generic;
using System.Globalization;

namespace ComplexNumbers
{
    // структура для работы с комплексными числами
    // z = a + bi, где a — действительная часть, b — мнимая
    public struct ComplexNumber : IEquatable<ComplexNumber>, IFormattable
    {
        // действительная часть
        public double Real { get; private set; }

        // мнимая часть
        public double Imaginary { get; private set; }

        // конструктор (задаём a и b)
        public ComplexNumber(double real, double imaginary) : this()
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        // нахожу сопряжённое число (меняется знак у мнимой части)
        public ComplexNumber Conjugate()
        {
            return new ComplexNumber(this.Real, -this.Imaginary);
        }

        // модуль |z| = sqrt(a² + b²)
        public double Magnitude()
        {
            return Math.Sqrt(this.Real * this.Real + this.Imaginary * this.Imaginary);
        }

        // аргумент (угол) числа в радианах
        public double Argument()
        {
            return Math.Atan2(this.Imaginary, this.Real);
        }

        // преобразование в полярную форму (выдаю через out)
        public void ToPolar(out double magnitude, out double argument)
        {
            magnitude = Magnitude();
            argument = Argument();
        }

        // создать комплексное число по полярной форме
        public static ComplexNumber FromPolar(double magnitude, double argument)
        {
            return new ComplexNumber(
                magnitude * Math.Cos(argument),
                magnitude * Math.Sin(argument));
        }

        // нахожу все n-е корни по формуле Муавра
        public IEnumerable<ComplexNumber> NthRoots(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException("n", "Степень корня должна быть положительной.");

            double r;
            double theta;
            ToPolar(out r, out theta);

            double rootMagnitude = Math.Pow(r, 1.0 / n);

            for (int k = 0; k < n; k++)
            {
                double angle = (theta + 2.0 * Math.PI * k) / n;
                yield return FromPolar(rootMagnitude, angle);
            }
        }

        // ===== арифметические операции =====

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(
                a.Real * b.Real - a.Imaginary * b.Imaginary,
                a.Real * b.Imaginary + a.Imaginary * b.Real);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double denom = b.Real * b.Real + b.Imaginary * b.Imaginary;
            if (denom == 0.0)
                throw new DivideByZeroException("Деление на нулевое комплексное число.");

            return new ComplexNumber(
                (a.Real * b.Real + a.Imaginary * b.Imaginary) / denom,
                (a.Imaginary * b.Real - a.Real * b.Imaginary) / denom);
        }

        // ===== сравнение и равенство =====

        public bool Equals(ComplexNumber other)
        {
            return this.Real.Equals(other.Real) && this.Imaginary.Equals(other.Imaginary);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ComplexNumber)) return false;
            return Equals((ComplexNumber)obj);
        }

        public override int GetHashCode()
        {
            return this.Real.GetHashCode() ^ (this.Imaginary.GetHashCode() << 2);
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b) { return a.Equals(b); }
        public static bool operator !=(ComplexNumber a, ComplexNumber b) { return !a.Equals(b); }

        // ===== вывод числа в строку =====

        public override string ToString()
        {
            return ToString(null, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            string fmt = format ?? "G";
            IFormatProvider culture = formatProvider ?? CultureInfo.CurrentCulture;

            string r = this.Real.ToString(fmt, culture);
            string iAbs = Math.Abs(this.Imaginary).ToString(fmt, culture);
            string sign = this.Imaginary >= 0 ? "+" : "-";

            return string.Format("{0} {1} {2}i", r, sign, iAbs);
        }

        // ===== разбор строки в комплексное число =====
        // поддерживаются: "a+bi", "a-bi", "a", "bi", "i", "-i"
        public static bool TryParse(string s, out ComplexNumber result)
        {
            result = new ComplexNumber(0.0, 0.0);
            if (string.IsNullOrEmpty(s)) return false;

            string text = s.Trim().Replace(" ", "");
            if (text.Length == 0) return false;

            IFormatProvider culture = CultureInfo.CurrentCulture;

            // случай: только мнимая часть ("i", "-i", "2i")
            if (text.EndsWith("i", StringComparison.OrdinalIgnoreCase))
            {
                string withoutI = text.Substring(0, text.Length - 1);
                if (withoutI.Length == 0 || withoutI == "+" || withoutI == "-")
                {
                    double sign = withoutI == "-" ? -1.0 : 1.0;
                    result = new ComplexNumber(0.0, sign);
                    return true;
                }

                double imagOnly;
                if (double.TryParse(withoutI, NumberStyles.Float, culture, out imagOnly))
                {
                    result = new ComplexNumber(0.0, imagOnly);
                    return true;
                }
            }

            // случай: "a+bi" или "a-bi"
            if (text.EndsWith("i", StringComparison.OrdinalIgnoreCase))
            {
                int plusIndex = text.IndexOf('+', 1);
                int minusIndex = text.IndexOf('-', 1);
                int sep = plusIndex >= 0 ? plusIndex : (minusIndex >= 0 ? minusIndex : -1);

                if (sep > 0)
                {
                    string realPart = text.Substring(0, sep);
                    string imagPartWithSign = text.Substring(sep, text.Length - sep - 1);

                    double rVal, iVal;
                    if (double.TryParse(realPart, NumberStyles.Float, culture, out rVal) &&
                        double.TryParse(imagPartWithSign, NumberStyles.Float, culture, out iVal))
                    {
                        result = new ComplexNumber(rVal, iVal);
                        return true;
                    }
                }
            }

            // если только действительное число
            double realOnly;
            if (double.TryParse(text, NumberStyles.Float, culture, out realOnly))
            {
                result = new ComplexNumber(realOnly, 0.0);
                return true;
            }

            return false;
        }
    }
}
