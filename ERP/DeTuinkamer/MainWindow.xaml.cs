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
using ErpLibrary;
using ErpLibrary.Enums;
using ErpLibrary.H_R;

namespace DeTuinkamer
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

        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee("Vermeulen" , "Jos" , "jos@vml.com","berkelei","berchem","2620",Gender.Male,JobType.Programmer, DateTime.Now,"19940427666187" );
            Employee emp2 = new Employee("Vermeulen", "Jos", "jos@vml.com", "berkelei", "berchem", "2620", Gender.Male, JobType.Programmer, DateTime.Now, "19990929458798");

            

            MessageBox.Show(emp.ToString() + Environment.NewLine+ emp2.ToString());
        }
    }
}
