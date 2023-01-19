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
    /// Логика взаимодействия для MetallWindow.xaml
    /// </summary>
    public partial class MetallWindow : Window
    {
        AlmazEnt almaz;
        public MetallWindow()
        {
            almaz = new AlmazEnt();
            InitializeComponent();
            MetallTable.ItemsSource = almaz.Металл.ToList();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            ProductsWindow productsWindow = new ProductsWindow();
            productsWindow.Show();
            Close();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            var Dob = new Металл();
            almaz.Металл.Add(Dob);
            var Dob1 = new MetallAdd(almaz, Dob);
            Dob1.ShowDialog();
            MetallTable.ItemsSource = almaz.Металл.ToList();
        }
    }
}
