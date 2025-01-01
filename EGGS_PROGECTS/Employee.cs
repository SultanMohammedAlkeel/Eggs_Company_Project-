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
    public partial class Employee : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isnew;
        int x;
        public Employee()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            get_dgv_data();
            get_cmbAmber();
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
        private void get_dgv_data()
        {
            adapter = new SqlDataAdapter("exec get_data_emp", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;
        }
        private void pnl_state(bool v)
        {
            pnlfields.Visible = v;
            btnnew.Enabled = btnupdate.Enabled = !v;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
        private void trans_values()
        {
            txtEname.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtEmpphone.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtEaddrss.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            txtEjob.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            txtEsal.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            cmbAmber.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
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

        private void updateEmp(int Eid, string name, string phone, string address, string job, string sal, int A_id)
        {
            con.Open();
            cmd = new SqlCommand($"exec update_Emp {Eid},'{name}','{phone}','{address}','{job}','{sal}',{A_id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            get_dgv_data();
        }

        private void newEmp(string name, string phone, string address, string job, string sal, int A_id)
        {
            con.Open();
            cmd = new SqlCommand($"exec new_Emp '{name}','{phone}','{address}','{job}','{sal}',{A_id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            get_dgv_data();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
        }

        private void delete_Employee(int x)
        {
            con.Open();
            cmd = new SqlCommand($" delete from emp where E_id= {x}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            if (search.text == "")
                get_dgv_data();
            else
            {
                adapter = new SqlDataAdapter($"exec search_Employee '{search.text}'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }

        }

        private void txtEaddrss_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (isnew && check())
            {
                newEmp(txtEname.Text, txtEmpphone.Text,
                   txtEaddrss.Text, txtEjob.Text, txtEsal.Text, Convert.ToInt32(cmbAmber.SelectedValue.ToString()));
                pnl_state(false);
                clear_fields();
            }
            else if (check() && !isnew)
            {
                updateEmp(x, txtEname.Text, txtEmpphone.Text,
                   txtEaddrss.Text, txtEjob.Text, txtEsal.Text, Convert.ToInt32(cmbAmber.SelectedValue.ToString()));
                pnl_state(false);
                clear_fields();
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            clear_fields();
            pnl_state(false);
            btndelete.Enabled = btnupdate.Enabled = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btndelete.Enabled = btnupdate.Enabled = true;

        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {

        }

        private void btnnew_Click_2(object sender, EventArgs e)
        {
            isnew = true;
            pnl_state(true);
        }

        private void btnupdate_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
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
                delete_Employee(x);
            }
            get_dgv_data();
        }
        bool flag;
        private void txtEmpphone_KeyDown(object sender, KeyEventArgs e)
        {

            flag = ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back);
        }

        private void txtEmpphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !flag;
        }
    }
}
