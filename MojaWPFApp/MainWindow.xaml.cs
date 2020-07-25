using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

namespace MojaWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Osoba> Osobe = new ObservableCollection<Osoba>();

        public MainWindow()
        {

            InitializeComponent();
            DataContext = new Osoba();
            BindingGroup = new BindingGroup();
            datagrid.ItemsSource = Osobe;
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            Prozor p = new Prozor();
            p.Owner = this;

            if (p.ShowDialog().Value)
            {
                Osobe.Add(p.DataContext as Osoba);
            }

        }

        private void Brisi(object sender, RoutedEventArgs e)
        {
            Osobe.Remove(datagrid.SelectedItem as Osoba);
        }

        private void Izmena(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedItem != null)
            {
                Prozor p = new Prozor();
                p.Owner = this;
                p.DataContext = datagrid.SelectedItem;
                p.ShowDialog();
            }
        }
    }
}
