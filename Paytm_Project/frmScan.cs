using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebEye.Controls.WinForms.WebCameraControl;

namespace Paytm_Project
{
    public partial class frmScan : Form
    {
        public frmScan()
        {
            InitializeComponent();
        }
        private class ComboBoxItem
        {
            public ComboBoxItem(WebCameraId id)
            {
                _id = id;
            }

            private readonly WebCameraId _id;
            public WebCameraId Id
            {
                get { return _id; }
            }

            public override string ToString()
            {
                // Generates the text shown in the combo box.
                return _id.Name;
            }
        }

        private void frmScan_Load(object sender, EventArgs e)
        {
            foreach (WebCameraId camera in webCameraControl1.GetVideoCaptureDevices())
            {
                comboBox1.Items.Add(new ComboBoxItem(camera));
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
            ComboBoxItem i = (ComboBoxItem)comboBox1.SelectedItem;

            try
            {
                webCameraControl1.StartCapture(i.Id);
            }
            finally
            {
               // UpdateButtons();
            }
        }

        private void webCameraControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }

