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
        char aOuR;
        List<string> dadosResp = new List<string>();
        public QuadroDeHorarios(List<string> nomeAl, string cpfAl, string cursoAl, char aour, List<string> dadosRe)
        {
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;
            cursoAluno = cursoAl;
            aOuR = aour;
            dadosResp = dadosRe;
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Server=SNCCH01LABF123\SQLEXPRESS;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

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

        private void QuadroDeHorarios_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select d.nome from tbnotas as n inner join Aluno as a on n.Aluno_idAluno = a.idAluno inner join disciplina as d on d.notas_id_notas = n.id_notas where a.cpf = @cpf", conexao);
            cmd.Parameters.AddWithValue("@cpf", cpfAluno);
            conexao.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                label2.Text = sqlDataReader[0].ToString();
            }
            conexao.Close();
        }

        private void QuadroDeHorarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
