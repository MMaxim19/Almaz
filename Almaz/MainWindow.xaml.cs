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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Almaz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AlmazEnt almaz { get; set; }
        public MainWindow()
        {
            almaz = new AlmazEnt();
            InitializeComponent();
            ZakazTable.ItemsSource = almaz.Изготовление.ToList();
        }

        private void WindowClient(object sender, RoutedEventArgs e)
        {
            WinClient winClient = new WinClient();
            winClient.Show();
            Close();
        }
        private void WindowMaster(object sender, RoutedEventArgs e)
        {
            WindowMaster windowMaster = new WindowMaster();
            windowMaster.Show();
            Close();
        }

        private void WindowProduct(object sender, RoutedEventArgs e)
        {
            ProductsWindow productsWindow = new ProductsWindow();
            productsWindow.Show();
            Close();
        }

        private void AddOrder(object sender, RoutedEventArgs e)
        {
            var Dob = new Изготовление();
            almaz.Изготовление.Add(Dob);
            var Dob1 = new OrderAdd(almaz, Dob);
            Dob1.ShowDialog();
            ZakazTable.ItemsSource = almaz.Изготовление.ToList();
        }

        private void Filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = (sender as TextBox).Text.ToLower();
            if (!(string.IsNullOrEmpty(input)))
            {
                int resultCount = almaz.Изготовление.Count(x => x.Изделия.Тип_изделия.Contains(input));
                ZakazTable.ItemsSource = almaz.Изготовление.Where(x => x.Изделия.Тип_изделия.Contains(input)).ToList();
            }
            else
            {
                ZakazTable.ItemsSource = almaz.Изготовление.ToList();
            }
        }
    }
}
