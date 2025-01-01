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
    public partial class Requirment : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isnew;
        int x;
           
        
        public Requirment()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Requirment_Load(object sender, EventArgs e)
        {
            get_cmbItems();
            get_cmbAmber();
            get_cmbSname();
            get_dgv_data();

        }
        private void get_cmbItems()
        {
            adapter = new SqlDataAdapter("select * from items", con);
            DataTable dtca = new DataTable();
            adapter.Fill(dtca);
            cmbTname.DataSource = dtca;
            cmbTname.DisplayMember = "T_name";
            cmbTname.ValueMember = "T_id";
        }
        private void get_dgv_data()
        {
            adapter = new SqlDataAdapter("exec get_data_requirments", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvrequir.DataSource = dt;
        }
        private void get_cmbAmber()
        {
            adapter = new SqlDataAdapter("exec get_Amber_values_to_cmb", con);
            DataTable dtca = new DataTable();
            adapter.Fill(dtca);
            cmbAmber.DataSource = dtca;
            cmbAmber.DisplayMember = "A_name";
            cmbAmber.ValueMember = "A_id";
        }
        private void get_cmbSname()
        {
            adapter = new SqlDataAdapter("select S_id,S_name from suppliers", con);
            DataTable dtca = new DataTable();
            adapter.Fill(dtca);
            cmbSname.DataSource = dtca;
            cmbSname.DisplayMember = "S_name";
            cmbSname.ValueMember = "S_id";
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
            cmbAmber.Text = dgvrequir.SelectedRows[0].Cells[1].Value.ToString();
            cmbSname.Text = dgvrequir.SelectedRows[0].Cells[2].Value.ToString();
            cmbTname.Text = dgvrequir.SelectedRows[0].Cells[3].Value.ToString();
            txtqty.Text = dgvrequir.SelectedRows[0].Cells[4].Value.ToString();
            txtunitPrice.Text = dgvrequir.SelectedRows[0].Cells[5].Value.ToString();
            txttotalPrice.Text= dgvrequir.SelectedRows[0].Cells[6].Value.ToString();


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

        private void newRequir(int Aid, int Sid, int Tid, int qty, int uprice, int tprice, string date)
        {
            con.Open();
            cmd = new SqlCommand($"exec new_requirment {Aid},{Sid},{Tid},{qty},{uprice},{tprice},'{date}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            get_dgv_data();
        }
        private void updateRequir(int Rid ,int Aid, int Sid, int Tid, int qty, int uprice, int tprice, string date)
        {

        }
     	
         private void txtunitPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtunitPrice.Text.Length > 0)
            {
                int qn = Convert.ToInt32(txtqty.Text);
                int price = Convert.ToInt32(txtunitPrice.Text);

                txttotalPrice.Text = (qn * price).ToString();
            }
            }
            catch (global::System.Exception)
            {

                
            }
        }

    
	
       

        private void btncancel_Click(object sender, EventArgs e)
        {
          
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            if (search.text == "")
                get_dgv_data();
            else
            {
                adapter = new SqlDataAdapter($"exec search_requir '{search.text}'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvrequir.DataSource = dt;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }
        private void delete_requir(int x)
        {
            con.Open();
            cmd = new SqlCommand($" delete from requirments where R_id= {x}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (isnew && check())
            {
                newRequir(Convert.ToInt32(cmbAmber.SelectedValue), Convert.ToInt32(cmbSname.SelectedValue), Convert.ToInt32(cmbTname.SelectedValue), Convert.ToInt32(txtqty.Text), Convert.ToInt32(txtunitPrice.Text), Convert.ToInt32(txttotalPrice.Text), DateTime.Now.ToShortDateString());
                pnl_state(false);
                clear_fields();
                get_dgv_data();
            }
            else if (check() && !isnew)
            {
                updateRequir(x, Convert.ToInt32(cmbAmber.SelectedValue), Convert.ToInt32(cmbSname.SelectedValue), Convert.ToInt32(cmbTname.SelectedValue), Convert.ToInt32(txtqty.Text), Convert.ToInt32(txtunitPrice.Text), Convert.ToInt32(txttotalPrice.Text), DateTime.Now.ToShortDateString());
                pnl_state(false);
                clear_fields();
                get_dgv_data();

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

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (dgvrequir.SelectedRows.Count > 0)
            {
                x = Convert.ToInt32(dgvrequir.SelectedRows[0].Cells[0].Value.ToString());
                trans_values();
                isnew = false;
                pnl_state(true);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dgvrequir.SelectedRows.Count > 0)
            {
                if (
                MessageBox.Show("سيتم حذف هذاالسجل نهائيا", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) return;
                x = Convert.ToInt32(dgvrequir.SelectedRows[0].Cells[0].Value.ToString());
                delete_requir(x);
            }
            get_dgv_data();
        }

        private void dgvrequir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btndelete.Enabled = btnupdate.Enabled = true;
        }
        bool flag;
        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {

            flag = ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back);
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !flag;
        }
    }
}
