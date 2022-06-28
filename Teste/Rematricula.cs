using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SistemaSENAI
{
    public partial class Rematricula : Form
    {

        SqlConnection conexao = new SqlConnection(@"Server=SNCCH01LABF123\SQLEXPRESS;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        string cursoAluno;

        public Rematricula(List<string> nomeAl, string cpfAl, string cursoAl)
        {
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;
            cursoAluno = cursoAl;
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagInicialAluno PIAluno = new PagInicialAluno(nomeAluno, cpfAluno, cursoAluno);
            PIAluno.Show();
        }

        private void Rematricula_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo fazer a rematrícula?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update Aluno set rematricula = 1 where cpf = @cpf", conexao);
                cmd.Parameters.AddWithValue("@cpf", cpfAluno);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //false
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void Rematricula_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
