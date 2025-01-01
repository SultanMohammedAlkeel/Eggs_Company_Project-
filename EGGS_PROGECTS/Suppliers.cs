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
    public partial class Suppliers : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isnew;
        int x;

        public Suppliers()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            get_dgv_data();

        }
        private void get_dgv_data()
        {
            adapter = new SqlDataAdapter("exec get_data_suppliers", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvsupp.DataSource = dt;
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

        private void updatesupp(int id, string name, string phone, string address, object contry)
        {
            con.Open();
            cmd = new SqlCommand($"exec update_supplier {id},'{name}','{phone}','{address}','{contry}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            get_dgv_data();
        }

        private void newSupp(string name, string phone, string address, object contry)
        {
            con.Open();
            cmd = new SqlCommand($"exec new_supplier '{name}','{phone}','{address}','{contry}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            get_dgv_data();
        }
        private void trans_values()
        {
            txtSname.Text = dgvsupp.SelectedRows[0].Cells[1].Value.ToString();
            txtSphone.Text = dgvsupp.SelectedRows[0].Cells[2].Value.ToString();
            txtSaddrss.Text = dgvsupp.SelectedRows[0].Cells[3].Value.ToString();
            cmbcountry.Text = dgvsupp.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }
        private void delete_suppliers(int x)
        {
            con.Open();
            cmd = new SqlCommand($" delete from suppliers where S_id= {x}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            if (search.text == "")
                get_dgv_data();
            else
            {
                adapter = new SqlDataAdapter($"exec search_supplier '{search.text}'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvsupp.DataSource = dt;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (isnew && check())
            {
                newSupp(txtSname.Text, txtSphone.Text,
                   txtSaddrss.Text, cmbcountry.SelectedItem);
                pnl_state(false);
                clear_fields();
            }
            else if (check() && !isnew)
            {
                updatesupp(x, txtSname.Text, txtSphone.Text,
                   txtSaddrss.Text, cmbcountry.SelectedItem);
                pnl_state(false);
                clear_fields();
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            clear_fields();
            pnl_state(false);
            btndelete.Enabled = btnupdate.Enabled = false;

        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            isnew = true;
            pnl_state(true);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dgvsupp.SelectedRows.Count > 0)
            {
                x = Convert.ToInt32(dgvsupp.SelectedRows[0].Cells[0].Value.ToString());
                trans_values();
                isnew = false;
                pnl_state(true);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dgvsupp.SelectedRows.Count > 0)
            {
                if (
                MessageBox.Show("سيتم حذف هذاالسجل نهائيا", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) return;
                x = Convert.ToInt32(dgvsupp.SelectedRows[0].Cells[0].Value.ToString());
                delete_suppliers(x);
            }
            get_dgv_data();
        }

        private void dgvsupp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btndelete.Enabled = btnupdate.Enabled = true;
        }
        bool flag;
        private void txtSphone_KeyDown(object sender, KeyEventArgs e)
        {
             
            flag = ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back);
        }

        private void txtSphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !flag;
        }
    }
}
