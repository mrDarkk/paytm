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
using System.Diagnostics;

namespace Paytm_Project
{
    public partial class Form3 : Form
    {
        public static string strname;
        public static int strbal;
        public static string NO_code;
        public Form3()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                textBox1.BackColor = Color.IndianRed;
                textBox2.BackColor = Color.IndianRed;
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=BHUPEDRA-PC;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from passbook where mo_no=" + textBox1.Text + "", con);
                    SqlDataReader DR1 = cmd.ExecuteReader();
                    if (DR1.Read())
                    {
                        label1.Text = DR1.GetValue(0).ToString();
                        label2.Text = DR1.GetValue(2).ToString();
                        label3.Text = DR1.GetValue(4).ToString();
                        label11.Text = DR1.GetValue(1).ToString();
                    }


                    con.Close();
               
                strname = label1.Text;
                NO_code = label11.Text;
                strbal = Convert.ToInt32(label3.Text) ;
                }
                catch
                {
                    MessageBox.Show("invalid");
                }
                if (textBox2.Text == label2.Text)
                {
                    // Form1 f3 = new Form1();
                    // f3.Show();
                    //Form2 f2 = new Form2();
                    //f2.Show();
                    //frmaaa form1 = new frmaaa();
                    //form1.StartPosition = FormStartPosition.Manual;
                    //form1.DesktopLocation = new Point(1000, 0);
                   
                    NotifyIcon notifyIcon = new NotifyIcon();
                    notifyIcon.Visible = true;
                   // notifyIcon = new NotifyIcon();
                    notifyIcon.Icon = new Icon("paytm.ico");
                  //  notifyIcon.Text = "Folder Monitor";
                   // notifyIcon.Visible = true;


                    notifyIcon.BalloonTipTitle = "Paytm";
                        notifyIcon.BalloonTipText = "Successful Login \n wlc "+strname+"";
                    //notifyIcon.Icon = SystemIcons.Application;
                    notifyIcon.ShowBalloonTip(30000);

                    frmhome f2 = new frmhome();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("sorry");
                }
            }   
                    
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            panel2.Height = 0;
            pictureBox13.Visible = false;
            label8.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = char.Parse("\0");
            //textBox2.Visible = true;
        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel2.Height = 40;
            label8.Visible = true;
            pictureBox13.Visible = true;
            pictureBox12.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel2.Height = 0;
            pictureBox12.Visible = true;
            pictureBox13.Visible = false;
            label8.Visible = false;
        }

        //private void textBox2_MouseClick(object sender, MouseEventArgs e)
        //{
        //    //this.textBox2.PasswordChar = char.Parse("*");
        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = char.Parse("*");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start("https://accounts.google.com/ServiceLogin/signinchooser?service=mail&passive=true&rm=false&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&osid=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(timer1.Interval == timer1.)
        }
    }
}
