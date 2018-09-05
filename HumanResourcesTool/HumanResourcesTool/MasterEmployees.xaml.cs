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
        string optionSelectedCRUM = "i";

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

            txtEmployeeId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            cbCities.Text = "";
            txtPostCode.Text = "";
            txtHomeTelephone.Text = "";
            txtMobileTelephone.Text = "";
            txtEmail.Text = "";

            dpDOB.Text = DateTime.Now.Date.ToString();

            txtAge.Text = "";
            txtAnnualSalary.Text = "";
            txtHouralyRate.Text = "";

            //imgGenderMale.Visibility = true;
            imgGenderMale.Visibility = System.Windows.Visibility.Visible;
            imgGenderFemale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Hidden;

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
            int query = WCFHRHumanResources.GetLastEmployeeId();
            return query;
        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {

            optionSelectedCRUM = "i";

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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (fValidate_Info_Employee())
            {
                switch (optionSelectedCRUM)
                {
                    case "i":
                        insertEmployee();
                        break;
                    case "u":
                        //updateEmployee();
                        break;
                    case "d":
                        //deleteEmployee();
                        break;
                }
            }
        }

        private bool fValidate_Info_Employee()
        {

            //***************************************************************
            //***************************************************************
            // ... Get DatePicker reference.
            var picker = dpDOB as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                this.Title = date.Value.ToShortDateString();
            }
            //***************************************************************
            //***************************************************************



            return true;
        }

        private void insertEmployee()
        {
            //reference to clase
            ServiceReference.tblEmployee objEmployee = new ServiceReference.tblEmployee();

            ////mapping data
            //objEmployee.Cit_CityId = 1;
            //objEmployee.Dep_DepartmentId = 1;
            //objEmployee.Emp_Address = "Address 2";
            //objEmployee.Emp_AnualSalary = 65000;
            //objEmployee.Emp_CellPhone = "514836664";
            //objEmployee.Emp_Email = "Lromanz@132.com";
            //objEmployee.Emp_FirstName = "Ernesto";
            //objEmployee.Emp_Gender = "M";
            //objEmployee.Emp_HourlyRate = 30;
            //objEmployee.Emp_LastName = "Zambrano";
            //objEmployee.Emp_Phone = "514524154";
            //objEmployee.Emp_Photo = null;
            //objEmployee.Emp_PostalCode = "H3E1C9";

            //objEmployee.Emp_BirthOfDate = DateTime.Now;
            //objEmployee.Emp_StartDate = DateTime.Now;
            //objEmployee.Emp_TerminationDate = DateTime.Now;

            //objEmployee.Tit_TitleId = 1;
            //objEmployee.Pos_PositionId = 1;


            //mapping data
            objEmployee.Cit_CityId = Int32.Parse(cbCities.SelectedValue.ToString());
            objEmployee.Dep_DepartmentId = Int32.Parse(cbDepartment.SelectedValue.ToString());
            objEmployee.Emp_Address = txtAddress.Text;

            objEmployee.Emp_AnualSalary = 65000;
            objEmployee.Emp_CellPhone = "514836664";
            objEmployee.Emp_Email = "Lromanz@132.com";
            objEmployee.Emp_FirstName = "Ernesto";
            objEmployee.Emp_Gender = "M";
            objEmployee.Emp_HourlyRate = 30;
            objEmployee.Emp_LastName = "Zambrano";
            objEmployee.Emp_Phone = "514524154";
            objEmployee.Emp_Photo = null;
            objEmployee.Emp_PostalCode = "H3E1C9";

            objEmployee.Emp_BirthOfDate = DateTime.Now;
            objEmployee.Emp_StartDate = DateTime.Now;
            objEmployee.Emp_TerminationDate = DateTime.Now;

            objEmployee.Tit_TitleId = 1;
            objEmployee.Pos_PositionId = 1;


            if (WCFHRHumanResources.insertEmployees(objEmployee))
            {
                MessageBox.Show("Employee inserted successfully");
            } else
            {
                MessageBox.Show("Failed insert Employee");
            }
            

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            optionSelectedCRUM = "u";


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            optionSelectedCRUM = "d";


        }

        private void btnGenderFemale_Click(object sender, RoutedEventArgs e)
        {

            imgGenderMale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderFemale.Visibility = System.Windows.Visibility.Visible;
            imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnGenderMaleAndFemale_Click(object sender, RoutedEventArgs e)
        {
            imgGenderMale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderFemale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Visible;

        }

        private void btnGenderMale_Click(object sender, RoutedEventArgs e)
        {
            imgGenderMale.Visibility = System.Windows.Visibility.Visible;
            imgGenderFemale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Hidden;

        }

        private void btnTestingInsert_Click(object sender, RoutedEventArgs e)
        {
            //reference to clase
            ServiceReference.tblDepartment objDepartment = new ServiceReference.tblDepartment();
            objDepartment.Dep_Name = "Sales";
            if (WCFHRHumanResources.insertDepartments(objDepartment))
            {
                MessageBox.Show("Employee inserted successfully");
            }
            else
            {
                MessageBox.Show("Failed insert Employee");
            }
        }
    }
}

