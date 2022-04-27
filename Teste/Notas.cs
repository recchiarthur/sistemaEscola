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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            bdsistemaescolaEntities entities = new bdsistemaescolaEntities();
            var pprofessor = entities.Professor.FirstOrDefault();
            label2.Text = pprofessor.email;
        }
    }
}
