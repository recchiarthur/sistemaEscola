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
    public partial class GradeCurricular : Form
    {
        List<string> nomeAluno = new List<string>();
        string cpfAluno;
        string cursoAluno;
        public GradeCurricular(List<string> nomeAl, string cpfAl, string cursoAl)
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

        private void GradeCurricular_Load(object sender, EventArgs e)
        {
            if (cursoAluno == "Análise e Desenvolvimento de Sistemas")
            {
                label1.Text = "Grade curricular do curso de Análise e Desenvolvimento de Sistemas\n3º período:";
                label2.Text = "18 meses";
                label3.Text = "Desenvolvimento de Sistemas";
                label7.Text = "160";
                label4.Text = "Implantação de Sistemas";
                label8.Text = "30";
                label5.Text = "Modelagem de Sistemas";
                label9.Text = "80";
                label6.Text = "Teste de Sistemas";
                label10.Text = "60";
            }
            else if (cursoAluno == "Mecatrônica")
            {
                label1.Text = "Grade curricular do curso de Mecatrônica\n3º período:";
                label2.Text = "24 meses";
                label3.Text = "Sistemas Automatizados I";
                label7.Text = "40";
                label4.Text = "Sistemas Automatizados II";
                label8.Text = "80";
                label5.Text = "Manutenção Aplicada";
                label9.Text = "30";
                label6.Text = "Sistemas Lógicos Programáveis II";
                label10.Text = "70";
            }
            else if (cursoAluno == "Desenvolvimento de Jogos")
            {
                label1.Text = "Grade curricular do curso de Desenvolvimento de Jogos\n3º período:";
                label2.Text = "24 meses";
                label3.Text = "Programação de Jogos";
                label7.Text = "140";
                label4.Text = "Teste de Jogos";
                label8.Text = "60";
                label5.Text = "Publicação de Jogos";
                label9.Text = "34";
                label6.Text = "Manutenção de Jogos";
                label10.Text = "40";
            }
            else if (cursoAluno == "Rede de Computadores")
            {
                label1.Text = "Grade curricular do curso de Rede de Computadores\n3º período:";
                label2.Text = "18 meses";
                label3.Text = "Segurança de Redes";
                label7.Text = "60";
                label4.Text = "Serviços de Rede Corporativa";
                label8.Text = "60";
                label5.Text = "Gerenciamento de Rede";
                label9.Text = "34";
                label6.Text = "Trabalho de Conclusão de Curso";
                label10.Text = "60";
            }
        }
    }
}
