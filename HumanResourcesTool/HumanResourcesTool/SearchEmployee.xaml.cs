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
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MasterEmployees editWindow = new MasterEmployees();
            //var selectedItem = dataGrid1.SelectedItem as tblEmployee;
            //if (selectedItem != null)
            //    //MessageBox.Show(selectedItem.Emp_EmployeeId.ToString());
            //    editWindow.Owner = this;
            //editWindow.btnDelete.IsEnabled = false;
            //editWindow.btnUpdate.IsEnabled = false;
            //editWindow.btnNew.IsEnabled = false;

            //editWindow.optionSelectedCRUM = "u";
            //editWindow.flag = true;
            //editWindow.txtEmployeeId.Text = selectedItem.Emp_EmployeeId.ToString();
            //editWindow.Fill_Employee_Info(selectedItem.Emp_EmployeeId);
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
    }
}
