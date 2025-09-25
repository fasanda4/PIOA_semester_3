using System;
using System.Globalization;
using System.Windows.Forms;
using ComplexNumbers; // библиотека с классом ComplexNumber

namespace ComplexNumbers.Demo
{
    public partial class ComplexCalculatorForm : Form
    {
        public ComplexCalculatorForm()
        {
            // инициализация всех элементов формы 
            InitializeComponent();
        }

        // читаю только первое число из текстбокса
        private bool TryReadFirst(out ComplexNumber z1)
        {
            z1 = new ComplexNumber(0.0, 0.0);
            ComplexNumber parsed;

            // проверяю, получилось ли разобрать строку
            if (!ComplexNumber.TryParse(this.txtFirstComplex.Text, out parsed))
            {
                MessageBox.Show("Некорректный формат первого числа. Примеры: 3-4i, 2, -1.5+2.2i, i.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            z1 = parsed;
            return true;
        }

        // читаю сразу два числа (для сложения, деления и т.д.)
        private bool TryReadBoth(out ComplexNumber z1, out ComplexNumber z2)
        {
            z1 = new ComplexNumber(0.0, 0.0);
            z2 = new ComplexNumber(0.0, 0.0);

            if (!TryReadFirst(out z1)) return false; // если первое число неправильное, дальше нет смысла

            ComplexNumber parsed2;
            if (!ComplexNumber.TryParse(this.txtSecondComplex.Text, out parsed2))
            {
                MessageBox.Show("Некорректный формат второго числа. Примеры: 1+i, -2i, 5.2-0.1i.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            z2 = parsed2;
            return true;
        }

        // отдельный метод для вывода результата в текстбокс
        private void ShowResult(string text)
        {
            this.txtResult.Text = text;
        }

        // ==== обработчики кнопок ====

        private void OnAdd(object sender, EventArgs e)
        {
            // сложение комплексных чисел
            ComplexNumber z1, z2;
            if (!TryReadBoth(out z1, out z2)) return;

            ComplexNumber r = z1 + z2;
            ShowResult(string.Format("{0} + {1} = {2}", z1, z2, r));
        }

        private void OnSubtract(object sender, EventArgs e)
        {
            // вычитание
            ComplexNumber z1, z2;
            if (!TryReadBoth(out z1, out z2)) return;

            ComplexNumber r = z1 - z2;
            ShowResult(string.Format("{0} - {1} = {2}", z1, z2, r));
        }

        private void OnMultiply(object sender, EventArgs e)
        {
            // умножение
            ComplexNumber z1, z2;
            if (!TryReadBoth(out z1, out z2)) return;

            ComplexNumber r = z1 * z2;
            ShowResult(string.Format("{0} × {1} = {2}", z1, z2, r));
        }

        private void OnDivide(object sender, EventArgs e)
        {
            // деление (проверка на ноль внутри ComplexNumber)
            try
            {
                ComplexNumber z1, z2;
                if (!TryReadBoth(out z1, out z2)) return;

                ComplexNumber r = z1 / z2;
                ShowResult(string.Format("{0} ÷ {1} = {2}", z1, z2, r));
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnConjugateFirst(object sender, EventArgs e)
        {
            // нахожу сопряжённое к первому числу
            ComplexNumber z1;
            if (!TryReadFirst(out z1)) return;

            ComplexNumber c = z1.Conjugate();
            ShowResult(string.Format("Сопряжённое к {0}: {1}", z1, c));
        }

        private void OnMagnitudeFirst(object sender, EventArgs e)
        {
            // модуль первого числа
            ComplexNumber z1;
            if (!TryReadFirst(out z1)) return;

            double m = z1.Magnitude();
            ShowResult(string.Format("Модуль |{0}| = {1}", z1, m.ToString("G6", CultureInfo.CurrentCulture)));
        }

        private void OnArgumentFirst(object sender, EventArgs e)
        {
            // аргумент (угол) первого числа
            ComplexNumber z1;
            if (!TryReadFirst(out z1)) return;

            double a = z1.Argument();
            ShowResult(string.Format("Аргумент Arg({0}) = {1} рад", z1, a.ToString("G6", CultureInfo.CurrentCulture)));
        }

        private void OnNthRootsFirst(object sender, EventArgs e)
        {
            // нахожу все n-е корни из первого числа
            ComplexNumber z1;
            if (!TryReadFirst(out z1)) return;

            int n = (int)this.nudRootDegree.Value;
            this.lstRootsOutput.Items.Clear();

            try
            {
                int count = 0;
                foreach (ComplexNumber root in z1.NthRoots(n))
                {
                    this.lstRootsOutput.Items.Add(string.Format("k={0}: {1}", count, root));
                    count++;
                }
                ShowResult(string.Format("Найдено {0} корней {1}-й степени для {2}.", count, n, z1));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

