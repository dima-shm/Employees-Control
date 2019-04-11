using System;
using System.Windows.Forms;
using Employees.Model;
using Employees.Database;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace Employees
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateComponentsData();
        }

        private void UpdateComponentsData()
        {
            UpdateEmployeesGridView(DbHelper.Query("SELECT * FROM [Employee]"));
            UpdateFilterDropDown(DbHelper.Query("SELECT DISTINCT [Position] FROM [Employee]"));
        }

        private void UpdateEmployeesGridView(DataTable dataTable)
        {
            employeesGridView.DataSource = dataTable;
        }

        private void UpdateFilterDropDown(DataTable dataTable)
        {
            dataTable.Rows.Add("Нет");
            filterDropDown.DataSource = dataTable;
            filterDropDown.DisplayMember = "Position";
            filterDropDown.SelectedIndex = dataTable.Rows.Count - 1;
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DbHelper.Query("SELECT * FROM [Employee] WHERE Id = '" + employeesGridView[0, employeesGridView.CurrentRow.Index].Value.ToString() + "'");
            Employee employee = new Employee()
            {
                Id = (int)dataTable.Rows[0].ItemArray[0],
                Name = dataTable.Rows[0].ItemArray[1].ToString(),
                Surname = dataTable.Rows[0].ItemArray[2].ToString(),
                Position = dataTable.Rows[0].ItemArray[3].ToString()
            };
            DeleteEmployeeForm deleteForm = new DeleteEmployeeForm(employee);
            deleteForm.FormClosed += DeleteForm_FormClosed;
            deleteForm.Show();
        }

        private void DeleteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateComponentsData();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addForm = new AddEmployeeForm();
            addForm.FormClosed += AddForm_FormClosed;
            addForm.Show();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateComponentsData();
        }

        private void getReport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            workSheet.Cells[1, 1] = "Должность";
            workSheet.Cells[1, 2] = "Средняя зарплата";
            int rowExcel = 2;
            DataTable dataTable = DbHelper.Query("SELECT [Position], AVG([Salary]) FROM [Employee] GROUP BY [Position]");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, "A"] = dataTable.Rows[i].ItemArray[0];
                workSheet.Cells[rowExcel, "B"] = dataTable.Rows[i].ItemArray[1];
                ++rowExcel;
            }
            string pathToXmlFile = Environment.CurrentDirectory + "\\" + "report.xls";
            workSheet.SaveAs(pathToXmlFile);
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void filterDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView oDataRowView = filterDropDown.SelectedItem as DataRowView;
            string position = string.Empty;
            if (oDataRowView != null)
                position = oDataRowView.Row["Position"] as string;
            string query = "SELECT * FROM [Employee]";
            if (position != "Нет")
                query = "SELECT * FROM [Employee] WHERE [Position] = N'" + position + "'";
            UpdateEmployeesGridView(DbHelper.Query(query));
        }
    }
}