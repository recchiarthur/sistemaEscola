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
    public partial class PagInicialResp : Form
    {
        public PagInicialResp()
        {
            InitializeComponent();
        }

        private void buttonFaltasResp_Click(object sender, EventArgs e)
        {
            Faltas faltas = new Faltas();
            faltas.ShowDialog();
            this.Hide();
        }

        private void buttonNotasResp_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.ShowDialog();
            this.Hide();
        }

        private void buttonBoletoResp_Click(object sender, EventArgs e)
        {
            Boleto boleto = new Boleto();
            boleto.ShowDialog();
            this.Hide();
        }

        private void buttonHorarioResp_Click(object sender, EventArgs e)
        {
            QuadroDeHorarios quadroDeHorarios = new QuadroDeHorarios();
            quadroDeHorarios.ShowDialog();
            this.Hide();
        }
    }
}
