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
    /// Логика взаимодействия для CarData.xaml
    /// </summary>
    public partial class CarData : Window
    {
        public CarData()
        {
            InitializeComponent();
            FillCarTable();
        }

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
        /// Метод заполенения DataGrid окна CarData данными из таблицы Car базы данных 
        /// </summary>

        public void FillCarTable()
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                CarDataGrid.ItemsSource = db.Car.ToList();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!");
            }
        }

        /// <summary>
        /// Кнопка показа информации о владельце автомобиля из DataGrid окна CarData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ShowOwnerData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car_InspectionEntities db = new Car_InspectionEntities();
                Car car = (sender as Button).DataContext as Car;

                string License_number_str = "";
                string FIO_str = "";
                string Adress_str = "";
                string Birth_date = "";
                string Gender = "";

                foreach (Owner owner in db.Owner)
                {
                    if (owner.Owner_id == car.OwnerID)
                    {
                        License_number_str = owner.License_number;
                        FIO_str = owner.FIO;
                        Adress_str = owner.Adress;
                        Birth_date = owner.Birth_date.ToString("yyyy-MM-dd");
                        Gender = owner.Gender;
                    }
                }
                MessageBox.Show("Информация о владельце\n" + "Номер вод. удстоверения: " + License_number_str + "\nФИО: " + FIO_str + "\nАдрес: " + Adress_str + "\nДата рождения: " + Birth_date + "\nПол: " + Gender);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка связи с базой данных, исправьте ошибку!");
            }
        }
    }
}
