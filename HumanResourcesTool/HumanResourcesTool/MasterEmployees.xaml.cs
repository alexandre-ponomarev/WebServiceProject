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
            Enabled_Desabled_Controls(true);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeesList myWindow1 = new EmployeesList();
            myWindow1.Owner = this;
            myWindow1.Show();


        }


        //**************************************************************************
        // Additional Methods
        public void Clear_Controls ()
        {
            //txtsdfsdf.text = ""

            Fill_cbPositions();
            Fill_cbDepartments();
            Fill_cbTitles();
            Fill_cbCountries();
            Fill_cbProvinces();
            Fill_cbCities();

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

        private void Fill_cbTitles()
        {
            var query = WCFHRHumanResources.GetTitles();
            cbTitles.DisplayMemberPath = "Tit_Name";
            cbTitles.SelectedValuePath = "Tit_TitleId";
            cbTitles.ItemsSource = query;
            if (cbTitles.Items.Count > 0)
            {
                cbTitles.SelectedIndex = 0;
            }
        }

        private void Fill_cbCountries()
        {
            var query = WCFHRHumanResources.GetCountries();
            cbCountries.DisplayMemberPath = "Cuo_Name";
            cbCountries.SelectedValuePath = "Cuo_CountryId";
            cbCountries.ItemsSource = query;
            if (cbCountries.Items.Count > 0)
            {
                cbCountries.SelectedIndex = 0;
            }
        }


        private void Fill_cbProvinces()
        {
            var query = WCFHRHumanResources.GetProvinces();
            cbProvinces.DisplayMemberPath = "Pro_Name";
            cbProvinces.SelectedValuePath = "Pro_ProvinceId";
            cbProvinces.ItemsSource = query;
            if (cbProvinces.Items.Count > 0)
            {
                cbProvinces.SelectedIndex = 0;
            }
        }


        private void Fill_cbCities()
        {
            var query = WCFHRHumanResources.GetCities();
            cbCities.DisplayMemberPath = "Cit_Name";
            cbCities.SelectedValuePath = "Cit_CityId";
            cbCities.ItemsSource = query;
            if (cbCities.Items.Count > 0)
            {
                cbCities.SelectedIndex = 0;
            }
        }


        private void Enabled_Desabled_Controls(bool option)
        {
            txtEmployeeId.IsEnabled = option;
            btnSearchEmployee.IsEnabled = option;
            cbTitles.IsEnabled = option;
            txtFirstName.IsEnabled = option;
            txtLastName.IsEnabled = option;
            cbDepartment.IsEnabled = option;
            btnGenderMale.IsEnabled = option;
            btnGenderFemale.IsEnabled = option;
            btnGenderMaleAndFemale.IsEnabled = option;
            txtAddress.IsEnabled = option;
            cbCountries.IsEnabled = option;
            cbProvinces.IsEnabled = option;
            cbCities.IsEnabled = option;
            txtPostCode.IsEnabled = option;
            cbPositions.IsEnabled = option;
            txtHomeTelephone.IsEnabled = option;
            txtMobileTelephone.IsEnabled = option;
            txtEmail.IsEnabled = option;
            dpDOB.IsEnabled = option;
            txtAge.IsEnabled = option;
            txtAnnualSalary.IsEnabled = option;
            txtHouralyRate.IsEnabled = option;

        }

        private int fSearchLastEmployeeId()
        {
            return 0;
        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Clear_Controls();
            txtEmployeeId.Text = fSearchLastEmployeeId().ToString();
            Enabled_Desabled_Controls(true);
            txtEmployeeId.IsEnabled = false;
            cbTitles.Focus();

        }

        private void cbTitles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtFirstName.Focus();
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtLastName.Focus();
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) cbDepartment.Focus();
        }

        private void cbDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) btnGenderMale.Focus();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) cbCountries.Focus();
        }

        private void cbCountries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) cbProvinces.Focus();
        }

        private void cbProvinces_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) cbCities.Focus();
        }

        private void cbCities_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtPostCode.Focus();
        }

        private void txtPostCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) cbPositions.Focus();
        }

        private void cbPositions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtHomeTelephone.Focus();
        }

        private void txtHomeTelephone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtMobileTelephone.Focus();
        }

        private void txtMobileTelephone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtEmail.Focus();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) dpDOB.Focus();
        }

        private void dpDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtAnnualSalary.Focus();
        }

        private void txtAnnualSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtHouralyRate.Focus();
        }

        private void txtHouralyRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) btnSave.Focus();
        }

        private void txtFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.SelectionStart = 0;
                txtFirstName.SelectionLength = txtFirstName.Text.Length;
            }
        }

        private void txtLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.SelectionStart = 0;
                txtLastName.SelectionLength = txtLastName.Text.Length;
            }

        }

        private void txtAddress_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.SelectionStart = 0;
                txtAddress.SelectionLength = txtLastName.Text.Length;
            }

        }

        private void txtPostCode_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPostCode.Text))
            {
                txtPostCode.SelectionStart = 0;
                txtPostCode.SelectionLength = txtPostCode.Text.Length;
            }

        }

        private void txtHomeTelephone_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHomeTelephone.Text))
            {
                txtHomeTelephone.SelectionStart = 0;
                txtHomeTelephone.SelectionLength = txtHomeTelephone.Text.Length;
            }

        }

        private void txtMobileTelephone_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMobileTelephone.Text))
            {
                txtMobileTelephone.SelectionStart = 0;
                txtMobileTelephone.SelectionLength = txtMobileTelephone.Text.Length;
            }

        }

        private void txtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.SelectionStart = 0;
                txtEmail.SelectionLength = txtEmail.Text.Length;
            }

        }

        private void txtAnnualSalary_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAnnualSalary.Text))
            {
                txtAnnualSalary.SelectionStart = 0;
                txtAnnualSalary.SelectionLength = txtAnnualSalary.Text.Length;
            }

        }

        private void txtHouralyRate_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHouralyRate.Text))
            {
                txtHouralyRate.SelectionStart = 0;
                txtHouralyRate.SelectionLength = txtHouralyRate.Text.Length;
            }

        }
    }
}

