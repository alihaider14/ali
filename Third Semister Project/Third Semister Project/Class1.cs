using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Third_Semister_Project
{
    class Class1
    {
        public SqlConnection sql = new SqlConnection();
        public void consqlstng()
        {
            sql.ConnectionString = @"Data Source=ALIHAIDER-PC;Initial Catalog=project;Integrated Security=True";
        }
        //@"Data Source=.\SQLEXPRESS;Integrated security=SSPI;database=DCS"
        //@"Data Source=ALIHAIDER-PC;Initial Catalog=project;Integrated Security=True"
    }
}
