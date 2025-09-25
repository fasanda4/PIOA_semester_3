using System.Drawing;
using System.Windows.Forms;

namespace ComplexNumbers.Demo
{
    partial class ComplexCalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

       
        private TextBox txtFirstComplex;
        private TextBox txtSecondComplex;

        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;

        private Button btnConjugateFirst;
        private Button btnMagnitudeFirst;
        private Button btnArgumentFirst;

        private Label lblFirstCaption;
        private Label lblSecondCaption;

        private Label lblRootDegreeCaption;
        private NumericUpDown nudRootDegree;
        private Button btnNthRootsFirst;
        private ListBox lstRootsOutput;

        private Label lblResultCaption;
        private TextBox txtResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblFirstCaption = new Label();
            this.txtFirstComplex = new TextBox();
            this.lblSecondCaption = new Label();
            this.txtSecondComplex = new TextBox();

            this.btnAdd = new Button();
            this.btnSubtract = new Button();
            this.btnMultiply = new Button();
            this.btnDivide = new Button();

            this.btnConjugateFirst = new Button();
            this.btnMagnitudeFirst = new Button();
            this.btnArgumentFirst = new Button();

            this.lblRootDegreeCaption = new Label();
            this.nudRootDegree = new NumericUpDown();
            this.btnNthRootsFirst = new Button();
            this.lstRootsOutput = new ListBox();

            this.lblResultCaption = new Label();
            this.txtResult = new TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.nudRootDegree)).BeginInit();
            this.SuspendLayout();

            

            // lblFirstCaption
            this.lblFirstCaption.AutoSize = true;
            this.lblFirstCaption.Location = new Point(12, 12);
            this.lblFirstCaption.Name = "lblFirstCaption";
            this.lblFirstCaption.Size = new Size(325, 13);
            this.lblFirstCaption.Text = "Первое число (например: 3-4i, 2, -1.5+2.2i, i):";

            // txtFirstComplex
            this.txtFirstComplex.Location = new Point(12, 32);
            this.txtFirstComplex.Name = "txtFirstComplex";
            this.txtFirstComplex.Size = new Size(360, 20);

            // lblSecondCaption
            this.lblSecondCaption.AutoSize = true;
            this.lblSecondCaption.Location = new Point(12, 68);
            this.lblSecondCaption.Name = "lblSecondCaption";
            this.lblSecondCaption.Size = new Size(228, 13);
            this.lblSecondCaption.Text = "Второе число (для бинарных операций):";

            // txtSecondComplex
            this.txtSecondComplex.Location = new Point(12, 88);
            this.txtSecondComplex.Name = "txtSecondComplex";
            this.txtSecondComplex.Size = new Size(360, 20);

            // Кнопки бинарных операций (1-й ряд)
            // btnAdd
            this.btnAdd.Location = new Point(12, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(200, 32);
            this.btnAdd.Text = "Сложение (z1 + z2)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAdd);

            // btnSubtract
            this.btnSubtract.Location = new Point(224, 124);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new Size(200, 32);
            this.btnSubtract.Text = "Вычитание (z1 − z2)";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.OnSubtract);

            // btnMultiply
            this.btnMultiply.Location = new Point(436, 124);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new Size(200, 32);
            this.btnMultiply.Text = "Умножение (z1 × z2)";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OnMultiply);

            // btnDivide
            this.btnDivide.Location = new Point(648, 124);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new Size(200, 32);
            this.btnDivide.Text = "Деление (z1 ÷ z2)";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OnDivide);

            // Операции над z1 (2-й ряд)
            // btnConjugateFirst
            this.btnConjugateFirst.Location = new Point(12, 172);
            this.btnConjugateFirst.Name = "btnConjugateFirst";
            this.btnConjugateFirst.Size = new Size(200, 32);
            this.btnConjugateFirst.Text = "Сопряжение z1̄";
            this.btnConjugateFirst.UseVisualStyleBackColor = true;
            this.btnConjugateFirst.Click += new System.EventHandler(this.OnConjugateFirst);

            // btnMagnitudeFirst
            this.btnMagnitudeFirst.Location = new Point(224, 172);
            this.btnMagnitudeFirst.Name = "btnMagnitudeFirst";
            this.btnMagnitudeFirst.Size = new Size(200, 32);
            this.btnMagnitudeFirst.Text = "Модуль |z1|";
            this.btnMagnitudeFirst.UseVisualStyleBackColor = true;
            this.btnMagnitudeFirst.Click += new System.EventHandler(this.OnMagnitudeFirst);

            // btnArgumentFirst
            this.btnArgumentFirst.Location = new Point(436, 172);
            this.btnArgumentFirst.Name = "btnArgumentFirst";
            this.btnArgumentFirst.Size = new Size(200, 32);
            this.btnArgumentFirst.Text = "Аргумент Arg(z1)";
            this.btnArgumentFirst.UseVisualStyleBackColor = true;
            this.btnArgumentFirst.Click += new System.EventHandler(this.OnArgumentFirst);

            // lblRootDegreeCaption
            this.lblRootDegreeCaption.AutoSize = true;
            this.lblRootDegreeCaption.Location = new Point(12, 220);
            this.lblRootDegreeCaption.Name = "lblRootDegreeCaption";
            this.lblRootDegreeCaption.Size = new Size(95, 13);
            this.lblRootDegreeCaption.Text = "Степень корня n:";

            // nudRootDegree
            this.nudRootDegree.Location = new Point(120, 218);
            this.nudRootDegree.Name = "nudRootDegree";
            this.nudRootDegree.Size = new Size(80, 20);
            this.nudRootDegree.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudRootDegree.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            this.nudRootDegree.Value = new decimal(new int[] { 3, 0, 0, 0 });

            // btnNthRootsFirst
            this.btnNthRootsFirst.Location = new Point(224, 216);
            this.btnNthRootsFirst.Name = "btnNthRootsFirst";
            this.btnNthRootsFirst.Size = new Size(220, 32);
            this.btnNthRootsFirst.Text = "Корни n-й степени для z1";
            this.btnNthRootsFirst.UseVisualStyleBackColor = true;
            this.btnNthRootsFirst.Click += new System.EventHandler(this.OnNthRootsFirst);

            // lstRootsOutput
            this.lstRootsOutput.Location = new Point(12, 252);
            this.lstRootsOutput.Name = "lstRootsOutput";
            this.lstRootsOutput.Size = new Size(620, 212);

            // lblResultCaption
            this.lblResultCaption.AutoSize = true;
            this.lblResultCaption.Location = new Point(12, 476);
            this.lblResultCaption.Name = "lblResultCaption";
            this.lblResultCaption.Size = new Size(66, 13);
            this.lblResultCaption.Text = "Результат:";

            // txtResult
            this.txtResult.Location = new Point(90, 474);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new Size(760, 20);

            // ===== Настройки формы =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(980, 520);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "ComplexCalculatorForm";
            this.Text = "Калькулятор комплексных чисел — ComplexCalculatorForm";

            
            this.Controls.Add(this.lblFirstCaption);
            this.Controls.Add(this.txtFirstComplex);
            this.Controls.Add(this.lblSecondCaption);
            this.Controls.Add(this.txtSecondComplex);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);

            this.Controls.Add(this.btnConjugateFirst);
            this.Controls.Add(this.btnMagnitudeFirst);
            this.Controls.Add(this.btnArgumentFirst);

            this.Controls.Add(this.lblRootDegreeCaption);
            this.Controls.Add(this.nudRootDegree);
            this.Controls.Add(this.btnNthRootsFirst);
            this.Controls.Add(this.lstRootsOutput);

            this.Controls.Add(this.lblResultCaption);
            this.Controls.Add(this.txtResult);

            ((System.ComponentModel.ISupportInitialize)(this.nudRootDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
