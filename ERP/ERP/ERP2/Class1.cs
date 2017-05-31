using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace ERP2
{
    class Class1
    {
        public OleDbConnection c = new OleDbConnection();
     public void constring() 
     {
         c.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//PC_DB.accdb";
     }
    }
}
