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

namespace HumanResourcesTool
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           string pass = pbPass.Password;

            ServiceReference.HRWebServicesClient sref = new ServiceReference.HRWebServicesClient();

            bool access = sref.Login(pass);

            if (access)
            {
                PrincipalMenu main = new PrincipalMenu();
                main.Show();
                this.Close();
                
            } else
            {
                MessageBox.Show("Access denied. Try again!");
            }

        }
    }
}
