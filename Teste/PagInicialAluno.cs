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
        public PagInicialAluno()
        {
            InitializeComponent();
        }

        private void PagInicial_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            this.Hide();
            notas.ShowDialog();
            this.Show();
        }

        private void buttonCalend_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            this.Hide();
            calendario.ShowDialog();
            this.Show();
        }

        private void buttonQuadro_Click(object sender, EventArgs e)
        {
            QuadroDeHorarios quadroDeHorarios = new QuadroDeHorarios();
            this.Hide();
            quadroDeHorarios.ShowDialog();
            this.Show();
        }

        private void buttonFaltas_Click(object sender, EventArgs e)
        {
            Faltas faltas = new Faltas();
            this.Hide();
            faltas.ShowDialog();
            this.Show();
        }

        private void buttonRemat_Click(object sender, EventArgs e)
        {
            Rematricula rematricula = new Rematricula();
            this.Hide();
            rematricula.ShowDialog();
            this.Show();
        }

        private void buttonBoleto_Click(object sender, EventArgs e)
        {
            Boleto boleto = new Boleto();
            this.Hide();
            boleto.ShowDialog();
            this.Show();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            Carteirinha carteirinha = new Carteirinha();
            this.Hide();
            carteirinha.ShowDialog();
            this.Show();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            GradeCurricular gradeCurricular = new GradeCurricular();
            this.Hide();
            gradeCurricular.ShowDialog();
            this.Show();
        }

        private void PagInicialAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
