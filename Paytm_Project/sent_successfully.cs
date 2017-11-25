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
    public partial class sent_successfully : UserControl
    {
        public sent_successfully()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = Form2.stbal;
            label3.Text = Form2.no;
            label5.Text = Form2.balance;
        }
    }
}
