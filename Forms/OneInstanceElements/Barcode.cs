using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace WhereIsMyBox.Forms.OneInstanceElements
{
    public partial class Barcode : Form
    {
        private string sourceString;
        private Bitmap resultImage;
        public Barcode(string input)
        {
            InitializeComponent();
            ConvertToQr(input);
            this.textLabel.Text = input;
            sourceString = input;
        }

        private void ConvertToQr(string input)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(input, QRCodeGenerator.ECCLevel.H);
            QRCode code = new QRCode(data);
            picture.Image = code.GetGraphic(7);
            resultImage = code.GetGraphic(20);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
        private void SaveToFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = $"Сохранить QR-код для \"{sourceString}\"";
            sfd.InitialDirectory = @"C:\";
            sfd.FileName = sourceString;
            sfd.Filter = "PNG(*.PNG)|*.png";
            sfd.DefaultExt = "png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                resultImage.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }
        private void CopyToClipboard()
        {
            Clipboard.SetImage(resultImage);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.C))
            {
                CopyToClipboard();
                return true;
            }
            else if (keyData == (Keys.S))
            {
                SaveToFile();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
