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

        private void PagInicial_Load(object sender, EventArgs e)
        {
            label1.Text = "Olá, " + nomeAluno[0];
        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas(nomeAluno);
            this.Hide();
            notas.ShowDialog();
        }

        private void buttonCalend_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            this.Hide();
            calendario.ShowDialog();
        }

        private void buttonQuadro_Click(object sender, EventArgs e)
        {
            QuadroDeHorarios quadroDeHorarios = new QuadroDeHorarios(nomeAluno);
            this.Hide();
            quadroDeHorarios.ShowDialog();
        }

        private void buttonFaltas_Click(object sender, EventArgs e)
        {
            Faltas faltas = new Faltas();
            this.Hide();
            faltas.ShowDialog();
        }

        private void buttonRemat_Click(object sender, EventArgs e)
        {
            Rematricula rematricula = new Rematricula();
            this.Hide();
            rematricula.ShowDialog();
        }

        private void buttonBoleto_Click(object sender, EventArgs e)
        {
            Boleto boleto = new Boleto();
            this.Hide();
            boleto.ShowDialog();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            Carteirinha carteirinha = new Carteirinha();
            this.Hide();
            carteirinha.ShowDialog();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            GradeCurricular gradeCurricular = new GradeCurricular();
            this.Hide();
            gradeCurricular.ShowDialog();
        }

        private void PagInicialAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
