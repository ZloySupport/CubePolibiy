using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System;
namespace Shiferina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool is_Autorization = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            if (is_Autorization == false)
            {
                var form2 = new Aut2();
                form2.Show();
                Opacity = 0;
                ShowInTaskbar = false;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        ProcessStartInfo ProcRik = new ProcessStartInfo
        {
            FileName = "C:\\Users\\alexb\\source\\repos\\Shiferina\\Shiferina\\Resources\\1.mp4",
            UseShellExecute = true
        };
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //var Meme = new Usolcev();
            //Meme.ShowDialog();
            //Meme.WindowState = FormWindowState.Minimized;
            Process.Start(ProcRik);
        }
        private void Shif_Click(object sender, EventArgs e)
        {
            Crypto crypto = new Crypto();
            string[] str = new string[2];
            str = crypto.Encrypt(MainText.Text);
            OutText.Text = str[0];
            Kkey.Text = str[1];
            
        }
        private void Deshif_Click(object sender, EventArgs e)
        {
            Crypto crypto = new Crypto();
            OutText.Text = crypto.Decrypt(MainText.Text, Kkey.Text);
            
        }

        private void ImportFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    fileStream.Close();
                }
            }
            MainText.Text = fileContent;

        }

        private void ExportFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    fileStream.Close();
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {

                        writer.WriteLine(OutText.Text);
                        writer.Close();
                        OutText.Text = "Данные записаны! Не забудьте записать ключь!";
                    }
                }

            }
        }
    }
}
