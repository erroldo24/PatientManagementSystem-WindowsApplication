using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PatientManagementSystem_WindowsApplication
{
    public class databasemanagement
    {
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection connection;
            connection = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Database is Not Acessible", "Error");
            }
            return connection;
        }

        // Adding Data into Table


    }
}
