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
    public partial class Carteirinha : Form
    {
        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        string cursoAluno;
        public Carteirinha(List<string> nomeAl)
        {
            nomeAluno = nomeAl;
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Server=SNCCH01LABF122\TEW_SQLEXPRESS;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Carteirinha_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Aluno as a inner join turmas as t on turmas_id_turmas = id_turmas inner join curso as c on curso_id_curso = id_curso where a.nome = @nome and a.sobrenome = @sobrenome and a.cpf = @cpf and c.nome = @curso", conexao);
            cmd.Parameters.AddWithValue("@nome", nomeAluno[0]);
            cmd.Parameters.AddWithValue("@sobrenome", nomeAluno[1]);
            cmd.Parameters.AddWithValue("@cpf", cpfAluno);
            cmd.Parameters.AddWithValue("@curso", cursoAluno);
            conexao.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                label8.Text = sqlDataReader[3].ToString() + sqlDataReader[4].ToString();
                label9.Text = sqlDataReader[14].ToString();
                label10.Text = sqlDataReader[8].ToString();
            }
            conexao.Close();
        }
    }
}
