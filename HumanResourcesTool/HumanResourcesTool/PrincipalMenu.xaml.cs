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
    /// Interaction logic for PrincipalMenu.xaml
    /// </summary>
    public partial class PrincipalMenu : Window
    {
        public PrincipalMenu()
        {
            InitializeComponent();
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;

        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MasterEmployees EmployeeMaintenanceWindow = new MasterEmployees();
            EmployeeMaintenanceWindow.Owner = this;
            //EmployeeListWindow.Show();
            EmployeeMaintenanceWindow.ShowDialog();
        }

        private void ListBoxItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            EmployeesList EmployeeListWindow = new EmployeesList();
            EmployeeListWindow.Owner = this;
            //EmployeeListWindow.Show();
            EmployeeListWindow.ShowDialog();

        }
    }
}
