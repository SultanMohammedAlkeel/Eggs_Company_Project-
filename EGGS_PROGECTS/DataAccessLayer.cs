using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EGGS_PROGECTS
{
    class DataAccessLayer
    {
       public SqlConnection con;
        DataTable dt;
        SqlDataAdapter adepter;
        public DataAccessLayer()
        {
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
            open_con();
        }

        public void open_con()
        {
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void close_con()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }




    }
}
