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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка перехода в окно InspectionData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ToInspectionForm_Click(object sender, RoutedEventArgs e)
        {
            InspectionData inspectionData = new InspectionData();
            this.Close();
            inspectionData.ShowDialog();            
        }

        /// <summary>
        /// Кнопка перехода в окно CarData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ToCarData_Click(object sender, RoutedEventArgs e)
        {
            CarData carData = new CarData();
            this.Close();
            carData.ShowDialog();
        }
    }
}
