using Employees.Database;
using Employees.Model;
using System.Windows.Forms;

namespace Employees
{
    public partial class DeleteEmployeeForm : Form
    {
        private Employee _employee;

        public DeleteEmployeeForm()
        {
            InitializeComponent();
        }

        public DeleteEmployeeForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            labelEmployeeInfo.Text = employee.ToString();
        }

        private void buttonYes_Click(object sender, System.EventArgs e)
        {
            DbHelper.Query("DELETE FROM [Employee] WHERE Id = '" + _employee.Id + "'");
            this.Close();
        }

        private void buttonNo_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}