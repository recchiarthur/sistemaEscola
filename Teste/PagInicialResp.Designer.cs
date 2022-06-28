namespace SistemaSENAI
{
    partial class PagInicialResp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagInicialResp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNotasResp = new System.Windows.Forms.Button();
            this.buttonBoletoResp = new System.Windows.Forms.Button();
            this.buttonHorarioResp = new System.Windows.Forms.Button();
            this.labelOla = new System.Windows.Forms.Label();
            this.labelGrau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 524);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNotasResp
            // 
            this.buttonNotasResp.BackColor = System.Drawing.Color.DarkRed;
            this.buttonNotasResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonNotasResp.ForeColor = System.Drawing.Color.Coral;
            this.buttonNotasResp.Location = new System.Drawing.Point(22, 313);
            this.buttonNotasResp.Name = "buttonNotasResp";
            this.buttonNotasResp.Size = new System.Drawing.Size(166, 68);
            this.buttonNotasResp.TabIndex = 12;
            this.buttonNotasResp.Text = "NOTAS";
            this.buttonNotasResp.UseVisualStyleBackColor = false;
            this.buttonNotasResp.Click += new System.EventHandler(this.buttonNotasResp_Click);
            // 
            // buttonBoletoResp
            // 
            this.buttonBoletoResp.BackColor = System.Drawing.Color.DarkRed;
            this.buttonBoletoResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonBoletoResp.ForeColor = System.Drawing.Color.Coral;
            this.buttonBoletoResp.Location = new System.Drawing.Point(221, 313);
            this.buttonBoletoResp.Name = "buttonBoletoResp";
            this.buttonBoletoResp.Size = new System.Drawing.Size(166, 68);
            this.buttonBoletoResp.TabIndex = 13;
            this.buttonBoletoResp.Text = "EMITIR BOLETO";
            this.buttonBoletoResp.UseVisualStyleBackColor = false;
            this.buttonBoletoResp.Click += new System.EventHandler(this.buttonBoletoResp_Click);
            // 
            // buttonHorarioResp
            // 
            this.buttonHorarioResp.BackColor = System.Drawing.Color.DarkRed;
            this.buttonHorarioResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonHorarioResp.ForeColor = System.Drawing.Color.Coral;
            this.buttonHorarioResp.Location = new System.Drawing.Point(418, 313);
            this.buttonHorarioResp.Name = "buttonHorarioResp";
            this.buttonHorarioResp.Size = new System.Drawing.Size(166, 68);
            this.buttonHorarioResp.TabIndex = 14;
            this.buttonHorarioResp.Text = "HORÁRIO";
            this.buttonHorarioResp.UseVisualStyleBackColor = false;
            this.buttonHorarioResp.Click += new System.EventHandler(this.buttonHorarioResp_Click);
            // 
            // labelOla
            // 
            this.labelOla.BackColor = System.Drawing.Color.Transparent;
            this.labelOla.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.labelOla.ForeColor = System.Drawing.Color.Coral;
            this.labelOla.Location = new System.Drawing.Point(3, 9);
            this.labelOla.Name = "labelOla";
            this.labelOla.Size = new System.Drawing.Size(630, 145);
            this.labelOla.TabIndex = 15;
            this.labelOla.Text = "Portal do Responsável";
            // 
            // labelGrau
            // 
            this.labelGrau.AutoSize = true;
            this.labelGrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelGrau.ForeColor = System.Drawing.Color.MintCream;
            this.labelGrau.Location = new System.Drawing.Point(14, 171);
            this.labelGrau.Name = "labelGrau";
            this.labelGrau.Size = new System.Drawing.Size(419, 46);
            this.labelGrau.TabIndex = 16;
            this.labelGrau.Text = "Hoje sua aula será de:";
            // 
            // PagInicialResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.Controls.Add(this.labelGrau);
            this.Controls.Add(this.labelOla);
            this.Controls.Add(this.buttonHorarioResp);
            this.Controls.Add(this.buttonBoletoResp);
            this.Controls.Add(this.buttonNotasResp);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "PagInicialResp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagInicialResp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PagInicialResp_FormClosed);
            this.Load += new System.EventHandler(this.PagInicialResp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNotasResp;
        private System.Windows.Forms.Button buttonBoletoResp;
        private System.Windows.Forms.Button buttonHorarioResp;
        private System.Windows.Forms.Label labelOla;
        private System.Windows.Forms.Label labelGrau;
    }
}