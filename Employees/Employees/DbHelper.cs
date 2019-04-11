using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Employees.Database
{
    class DbHelper
    {
        static public DataTable Query(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDB"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}