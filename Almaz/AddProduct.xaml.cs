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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        AlmazEnt almaz;
        public AddProduct(AlmazEnt almaz, Изделия изделия)
        {
            InitializeComponent();
            this.almaz = almaz;
            this.DataContext = изделия;
        }

        private void AddProd(object sender, RoutedEventArgs e)
        {
            almaz.SaveChanges();
            Close();
        }
    }
}
