using ItemsLibrary;
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

namespace FactuurManipulatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            decimal price = 10;
            items.Add(new Item(cbItems.Text, price, Int32.Parse(txtAmount.Text), BTW.STANDAARD));
            RefreshListbox();
        }
        private List<Item> items;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            items = new List<Item>();

        }

        private void RefreshListbox()
        {
            lstItemsAdded.Items.Clear();
            lstItemsAdded.ItemsSource = items;
        }
    }
}
