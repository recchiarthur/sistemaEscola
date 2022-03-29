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
            notas.ShowDialog();
            this.Hide();
        }

        private void buttonCalend_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.ShowDialog();
            this.Hide();
        }

        private void buttonQuadro_Click(object sender, EventArgs e)
        {
            QuadroDeHorarios quadroDeHorarios = new QuadroDeHorarios();
            quadroDeHorarios.ShowDialog();
            this.Hide();
        }

        private void buttonFaltas_Click(object sender, EventArgs e)
        {
            Faltas faltas = new Faltas();
            faltas.ShowDialog();
            this.Hide();
        }

        private void buttonRemat_Click(object sender, EventArgs e)
        {
            Rematricula rematricula = new Rematricula();
            rematricula.ShowDialog();
            this.Hide();
        }

        private void buttonBoleto_Click(object sender, EventArgs e)
        {
            Boleto boleto = new Boleto();
            boleto.ShowDialog();
            this.Hide();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            Carteirinha carteirinha = new Carteirinha();
            carteirinha.ShowDialog();
            this.Hide();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            GradeCurricular gradeCurricular = new GradeCurricular();
            gradeCurricular.ShowDialog();
            this.Hide();
        }
    }
}
