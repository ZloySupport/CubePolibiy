using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Shiferina
{
    public partial class Reg : Form
    {
        private DB dbworcker = new DB();
        public Reg()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbworcker.ConnectDB("C:\\Games\\Data.db");
            char[] chek = PasswordF.Text.ToCharArray();
            char[] logcheck = RegUserN.Text.ToCharArray();
            bool tryhacked = false;
            foreach (char c in chek)
            {
                if (c == '\'')
                {
                    MessageBox.Show("Не допускается использовать в логине или в пароле апостроф", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tryhacked = true;
                }
            }
            foreach (char c in logcheck)
            {
                if (c == '\'')
                {
                    MessageBox.Show("Не допускается использовать в логине или в пароле апостроф", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tryhacked = true;
                }
            }
            if (RegUserN.Text != "" & tryhacked == false & chek.Length >= 5 & PasswordF.Text == PasswordS.Text)
            {

                bool ac = dbworcker.RegisterUser(RegUserN.Text, PasswordF.Text);
                dbworcker.DisDB();
                if (ac)
                {
                    MessageBox.Show("Успешная регистрация", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                MessageBox.Show("Не верные данные", "-", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }
    }
}
