using System.Data.SqlClient;

namespace EasyBank_Management_System
{
    // This is a static class, so you don't need to create an "instance" of it.
    // You can just call DatabaseConnector.GetConnection() from any form.
    public static class DatabaseConnector
    {
        // ⚠️ PUT YOUR REAL CONNECTION STRING HERE
        private static string connectionString = @"Data Source=LAPTOP-6MG735JK\DBS;Initial Catalog=EasyBankManagementSystem;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            // This creates and returns a new connection object
            return new SqlConnection(connectionString);
        }
    }
}