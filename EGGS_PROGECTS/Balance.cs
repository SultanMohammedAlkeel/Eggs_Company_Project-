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
    public partial class Balance : Form
    {
        SqlDataAdapter adapter;
        SqlConnection con;
        DataTable dt = new DataTable();
        public Balance()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            get_data();
            get_Product_chart();
            get_Sells();

        }

        private void get_Sells()
        {
            con.Open();
            int i = 0;
            adapter = new SqlDataAdapter("select Ss_cartons,Ss_date from sales ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            var data1 = new Dictionary<string, int>();
            foreach (DataRow row in dt.Rows)
            {
                string date = row["Ss_date"].ToString()+" "+(i++).ToString();
                int cartons = Convert.ToInt32(row["Ss_cartons"]);
                data1.Add(date, cartons);
            }
            foreach (var item in data1)
            {
                charteggs.Series["sales"].Points.AddXY(item.Key, item.Value);
            }
            con.Close();
        }

        private void get_Product_chart()
        {
            con.Open();
            adapter = new SqlDataAdapter("select A_name,A_remain_cartons from Amber ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            var data = new Dictionary<string, int>();
            foreach (DataRow row in dt.Rows)
            {
                string amber = row["A_name"].ToString();
                int cartons =Convert.ToInt32(row["A_remain_cartons"]);
                data.Add(amber, cartons);
            }
            foreach (var item in data)
            {
                chart1.Series["eggs"].Points.AddXY(item.Key, item.Value);
            }
            con.Close();
        }

        private void get_data()
        {
            con.Open();
            adapter = new SqlDataAdapter(" select b_value from balance", con);
            adapter.Fill(dt);
            txtmony.Text = dt.Rows[0].ItemArray[0].ToString();
            txtfeed.Text = dt.Rows[1].ItemArray[0].ToString();
            txtemcarton.Text = dt.Rows[2].ItemArray[0].ToString();
            txtemdish.Text = dt.Rows[3].ItemArray[0].ToString();
            txtdish.Text = dt.Rows[4].ItemArray[0].ToString();
            txtcarton.Text = dt.Rows[5].ItemArray[0].ToString();
            con.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grb_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
