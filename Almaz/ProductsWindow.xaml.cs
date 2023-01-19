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

namespace Almaz
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        AlmazEnt almaz;
        public ProductsWindow()
        {
            almaz= new AlmazEnt();
            InitializeComponent();
            ProductTable.ItemsSource = almaz.Изделия.ToList();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            var Dob = new Изделия();
            almaz.Изделия.Add(Dob);
            var Dob1 = new AddProduct(almaz, Dob);
            Dob1.ShowDialog();
            ProductTable.ItemsSource = almaz.Изделия.ToList();
        }

        private void MetallWindow(object sender, RoutedEventArgs e)
        {
            MetallWindow metallWindow= new MetallWindow();
            metallWindow.Show();
            Close();
        }
    }
}
