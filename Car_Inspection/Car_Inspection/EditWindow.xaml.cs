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

namespace Car_Inspection
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {

        private InspectionData inspectionDataWindow;

        public EditWindow(InspectionData inspectionData)
        {
            InitializeComponent();
            inspectionDataWindow = inspectionData;
            FillCarComboBox();
            FillOfficerComboBox();
            FillDataInField();
        }

        /// <summary>
        /// Метод заполнения полей при наличии переданного InspectId из InspectionData со значением выше 0
        /// </summary>

        public void FillDataInField()
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                foreach (Inspection inspection1 in db.Inspection)
                {
                    if (inspection1.Inspection_id == inspectionDataWindow.InspectId)
                    {
                        foreach (Car car in db.Car)
                        {
                            if (inspection1.CarID == car.Car_id)
                            {
                                CarComboBox.Text = car.State_number;
                            }
                        }
                        foreach (PoliceOfficer policeOfficer in db.PoliceOfficer)
                        {
                            if (inspection1.OfficerID == policeOfficer.Officer_id)
                            {
                                OfficerComboBox.Text = policeOfficer.FIO;
                            }
                        }
                        DateText.Text = inspection1.Inspection_date.ToString();
                        ResultTextBox.Text = inspection1.Result.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!");
            }
        }

        /// <summary>
        /// Метод заполнения CarComboBox значениями из бд
        /// </summary>

        public void FillCarComboBox()
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                foreach (Car car in db.Car)
                {
                    string name = car.State_number;
                    CarComboBox.Items.Add(name);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!");
            }
        }

        /// <summary>
        /// Метод заполнения OfficerComboBox значениями из бд
        /// </summary>

        public void FillOfficerComboBox()
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                foreach (PoliceOfficer policeOfficer in db.PoliceOfficer)
                {
                    string name = policeOfficer.FIO;
                    OfficerComboBox.Items.Add(name);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!");
            }
        }

        /// <summary>
        /// Метод реализации динамического поиска нужного значения в CarComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void OnComboboxTextChanged1(object sender, RoutedEventArgs e)
        {
            try
            {
                CarComboBox.IsDropDownOpen = true;
                var tb = (TextBox)e.OriginalSource;
                tb.Select(tb.SelectionStart + tb.SelectionLength, 0);
                CollectionView cv = (CollectionView)CollectionViewSource.GetDefaultView(CarComboBox.Items);
                cv.Filter = s =>
                    ((string)s).IndexOf(CarComboBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0;
            }
            catch
            {
                MessageBox.Show("Ошибка работы выбора элементов!");
            }
        }

        /// <summary>
        /// Метод реализации динамического поиска нужного значения в OfficerComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void OnComboboxTextChanged2(object sender, RoutedEventArgs e)
        {
            try
            {
                OfficerComboBox.IsDropDownOpen = true;
                var tb = (TextBox)e.OriginalSource;
                tb.Select(tb.SelectionStart + tb.SelectionLength, 0);
                CollectionView cv = (CollectionView)CollectionViewSource.GetDefaultView(OfficerComboBox.Items);
                cv.Filter = s =>
                    ((string)s).IndexOf(OfficerComboBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0;
            }
            catch
            {
                MessageBox.Show("Ошибка работы выбора элементов!");
            }
        }

        /// <summary>
        /// Метод добавления/изменения данных (в зависимости от текста кнопки AddData)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AddData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                int InspectorID = 0;
                int IdCheck = 0;
                int CountOfRepeatsDate = 0;
                Inspection inspection = new Inspection();

                if (AddData.Content.ToString() == "Изменить")
                {
                    foreach (Inspection inspection1 in db.Inspection)
                    {
                        if (inspection1.Inspection_id == inspectionDataWindow.InspectId)
                        {
                            inspection = inspection1;
                        }
                    }
                }

                if (CarComboBox.Text != "")
                {
                    foreach (Car car in db.Car)
                    {
                        if (car.State_number == CarComboBox.Text)
                        {
                            inspection.CarID = car.Car_id;
                            IdCheck = 1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите номер машины!");
                    return;
                }

                if (IdCheck != 1)
                {
                    MessageBox.Show("Машины с данным номером не существует, перепроверьте данные!");
                    return;
                }

                if (OfficerComboBox.Text != "")
                {
                    foreach (PoliceOfficer policeOfficer in db.PoliceOfficer)
                    {
                        if (policeOfficer.FIO == OfficerComboBox.Text)
                        {
                            inspection.OfficerID = policeOfficer.Officer_id;
                            IdCheck = 0;
                            InspectorID = policeOfficer.Officer_id;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите сотрудника ГАИ!");
                    return;
                }

                if (IdCheck != 0 || OfficerComboBox.Text == null)
                {
                    MessageBox.Show("Работника ГАИ с данным ФИО не существует, перепроверьте данные!");
                    return;
                }

                if (DateText.Text != "")
                {
                    foreach (Inspection inspection1 in db.Inspection)
                    {
                        if (InspectorID == inspection1.OfficerID && Convert.ToDateTime(DateText.Text) == inspection1.Inspection_date)
                        {
                            CountOfRepeatsDate++;
                        }
                        if (CountOfRepeatsDate > 9)
                        {
                            MessageBox.Show("Этот сотрудник ГАИ уже совершил более 10 проверок за этот день!" + InspectorID.ToString());
                            return;
                        }
                        else
                        {
                            inspection.Inspection_date = Convert.ToDateTime(DateText.Text);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите дату!");
                    return;
                }

                if (ResultTextBox.Text != "")
                {
                    inspection.Result = ResultTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Введите результат проверки!");
                    return;
                }

                if (IdCheck == 0)
                {
                    if (AddData.Content.ToString() != "Изменить")
                    {
                        db.Inspection.Add(inspection);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!");
                    inspectionDataWindow.FillInspectionTable();
                    inspectionDataWindow.InspectId = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }

            }
            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }

        /// <summary>
        /// Возврат на предыдущее окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BackToInspection_Click(object sender, RoutedEventArgs e)
        {
            inspectionDataWindow.InspectId = 0;
            this.Close();
        }
    }
}
