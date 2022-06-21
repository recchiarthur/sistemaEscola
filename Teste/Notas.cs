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
        public Notas(List<string> nomeAl, string cpfAl, string cursoAl)
        {
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;
            cursoAluno = cursoAl;
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Server=SNCCH01LABF122\TEW_SQLEXPRESS;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        private void Notas_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select nota from tbnotas inner join Aluno on tbnotas.Aluno_idAluno = Aluno.idAluno where Aluno.nome = @nome and Aluno.sobrenome = @sobrenome", conexao);
            cmd.Parameters.AddWithValue("@nome", nomeAluno[0]);
            cmd.Parameters.AddWithValue("@sobrenome", nomeAluno[1]);
            conexao.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            label1.Text = "Média geral de " + nomeAluno[0] + " " + nomeAluno[1];
            while(sqlDataReader.Read())
            {
                label2.Text = sqlDataReader[0].ToString();
            }
            conexao.Close();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagInicialAluno PIAluno = new PagInicialAluno(nomeAluno, cpfAluno, cursoAluno);
            PIAluno.Show();
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
