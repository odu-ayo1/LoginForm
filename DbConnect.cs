using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LoginForm
{
    class DbConnect
    {

        void connect() {

            string con = @"Data Source=DESKTOP-QL6Q26N;Initial Catalog=CRUDDB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(con);
            sc.Open();
        }

        void insert()
        {
           
        
        }


    }
}
