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
    public partial class Sales : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isnew;
        int x;
        public Sales()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
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
        private void get_cmbClient()
        {
            adapter = new SqlDataAdapter("exec get_Client_values_to_cmb", con);
            DataTable dtca = new DataTable();
            adapter.Fill(dtca);
            cmbCname.DataSource = dtca;
            cmbCname.DisplayMember = "C_name";
            cmbCname.ValueMember = "C_id";
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            get_cmbAmber();
            get_cmbClient();
            get_dgv_data();
        }
        private void pnl_state(bool v)
        {
            pnlfieldes.Visible  = v;
            btnnew.Enabled = btnupdate.Enabled = !v;
        }
        private void get_dgv_data()
        {
            adapter = new SqlDataAdapter("exec get_data_Sales", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;
        }
        private bool check()
        {
            foreach (Control cont in pnlfieldes.Controls)
            {
                if ((cont is TextBox) && (cont as TextBox).Text == "")
                {
                    (cont as TextBox).Focus(); return false;
                }
            }
            return true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
        }
        private void trans_values()
        {
            cmbAmber.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            cmbCname.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtcartons.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            txtunitPrice.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            txtdiscount.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            txttotalPrice.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();
            dtmSsdate.Text = dgv.SelectedRows[0].Cells[7].Value.ToString();
        }
        private void clear_fields()
        {
            foreach (Control con in pnlfieldes.Controls)
            {
                if (con is TextBox)
                    (con as TextBox).Clear();
            }
        }
        private void t_Click(object sender, EventArgs e)
        {
           
        }

        private void updateSales(int Sid, int Aid, int Cid, int cartons, int uprice, int discount, int tprice, string date)
        {
            con.Open();
            cmd = new SqlCommand($"exec update_Sales {Sid}, {Aid},{Cid},{cartons},{uprice},{discount},{tprice},'{date}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void newSale(int Aid, int Cid, int cartons, int uprice, int discount, int tprice, string date)
        {
            con.Open();
            cmd = new SqlCommand($"exec new_Sales {Aid},{Cid},{cartons},{uprice},{discount},{tprice},'{date}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }
        private void delete_Sales(int x)
        {
            con.Open();
            cmd = new SqlCommand($" delete from sales where Ss_id= {x}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            if (search.text == "")
                get_dgv_data();
            else
            {
                adapter = new SqlDataAdapter($"exec search_Sales '{search.text}'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
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
                MessageBox.Show("سيتم حذف هذاالسجل نهائيا", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) return;
                x = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString());
                delete_Sales(x);
            }
            get_dgv_data();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (isnew && check())
            {
                newSale(Convert.ToInt32(cmbAmber.SelectedValue), Convert.ToInt32(cmbCname.SelectedValue), Convert.ToInt32(txtcartons.Text), Convert.ToInt32(txtunitPrice.Text), Convert.ToInt32(txtdiscount.Text), Convert.ToInt32(txttotalPrice.Text), DateTime.Now.ToShortDateString());
                pnl_state(false);
                clear_fields();
                get_dgv_data();
            }
            else if (check() && !isnew)
            {
                updateSales(x, Convert.ToInt32(cmbAmber.SelectedValue), Convert.ToInt32(cmbCname.SelectedValue), Convert.ToInt32(txtcartons.Text), Convert.ToInt32(txtunitPrice.Text), Convert.ToInt32(txtdiscount.Text), Convert.ToInt32(txttotalPrice.Text), DateTime.Now.ToShortDateString());
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          btnprint.Enabled=  btndelete.Enabled = btnupdate.Enabled = true;
        }
        bool flag;
        private void txtcartons_KeyDown(object sender, KeyEventArgs e)
        {

            flag = ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back);
        }

        private void txtcartons_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !flag;
        }

        private void txtunitPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int crton = Convert.ToInt32(txtcartons.Text);
                int uintprice = Convert.ToInt32(txtunitPrice.Text);
                txttotalPrice.Text = (crton * uintprice).ToString();

            }
            catch(System.Exception)
            {

            }
        
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int crton = Convert.ToInt32(txtcartons.Text);
                int uintprice = Convert.ToInt32(txtunitPrice.Text);
                int disc = Convert.ToInt32(txtdiscount.Text);
                int total = crton * uintprice;
                txttotalPrice.Text = (total - disc).ToString();

            }
            catch (System.Exception)
            {

            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv.SelectedRows[0];
            string cell = row.Cells[0].Value.ToString();
            int ss_id = Convert.ToInt32(cell);
            REport report = new REport();
            report.Show();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            adapter = new SqlDataAdapter($"exec print_data_Sales {ss_id} ", con);
            dt.Clear();
            adapter.Fill(dt);

            //foreach (DataGridViewColumn item in dgv.SelectedRows)
            //{
            //    dt.Columns.Add(item.HeaderText);

            //}
            //foreach (DataGridViewRow row in dgv.SelectedRows)
            //{
            //    DataRow dr = dt.NewRow();
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        dr[cell.ColumnIndex] = cell.Value;
            //    }
            //    dt.Rows.Add(dr);
            //}

            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(dt);
            report.crystalReportViewer1.ReportSource = cr1;
            report.crystalReportViewer1.Refresh();
            con.Close();
        }
    }
}
