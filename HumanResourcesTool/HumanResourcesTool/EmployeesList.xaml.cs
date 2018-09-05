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
        public EmployeesList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference.HRWebServicesClient HRWebServices = new ServiceReference.HRWebServicesClient();
            //ServiceReference.HRWebServicesClient positions = new ServiceReference.HRWebServicesClient();



            var query = HRWebServices.GetEmployees();
            dataGrid1.ItemsSource = query;

            var query2 = HRWebServices.GetPositions();
            cbPositions.ItemsSource = query2;
            cbPositions.DisplayMemberPath = "Pos_Description";

            //DataTable dt = new DataTable();
            //dt.Columns.Add("Employee Id");
            //dt.Columns.Add("Fist Name");
            //dt.Columns.Add("Last Name");
            //dt.Columns.Add("Sur Name");
            //dt.Columns.Add("Orher Name");
            //dt.Rows.Add("1", "Luis", "Roman", "Lucho", "Ernesto");
            //dataGrid1.ItemsSource = dt.DefaultView;
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            MasterEmployees myWindow1 = new MasterEmployees();
            myWindow1.Owner = this;
            myWindow1.Show();
        }
    }
}
