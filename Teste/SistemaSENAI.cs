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
        public partial class Janela : Form
    {
        public Janela()
        {
            InitializeComponent();
        }

        string senhapadrao = "123456";

        RedefinirSenha senha = new RedefinirSenha();

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = senha.GetSenha();
        }

        private void TxtBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TxtBoxCPF_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckBoxAluno.Checked && !CheckBoxProf.Checked)
            {
                MessageBox.Show("Selecione se você é professor ou aluno!");
            }
            else if (TxtBoxCPF.Text.Length < 11)
            {
                MessageBox.Show("Insira o CPF corretamente!");
            }
            else if(TxtBoxSenha.Text == senhapadrao)
            {
                RedefinirSenha redsenha = new RedefinirSenha();
                redsenha.Show();
            }
            else if(TxtBoxSenha.Text == senha.GetSenha() && CheckBoxAluno.Checked)
            {
                PagInicialAluno PIAluno = new PagInicialAluno();
                PIAluno.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtBoxSenha.PasswordChar == '*')
            {
                TxtBoxSenha.PasswordChar = '\0';
            }
            else
            {
                TxtBoxSenha.PasswordChar = '*';
            }
        }

        private void CheckBoxAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAluno.Checked == true)
            {
                CheckBoxProf.Checked = false;
            }
        }

        private void CheckBoxProf_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProf.Checked == true)
            {
                CheckBoxAluno.Checked = false;
            }
        }

        private void TxtBoxCPF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            TxtBoxCPF.MaxLength = 11;
        }
    }
}
