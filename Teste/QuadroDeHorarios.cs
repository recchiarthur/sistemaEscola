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
    public partial class QuadroDeHorarios : Form
    {
        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        string cursoAluno;
        public QuadroDeHorarios(List<string> nomeAl, string cpfAl, string cursoAl)
        {
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;
            cursoAluno = cursoAl;
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Server=SNCCH01LABF123\TEW_SQLEXPRESS;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagInicialAluno PIAluno = new PagInicialAluno(nomeAluno, cpfAluno, cursoAluno);
            PIAluno.Show();
        }

        private void QuadroDeHorarios_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select c.nome, t.id_turmas from disciplina as c inner join turmas as t on c.id_disciplina = t.curso_id_curso inner join Aluno as a on t.id_turmas = a.turmas_id_turmas where a.nome = @nome and a.sobrenome = @sobrenome", conexao);
            cmd.Parameters.AddWithValue("@nome", nomeAluno[0]);
            cmd.Parameters.AddWithValue("@sobrenome", nomeAluno[1]);
            conexao.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                label2.Text = sqlDataReader[0].ToString();
                label4.Text = sqlDataReader[1].ToString();
            }
            conexao.Close();
        }

        private void QuadroDeHorarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
