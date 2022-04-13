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
    public partial class PagInicialProf : Form
    {
        public PagInicialProf()
        {
            InitializeComponent();
        }

        private void PagInicialProf_Load(object sender, EventArgs e)
        {

        }

        private void buttonHorario_Click(object sender, EventArgs e)
        {
            HorarioProf horarioProf = new HorarioProf();
            this.Hide();
            horarioProf.ShowDialog();
            this.Show();
        }

        private void buttonRegPresc_Click(object sender, EventArgs e)
        {
            PresencaProf presencaProf = new PresencaProf();
            this.Hide();
            presencaProf.ShowDialog();
            this.Show();
        }

        private void buttonRegNotas_Click(object sender, EventArgs e)
        {
            RegNotasProf regNotasProf = new RegNotasProf();
            this.Hide();
            regNotasProf.ShowDialog();
            this.Show();
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            PlanAulasProf planAulasProf = new PlanAulasProf();
            this.Hide();
            planAulasProf.ShowDialog();
            this.Show();
        }

        private void PagInicialProf_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
