using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MojaWPFApp
{
    /// <summary>
    /// Interaction logic for Prozor.xaml
    /// </summary>
    public partial class Prozor : Window
    {
 
        public Prozor()
        {
            InitializeComponent();
            DataContext = new Osoba();
            BindingGroup = new BindingGroup();
           
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            BindingGroup.CommitEdit();
            Close();
        }

        private void Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Izmeni(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
