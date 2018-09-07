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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HumanResourcesTool
{
    /// <summary>
    /// Interaction logic for EmployeesList.xaml
    /// </summary>
    public partial class EmployeesList : Window
    {
        ServiceReference.HRWebServicesClient HRWebServices;
        public EmployeesList()
        {
            InitializeComponent();
            Loading();
        }

        private void Loading()
        {
            HRWebServices = new ServiceReference.HRWebServicesClient();

            var query = HRWebServices.GetEmployees();
            dataGrid1.ItemsSource = query;

        }

        

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            MasterEmployees editWindow = new MasterEmployees();
            var selectedItem = dataGrid1.SelectedItem as tblEmployee;
            if (selectedItem != null)
                //MessageBox.Show(selectedItem.Emp_EmployeeId.ToString());
            editWindow.Owner = this;
            editWindow.Fill_Employee_Info(selectedItem.Emp_EmployeeId);
            editWindow.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MasterEmployees addWindow = new MasterEmployees();
            addWindow.Owner = this;
            addWindow.Show();
        }

        
    }
}
