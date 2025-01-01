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
    public partial class Client : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isnew;
        int x;
           
        public Client()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
            get_dgv_data();
        }
        private void get_dgv_data()
        {
            adapter = new SqlDataAdapter("exec get_data_clients", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            
        }
        private void pnl_state(bool v)
        {
            pnlfields.Visible = v;
            btnnew.Enabled = btnupdate.Enabled = !v;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

           
        }
        private void trans_values()
        {
            txtCname.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtCphone.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtCaddrss.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            cmbcountry.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
        }
        private bool check()
        {
            foreach (Control cont in pnlfields.Controls)
            {
                if ((cont is TextBox) && (cont as TextBox).Text == "")
                {
                    (cont as TextBox).Focus(); return false;
                }
                else
                if ((cont is ComboBox) && (cont as ComboBox).Text == "")
                {
                    (cont as ComboBox).Focus(); return false;
                }
            }
            return true;
        }
        private void clear_fields()
        {
            foreach (Control con in pnlfields.Controls)
            {
                if (con is TextBox)
                    (con as TextBox).Clear();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
        }

        private void newClient(string name, string phone, string address, string country)
        {
            con.Open();
            cmd = new SqlCommand($"exec new_Client '{name}','{phone}','{address}','{country}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            get_dgv_data();
        }
        private void updateClient(int id,string name, string phone, string address, string country)
        {
            con.Open();
            cmd = new SqlCommand($"exec update_Client {id},'{name}','{phone}','{address}','{country}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            get_dgv_data();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }
        private void delete_Client(int x)
        {
            con.Open();
            cmd = new SqlCommand($" exec delete_client {x}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            if (search.text == "")
                get_dgv_data();
            else
            {
                adapter = new SqlDataAdapter($"exec search_Client '{search.text}'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (isnew && check())
            {
                newClient(txtCname.Text, txtCphone.Text,
                   txtCaddrss.Text, cmbcountry.Text);
                pnl_state(false);
                clear_fields();
                get_dgv_data();
            }
            else if (check() && !isnew)
            {
                updateClient(x, txtCname.Text, txtCphone.Text,
                   txtCaddrss.Text, cmbcountry.Text);
                pnl_state(false);
                clear_fields();
                get_dgv_data();

            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            clear_fields();
            pnl_state(false);
        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            isnew = true;
            pnl_state(true);
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                x = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString());
                trans_values();
                isnew = false;
                pnl_state(true);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                if (
                MessageBox.Show(" سيتم حذف هذاالسجل نهائيا وكل السجلات المرتبطة به", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) return;
                x = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString());
                delete_Client(x);
            }
            get_dgv_data();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btndelete.Enabled = btnupdate.Enabled = true;
        }
        bool flag;
        private void txtCphone_KeyDown(object sender, KeyEventArgs e)
        {

            flag = ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back);
        }

        private void txtCphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !flag;
        }
    }
}
