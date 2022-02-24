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
        string senha;

        public string GetSenha()
        {
            return senha;
        }

        public void SetSenha(string s)
        {
            senha = s;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(NovaSenha.Text != SenhaConf.Text)
            {
                MessageBox.Show("As senhas estão diferentes!");
            }
            else
            {
                SetSenha(NovaSenha.Text);
                RedefinirSenha redsenha = new RedefinirSenha();
                redsenha.Close();
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
    }
}
