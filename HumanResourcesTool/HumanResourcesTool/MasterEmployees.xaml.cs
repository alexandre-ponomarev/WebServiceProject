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

        ServiceReference.HRWebServicesClient WCFHRHumanResources = new ServiceReference.HRWebServicesClient();

        public MasterEmployees()
        {
            InitializeComponent();

            Clear_Controls();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeesList myWindow1 = new EmployeesList();
            myWindow1.Owner = this;
            myWindow1.Show();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            //Clear_Controls();


        }


        //**************************************************************************
        // Additional Methods
        public void Clear_Controls ()
        {
            //txtsdfsdf.text = ""

            Fill_cbPositions();
            Fill_cbDepartments();


        }

        private void Fill_cbPositions()
        {
            var query = WCFHRHumanResources.GetPositions();
            cbPositions.DisplayMemberPath = "Pos_Description";
            cbPositions.SelectedValuePath = "Pos_PositionId";
            cbPositions.ItemsSource = query;
            if (cbPositions.Items.Count > 0)
            {
                cbPositions.SelectedIndex = 0;
            }
        }

        private void Fill_cbDepartments()
        {
            var query = WCFHRHumanResources.GetDepartments();
            cbDepartment.DisplayMemberPath = "Dep_Name";
            cbDepartment.SelectedValuePath = "Dep_DepartmentId";
            cbDepartment.ItemsSource = query;
            if (cbDepartment.Items.Count > 0)
            {
                cbDepartment.SelectedIndex = 0;
            }
        }


    }
}

