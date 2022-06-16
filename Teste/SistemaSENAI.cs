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
using System.Data.SqlClient;

namespace SistemaSENAI
{
        public partial class Janela : Form
    {
        public Janela()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Server=SNCCH01LABF122\TEW_SQLEXPRESS;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        public void ValidacaoEntrar()
        {
            List<string> nomeAluno = new List<string>();
            if (!CheckBoxAluno.Checked && !CheckBoxProf.Checked && !CheckBoxResp.Checked)
            {
                MessageBox.Show("Selecione se você é professor, aluno ou responsável!");
            }
            if (CheckBoxAluno.Checked)
            {
                SqlCommand select = new SqlCommand("select * from Aluno where email = @email and senha = @senha", conexao);
                select.Parameters.AddWithValue("@email", TxtBoxEmail.Text);
                select.Parameters.AddWithValue("@senha", TxtBoxSenha.Text);
                conexao.Open();
                SqlDataReader dataReader = select.ExecuteReader();
                while(dataReader.Read())
                {
                    nomeAluno.Add(dataReader[3].ToString());
                    nomeAluno.Add(dataReader[4].ToString());
                }
                if (TxtBoxEmail.Text.Length < 11 || !dataReader.HasRows)
                {
                    MessageBox.Show("CPF ou senha incorretos!");
                    conexao.Close();
                    return;
                }
                PagInicialAluno PIAluno = new PagInicialAluno(nomeAluno);
                this.Hide();
                PIAluno.ShowDialog();
                return;
            }
            if(CheckBoxProf.Checked)
            {
                SqlCommand select = new SqlCommand("select * from Professor where email = @email and senha = @senha", conexao);
                select.Parameters.AddWithValue("@email", TxtBoxEmail.Text);
                select.Parameters.AddWithValue("@senha", TxtBoxSenha.Text);
                conexao.Open();
                SqlDataReader dataReader = select.ExecuteReader();
                if (TxtBoxEmail.Text.Length < 11 || !dataReader.HasRows)
                {
                    MessageBox.Show("CPF ou senha incorretos!");
                    conexao.Close();
                    return;
                }
                PagInicialProf PIProf = new PagInicialProf();
                this.Hide();
                PIProf.ShowDialog();
                return;
            }
            if(CheckBoxResp.Checked)
            {
                SqlCommand select = new SqlCommand("select * from Responsavel where email = @email and senha = @senha", conexao);
                select.Parameters.AddWithValue("@email", TxtBoxEmail.Text);
                select.Parameters.AddWithValue("@senha", TxtBoxSenha.Text);
                conexao.Open();
                SqlDataReader dataReader = select.ExecuteReader();
                if (TxtBoxEmail.Text.Length < 11 || !dataReader.HasRows)
                {
                    MessageBox.Show("CPF ou senha incorretos!");
                    conexao.Close();
                    return;
                }
                PagInicialResp PIResp = new PagInicialResp();
                this.Hide();
                PIResp.ShowDialog();
                return;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValidacaoEntrar();
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

        private void Janela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void TxtBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidacaoEntrar();
            }
        }
    }
}
