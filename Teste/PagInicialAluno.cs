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
    public partial class PagInicialAluno : Form
    {

        SqlConnection conexao = new SqlConnection(@"Server=SNCCH01LABF122\TEW_SQLEXPRESS;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        string cursoAluno;

        public PagInicialAluno(List<string> nomeAl, string cpfAl, string cursoAl)
        {
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;
            cursoAluno = cursoAl;
            InitializeComponent();
        }

        public List<string> GetnomeAluno()
        {
            return nomeAluno;
        }

        private void PagInicial_Load(object sender, EventArgs e)
        {
            label1.Text = "Olá, " + nomeAluno[0];
        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notas notas = new Notas(nomeAluno, cpfAluno, cursoAluno);
            notas.ShowDialog();
        }

        private void buttonCalend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendario calendario = new Calendario(nomeAluno, cpfAluno, cursoAluno);
            calendario.ShowDialog();
        }

        private void buttonQuadro_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuadroDeHorarios quadroDeHorarios = new QuadroDeHorarios(nomeAluno, cpfAluno, cursoAluno);
            quadroDeHorarios.ShowDialog();
        }

        private void buttonFaltas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faltas faltas = new Faltas();
            faltas.ShowDialog();
        }

        private void buttonRemat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rematricula rematricula = new Rematricula();
            rematricula.ShowDialog();
        }

        private void buttonBoleto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boleto boleto = new Boleto();
            boleto.ShowDialog();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carteirinha carteirinha = new Carteirinha(nomeAluno, cpfAluno, cursoAluno);
            carteirinha.ShowDialog();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradeCurricular gradeCurricular = new GradeCurricular(nomeAluno, cpfAluno, cursoAluno);
            gradeCurricular.ShowDialog();
        }

        private void PagInicialAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
