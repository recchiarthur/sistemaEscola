﻿using System;
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
    public partial class PagInicialAluno : Form
    {
        public PagInicialAluno()
        {
            InitializeComponent();
        }

        private void PagInicial_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
        }
    }
}