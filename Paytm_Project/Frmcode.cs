using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Barcode;

namespace Paytm_Project
{
    public partial class Frmcode : Form
    {
        public Frmcode()
        {
            InitializeComponent();
        }

        private void Frmcode_Load(object sender, EventArgs e)
        {
            label1.Text = Form3.NO_code;

            BarcodeSettings.ApplyKey("your key");//you need a key from e-iceblue, otherwise the watermark 'E-iceblue' will be shown in barcode
            BarcodeSettings settings = new BarcodeSettings();
            settings.Type = BarCodeType.QRCode;
            settings.Unit = GraphicsUnit.Pixel;
            settings.ShowText = false;
            settings.ResolutionType = ResolutionType.UseDpi;
            //input data
            string data = label1.Text;
            settings.Data = data;
            settings.X = 6;
            settings.ForeColor = Color.Blue;

            //generate QR code
            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Image QRbarcode = generator.GenerateImage();
            //display QR code image in picture box
            pictureBox1.Image = QRbarcode;
        }
    }
}
