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
    public partial class Products : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isnew;
        int x;
        public Products()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }

        private void txtAemptycar_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlcontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            get_cmbAmber();
            get_dgv_data();
        }

        private void get_dgv_data()
        {
            adapter = new SqlDataAdapter("exec get_data_products", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void get_cmbAmber()
        {
            adapter = new SqlDataAdapter("exec get_Amber_values_to_cmb", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbAmber.DataSource = dt;
            cmbAmber.DisplayMember = "A_name";
            cmbAmber.ValueMember = "A_id";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            
        }

        private void pnl_state(bool v)
        {
            pnlfields.Visible = v;
            btnnew.Enabled = btnupdat.Enabled = !v;
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
        private void newProduct(int A_id, int carton, int dish, int feed, int dead, string date, string note)
        {
            con.Open();
            cmd = new SqlCommand($"exec new_product {A_id},{carton},{dish},{feed},{dead},'{date}','{note}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            get_dgv_data();

        }

        private void updateProduct(int id, int Aname, int carton, int dish, int feed, int dead, string note)
        {
            con.Open();
            cmd = new SqlCommand($"exec update_Product {id},{Aname},{carton},{dish},{feed},{dead},'{note}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
          
        }

        private void btnupdat_Click(object sender, EventArgs e)
        {
           
        }
        private void trans_values()
        {
            cmbAmber.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPcarton.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPdish.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPfeed.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtPdead.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtPnote.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnupdat_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            }

        private void delete_product(int x)
        {
            con.Open();
            cmd = new SqlCommand($" delete from products where P_id = {x}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            if (search.text == "")
                get_dgv_data();
            else
            {
                adapter = new SqlDataAdapter($"exec search_product '{search.text}'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (isnew && check())
            {
                newProduct(Convert.ToInt32(cmbAmber.SelectedValue), Convert.ToInt32(txtPcarton.Text), Convert.ToInt32(txtPdish.Text), Convert.ToInt32(txtPfeed.Text), Convert.ToInt32(txtPdead.Text), DateTime.Now.ToShortDateString(), txtPnote.Text);
                pnl_state(false);
                clear_fields();
                get_dgv_data();
            }
            else if (check() && !isnew)
            {
                updateProduct(x, Convert.ToInt32(cmbAmber.SelectedValue), Convert.ToInt32(txtPcarton.Text), Convert.ToInt32(txtPdish.Text), Convert.ToInt32(txtPfeed.Text), Convert.ToInt32(txtPdead.Text), txtPnote.Text);
                pnl_state(false);
                clear_fields();
                get_dgv_data();

            }
        }

        private void btncancel_Click_2(object sender, EventArgs e)
        {
            clear_fields();
            pnl_state(false);
            btndelete.Enabled = btnupdat.Enabled = false;
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                   MessageBox.Show("سيتم حذف هذاالسجل نهائيا  !!!", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) return;
                x = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                delete_product(x);
            }
            get_dgv_data();

        }

        private void btnupdat_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                x = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                trans_values();
                isnew = false;
                pnl_state(true);
            }
        }

        private void btnnew_Click_2(object sender, EventArgs e)
        {
            isnew = true;
            pnl_state(true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btndelete.Enabled = btnupdat.Enabled = true;

        }
        bool flag;
        private void txtPcarton_KeyDown(object sender, KeyEventArgs e)
        {

            flag = ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back);
        }

        private void txtPcarton_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !flag;
        }

        private void txtPdish_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtPdish.Text != "")
                {
                    int val = Convert.ToInt32(txtPdish.Text);
                    if (!(val >= 0 && val <= 11))
                    {
                        MessageBox.Show("the number of dishes most be between 0 and 11 ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPdish.Clear(); ;
                    }
                }
            }
        }

        private void cmbAmber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlfields_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
