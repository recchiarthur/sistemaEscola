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
    public partial class Boleto : Form
    {

        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        string cursoAluno;
        char aOuR;
        List<string> dadosResp = new List<string>();
        public Boleto(List<string> nomeAl, string cpfAl, string cursoAl, char aour, List<string> dadosRe)
        {
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;
            cursoAluno = cursoAl;
            aOuR = aour;
            dadosResp = dadosRe;
            InitializeComponent();
        }

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

        private void Boleto_Load(object sender, EventArgs e)
        {
           label2.Text = DateTime.Now.AddDays(Convert.ToInt32(30)).Date.ToString().Substring(0, 10);
        }

        private void Boleto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
