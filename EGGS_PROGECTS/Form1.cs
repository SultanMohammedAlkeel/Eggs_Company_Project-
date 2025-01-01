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
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }
        Form  POINTER  = new  Form();
        LOGIN log = new LOGIN();

        private void Form1_Load(object sender, EventArgs e)
        {
            log.ShowDialog();
            check_user();
            
        }

        private void check_user()
        {
            toolStrip1.Enabled = true;
            tool_state(false);
            try
            {
                int ob = Convert.ToInt32(log.dt.Rows[0].ItemArray[0].ToString());



                switch (ob)
                {
                    case 1:
                        {
                            tool_state(true);
                        }
                        break;
                    case 2:
                        {
                            tsbtn_Amber.Enabled =
                toolStripButtonProduct.Enabled = true;
                        }
                        break;
                    case 3:
                        {
                            toolStripButtonRequirment.Enabled =
    toolStripButtonSuppliers.Enabled = true;
                        }
                        break;
                    case 4:
                        {
                            toolStripButton2.Enabled =
                            toolStripButtonClients.Enabled = true;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch { }

        }

        private void tool_state(bool value)
        {
            tsbtn_Amber.Enabled =
            toolStripButtonProduct.Enabled =
            toolStripButton2.Enabled =
            toolStripButtonRequirment.Enabled =
            toolStripButtonSuppliers.Enabled =
            toolStripButtonClients.Enabled =
            toolStripButtonEmp.Enabled =
            toolStripButtonBalance.Enabled =
            toolStripButton1.Enabled =
            toolStripButton4.Enabled=value;
        }
        private void tsbtn_Amber_Click(object sender, EventArgs e)
        {
           
            clear_forms();
            ambers Amb = new ambers();
            POINTER = Amb;
            Amb.Show();

        }

        private void clear_forms()
        {
            POINTER.Close();

           //foreach(Form form in this.MdiChildren)
           // {
           //     (form as Form).Close();
           // }
        }

        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            clear_forms();
            Products Pro = new Products();
            POINTER = Pro;
            Pro.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            clear_forms();
            Sales sales = new Sales();
            POINTER = sales;
            sales.Show();
        }

        private void toolStripButtonRequirment_Click(object sender, EventArgs e)
        {
            clear_forms();
            Requirment requir = new Requirment();
            POINTER = requir;
            requir.Show();
        }

        private void toolStripButtonSuppliers_Click(object sender, EventArgs e)
        {
            clear_forms();
            Suppliers supply = new Suppliers();
            POINTER = supply;
            supply.Show();
        }
        Client client = new Client();
        private void toolStripButtonClients_Click(object sender, EventArgs e)
        {
            
            clear_forms();
            Client client = new Client();
            POINTER = client;
            client.Show();
            
        }

        private void toolStripButtonEmp_Click(object sender, EventArgs e)
        {
            clear_forms();
            Employee emp = new Employee();
            POINTER = emp;
            emp.Show();
        }

        private void toolStripButtonBalance_Click(object sender, EventArgs e)
        {
            clear_forms();
            Balance balance = new Balance();
            POINTER = balance;
            balance.Show();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            clear_forms();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            clear_forms();
            users user = new users();
            POINTER = user;
            user.Show();
        }
    }
}
