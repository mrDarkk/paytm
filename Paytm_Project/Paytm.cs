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
    public partial class Paytm : UserControl
    {
        public Paytm()
        {
            InitializeComponent();
        }

        private void Paytm_Load(object sender, EventArgs e)
        {
            panel3.Width = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Width = 100;
        }
    }
}
