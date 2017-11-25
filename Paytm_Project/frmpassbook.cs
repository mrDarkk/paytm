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

namespace Paytm_Project
{
    public partial class frmpassbook : Form
    {
        public frmpassbook()
        {
            InitializeComponent();
        }

        private void frmpassbook_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=BHUPEDRA-PC;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from passbook where name='" + Form3.strname + "' ", con);
               
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {
                    // label1.Text = DR1.GetValue(0).ToString();
                    // label2.Text = DR1.GetValue(2).ToString();
                    label5.Text = DR1.GetValue(4).ToString();

                }
                con.Close();

            }
            catch
            {
                MessageBox.Show("dkjsgd");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=BHUPEDRA-PC;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from pay where name='" + Form3.strname + "' ", con);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch
            {
                MessageBox.Show("dkjsgd");
            }
        }
    }
}

