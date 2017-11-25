using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paytm_Project
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            panel3.Width = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Width = 150;
           // panel4.Hide();
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Width = 0;
           // panel4.Show();
        }
    }
}
