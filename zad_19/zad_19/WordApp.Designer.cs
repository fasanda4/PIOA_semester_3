namespace zad_19
{
    partial class WordApp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createATitlePage = new System.Windows.Forms.Button();
            this.TypeDocument = new System.Windows.Forms.ComboBox();
            this.workType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.topicOfWork = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nameOfTheDiscipline = new System.Windows.Forms.TextBox();
            this.teacher = new System.Windows.Forms.TextBox();
            this.createADocument = new System.Windows.Forms.Button();
            this.CitiesLabel = new System.Windows.Forms.Label();
            this.CitiesName = new System.Windows.Forms.ComboBox();
            this.refreshCitiesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вид отчетного документа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вид работы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Преподаватель";
            // 
            // createATitlePage
            // 
            this.createATitlePage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createATitlePage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createATitlePage.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.createATitlePage.Location = new System.Drawing.Point(199, 446);
            this.createATitlePage.Name = "createATitlePage";
            this.createATitlePage.Size = new System.Drawing.Size(172, 102);
            this.createATitlePage.TabIndex = 15;
            this.createATitlePage.Text = "Создать титульный лист";
            this.createATitlePage.UseVisualStyleBackColor = false;
            this.createATitlePage.Click += new System.EventHandler(this.CreateATitle_Click);
            // 
            // TypeDocument
            // 
            this.TypeDocument.FormattingEnabled = true;
            this.TypeDocument.Location = new System.Drawing.Point(31, 107);
            this.TypeDocument.Name = "TypeDocument";
            this.TypeDocument.Size = new System.Drawing.Size(202, 33);
            this.TypeDocument.TabIndex = 16;
            // 
            // workType
            // 
            this.workType.FormattingEnabled = true;
            this.workType.Location = new System.Drawing.Point(325, 107);
            this.workType.Name = "workType";
            this.workType.Size = new System.Drawing.Size(202, 33);
            this.workType.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Номер работы";
            // 
            // number
            // 
            this.number.FormattingEnabled = true;
            this.number.Location = new System.Drawing.Point(31, 205);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(202, 33);
            this.number.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Тема работы";
            // 
            // topicOfWork
            // 
            this.topicOfWork.Location = new System.Drawing.Point(325, 208);
            this.topicOfWork.Name = "topicOfWork";
            this.topicOfWork.Size = new System.Drawing.Size(202, 30);
            this.topicOfWork.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Наименование дисциплины";
            // 
            // nameOfTheDiscipline
            // 
            this.nameOfTheDiscipline.Location = new System.Drawing.Point(31, 289);
            this.nameOfTheDiscipline.Name = "nameOfTheDiscipline";
            this.nameOfTheDiscipline.Size = new System.Drawing.Size(202, 30);
            this.nameOfTheDiscipline.TabIndex = 23;
            // 
            // teacher
            // 
            this.teacher.Location = new System.Drawing.Point(325, 289);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(202, 30);
            this.teacher.TabIndex = 24;
            // 
            // createADocument
            // 
            this.createADocument.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createADocument.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createADocument.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.createADocument.Location = new System.Drawing.Point(746, 547);
            this.createADocument.Name = "createADocument";
            this.createADocument.Size = new System.Drawing.Size(178, 102);
            this.createADocument.TabIndex = 26;
            this.createADocument.Text = "Создать индивидуальный документ";
            this.createADocument.UseVisualStyleBackColor = false;
            this.createADocument.Click += new System.EventHandler(this.CreateAIndividualDocument_Click);
            // 
            // CitiesLabel
            // 
            this.CitiesLabel.AutoSize = true;
            this.CitiesLabel.Location = new System.Drawing.Point(240, 379);
            this.CitiesLabel.Name = "CitiesLabel";
            this.CitiesLabel.Size = new System.Drawing.Size(69, 25);
            this.CitiesLabel.TabIndex = 28;
            this.CitiesLabel.Text = "Город";
            // 
            // CitiesName
            // 
            this.CitiesName.FormattingEnabled = true;
            this.CitiesName.Location = new System.Drawing.Point(186, 407);
            this.CitiesName.Name = "CitiesName";
            this.CitiesName.Size = new System.Drawing.Size(202, 33);
            this.CitiesName.TabIndex = 29;
            // 
            // refreshCitiesButton
            // 
            this.refreshCitiesButton.Location = new System.Drawing.Point(395, 407);
            this.refreshCitiesButton.Name = "refreshCitiesButton";
            this.refreshCitiesButton.Size = new System.Drawing.Size(132, 33);
            this.refreshCitiesButton.TabIndex = 30;
            this.refreshCitiesButton.Text = "Обновить";
            this.refreshCitiesButton.UseVisualStyleBackColor = true;
            this.refreshCitiesButton.Click += new System.EventHandler(this.RefreshCities_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::zad_19.Properties.Resources.rrr;
            this.pictureBox1.Location = new System.Drawing.Point(611, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // WordApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1099, 699);
            this.Controls.Add(this.refreshCitiesButton);
            this.Controls.Add(this.CitiesName);
            this.Controls.Add(this.CitiesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createADocument);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.nameOfTheDiscipline);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.topicOfWork);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.workType);
            this.Controls.Add(this.TypeDocument);
            this.Controls.Add(this.createATitlePage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "WordApp";
            this.Text = "Задание №19 выполнил: Богомолов В.Н.; Номер варианта: 2; Дата выполнения: 11.11.2" +
    "025";
            this.Load += new System.EventHandler(this.WordApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createATitlePage;
        private System.Windows.Forms.ComboBox TypeDocument;
        private System.Windows.Forms.ComboBox workType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox topicOfWork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nameOfTheDiscipline;
        private System.Windows.Forms.TextBox teacher;
        private System.Windows.Forms.Button createADocument;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CitiesLabel;
        private System.Windows.Forms.ComboBox CitiesName;
        private System.Windows.Forms.Button refreshCitiesButton;
    }
}
