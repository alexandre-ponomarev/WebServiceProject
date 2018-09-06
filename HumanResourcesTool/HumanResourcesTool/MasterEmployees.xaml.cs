using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        ServiceReference.HRWebServicesClient WCFHRHumanResources = new ServiceReference.HRWebServicesClient();
        string optionSelectedCRUM = "i";

        public MasterEmployees()
        {
            InitializeComponent();

            Clear_Controls();
            txtEmployeeId.Text = "";

            Enabled_Desabled_Controls(true);
            //case special
            txtAge.IsEnabled = false;


            Initial_Status_Bar();
            Initial_Timer();

        }


        //**************************************************************************
        // Additional Methods
        public void Clear_Controls()
        {

            //txtEmployeeId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            cbCities.Text = "";
            txtPostCode.Text = "";
            txtHomeTelephone.Text = "";
            txtMobileTelephone.Text = "";
            txtEmail.Text = "";

            dpDOB.Text = DateTime.Now.Date.ToString();
            dpDateStart.Text = DateTime.Now.Date.ToString();
            dpDateFinish.Text = DateTime.Now.Date.ToString();

            txtAge.Text = "";
            txtAnnualSalary.Text = "0";
            txtHouralyRate.Text = "0";

            //imgGenderMale.Visibility = true;
            imgGenderMale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderFemale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Hidden;

            Fill_cbPositions();
            Fill_cbDepartments();
            Fill_cbTitles();
            Fill_cbCountries();
            Fill_cbProvinces();
            Fill_cbCities();

            imgEmployee.Source = null;

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


        private void Fill_Employee_Info(int EmployeeId)
        {

            var query = WCFHRHumanResources.GetEmployeeInfo(EmployeeId);

            if (query != null)
            {
                //objEmployee.Cit_CityId = Int32.Parse(cbCities.SelectedValue.ToString());
                //objEmployee.Dep_DepartmentId = Int32.Parse(cbDepartment.SelectedValue.ToString());
                //objEmployee.Tit_TitleId = Int32.Parse(cbTitles.SelectedValue.ToString());
                //objEmployee.Pos_PositionId = Int32.Parse(cbPositions.SelectedValue.ToString());
                //query.Cit_CityId
                //query.Dep_DepartmentId

                txtAddress.Text = query.Emp_Address;
                txtAnnualSalary.Text = query.Emp_AnualSalary.ToString();
                txtHouralyRate.Text = query.Emp_HourlyRate.ToString();
                txtMobileTelephone.Text = query.Emp_CellPhone;
                txtHomeTelephone.Text = query.Emp_Phone;
                txtEmail.Text = query.Emp_Email;
                txtFirstName.Text = query.Emp_FirstName;
                txtLastName.Text = query.Emp_LastName;
                txtPostCode.Text = query.Emp_PostalCode;
                if (query.Emp_Gender == "M") imgGenderMale.Visibility = System.Windows.Visibility.Visible;
                if (query.Emp_Gender == "F") imgGenderFemale.Visibility = System.Windows.Visibility.Visible;
                if (query.Emp_Gender == "B") imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Visible;

                dpDOB.Text = query.Emp_BirthOfDate.ToString();
                dpDateStart.Text = query.Emp_StartDate.ToString();
                dpDateFinish.Text = query.Emp_TerminationDate.ToString();


                //----------------------------------------------------------------------
                //Special procesus for the photo
                //objEmployee.Emp_Photo = null;
                //----------------------------------------------------------------------

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
            dpDateStart.IsEnabled = option;
            dpDateFinish.IsEnabled = option;

            txtAnnualSalary.IsEnabled = option;
            txtHouralyRate.IsEnabled = option;

            btnGenderMale.IsEnabled = option;
            btnGenderFemale.IsEnabled = option;
            btnGenderMaleAndFemale.IsEnabled = option;

            btnEmployeePhoto.IsEnabled = option;

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
            sbItem3.Content = "New Employee";

            Clear_Controls();
            txtEmployeeId.Text = fSearchLastEmployeeId().ToString();
            Enabled_Desabled_Controls(true);
            txtEmployeeId.IsEnabled = false;
            //cbTitles.Focus();
            txtFirstName.Focus();

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

        private void dpDOB_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) dpDateStart.Focus();
        }

        private void dpDateStart_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) dpDateFinish.Focus();
        }

        private void dpDateFinish_PreviewKeyUp(object sender, KeyEventArgs e)
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
                        Clear_Controls();
                        Enabled_Desabled_Controls(true);
                        txtEmployeeId.IsEnabled = false;
                        txtFirstName.Focus();
                        break;
                    case "u":
                        updateEmployee();
                        Clear_Controls();
                        Enabled_Desabled_Controls(false);
                        txtEmployeeId.IsEnabled = true;
                        txtEmployeeId.Focus();

                        break;
                    case "d":
                        deleteEmployee();
                        Clear_Controls();
                        Enabled_Desabled_Controls(false);
                        txtEmployeeId.IsEnabled = true;
                        txtEmployeeId.Focus();
                        break;
                }
            }
        }

        private bool fValidate_Info_Employee()
        {
            string errorMessage = "";

            //***************************************************************
            //***************************************************************
            var varDOB = dpDOB as DatePicker;
            DateTime? dateDOB = varDOB.SelectedDate;
            if (dateDOB == null)
            {
                errorMessage += "Field: " + lblDateDOB.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************


            //***************************************************************
            //***************************************************************
            var varDateStart = dpDateStart as DatePicker;
            DateTime? dateStart = varDateStart.SelectedDate;
            if (dateStart == null)
            {
                errorMessage += "Field: " + lblDateStart.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            var varDateFinish = dpDateFinish as DatePicker;
            DateTime? dateFinish = varDateFinish.SelectedDate;
            if (dateFinish == null)
            {
                errorMessage += "Field: " + lblDateFinish.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (cbCities.Items.Count <= 0)
            {
                errorMessage += "Field: " + lblCity.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (cbCountries.Items.Count <= 0)
            {
                errorMessage += "Field: " + lblCountry.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (cbProvinces.Items.Count <= 0)
            {
                errorMessage += "Field: " + lblRegion.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (cbDepartment.Items.Count <= 0)
            {
                errorMessage += "Field: " + lblDepartment.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (txtFirstName.Text.Length <= 0)
            {
                errorMessage += "Field: " + lblFirstName.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (txtAddress.Text.Length <= 0)
            {
                errorMessage += "Field: " + lblLastName.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (txtLastName.Text.Length <= 0)
            {
                errorMessage += "Field: " + lblAddress.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (txtAnnualSalary.Text.Length <= 0)
            {
                errorMessage += "Field: " + lblAnnualSalary.Content + " is Invalid." + "\n";
            }
            else
            {
                if (!IsNumber(txtAnnualSalary.Text.ToString()))
                {
                    errorMessage += "Field: " + lblAnnualSalary.Content + " is Invalid. You need insert only numeric data" + "\n";
                }
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (txtHouralyRate.Text.Length <= 0)
            {
                errorMessage += "Field: " + lblHouralyRate.Content + " is Invalid." + "\n";
            }
            else
            {
                if (!IsNumber(txtHouralyRate.Text.ToString()))
                {
                    errorMessage += "Field: " + lblHouralyRate.Content + " is Invalid. You need insert only numeric data" + "\n";
                }
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (txtMobileTelephone.Text.Length <= 0)
            {
                errorMessage += "Field: " + lblMobile.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************


            //***************************************************************
            //***************************************************************
            if (txtHomeTelephone.Text.Length <= 0)
            {
                errorMessage += "Field: " + lblHomeTepehone.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************


            //***************************************************************
            //***************************************************************
            if (!validationEmail(txtEmail.Text))
            {
                errorMessage += "Field: " + lblPersonalEmail.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************


            //***************************************************************
            //***************************************************************
            if (!IsPostalCode(txtPostCode.Text))
            {
                errorMessage += "Field: " + lblPostCode.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (cbPositions.Items.Count <= 0)
            {
                errorMessage += "Field: " + lblPosition.Content + " is Invalid." + "\n";
            }
            //***************************************************************
            //***************************************************************

            //***************************************************************
            //***************************************************************
            if (imgGenderMale.IsVisible == false && imgGenderFemale.IsVisible == false && imgGenderMaleAndFemale.IsVisible == false)
            {
                errorMessage += "Field: " + lblGender.Content + " is Invalid. You need select Gender" + "\n";
            }
            //***************************************************************
            //***************************************************************

            if (errorMessage == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(errorMessage, "Verification Data");
                return false;
            }



        }

        private void insertEmployee()
        {
            //reference to clase
            ServiceReference.tblEmployee objEmployee = new ServiceReference.tblEmployee();


            //mapping data
            objEmployee.Cit_CityId = Int32.Parse(cbCities.SelectedValue.ToString());
            objEmployee.Dep_DepartmentId = Int32.Parse(cbDepartment.SelectedValue.ToString());
            objEmployee.Emp_Address = txtAddress.Text;
            objEmployee.Emp_AnualSalary = Decimal.Parse(txtAnnualSalary.Text);
            objEmployee.Emp_HourlyRate = Decimal.Parse(txtHouralyRate.Text);
            objEmployee.Emp_CellPhone = txtMobileTelephone.Text;
            objEmployee.Emp_Phone = txtHomeTelephone.Text;
            objEmployee.Emp_Email = txtEmail.Text;
            objEmployee.Emp_FirstName = txtFirstName.Text;
            objEmployee.Emp_LastName = txtLastName.Text;
            objEmployee.Emp_PostalCode = txtPostCode.Text;
            objEmployee.Tit_TitleId = Int32.Parse(cbTitles.SelectedValue.ToString());
            objEmployee.Pos_PositionId = Int32.Parse(cbPositions.SelectedValue.ToString());
            if (imgGenderMale.IsVisible) objEmployee.Emp_Gender = "M";
            if (imgGenderFemale.IsVisible) objEmployee.Emp_Gender = "F";
            if (imgGenderMaleAndFemale.IsVisible) objEmployee.Emp_Gender = "B";

            //----------------------------------------------------------------------
            objEmployee.Emp_BirthOfDate = DateTime.Now;
            DateTime? selectedDateDOB = dpDOB.SelectedDate;
            if (selectedDateDOB.HasValue)
            {
                //string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                objEmployee.Emp_BirthOfDate = selectedDateDOB.Value;
            }
            //----------------------------------------------------------------------

            //----------------------------------------------------------------------
            objEmployee.Emp_StartDate = DateTime.Now;
            DateTime? selectedDateStart = dpDateStart.SelectedDate;
            if (selectedDateStart.HasValue)
            {
                //string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                objEmployee.Emp_StartDate = selectedDateStart.Value;
            }
            //----------------------------------------------------------------------

            //----------------------------------------------------------------------
            objEmployee.Emp_TerminationDate = DateTime.Now;
            DateTime? selectedDateFinish = dpDateFinish.SelectedDate;
            if (selectedDateFinish.HasValue)
            {
                //string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                objEmployee.Emp_TerminationDate = selectedDateFinish.Value;
            }
            //----------------------------------------------------------------------


            objEmployee.Emp_Photo = null;



            if (WCFHRHumanResources.insertEmployees(objEmployee))
            {
                MessageBox.Show("Employee inserted successfully");
                txtEmployeeId.Text = fSearchLastEmployeeId().ToString();
            }
            else
            {
                MessageBox.Show("Failed insert Employee");
            }


        }



        private void updateEmployee()
        {
            //reference to clase
            ServiceReference.tblEmployee objEmployee = new ServiceReference.tblEmployee();

            int EmployeeId = Int32.Parse(txtEmployeeId.Text.ToString());


            //mapping data
            objEmployee.Emp_EmployeeId = EmployeeId;
            objEmployee.Cit_CityId = Int32.Parse(cbCities.SelectedValue.ToString());
            objEmployee.Dep_DepartmentId = Int32.Parse(cbDepartment.SelectedValue.ToString());
            objEmployee.Emp_Address = txtAddress.Text;
            objEmployee.Emp_AnualSalary = Decimal.Parse(txtAnnualSalary.Text);
            objEmployee.Emp_HourlyRate = Decimal.Parse(txtHouralyRate.Text);
            objEmployee.Emp_CellPhone = txtMobileTelephone.Text;
            objEmployee.Emp_Phone = txtHomeTelephone.Text;
            objEmployee.Emp_Email = txtEmail.Text;
            objEmployee.Emp_FirstName = txtFirstName.Text;
            objEmployee.Emp_LastName = txtLastName.Text;
            objEmployee.Emp_PostalCode = txtPostCode.Text;
            objEmployee.Tit_TitleId = Int32.Parse(cbTitles.SelectedValue.ToString());
            objEmployee.Pos_PositionId = Int32.Parse(cbPositions.SelectedValue.ToString());
            if (imgGenderMale.IsVisible) objEmployee.Emp_Gender = "M";
            if (imgGenderFemale.IsVisible) objEmployee.Emp_Gender = "F";
            if (imgGenderMaleAndFemale.IsVisible) objEmployee.Emp_Gender = "B";

            //----------------------------------------------------------------------
            objEmployee.Emp_BirthOfDate = DateTime.Now;
            DateTime? selectedDateDOB = dpDOB.SelectedDate;
            if (selectedDateDOB.HasValue)
            {
                //string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                objEmployee.Emp_BirthOfDate = selectedDateDOB.Value;
            }
            //----------------------------------------------------------------------

            //----------------------------------------------------------------------
            objEmployee.Emp_StartDate = DateTime.Now;
            DateTime? selectedDateStart = dpDateStart.SelectedDate;
            if (selectedDateStart.HasValue)
            {
                //string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                objEmployee.Emp_StartDate = selectedDateStart.Value;
            }
            //----------------------------------------------------------------------

            //----------------------------------------------------------------------
            objEmployee.Emp_TerminationDate = DateTime.Now;
            DateTime? selectedDateFinish = dpDateFinish.SelectedDate;
            if (selectedDateFinish.HasValue)
            {
                //string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                objEmployee.Emp_TerminationDate = selectedDateFinish.Value;
            }
            //----------------------------------------------------------------------


            objEmployee.Emp_Photo = null;
            //objEmployee.Emp_Photo = Bytes2Image(imgEmployee.Source);
            

            if (WCFHRHumanResources.updateEmployees(objEmployee, EmployeeId))
            {
                MessageBox.Show("Employee updated successfully");
                txtEmployeeId.Text = "";
            }
            else
            {
                MessageBox.Show("Failed update Employee");
            }


        }



        private void deleteEmployee()
        {

            if (MessageBox.Show("Are you sure that you delete this Employee?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                int EmployeeId = Int32.Parse(txtEmployeeId.Text.ToString());

                if (WCFHRHumanResources.deleteEmployees(EmployeeId))
                {
                    MessageBox.Show("Employee deleted successfully");
                    txtEmployeeId.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed delete Employee");
                }
            }

        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            optionSelectedCRUM = "u";
            sbItem3.Content = "Update Employee";

            Clear_Controls();
            txtEmployeeId.Text = "";

            Enabled_Desabled_Controls(false);
            txtEmployeeId.IsEnabled = true;
            //cbTitles.Focus();
            txtEmployeeId.Focus();


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            optionSelectedCRUM = "d";
            sbItem3.Content = "Delete Employee";

            Clear_Controls();
            txtEmployeeId.Text = "";

            Enabled_Desabled_Controls(false);
            txtEmployeeId.IsEnabled = true;
            //cbTitles.Focus();
            txtEmployeeId.Focus();


        }

        private void btnGenderMale_Click(object sender, RoutedEventArgs e)
        {
            imgGenderMale.Visibility = System.Windows.Visibility.Visible;
            imgGenderFemale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Hidden;
            txtAddress.Focus();

        }

        private void btnGenderFemale_Click(object sender, RoutedEventArgs e)
        {

            imgGenderMale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderFemale.Visibility = System.Windows.Visibility.Visible;
            imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Hidden;
            txtAddress.Focus();
        }

        private void btnGenderMaleAndFemale_Click(object sender, RoutedEventArgs e)
        {
            imgGenderMale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderFemale.Visibility = System.Windows.Visibility.Hidden;
            imgGenderMaleAndFemale.Visibility = System.Windows.Visibility.Visible;
            txtAddress.Focus();

        }



        public bool IsNumber(string num)
        {
            {
                try
                {
                    double x = Convert.ToDouble(num);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool IsIntegerNumber(string num)
        {
            {
                try
                {
                    int x = Convert.ToInt32(num);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        private Boolean validationEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsPostalCode(string postalCode)
        {

            //Canadian Postal Code in the format of "M3A 1A5"
            string pattern = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";

            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            if (!(reg.IsMatch(postalCode)))
                return false;
            return true;
        }


        private void Initial_Status_Bar()
        {
            sbItem1.Content = "Maintenace Employees";
            //sbItem3.Content = "New Employee";
            sbItem3.Content = "";
            sbItem4.Content = DateTime.Now;

        }


        private void Initial_Timer()
        {
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            sbItem4.Content = DateTime.Now;
        }

        private void txtEmployeeId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                if (txtEmployeeId.Text.Length > 0 && IsIntegerNumber(txtEmployeeId.Text.ToString()))
                {
                    int EmployeeId = Int32.Parse(txtEmployeeId.Text.ToString());

                    bool query = WCFHRHumanResources.GetVerifyIfEmployeeExist(EmployeeId);
                    if (query == true)
                    {
                        //fill fields in form
                        Fill_Employee_Info(EmployeeId);


                        if (optionSelectedCRUM == "u")
                        {

                            Enabled_Desabled_Controls(true);
                            txtFirstName.Focus();
                        }
                        else //delete
                        {

                            Enabled_Desabled_Controls(false);
                            btnSave.Focus();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                        txtEmployeeId.Text = "";
                        txtEmployeeId.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("Data field invalid. You need insert only integer numbers");
                    txtEmployeeId.Text = "";
                }

            }

        }

        private void txtEmployeeId_TextChanged(object sender, TextChangedEventArgs e)
        {
            Clear_Controls();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imgEmployee.Source = new BitmapImage(new Uri(op.FileName));
            }
        }





    }
}

