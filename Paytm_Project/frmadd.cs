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
    public partial class frmadd : Form
    {
        int no;
        public frmadd()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            no = 50;
            textBox1.Text = Convert.ToString(no);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            no = 100;
            textBox1.Text = Convert.ToString(no);
            //no = Convert.ToInt32(textBox1.Text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            no = 500;
            textBox1.Text = Convert.ToString(no);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmadd_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SqlConnection con = new SqlConnection("Data Source=BHUPEDRA-PC;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from passbook where name='" + Form3.strname + "' ", con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {
                // label1.Text = DR1.GetValue(0).ToString();
                // label2.Text = DR1.GetValue(2).ToString();
                label2.Text = DR1.GetValue(4).ToString();

            }
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel4.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label2.Text);
            int b= Convert.ToInt32(textBox1.Text);
            int c = a + b;
            SqlConnection con = new SqlConnection("Data Source=BHUPEDRA-PC;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            con.Open();
            SqlCommand cmd = new SqlCommand("update  passbook set bal="+c+" where name='" + Form3.strname + "' ", con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("ho gaya yarrr");
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            // notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon("paytm.ico");
            //  notifyIcon.Text = "Folder Monitor";
            // notifyIcon.Visible = true;


            notifyIcon.BalloonTipTitle = "Paytm";
            notifyIcon.BalloonTipText = "Successful added "+b+" \n updated balance "+c+"\n thanks for use  .-. "+Form3.strname+" ";
            //notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.ShowBalloonTip(30000);
            
            con.Close();

        }
    }
}
