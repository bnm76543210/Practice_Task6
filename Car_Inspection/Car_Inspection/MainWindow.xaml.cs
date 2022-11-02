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

        private void ToInspectionForm_Click(object sender, RoutedEventArgs e)
        {
            InspectionData inspectionData = new InspectionData();
            this.Close();
            inspectionData.ShowDialog();            
        }

        private void ToCarData_Click(object sender, RoutedEventArgs e)
        {
            CarData carData = new CarData();
            this.Close();
            carData.ShowDialog();
        }
    }
}
