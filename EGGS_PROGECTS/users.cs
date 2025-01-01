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
    public partial class users : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isnew;
        int x;
        public users()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }
        private void get_dgv_data()
        {
            adapter = new SqlDataAdapter("exec get_data_Users", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;
        }
        private void pnl_state(bool v)
        {
            pnlfields.Enabled = v;
            btnnew.Enabled = btnupdate.Enabled = !v;
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
        private void trans_values()
        {
            txtUname.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtUpass.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void clear_fields()
        {
            foreach (Control con in pnlfields.Controls)
            {
                if (con is TextBox)
                    (con as TextBox).Clear();
            }
        }
       

        private void cmblicense_data()
        {
            adapter = new SqlDataAdapter("select *from License", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmblicense.DataSource = dt;
            cmblicense.DisplayMember = "license";
            cmblicense.ValueMember = "id";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
          
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }

        private void delete_User(int x)
        {
            con.Open();
            cmd = new SqlCommand($" delete from users where u_id = {x}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
        }

        private bool check_pass()
        {
            if (txtUpass.Text == txtUUpass.Text)
            {
                return true;
            }
            MessageBox.Show("كلمة المرور ليست متطابقة حاول مجدداً");
            txtUUpass.Focus();
            return false;
        }

        private void updateUser(int id, string name, string Upass, string date, int Lid)
        {
            con.Open();
            cmd = new SqlCommand($"exec update_user {id},'{name}','{Upass}','{date}',{Lid}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void newUser(string name, string Upass, string date, int Lid)
        {
            con.Open();
            cmd = new SqlCommand($"exec new_user '{name}','{Upass}','{date}',{Lid}", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void users_Load(object sender, EventArgs e)
        {
            get_dgv_data();
            cmblicense_data();

        }

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
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
                   MessageBox.Show("سيتم حذف هذاالسجل نهائيا  !!!", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) return;
                x = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString());
                delete_User(x);
            }
            get_dgv_data();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            clear_fields();
            pnl_state(false);
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            check_pass();

            if (isnew && check())
            {
                newUser(txtUname.Text, txtUpass.Text, DateTime.Now.ToShortDateString(), Convert.ToInt32(cmblicense.SelectedValue));
                pnl_state(false);
                clear_fields();
                get_dgv_data();
            }
            else if (check() && !isnew)
            {
                updateUser(x, txtUname.Text, txtUpass.Text, DateTime.Now.ToShortDateString(), Convert.ToInt32(cmblicense.SelectedValue));
                pnl_state(false);
                clear_fields();
                get_dgv_data();

            }
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {






















            btndelete.Enabled = btnupdate.Enabled = true;
        }
    }
}
