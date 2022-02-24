using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSENAI
{
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            Label NovaSenha = new Label();
            NovaSenha.BackColor = System.Drawing.Color.Transparent;
            NovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            NovaSenha.Location = new System.Drawing.Point(30, 30);
            NovaSenha.Size = new System.Drawing.Size(126, 25);
            NovaSenha.TabIndex = 3;
            NovaSenha.Text = "Redefina a senha:";
        }
    }
}
