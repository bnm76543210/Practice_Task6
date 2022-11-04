using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;

namespace Car_Inspection
{
    /// <summary>
    /// Логика взаимодействия для InspectionData.xaml
    /// </summary>

    public partial class InspectionData : Window
    {

        public InspectionData()
        {
            InitializeComponent();
            FillInspectionTable();
        }
        public int InspectId;

        /// <summary>
        /// Кнопка возврата на главное окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        /// <summary>
        /// Метод заполенения DataGrid окна InspectionData данными из таблицы Inspection базы данных 
        /// </summary>

        public void FillInspectionTable()
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                Inspections.ItemsSource = db.Inspection.ToList();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!");
            }
        }

        /// <summary>
        /// Кнопка из DataGrid окна InspectionData, открывающая окно изменения информации (EditWindow) для изменения данных ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnEditInformation_Click(object sender, RoutedEventArgs e)
        {
            Inspection inspection = (sender as Button).DataContext as Inspection;
            InspectId = inspection.Inspection_id;
            EditWindow editWindow = new EditWindow(this);
            editWindow.ShowDialog();
        }

        /// <summary>
        /// Кнопка показа информации об автомобиле из DataGrid окна InspectionData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ShowCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                Inspection inspection = (sender as Button).DataContext as Inspection;
                string state_number_str = "";
                string Engine_number_str = "";
                string Color_str = "";
                string Brand_str = "";
                string Number_of_passpoert_str = "";
                int OwnerID_str = 0;

                foreach (Car car in db.Car)
                {
                    if (car.Car_id == inspection.CarID)
                    {
                        state_number_str = car.State_number;
                        Engine_number_str = car.Engine_number;
                        Color_str = car.Color;
                        Brand_str = car.Brand;
                        Number_of_passpoert_str = car.Number_of_passport;
                        OwnerID_str = car.OwnerID;
                    }
                }
                MessageBox.Show("Информация о машине\n" + "Гос. номер: " + state_number_str + "\nНомер двигателя: " + Engine_number_str + "\nЦвет: " + Color_str +
                "\nМарка: " + Brand_str + "\nНомер тех. паспорта: " + Number_of_passpoert_str + "\nКод владельца: " + OwnerID_str);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!");
            }
        }

        /// <summary>
        /// Кнопка показа информации о Сотруднике ГАИ из DataGrid окна InspectionData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ShowOfficer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                Inspection inspection = (sender as Button).DataContext as Inspection;

                string FIO_str = "";
                string Post_str = "";
                string Rank_str = "";

                foreach (PoliceOfficer policeOfficer in db.PoliceOfficer)
                {
                    if (policeOfficer.Officer_id == inspection.OfficerID)
                    {
                        FIO_str = policeOfficer.FIO;
                        Post_str = policeOfficer.Post;
                        Rank_str = policeOfficer.Rank;
                    }
                }
                MessageBox.Show("Информация о сотруднике ГАИ\n" + "ФИО: " + FIO_str + "\nДолжность: " + Post_str + "\nЗвание: " + Rank_str);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!");
            }
        }

        /// <summary>
        /// Кнопка удаления информации из DataGrid окна InspectionData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnDeleteInformation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                Inspection inspection;
                inspection = (sender as Button).DataContext as Inspection;
                string message = "Тех. осмотр с под номером " + Convert.ToString(inspection.Inspection_id) + " будет удалён.";
                string caption = "Удаление";
                var result = MessageBox.Show(this, message, caption, MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    foreach (Inspection inspection1 in db.Inspection)
                    {
                        if (inspection1.Inspection_id == inspection.Inspection_id)
                        {
                            db.Inspection.Remove(inspection1);
                        }
                    }               
                    db.SaveChanges();
                    FillInspectionTable();
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!!");
            }
        }

        /// <summary>
        /// Открывает окно EditWindow, изменяя его предназначение на добавление данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AddInspectionData_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow(this);
            editWindow.AddData.Content = "Добавить";
            editWindow.ShowDialog();
        }

        /// <summary>
        /// Сохранение отчёта в pdf файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void PrintInspectionData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                Word.Application app = new Word.Application();
                Word.Document doc = app.Documents.Add();
                Word.Paragraph pardo = doc.Paragraphs.Add();
                doc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                Word.Range pardorange = pardo.Range;
                pardorange.Text = "Отчёт о проведённых тех. осмотрах";
                pardorange.Font.Size = 22;
                pardorange.Font.Name = "Times New Roman";
                pardo.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                pardorange.InsertParagraphAfter();
                Word.Paragraph par = doc.Paragraphs.Add();
                Word.Range range = par.Range;
                Word.Table table = doc.Tables.Add(range, db.Inspection.ToList().Count + 1, 7);
                table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                int rowcount = 1;
                table.Cell(rowcount, 1).Range.Text = "Код тех. осмотра";
                table.Cell(rowcount, 2).Range.Text = "Код автомобиля";
                table.Cell(rowcount, 3).Range.Text = "Номер автомобиля";
                table.Cell(rowcount, 4).Range.Text = "Код сотрудника ГАИ";
                table.Cell(rowcount, 5).Range.Text = "ФИО сотрудника ГАИ";
                table.Cell(rowcount, 6).Range.Text = "Дата инспекции";
                table.Cell(rowcount, 7).Range.Text = "Результат осмотра";
                table.Rows[1].Range.Font.Size = 14;
                table.Rows[1].Range.Bold = 1;
                rowcount++;
                foreach (Inspection inspection in db.Inspection)
                {
                    table.Cell(rowcount, 1).Range.Text = inspection.Inspection_id.ToString();
                    table.Cell(rowcount, 2).Range.Text = inspection.CarID.ToString();
                    foreach (Car car in db.Car)
                    { 
                        if(car.Car_id == inspection.CarID)
                        {
                            table.Cell(rowcount, 3).Range.Text = car.State_number.ToString();
                        }
                    }
                    table.Cell(rowcount, 4).Range.Text = inspection.OfficerID.ToString();
                    foreach (PoliceOfficer policeOfficer in db.PoliceOfficer)
                    {
                        if (policeOfficer.Officer_id == inspection.OfficerID)
                        {
                            table.Cell(rowcount, 5).Range.Text = policeOfficer.FIO.ToString();
                        }
                    }
                    table.Cell(rowcount, 6).Range.Text = inspection.Inspection_date.ToString("dd-MM-yyyy");
                    table.Cell(rowcount, 7).Range.Text = inspection.Result.ToString();
                    rowcount++;
                }
                table.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                table.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
                table.Range.ParagraphFormat.SpaceAfter = 0.0f;
                table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
                table.Range.Font.Name = "Times New Roman";
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = "Data_of_Inspections";
                dlg.DefaultExt = ".pdf";
                dlg.Filter = "PDF document (.pdf)|*.pdf";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    string filename = dlg.FileName;
                    doc.SaveAs2(filename, Word.WdSaveFormat.wdFormatPDF);
                }
                MessageBox.Show("Документ сохранён в формате PDF!");
                app.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }
    }
}
