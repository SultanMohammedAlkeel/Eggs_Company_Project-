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
    public partial class ambers : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adepter;
        bool isnew;
        int x;
        public ambers()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PC_SULTAN\SU;Initial Catalog=EGGS_COMPANY;Integrated Security=True");
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //if (isnew && check())
            //{
            //    newAmber(txtAname.Text, Convert.ToInt32(txtAcarton.Text), Convert.ToInt32(txtAdish.Text), Convert.ToInt32(txtAfeed.Text), Convert.ToInt32(txtAdead.Text), Convert.ToInt32(txtAtotch.Text), Convert.ToInt32(txtAemptycar.Text), Convert.ToInt32(txtAemptydish.Text));
            //    pnl_state(false);
            //    clear_fields();
            //    get_data();
            //}
            //else if (check() && !isnew)
            //{
            //    updateAmber(x, txtAname.Text, Convert.ToInt32(txtAcarton.Text), Convert.ToInt32(txtAdish.Text), Convert.ToInt32(txtAfeed.Text), Convert.ToInt32(txtAdead.Text), Convert.ToInt32(txtAtotch.Text), Convert.ToInt32(txtAemptycar.Text), Convert.ToInt32(txtAemptydish.Text));
            //    pnl_state(false);
            //    clear_fields();
            //    get_data();

            //}
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //clear_fields();
            //pnl_state(false);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    if (
            //       MessageBox.Show("سيتم حذف هذاالسجل نهائيا بالإضافة الى جميع السجلات المرتبطة به !!!", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) return;
            //    x = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //    delete_Amber(x);
            //}
            //get_data();
        }

        private void btnupdat_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    x = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //    trans_values();
            //    isnew = false;
            //    pnl_state(true);
            //}
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            //isnew = true;
            //pnl_state(true);
        }

        private void ambers_Load(object sender, EventArgs e)
        {
            get_data();
            pnl_state(false);
        }
        private void delete_Amber(int x)
        {
            con.Open();
            cmd = new SqlCommand($" exec delete_Amber {x}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void trans_values()
        {
            txtAname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAcarton.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtAdish.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtAfeed.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtAdead.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtAtotch.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtAemptycar.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtAemptydish.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }
        private void newAmber(string name, int carton, int dish, int feed, int dead, int totalch, int emCar, int emDish)
        {
            con.Open();
            cmd = new SqlCommand($"exec add_new_Amber {name},{carton},{dish},{feed},{dead},{totalch},{emCar},{emDish}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void updateAmber(int id, string name, int carton, int dish, int feed, int dead, int totalch, int emCar, int emDish)
        {
            con.Open();
            cmd = new SqlCommand($"exec update_Amber {id},{name},{carton},{dish},{feed},{dead},{totalch},{emCar},{emDish}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void clear_fields()
        {
            foreach (Control con in pnlfields.Controls)
            {
                if (con is TextBox)
                    (con as TextBox).Clear();
            }
        }
        private bool check()
        {
            foreach (Control cont in pnlfields.Controls)
            {
                if ((cont is TextBox) && (cont as TextBox).Text == "")
                {
                    (cont as TextBox).Focus(); return false;
                }
            }
            return true;
        }
        private void get_data()
        {
            con.Open();
            adepter = new SqlDataAdapter("exec get_data_Amber", con);
            DataTable dt = new DataTable();
            adepter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            con.Close();
        }



        private void pnl_state(bool v)
        {
            pnlfields.Visible = v;
            btnnew.Enabled =!v;
        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnupdat_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
           
        }

        private void search_OnTextChange_1(object sender, EventArgs e)
        {
            if (search.text == "")
                get_data();
            else
            {
                adepter = new SqlDataAdapter($"exec search_Amber '{search.text}'", con);
                DataTable dt = new DataTable();
                adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            isnew = true;
            pnl_state(true);
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

        private void btndelete_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                   MessageBox.Show("سيتم حذف هذاالسجل نهائيا بالإضافة الى جميع السجلات المرتبطة به !!!", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) return;
                x = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                delete_Amber(x);
            }
            get_data();
        }

        private void btnsave_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click_2(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnupdat.Enabled = btndelete.Enabled = true;
        }

        private void txtAfeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlfields_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click_3(object sender, EventArgs e)
        {
            if (isnew && check())
            {
                newAmber(txtAname.Text, Convert.ToInt32(txtAcarton.Text), Convert.ToInt32(txtAdish.Text), Convert.ToInt32(txtAfeed.Text), Convert.ToInt32(txtAdead.Text), Convert.ToInt32(txtAtotch.Text), Convert.ToInt32(txtAemptycar.Text), Convert.ToInt32(txtAemptydish.Text));
                pnl_state(false);
                clear_fields();
                get_data();
            }
            else if (check() && !isnew)
            {
                updateAmber(x, txtAname.Text, Convert.ToInt32(txtAcarton.Text), Convert.ToInt32(txtAdish.Text), Convert.ToInt32(txtAfeed.Text), Convert.ToInt32(txtAdead.Text), Convert.ToInt32(txtAtotch.Text), Convert.ToInt32(txtAemptycar.Text), Convert.ToInt32(txtAemptydish.Text));
                pnl_state(false);
                clear_fields();
                get_data();

            }
        }

        private void btncancel_Click_3(object sender, EventArgs e)
        {
            clear_fields();
            pnl_state(false);
            btnupdat.Enabled = btndelete.Enabled = false;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox8_Click(object sender, EventArgs e)
        {

        }
        bool flag;
        private void txtAdish_KeyDown(object sender, KeyEventArgs e)
        {
            flag = ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)||e.KeyCode==Keys.Back);
        }

        private void txtAdish_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !flag;
        }

        private void txtAdish_TextChanged(object sender, EventArgs e)
        {
            if (txtAdish.Text != "")
            {
                int val = Convert.ToInt32(txtAdish.Text);
                if (!(val >= 0 && val <= 11))
                {
                    MessageBox.Show("the number of dishes most be between 0 and 11 ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdish.Clear(); ;
                }
            }
        }
    }
}
