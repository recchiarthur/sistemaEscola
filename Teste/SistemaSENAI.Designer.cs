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
            this.TxtBoxCPF = new System.Windows.Forms.TextBox();
            this.CheckBoxAluno = new System.Windows.Forms.CheckBox();
            this.CheckBoxProf = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBoxCPF
            // 
            this.TxtBoxCPF.BackColor = System.Drawing.Color.White;
            this.TxtBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtBoxCPF.Location = new System.Drawing.Point(596, 200);
            this.TxtBoxCPF.Name = "TxtBoxCPF";
            this.TxtBoxCPF.Size = new System.Drawing.Size(168, 30);
            this.TxtBoxCPF.TabIndex = 2;
            this.TxtBoxCPF.TextChanged += new System.EventHandler(this.TxtBoxCPF_TextChanged);
            this.TxtBoxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxCPF_KeyPress_1);
            // 
            // CheckBoxAluno
            // 
            this.CheckBoxAluno.AutoSize = true;
            this.CheckBoxAluno.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxAluno.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxAluno.Location = new System.Drawing.Point(596, 104);
            this.CheckBoxAluno.Name = "CheckBoxAluno";
            this.CheckBoxAluno.Size = new System.Drawing.Size(77, 27);
            this.CheckBoxAluno.TabIndex = 0;
            this.CheckBoxAluno.Text = "Aluno";
            this.CheckBoxAluno.UseVisualStyleBackColor = false;
            this.CheckBoxAluno.CheckedChanged += new System.EventHandler(this.CheckBoxAluno_CheckedChanged);
            // 
            // CheckBoxProf
            // 
            this.CheckBoxProf.AutoSize = true;
            this.CheckBoxProf.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxProf.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxProf.Location = new System.Drawing.Point(596, 137);
            this.CheckBoxProf.Name = "CheckBoxProf";
            this.CheckBoxProf.Size = new System.Drawing.Size(115, 27);
            this.CheckBoxProf.TabIndex = 1;
            this.CheckBoxProf.Text = "Professor";
            this.CheckBoxProf.UseVisualStyleBackColor = false;
            this.CheckBoxProf.CheckedChanged += new System.EventHandler(this.CheckBoxProf_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(596, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira o CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(596, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira a senha:";
            // 
            // TxtBoxSenha
            // 
            this.TxtBoxSenha.BackColor = System.Drawing.Color.White;
            this.TxtBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtBoxSenha.Location = new System.Drawing.Point(596, 263);
            this.TxtBoxSenha.Name = "TxtBoxSenha";
            this.TxtBoxSenha.PasswordChar = '*';
            this.TxtBoxSenha.Size = new System.Drawing.Size(168, 30);
            this.TxtBoxSenha.TabIndex = 4;
            this.TxtBoxSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.button2.Location = new System.Drawing.Point(743, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "👁";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha padrão: 123456";
            // 
            // Janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxAluno);
            this.Controls.Add(this.CheckBoxProf);
            this.Controls.Add(this.TxtBoxCPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Janela";
            this.Text = "SistemaSENAI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBoxCPF;
        private CheckBox CheckBoxAluno;
        private CheckBox CheckBoxProf;
        private Label label1;
        private Label label2;
        private TextBox TxtBoxSenha;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}

