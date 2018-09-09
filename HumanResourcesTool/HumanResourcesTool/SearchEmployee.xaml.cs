using HumanResourcesTool.ServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
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

        public string myOptionSended;
        public MasterEmployees newFormReceived;

        public SearchEmployee(string value, MasterEmployees formReceived)
        {
            InitializeComponent();
            Loading();

            newFormReceived = formReceived;

            this.myOptionSended = value;


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
            MasterEmployees editWindow = newFormReceived;
            
            var selectedItem = dataGrid1.SelectedItem as ClassEmployee;
            if (selectedItem != null)
                //MessageBox.Show(selectedItem.Emp_EmployeeId.ToString());
            //editWindow.Owner = this;

            editWindow.flagSearchEmployee = true;

            editWindow.txtEmployeeId.Text = selectedItem.employeeId.ToString();

            if (myOptionSended.ToString() == "u")
            {
                editWindow.btnSearchEmployee.IsEnabled = true;
                editWindow.optionSelectedCRUM = myOptionSended;
                editWindow.sbItem3.Content = "Update Employee";

                editWindow.txtEmployeeId.IsEnabled = true;

            } else //delete
            {
                editWindow.btnSearchEmployee.IsEnabled = true;
                editWindow.optionSelectedCRUM = myOptionSended;
                editWindow.sbItem3.Content = "Delete Employee";
                editWindow.txtEmployeeId.IsEnabled = true;
                //cbTitles.Focus();
                //editWindow.txtEmployeeId.Focus();

            }


            //------------------------------------------------------------------------
            //this seccion is to call event txtEmployeeId_KeyDown
            var kea = new KeyEventArgs(
                Keyboard.PrimaryDevice,
                new HwndSource(0, 0, 0, 0, 0, "", IntPtr.Zero), // dummy source
                0,
                Key.Enter);

            editWindow.txtEmployeeId_KeyDown(this, kea);
            //------------------------------------------------------------------------


            //editWindow.Show();

            Close();

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

            var query = HRWebServices.GetEmployeesByLastAndFirstName(lastName, firstName);
            dataGrid1.ItemsSource = query;

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
