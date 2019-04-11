using Employees.Database;
using System;
using System.Windows.Forms;

namespace Employees
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                string name = textBoxName.Text;
                string surname = textBoxSurname.Text;
                string position = textBoxPosition.Text;
                int birthYear = (int)numericBirthYear.Value;
                int salary = (int)numericSalary.Value;
                string query = "INSERT INTO [Employee] ([Name], [Surname], [Position], [BirthYear], [Salary]) " +
                "VALUES (N'" + name + "', N'" + surname + "', N'" + position + "', N'" + birthYear + "', N'" + salary + "')";
                DbHelper.Query(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте корректность введенных данных");
            }
        }

        private bool IsModelValid()
        {
            return textBoxName.Text != string.Empty &&
                textBoxSurname.Text != string.Empty &&
                textBoxPosition.Text != string.Empty;
        }
    }
}