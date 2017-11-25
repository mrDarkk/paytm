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
    public partial class Form2 : Form
    {
        public static string stbal;
        public static string balance;
        public static string no;
       //public SqlConnection con = new SqlConnection("Data Source=BHUPEDRA-PC;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public Form2()
        {
            InitializeComponent();
        }
        string g;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int bal = Form3.strbal;
            string name = Form3.strname;
             int c_bal100; 
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(bal);

            SqlConnection con2 = new SqlConnection("Data Source=BHUPEDRA-PC;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con2.Open();
            SqlCommand cmd4 = new SqlCommand("select * from passbook where name='" + name + "' ", con2);
            SqlDataReader DR2 = cmd4.ExecuteReader();
            if (DR2.Read())
            {
                label2.Text = DR2.GetValue(4).ToString();
            }
            con2.Close();
           

            c_bal100 = b - a;


            try
            {

                SqlConnection con = new SqlConnection("Data Source=BHUPEDRA-PC;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                SqlCommand cmd3 = new SqlCommand("select * from passbook where mo_no='" + textBox1.Text + "' ", con);
               // SqlCommand cmd4 = new SqlCommand("select * from passbook where mo_no=" + textBox1.Text + "", con2);
                SqlDataReader DR1 = cmd3.ExecuteReader();
                if (DR1.Read())
                {
                   label3.Text  = DR1.GetValue(4).ToString();
                }
                con.Close();
               
              try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update passbook set bal=" + c_bal100 + " where name='" + name + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();

                    int ac;
                    int c = Convert.ToInt32(label3.Text);
                    ac = a + c;
                    SqlCommand cmd1 = new SqlCommand("update passbook set bal='" + ac + "' where mo_no=" + textBox1.Text + " ", con);
                    
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    SqlCommand cmd5 = new SqlCommand("insert into pay (name,bal,send,con) values('" + Form3.strname + "','" + c_bal100 + "','" + textBox1.Text + "','" + g + "') ", con);
                    cmd5.ExecuteNonQuery();
                    con.Close();

                    NotifyIcon notifyIcon = new NotifyIcon();
                    notifyIcon.Visible = true;
                    // notifyIcon = new NotifyIcon();
                    notifyIcon.Icon = new Icon("paytm.ico");
                    //  notifyIcon.Text = "Folder Monitor";
                    // notifyIcon.Visible = true;


                    notifyIcon.BalloonTipTitle = "Paytm";
                    notifyIcon.BalloonTipText = "Successful payed " +a + " \n updated balance " + c_bal100 + "\n thanks for use  .-. " + Form3.strname + " ";
                    //notifyIcon.Icon = SystemIcons.Application;
                    notifyIcon.ShowBalloonTip(30000);

                    stbal = textBox2.Text;
                    balance = Convert.ToString(c_bal100);
                    no = textBox1.Text;
                    frmsendSuccess send = new frmsendSuccess();
                    send.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

               
            }
            catch(Exception ex)
            {
                MessageBox.Show("sorry invalid no");
                
            }

           

            
        }
    }   
}
