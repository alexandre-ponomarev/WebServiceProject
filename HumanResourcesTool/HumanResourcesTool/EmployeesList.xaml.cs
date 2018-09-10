using HumanResourcesTool.ServiceReference;
using Microsoft.Win32;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HumanResourcesTool
{
    /// <summary>
    /// Interaction logic for EmployeesList.xaml
    /// </summary>
    public partial class EmployeesList : Window
    {
        ServiceReference.HRWebServicesClient HRWebServices;
        List<tblEmployee> query;

        public EmployeesList()
        {
            InitializeComponent();
            Loading();
        }



        private void Loading()
        {
            HRWebServices = new ServiceReference.HRWebServicesClient();

            query = HRWebServices.GetEmployees();
            dataGrid1.ItemsSource = query;
        }



        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            MasterEmployees editWindow = new MasterEmployees();
            var selectedItem = dataGrid1.SelectedItem as tblEmployee;
            if (selectedItem != null)
                //MessageBox.Show(selectedItem.Emp_EmployeeId.ToString());
                editWindow.Owner = this;
            editWindow.btnDelete.IsEnabled = false;
            editWindow.btnUpdate.IsEnabled = false;
            editWindow.btnNew.IsEnabled = false;

            editWindow.optionSelectedCRUM = "u";
            editWindow.flag = true;
            editWindow.txtEmployeeId.Text = selectedItem.Emp_EmployeeId.ToString();
            editWindow.Fill_Employee_Info(selectedItem.Emp_EmployeeId);
            editWindow.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MasterEmployees addWindow = new MasterEmployees();
            addWindow.Owner = this;
            addWindow.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            var query = HRWebServices.GetEmployees();
            dataGrid1.ItemsSource = query;
        }

        

        private void btnPDF_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() == true)
            {

                Document document = new Document();

                String tPdfFont = "Verdana";
                MigraDoc.DocumentObjectModel.Style style = document.Styles["Normal"];
                style.Font.Name = tPdfFont;
                style.Font.Size = 6;

                Section section = document.AddSection();

                Table table = new Table();
                table.Borders.Width = 0.75;

                Column column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column = table.AddColumn(Unit.FromCentimeter(1.5));
                column.Format.Alignment = ParagraphAlignment.Center;

                table.AddColumn(Unit.FromCentimeter(1.5));

                Row row = table.AddRow();
                row.Shading.Color = MigraDoc.DocumentObjectModel.Colors.PaleGoldenrod;
                Cell cell = row.Cells[0];
                cell.AddParagraph("ID");
                cell = row.Cells[1];
                cell.AddParagraph("FN");
                cell = row.Cells[2];
                cell.AddParagraph("LN");
                cell = row.Cells[3];
                cell.AddParagraph("Gender");
                cell = row.Cells[4];
                cell.AddParagraph("DOB");
                cell = row.Cells[5];
                cell.AddParagraph("Address");
                cell = row.Cells[6];
                cell.AddParagraph("City");
                cell = row.Cells[7];
                cell.AddParagraph("ZIP");
                cell = row.Cells[8];
                cell.AddParagraph("Department");
                cell = row.Cells[9];
                cell.AddParagraph("Position");
                cell = row.Cells[10];
                cell.AddParagraph("Salary");

                foreach (var emp in query)
                {
                    row = table.AddRow();
                    cell = row.Cells[0];
                    cell.AddParagraph(emp.Emp_EmployeeId.ToString());
                    cell = row.Cells[1];
                    cell.AddParagraph(emp.Emp_FirstName);
                    cell = row.Cells[2];
                    cell.AddParagraph(emp.Emp_LastName);
                    cell = row.Cells[3];
                    cell.AddParagraph(emp.Emp_Gender);
                    cell = row.Cells[4];
                    cell.AddParagraph(emp.Emp_BirthOfDate.ToShortDateString());
                    cell = row.Cells[5];
                    cell.AddParagraph(emp.Emp_Address);
                    cell = row.Cells[6];
                    cell.AddParagraph(emp.tblCity.Cit_Name);
                    cell = row.Cells[7];
                    cell.AddParagraph(emp.Emp_PostalCode);
                    cell = row.Cells[8];
                    cell.AddParagraph(emp.tblDepartment.Dep_Name);
                    cell = row.Cells[9];
                    cell.AddParagraph(emp.tblPosition.Pos_Description);
                    cell = row.Cells[10];
                    cell.AddParagraph(Convert.ToDouble(emp.Emp_AnualSalary).ToString("0.##"));
                }

                //table.SetEdge(0, 0, 2, 3, Edge.Box, BorderStyle.Single, 1.5, MigraDoc.DocumentObjectModel.Colors.Black);

                document.LastSection.Add(table);

                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false,
      PdfFontEmbedding.Always);

                pdfRenderer.Document = document;

                pdfRenderer.RenderDocument();


                string filename = saveFileDialog.FileName;
                pdfRenderer.PdfDocument.Save(filename);

                Process.Start(filename);

            }
        }

        
    }
}
