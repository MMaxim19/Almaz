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
    /// Логика взаимодействия для MetallAdd.xaml
    /// </summary>
    public partial class MetallAdd : Window
    {
        AlmazEnt almaz;
        public MetallAdd(AlmazEnt almaz, Металл металл)
        {
            InitializeComponent();
            this.almaz = almaz;
            this.DataContext = металл;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            almaz.SaveChanges();
            Close();
        }
    }
}
