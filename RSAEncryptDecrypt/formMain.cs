using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAEncryptDecrypt
{
    public partial class formMain : Form
    {
        String sourcePath;

        String destPath;

        public formMain()
        {
            InitializeComponent();
        }

        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            String key = txtKey.Text;
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"python",
                    Arguments = @Environment.CurrentDirectory + "/command/ImageEncryption.py 1 " + key,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                }
            };

            proc.Start();

            proc.WaitForExit();
            string output = proc.StandardOutput.ReadToEnd();

            string error = proc.StandardError.ReadToEnd();

            if( output.Equals("1") )
            {

            }
            else if (output.Equals("0"))
            {

            }
        }

        private void btnTabEncryptOpenFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        sourcePath = openFileDialog.FileName;
                        sourceEncryptPictureBox.Image = Image.FromFile(sourcePath);
                        sourceEncryptPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            String key = txtTbEncryptKey.Text;
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"python",
                    Arguments = @Environment.CurrentDirectory + "/command/ImageEncryption.py 2 " + key + " " + sourcePath,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                }
            };
            proc.Start();
            proc.WaitForExit();
            string output = proc.StandardOutput.ReadToEnd();
            string error  = proc.StandardError.ReadToEnd();
            targetEncryptPictureBox.Image = Image.FromFile(output.Trim());
            targetEncryptPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btnDecryptDest_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        destPath = openFileDialog.FileName;
                        destPictureBox.Image = Image.FromFile(destPath);
                        destPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            String key = txtDecryptKey.Text;
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"python",
                    Arguments = @Environment.CurrentDirectory + "/command/ImageEncryption.py 3 " + key + " " + destPath,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                }
            };
            proc.Start();
            proc.WaitForExit();
            string output = proc.StandardOutput.ReadToEnd();
            string error = proc.StandardError.ReadToEnd();
            descryptPictureBox.Image = Image.FromFile(output.Trim());
            descryptPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
