using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для WinClient.xaml
    /// </summary>
    public partial class WinClient : Window
    {
        AlmazEnt almaz { get; set; }
        public WinClient()
        {
            almaz= new AlmazEnt();
            InitializeComponent();
            ClientTable.ItemsSource = almaz.Заказчики.ToList();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow MN = new MainWindow();
            MN.Show();
            Close();
        }

        private void UpdateMaster(object sender, RoutedEventArgs e)
        {
            Button red1 = sender as Button;
            var red2 = red1.DataContext as Заказчики;
            var red3 = new AddClient(almaz, red2);
            red3.ShowDialog();
            ClientTable.ItemsSource = almaz.Заказчики.ToList();
        }

        private void DeleteMaster(object sender, RoutedEventArgs e)
        {
            var dea = ClientTable.SelectedItem as Заказчики;
            if (dea == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            almaz.Заказчики.Remove(dea);
            almaz.SaveChanges();
            ClientTable.ItemsSource = almaz.Заказчики.ToList();
        }

        private void AddClient(object sender, RoutedEventArgs e)
        {
            var Dob = new Заказчики();
            almaz.Заказчики.Add(Dob);
            var Dob1 = new AddClient(almaz, Dob);
            Dob1.ShowDialog();
            ClientTable.ItemsSource = almaz.Заказчики.ToList();
        }
    }
}
