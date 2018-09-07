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
    /// Interaction logic for SearchEmployee.xaml
    /// </summary>
    public partial class SearchEmployee : Window
    {

        ServiceReference.HRWebServicesClient HRWebServices;

        public SearchEmployee()
        {
            InitializeComponent();
            Loading();
        }

        private void Loading()
        {
            string lastName = "";
            string firstName = "";

            lastName = txtLastName.Text;
            firstName = txtFirstName.Text;

            if (lastName.Length <= 0) lastName = "";
            if (firstName.Length <= 0) firstName = "";

            HRWebServices = new ServiceReference.HRWebServicesClient();

            var query = HRWebServices.GetEmployeesByLastAndFirstName(lastName, firstName);
            dataGrid1.ItemsSource = query;
            
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MasterEmployees editWindow = new MasterEmployees();
            //var selectedItem = dataGrid1.SelectedItem as sender;
            //if (selectedItem != null)
            //    //MessageBox.Show(selectedItem.Emp_EmployeeId.ToString());
            //    editWindow.Owner = this;

            //editWindow.txtEmployeeId.Text = "1";


            //editWindow.Show();
        }

        private void txtLastName_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtFirstName_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string lastName;
            string firstName;

            lastName = txtLastName.Text;
            firstName = txtFirstName.Text;

            if (lastName.Length <= 0) lastName = "";
            if (firstName.Length <= 0) firstName = "";

            HRWebServices = new ServiceReference.HRWebServicesClient();

            var query = HRWebServices.GetEmployeesByLastAndFirstName(lastName, firstName);
            dataGrid1.ItemsSource = query;

        }
    }
}
