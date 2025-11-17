using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Microsoft.Office.Interop.Word;

namespace zad_19
{
    public partial class WordApp : Form
    {
        private Word.Application wordApp;
        private Word.Document docTwo;


        private readonly string citiesFilePath =
            System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, @"..\..\Data\cities.txt");

        object ObjMissing = Missing.Value;
        private string[] typeDocument = { "Отчёт", "Реферат", "Эссе", "Курсовой проект",
            "Курсовая работа", "Доклад", "Домашнее задание"};
        private string[] typeOfWork = { "Лабораторная работа", "Практическая работа", "Индивидуальное задание",
            "Учебная практика", "Производственная практика", "Преддипломная практика"};
        private string[] numberOfWork = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        private string[] Cities = { "Москва", "Санкт-Петербург", "Казань", "Орёл", "Чебоксары", "Тверь", "Старый Оскол", "Нижний Новгород" };

        public WordApp()
        {
            InitializeComponent();
            TypeDocument.Items.AddRange(typeDocument);
            workType.Items.AddRange(typeOfWork);
            number.Items.AddRange(numberOfWork);
            CitiesName.Items.AddRange(Cities);   


            LoadCitiesFromFile();
        }



        private void LoadCitiesFromFile()
        {
            try
            {
                if (!File.Exists(citiesFilePath))
                {
                    
                    return;
                }

                var lines = File.ReadAllLines(citiesFilePath, Encoding.UTF8)
                                .Select(s => s.Trim())
                                .Where(s => !string.IsNullOrEmpty(s))
                                .Distinct()
                                .ToArray();

                CitiesName.BeginUpdate();
                CitiesName.Items.Clear();
                CitiesName.Items.AddRange(lines);
                CitiesName.EndUpdate();

               
                if (CitiesName.Items.Count > 0)
                {
                    CitiesName.SelectedIndex = 0;
                }
                else
                {
                    CitiesName.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить города из файла:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCities_Click(object sender, EventArgs e)
        {

            LoadCitiesFromFile();
        }

        private static void ParagraphText(Paragraph paragraph, string text, int fontSize, string font, string alignment)
        {
            paragraph.Range.Text = text;
            paragraph.Range.Font.Size = fontSize;
            paragraph.Range.Font.Name = font;
            switch (alignment)
            {
                case "Right":
                    paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    break;
                case "Left":
                    paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    break;
                case "Center":
                    paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    break;
                default:
                    break;
            }
            paragraph.Range.InsertParagraphAfter();
        }

        private void CreateATitle_Click(object sender, EventArgs e)
        {
            Word.Document oDoc;
            Word.Paragraph oPr;
            Word.Application oWord = new Word.Application();
            oDoc = oWord.Documents.Add();
            oPr = oDoc.Paragraphs.Add();

            ParagraphText(oPr, "Министерство транспорта Российской Федерации", 14, "Times new roman", "Center");
            ParagraphText(oPr, "Федеральное государственное автономное образовательное", 14, "Times new roman", "Center");
            ParagraphText(oPr, "учреждение высшего образования", 14, "Times new roman", "Center");
            ParagraphText(oPr, "«Российский университет транспорта»", 14, "Times new roman", "Center");
            ParagraphText(oPr, "(ФГАОУ ВО РУТ(МИИТ), РУТ (МИИТ)", 14, "Times new roman", "Center");

            oPr.Range.InsertParagraphAfter();

            ParagraphText(oPr, "Институт транспортной техники и систем управления", 14, "Times new roman", "Center");

            oPr.Range.InsertParagraphAfter();

            ParagraphText(oPr, "Кафедра «Управление и защита информации»", 14, "Times new roman", "Center");

            oPr.Range.InsertParagraphAfter();
            oPr.Range.InsertParagraphAfter();
            oPr.Range.InsertParagraphAfter();
            oPr.Range.InsertParagraphAfter();
            

            string changingText = (TypeDocument.SelectedIndex >= 0 ? TypeDocument.Text : workType.Text) + " №" + number.Text;
            ParagraphText(oPr, changingText, 28, "Times new roman", "Center");

            oPr.Range.InsertParagraphAfter();

            ParagraphText(oPr, $"по дисциплине: «{nameOfTheDiscipline.Text}»", 14, "Times new roman", "Center");

            oPr.Range.InsertParagraphAfter();

            ParagraphText(oPr, $"на тему: «{topicOfWork.Text}»", 14, "Times new roman", "Center");

            oPr.Range.InsertParagraphAfter();
            oPr.Range.InsertParagraphAfter();

            ParagraphText(oPr, "Выполнил: ст. гр. ТУУ-211", 14, "Times new roman", "Right");
            ParagraphText(oPr, "Богомолов В.Н.", 14, "Times new roman", "Right");
            ParagraphText(oPr, "Вариант №2", 14, "Times new roman", "Right");
            ParagraphText(oPr, $"Проверил: {teacher.Text}", 14, "Times new roman", "Right");

            oPr.Range.InsertParagraphAfter();

            ParagraphText(oPr, $"{CitiesName.Text} – 2025 г.", 14, "Times new roman", "Center");

            oDoc.SaveAs2(System.Windows.Forms.Application.StartupPath + "\\Титульный лист.docx");
            oWord.Quit();
        }

        private void CreateAIndividualDocument_Click(object sender, EventArgs e)
        {
            Word.Application oWord2 = new Word.Application();
            Word.Document oDoc2 = oWord2.Documents.Add();
            Word.Paragraph oPr2 = oDoc2.Paragraphs.Add();

            ParagraphText(oPr2, "Утверждена", 10, "Times new roman", "Right");
            ParagraphText(oPr2, "распоряжением Правительства", 10, "Times new roman", "Right");
            ParagraphText(oPr2, "Российской Федерации", 10, "Times new roman", "Right");
            ParagraphText(oPr2, "от 26 мая 2005 г. № 667-р", 10, "Times new roman", "Right");
            ParagraphText(oPr2, "(в ред. от 5 марта 2018 г.) ", 10, "Times new roman", "Right");

            Word.Table table = oDoc2.Tables.Add(oDoc2.Range(113, 113), 4, 5);
            table.Cell(2, 3).Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Cell(3, 3).Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Cell(4, 3).Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Cell(1, 1).Merge(table.Cell(1, 5));
            table.Cell(2, 1).Width = 100;
            table.Cell(3, 1).Width = 100;
            table.Cell(4, 1).Width = 100;
            table.Cell(2, 2).Width = 15;
            table.Cell(3, 2).Width = 15;
            table.Cell(4, 2).Width = 15;
            table.Cell(2, 3).Width = 250;
            table.Cell(3, 3).Width = 250;
            table.Cell(4, 3).Width = 250;
            table.Cell(2, 4).Width = 15;
            table.Cell(3, 4).Width = 15;
            table.Cell(4, 4).Width = 15;
            table.Cell(2, 5).Merge(table.Cell(4, 5));
            table.Cell(2, 5).Borders.Enable = 1;
            string[,] data = {
                {"Анкета", "", "", "",""},
                {"1. Фамилия", "", "", "", ""},
                {"Имя", "", "", "", ""},
                {"Отчество", "", "", "", ""},
            };
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    try
                    {
                        table.Cell(i, j).Range.Text = data[i - 1, j - 1];
                        table.Cell(i, j).Range.Font.Size = 14;
                        table.Cell(i, j).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    catch { }
                }
            }
            table.Cell(2, 5).Range.Text = "Место для фотографии";
            table.Cell(2, 5).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            table.Cell(1, 1).Range.Font.Size = 16;
            table.Cell(1, 1).Range.Bold = 1;

            Word.Paragraph oPr3 = oDoc2.Paragraphs.Add();
            oPr3.Range.InsertParagraphAfter();
            Word.Table newTable = oDoc2.Tables.Add(oPr3.Range, 6, 2);
            string[,] data2 = {
                {"2. Если изменяли фамилию, имя или отчество, то укажите их, а также когда, где и по какой причине изменяли", ""},
                {"3. Число, месяц, год и место рождения (село, деревня, город, район, область, край, республика, страна)", ""},
                {"4. Гражданство (если изменяли, то укажите, когда и по какой причине, если имеете гражданство другого государства – укажите ", ""},
                {"5. Образование (когда и какие учебные заведения окончили, номера дипломов) Направление подготовки или специальность по диплому Квалификация по диплому", ""},
                {"6. Послевузовское профессиональное образование: адьюнктура, докторантура (наименование образовательного или научного учреждения, год окончания)Ученая степень, ученое звание (когда присвоены, номера дипломов, аттестатов)", ""},
                {"7. Какими иностранными языками и языками народов Российской Федерации владеете и в какой степени (читаете и переводите со словарем, читаете и можете объясняться, владеете свободно)", ""},
            };
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    try
                    {
                        newTable.Cell(i, j).Range.Text = data2[i - 1, j - 1];
                        newTable.Cell(i, j).Range.Font.Size = 12;
                        newTable.Cell(i, j).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    }
                    catch { }
                }
            }
            newTable.Borders.Enable = 1;
            newTable.Borders[Word.WdBorderType.wdBorderLeft].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            newTable.Borders[Word.WdBorderType.wdBorderRight].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oDoc2.SaveAs2(System.Windows.Forms.Application.StartupPath + "\\Индивидуальный документ.docx");
            oWord2.Quit();
        }

        private void WordApp_Load(object sender, EventArgs e)
        {

        }
    }
}
