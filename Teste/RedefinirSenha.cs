using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSENAI
{
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }
        string senha = "42";

        public string GetSenha()
        {
            return senha;
        }

        public void SetSenha(string sen)
        {
            senha = sen;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(NovaSenha.Text != SenhaConf.Text)
            {
                MessageBox.Show("As senhas estão diferentes!");
            }
            else
            {
                SetSenha(SenhaConf.Text);
                this.Close();
            }
        }

        private void NovaSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NovaSenha.PasswordChar == '*')
            {
                NovaSenha.PasswordChar = '\0';
            }
            else
            {
                NovaSenha.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SenhaConf.PasswordChar == '*')
            {
                SenhaConf.PasswordChar = '\0';
            }
            else
            {
                SenhaConf.PasswordChar = '*';
            }
        }

        private void SenhaConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (SenhaConf.PasswordChar == '*')
            {
                SenhaConf.PasswordChar = '\0';
            }
            else
            {
                SenhaConf.PasswordChar = '*';
            }
        }
    }
}
