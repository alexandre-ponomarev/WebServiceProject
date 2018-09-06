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
            editWindow.Owner = this;
            editWindow.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MasterEmployees addWindow = new MasterEmployees();
            addWindow.Owner = this;
            addWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fd = new Microsoft.Win32.OpenFileDialog();
            fd.Filter = "All image formats (*.jpg; *.jpeg; *.bmp; *.png; *.gif)|*.jpg;*.jpeg;*.bmp;*.png;*.gif";
            var ret = fd.ShowDialog();

            if (ret.GetValueOrDefault())
            {
                txtFileName.Text = fd.FileName;

                try
                {
                    BitmapImage bmp = new BitmapImage(new Uri(fd.FileName, UriKind.Absolute));
                    imgPhoto.Source = bmp;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid image file.", "Browse", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }
    }
}
