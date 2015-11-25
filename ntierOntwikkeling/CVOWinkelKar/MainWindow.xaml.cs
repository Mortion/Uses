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

namespace CVOWinkelKar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WinkelService _service = new WinkelService();

        public MainWindow()
        {
            InitializeComponent();
            RefreshListbox();
        }

        private void RefreshListbox()
        {
            
            lsbProducten.ItemsSource = _service.AlleBoodschappenOpvragen();
         
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            Boodschap boodschap = new Boodschap();
            boodschap.Aantal = Convert.ToInt32(txtAantal.Text);
            boodschap.Beschrijving = txtBeschrijving.Text;
            boodschap.Winkel = cboWinkel.Text;
            _service.BoodschapToevoegen(boodschap);
            RefreshListbox();
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            var product =(Boodschap) lsbProducten.SelectedItem;
            _service.BoodschapVerwijderen(product);
            RefreshListbox();

        }

      
    }
}
