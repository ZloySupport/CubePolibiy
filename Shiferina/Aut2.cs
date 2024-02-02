using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Shiferina
{
    public partial class Aut2 : Form
    {
        private DB DataB = new DB();
        public Aut2()
        {
            InitializeComponent();
        }
        private void Aut2_Load(object sender, EventArgs e)
        {
            var formMain = new Form1();
            formMain.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Log = Login.Text;
            char[] chars = Log.ToCharArray();
            bool hacked = false;
            foreach (char c in chars)
            {
                if (c == '\'')
                {
                    var usolcev = new Usolcev();
                    usolcev.Show();
                    usolcev.WindowState = FormWindowState.Maximized;
                    hacked = true;
                    break;
                }
            }

            char[] chars2 = Password.Text.ToCharArray();
            foreach (char c in chars2)
            {
                if (c == '\'')
                {
                    var usolcev = new Usolcev();
                    usolcev.Show();
                    usolcev.WindowState = FormWindowState.Maximized;
                    hacked = true;
                    break;
                }

            }

            if (hacked == false)
            {
                DataB.ConnectDB("C:\\Games\\Data.db");
                bool Au = DataB.AutUser(Login.Text, Password.Text);
                if (Au)
                {
                    var formMain = new Form1();
                    formMain.is_Autorization = true;
                    formMain.Show();
                    Opacity = 0;
                    ShowInTaskbar = false;
                }
                else
                {
                    MessageBox.Show("Не верные данные", "-", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                DataB.DisDB();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        private void OLink()
        {
            var RegForm = new Reg();
            RegForm.ShowDialog();
        }
        private void Aut2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var MainForm = new Form1();
        }
        private void Aut2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
