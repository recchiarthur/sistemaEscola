using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSENAI
{
    public partial class Notas : Form
    {
        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        string cursoAluno;
        char aOuR;
        List<string> dadosResp = new List<string>();
        public Notas(List<string> nomeAl, string cpfAl, string cursoAl, char aour, List<string> dadosRe)
        {
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;
            cursoAluno = cursoAl;
            aOuR = aour;
            dadosResp = dadosRe;
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Server=ARTHUREC-LAPTOP\SQLEXPRESS03;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        private void Notas_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select nota from tbnotas inner join Aluno on tbnotas.Aluno_idAluno = Aluno.idAluno where Aluno.cpf = @cpf", conexao);
            cmd.Parameters.AddWithValue("@cpf", cpfAluno);
            conexao.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            label1.Text = "Média geral de " + nomeAluno[0] + " " + nomeAluno[1];
            while (sqlDataReader.Read())
            {
                label2.Text = sqlDataReader[0].ToString();
            }
            conexao.Close();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (aOuR == 'a')
            {
                PagInicialAluno PIAluno = new PagInicialAluno(nomeAluno, cpfAluno, cursoAluno);
                PIAluno.ShowDialog();
            }
            else if (aOuR == 'r')
            {
                PagInicialResp PIResp = new PagInicialResp(dadosResp, nomeAluno, cpfAluno);
                PIResp.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Notas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
