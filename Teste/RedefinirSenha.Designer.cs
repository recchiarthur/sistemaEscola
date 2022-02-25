namespace SistemaSENAI
{
    partial class RedefinirSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelRedSenha = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.NovaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SenhaConf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelRedSenha
            // 
            this.LabelRedSenha.AutoSize = true;
            this.LabelRedSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LabelRedSenha.Location = new System.Drawing.Point(11, 16);
            this.LabelRedSenha.Name = "LabelRedSenha";
            this.LabelRedSenha.Size = new System.Drawing.Size(263, 31);
            this.LabelRedSenha.TabIndex = 0;
            this.LabelRedSenha.Text = "Redefina sua senha:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(208, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "👁";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NovaSenha
            // 
            this.NovaSenha.BackColor = System.Drawing.Color.White;
            this.NovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NovaSenha.Location = new System.Drawing.Point(61, 50);
            this.NovaSenha.Name = "NovaSenha";
            this.NovaSenha.PasswordChar = '*';
            this.NovaSenha.Size = new System.Drawing.Size(168, 30);
            this.NovaSenha.TabIndex = 8;
            this.NovaSenha.TextChanged += new System.EventHandler(this.NovaSenha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirme a senha:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(84, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Redefinir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(208, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "👁";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SenhaConf
            // 
            this.SenhaConf.BackColor = System.Drawing.Color.White;
            this.SenhaConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SenhaConf.Location = new System.Drawing.Point(61, 138);
            this.SenhaConf.Name = "SenhaConf";
            this.SenhaConf.PasswordChar = '*';
            this.SenhaConf.Size = new System.Drawing.Size(168, 30);
            this.SenhaConf.TabIndex = 14;
            this.SenhaConf.TextChanged += new System.EventHandler(this.SenhaConf_TextChanged);
            // 
            // RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SenhaConf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NovaSenha);
            this.Controls.Add(this.LabelRedSenha);
            this.Name = "RedefinirSenha";
            this.Text = "Redefinir Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelRedSenha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NovaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SenhaConf;
    }
}