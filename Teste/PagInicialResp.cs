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
    public partial class PagInicialResp : Form
    {

        SqlConnection conexao = new SqlConnection(@"Server=ARTHUREC-LAPTOP\SQLEXPRESS03;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        List<string> dadosResp = new List<string>();
        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        const char aOuR = 'r';


        public PagInicialResp(List<string> dadosRe, List<string> nomeAl, string cpfAl)
        {
            dadosResp = dadosRe;
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;

            InitializeComponent();
        }

        private void buttonFaltasResp_Click(object sender, EventArgs e)
        {
            //Faltas faltas = new Faltas();
            //this.Hide();
            //faltas.ShowDialog();
            //this.Show();
        }

        private void buttonNotasResp_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas(nomeAluno, cpfAluno, "", aOuR, dadosResp);
            this.Hide();
            notas.ShowDialog();
            this.Show();
        }

        private void buttonBoletoResp_Click(object sender, EventArgs e)
        {
            Boleto boleto = new Boleto(nomeAluno, cpfAluno, "", aOuR, dadosResp);
            this.Hide();
            boleto.ShowDialog();
        }

        private void buttonHorarioResp_Click(object sender, EventArgs e)
        {
            QuadroDeHorarios quadroDeHorarios = new QuadroDeHorarios(nomeAluno, cpfAluno, "", aOuR, dadosResp);
            this.Hide();
            quadroDeHorarios.ShowDialog();
            this.Show();
        }

        private void PagInicialResp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PagInicialResp_Load(object sender, EventArgs e)
        {
            labelOla.Text = $"Olá, {dadosResp[0]}";
            labelGrau.Text = $"{dadosResp[4]} de {nomeAluno[0]} {nomeAluno[1]}";
        }
    }
}
