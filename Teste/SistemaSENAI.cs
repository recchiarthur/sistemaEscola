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

namespace SistemaSENAI
{
        public partial class Janela : Form
    {
        public Janela()
        {
            InitializeComponent();

            //bdsistemaescolaEntities entities = new bdsistemaescolaEntities();
            //var quatro = entities.Aluno.FirstOrDefault(a => a.idAluno == 4);
            //label1.Text = quatro.nome;
        }

        internal static readonly char[] chars =
            "1234567890".ToCharArray();

        public static string GetUniqueKey(int size)
        {
            byte[] data = new byte[4 * size];
            using (var crypto = RandomNumberGenerator.Create())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % chars.Length;

                result.Append(chars[idx]);
            }

            return result.ToString();
        }

        public static string GetUniqueKeyOriginal_BIASED(int size)
        {
            char[] chars =
                "1234567890".ToCharArray();
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        string senhapadrao = GetUniqueKey(6);
        RedefinirSenha senha = new RedefinirSenha();

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Senha padrão: " + senhapadrao;
        }

        private void TxtBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TxtBoxCPF_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckBoxAluno.Checked && !CheckBoxProf.Checked && !CheckBoxResp.Checked)
            {
                MessageBox.Show("Selecione se você é professor, aluno ou responsável!");
            }
            else if (TxtBoxCPF.Text.Length < 11)
            {
                MessageBox.Show("Insira o CPF corretamente!");
            }
            else if(TxtBoxSenha.Text == senhapadrao)
            {
                senha.ShowDialog();
            }
            else if(TxtBoxSenha.Text == senha.GetSenha() && CheckBoxAluno.Checked)
            {
                PagInicialAluno PIAluno = new PagInicialAluno();
                this.Hide();
                PIAluno.ShowDialog();
            }
            else if(TxtBoxSenha.Text == senha.GetSenha() && CheckBoxProf.Checked)
            {
                PagInicialProf PIProf = new PagInicialProf();
                this.Hide();
                PIProf.ShowDialog();
            }
            else if(TxtBoxSenha.Text == senha.GetSenha() && CheckBoxResp.Checked)
            {
                PagInicialResp PIResp = new PagInicialResp();
                this.Hide();
                PIResp.ShowDialog();
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
                CheckBoxResp.Checked = false;
            }
        }

        private void CheckBoxProf_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProf.Checked == true)
            {
                CheckBoxAluno.Checked = false;
                CheckBoxResp.Checked = false;
            }
        }

        private void CheckBoxResp_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxResp.Checked == true)
            {
                CheckBoxAluno.Checked = false;
                CheckBoxProf.Checked = false;
            }
        }

        private void TxtBoxCPF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            TxtBoxCPF.MaxLength = 11;
        }

        private void Janela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(CheckBoxAluno.Checked)
            {
                PagInicialAluno PIAluno = new PagInicialAluno();
                PIAluno.ShowDialog();
                this.Hide();
            }
            else if(CheckBoxProf.Checked)
            {
                PagInicialProf PIProf = new PagInicialProf();
                PIProf.ShowDialog();
                this.Hide();
            }
            else if(CheckBoxResp.Checked)
            {
                PagInicialResp PIResp = new PagInicialResp();
                PIResp.ShowDialog();
                this.Hide();
            }
        }

    }
}
