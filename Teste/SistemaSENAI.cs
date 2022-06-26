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

        SqlConnection conexao = new SqlConnection(@"Server=ARTHUREC-LAPTOP\SQLEXPRESS03;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        public void ValidacaoEntrar()
        {
            List<string> nomeAluno = new List<string>();
            List<string> dadosResp = new List<string>();
            string cpfAluno = "";
            string cursoAluno = "";
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
                    cpfAluno = dataReader[8].ToString();
                }
                if (TxtBoxEmail.Text.Length < 11 || !dataReader.HasRows)
                {
                    MessageBox.Show("CPF ou senha incorretos!");
                    conexao.Close();
                    return;
                }
                conexao.Close();
                SqlCommand cmd = new SqlCommand("select * from Aluno as a inner join turmas as t on turmas_id_turmas = id_turmas inner join curso as c on curso_id_curso = id_curso where a.cpf = @cpf", conexao);
                cmd.Parameters.AddWithValue("@cpf", cpfAluno);
                conexao.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    cursoAluno = sqlDataReader[15].ToString();
                }
                conexao.Close();
                PagInicialAluno PIAluno = new PagInicialAluno(nomeAluno, cpfAluno, cursoAluno);
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
                SqlCommand select = new SqlCommand("select r.nome, r.sobrenome, r.email, r.CPF, r.senha, g.grau, a.nome, a.sobrenome, a.cpf from Responsavel as r inner join grau_parentesco as g on id_grau = grau_parentesco_id_grau inner join Aluno as a on Responsavel_idResponsavel = idResponsavel where r.email = @email and r.senha = @senha", conexao);
                select.Parameters.AddWithValue("@email", TxtBoxEmail.Text);
                select.Parameters.AddWithValue("@senha", TxtBoxSenha.Text);
                conexao.Open();
                SqlDataReader dataReader = select.ExecuteReader();
                while(dataReader.Read())
                {
                    dadosResp.Add(dataReader[0].ToString());
                    dadosResp.Add(dataReader[1].ToString());
                    dadosResp.Add(dataReader[2].ToString());
                    dadosResp.Add(dataReader[3].ToString());
                    dadosResp.Add(dataReader[5].ToString());

                    nomeAluno.Add(dataReader[6].ToString());
                    nomeAluno.Add(dataReader[7].ToString());

                    cpfAluno = dataReader[8].ToString();

                    //  dadosResp
                    //  {
                    //      0 = nome
                    //      1 = sobrenome;
                    //      2 = email;
                    //      3 = cpf;
                    //      4 = grau_parentesco;
                    //  }

                    //  nomeAluno
                    //  {
                    //      0 = nome;
                    //      1 = sobrenome;
                    //  }
                }
                if (TxtBoxEmail.Text.Length < 11 || !dataReader.HasRows)
                {
                    MessageBox.Show("CPF ou senha incorretos!");
                    conexao.Close();
                    return;
                }
                PagInicialResp PIResp = new PagInicialResp(dadosResp, nomeAluno, cpfAluno);
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
            if (TxtBoxSenha.PasswordChar == '●')
            {
                TxtBoxSenha.PasswordChar = '\0';
            }
            else
            {
                TxtBoxSenha.PasswordChar = '●';
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
