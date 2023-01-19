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
    /// Логика взаимодействия для WindowMaster.xaml
    /// </summary>
    public partial class WindowMaster : Window
    {
        AlmazEnt almaz;
        public WindowMaster()
        {
            almaz= new AlmazEnt();
            InitializeComponent();
            MasterTable.ItemsSource = almaz.Ювелир.ToList();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void AddMaster(object sender, RoutedEventArgs e)
        {
            var Dob = new Ювелир();
            almaz.Ювелир.Add(Dob);
            var Dob1 = new MasterWin(almaz, Dob);
            Dob1.ShowDialog();
            MasterTable.ItemsSource = almaz.Ювелир.ToList();
        }

        private void DeleteMaster(object sender, RoutedEventArgs e)
        {
            var dea = MasterTable.SelectedItem as Ювелир;
            if (dea == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            almaz.Ювелир.Remove(dea);
            almaz.SaveChanges();
            MasterTable.ItemsSource = almaz.Ювелир.ToList();
        }

        private void UpdateMaster(object sender, RoutedEventArgs e)
        {
            Button red1 = sender as Button;
            var red2 = red1.DataContext as Ювелир;
            var red3 = new MasterWin(almaz, red2);
            red3.ShowDialog();
            MasterTable.ItemsSource = almaz.Ювелир.ToList();
        }
    }
}
