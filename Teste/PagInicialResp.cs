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
            this.Hide();
            faltas.ShowDialog();
            this.Show();
        }

        private void buttonNotasResp_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            this.Hide();
            notas.ShowDialog();
            this.Show();
        }

        private void buttonBoletoResp_Click(object sender, EventArgs e)
        {
            Boleto boleto = new Boleto();
            this.Hide();
            boleto.ShowDialog();
        }

        private void buttonHorarioResp_Click(object sender, EventArgs e)
        {
            QuadroDeHorarios quadroDeHorarios = new QuadroDeHorarios();
            this.Hide();
            quadroDeHorarios.ShowDialog();
            this.Show();
        }

        private void PagInicialResp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
