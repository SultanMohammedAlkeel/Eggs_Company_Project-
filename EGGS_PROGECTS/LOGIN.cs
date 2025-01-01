using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EGGS_PROGECTS
{
    public partial class LOGIN : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        public DataTable dt = new DataTable();

        public LOGIN()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }

        

        

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($" exec test_password '{txtname.Text}','{txtpass.Text}'", con);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                this.Close();
            }
            else
                MessageBox.Show("حاول مجددا");
            txtname.Clear();
            txtpass.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


    
