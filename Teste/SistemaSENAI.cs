using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
        public partial class Janela : Form
    {
        public Janela()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TxtBoxCPF_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void CheckBoxAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAluno.Checked == true)
            {
                CheckBoxProf.Checked = false;
            }
        }

        private void CheckBoxProf_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProf.Checked == true)
            {
                CheckBoxAluno.Checked = false;
            }
        }

        private void TxtBoxCPF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            TxtBoxCPF.MaxLength = 11;
        }
    }
}
