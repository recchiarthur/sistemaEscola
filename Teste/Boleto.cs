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
        public Boleto(List<string> nomeAl, string cpfAl, string cursoAl)
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
