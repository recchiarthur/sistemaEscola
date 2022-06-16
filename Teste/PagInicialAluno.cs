using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSENAI
{
    public partial class PagInicialAluno : Form
    {

        List<string> nomeAluno = new List<string>();

        public PagInicialAluno(List<string> nomeAl)
        {
            nomeAluno = nomeAl;
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
            Notas notas = new Notas(nomeAluno);
            notas.ShowDialog();
        }

        private void buttonCalend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendario calendario = new Calendario();
            calendario.ShowDialog();
        }

        private void buttonQuadro_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuadroDeHorarios quadroDeHorarios = new QuadroDeHorarios(nomeAluno);
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
            Carteirinha carteirinha = new Carteirinha(nomeAluno);
            carteirinha.ShowDialog();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradeCurricular gradeCurricular = new GradeCurricular();
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
