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

namespace HumanResourcesTool
{
    /// <summary>
    /// Interaction logic for MasterEmployees.xaml
    /// </summary>
    public partial class MasterEmployees : Window
    {
        public MasterEmployees()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeesList myWindow1 = new EmployeesList();
            myWindow1.Owner = this;
            myWindow1.Show();


        }
    }
}
