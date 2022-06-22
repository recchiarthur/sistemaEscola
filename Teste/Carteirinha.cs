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
    public partial class Carteirinha : Form
    {
        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        string cursoAluno;
        public Carteirinha(List<string> nomeAl, string cpfAl, string cursoAl)
        {
            nomeAluno = nomeAl;
            cpfAluno = cpfAl;
            cursoAluno = cursoAl;
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Server=SNCCH01LABF123\TEW_SQLEXPRESS;Database=sistemaescola;Trusted_Connection=True;MultipleActiveResultSets=True;");

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagInicialAluno PIAluno = new PagInicialAluno(nomeAluno, cpfAluno, cursoAluno);
            PIAluno.Show();
        }

        private void Carteirinha_Load(object sender, EventArgs e)
        {
            label8.Text = nomeAluno[0] + " " + nomeAluno[1];
            label9.Text = cursoAluno;
            label10.Text = cpfAluno;
        }
    }
}
