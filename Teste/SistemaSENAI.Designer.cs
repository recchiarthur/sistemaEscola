using System.Windows.Forms;

namespace SistemaSENAI
{
    partial class Janela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Janela));
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.CheckBoxAluno = new System.Windows.Forms.CheckBox();
            this.CheckBoxProf = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckBoxResp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.BackColor = System.Drawing.Color.White;
            this.TxtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtBoxEmail.Location = new System.Drawing.Point(596, 200);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(245, 30);
            this.TxtBoxEmail.TabIndex = 2;
            // 
            // CheckBoxAluno
            // 
            this.CheckBoxAluno.AutoSize = true;
            this.CheckBoxAluno.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxAluno.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBoxAluno.Font = new System.Drawing.Font("Arial", 20F);
            this.CheckBoxAluno.Location = new System.Drawing.Point(482, 198);
            this.CheckBoxAluno.Name = "CheckBoxAluno";
            this.CheckBoxAluno.Size = new System.Drawing.Size(102, 36);
            this.CheckBoxAluno.TabIndex = 0;
            this.CheckBoxAluno.Text = "Aluno";
            this.CheckBoxAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBoxAluno.UseVisualStyleBackColor = false;
            this.CheckBoxAluno.CheckedChanged += new System.EventHandler(this.CheckBoxAluno_CheckedChanged);
            // 
            // CheckBoxProf
            // 
            this.CheckBoxProf.AutoSize = true;
            this.CheckBoxProf.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxProf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBoxProf.Font = new System.Drawing.Font("Arial", 20F);
            this.CheckBoxProf.Location = new System.Drawing.Point(437, 227);
            this.CheckBoxProf.Name = "CheckBoxProf";
            this.CheckBoxProf.Size = new System.Drawing.Size(148, 36);
            this.CheckBoxProf.TabIndex = 1;
            this.CheckBoxProf.Text = "Professor";
            this.CheckBoxProf.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CheckBoxProf.UseVisualStyleBackColor = false;
            this.CheckBoxProf.CheckedChanged += new System.EventHandler(this.CheckBoxProf_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(597, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira o e-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(597, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira a senha:";
            // 
            // TxtBoxSenha
            // 
            this.TxtBoxSenha.BackColor = System.Drawing.Color.White;
            this.TxtBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtBoxSenha.Location = new System.Drawing.Point(597, 263);
            this.TxtBoxSenha.Name = "TxtBoxSenha";
            this.TxtBoxSenha.PasswordChar = '●';
            this.TxtBoxSenha.Size = new System.Drawing.Size(244, 30);
            this.TxtBoxSenha.TabIndex = 4;
            this.TxtBoxSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxSenha_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(601, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fazer login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(806, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "👁";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckBoxResp
            // 
            this.CheckBoxResp.AutoSize = true;
            this.CheckBoxResp.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxResp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBoxResp.Font = new System.Drawing.Font("Arial", 20F);
            this.CheckBoxResp.Location = new System.Drawing.Point(395, 259);
            this.CheckBoxResp.Name = "CheckBoxResp";
            this.CheckBoxResp.Size = new System.Drawing.Size(190, 36);
            this.CheckBoxResp.TabIndex = 9;
            this.CheckBoxResp.Text = "Responsável";
            this.CheckBoxResp.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CheckBoxResp.UseVisualStyleBackColor = false;
            this.CheckBoxResp.CheckedChanged += new System.EventHandler(this.CheckBoxResp_CheckedChanged);
            // 
            // Janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.Controls.Add(this.CheckBoxResp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxAluno);
            this.Controls.Add(this.CheckBoxProf);
            this.Controls.Add(this.TxtBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Janela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemaSENAI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Janela_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private CheckBox CheckBoxAluno;
        private CheckBox CheckBoxProf;
        private Label label1;
        private Label label2;
        private TextBox TxtBoxSenha;
        private Button button1;
        private Button button2;
        private CheckBox CheckBoxResp;
    }
}

