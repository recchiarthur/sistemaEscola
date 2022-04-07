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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFaltasResp = new System.Windows.Forms.Button();
            this.buttonNotasResp = new System.Windows.Forms.Button();
            this.buttonBoletoResp = new System.Windows.Forms.Button();
            this.buttonHorarioResp = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 230);
            this.label1.TabIndex = 10;
            this.label1.Text = "Portal do Responsável";
            // 
            // buttonFaltasResp
            // 
            this.buttonFaltasResp.BackColor = System.Drawing.Color.DarkRed;
            this.buttonFaltasResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonFaltasResp.ForeColor = System.Drawing.Color.Coral;
            this.buttonFaltasResp.Location = new System.Drawing.Point(143, 282);
            this.buttonFaltasResp.Name = "buttonFaltasResp";
            this.buttonFaltasResp.Size = new System.Drawing.Size(166, 68);
            this.buttonFaltasResp.TabIndex = 11;
            this.buttonFaltasResp.Text = "FALTAS";
            this.buttonFaltasResp.UseVisualStyleBackColor = false;
            this.buttonFaltasResp.Click += new System.EventHandler(this.buttonFaltasResp_Click);
            // 
            // buttonNotasResp
            // 
            this.buttonNotasResp.BackColor = System.Drawing.Color.DarkRed;
            this.buttonNotasResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonNotasResp.ForeColor = System.Drawing.Color.Coral;
            this.buttonNotasResp.Location = new System.Drawing.Point(359, 282);
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
            this.buttonBoletoResp.Location = new System.Drawing.Point(143, 387);
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
            this.buttonHorarioResp.Location = new System.Drawing.Point(359, 387);
            this.buttonHorarioResp.Name = "buttonHorarioResp";
            this.buttonHorarioResp.Size = new System.Drawing.Size(166, 68);
            this.buttonHorarioResp.TabIndex = 14;
            this.buttonHorarioResp.Text = "HORÁRIO";
            this.buttonHorarioResp.UseVisualStyleBackColor = false;
            this.buttonHorarioResp.Click += new System.EventHandler(this.buttonHorarioResp_Click);
            // 
            // PagInicialResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.Controls.Add(this.buttonHorarioResp);
            this.Controls.Add(this.buttonBoletoResp);
            this.Controls.Add(this.buttonNotasResp);
            this.Controls.Add(this.buttonFaltasResp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PagInicialResp";
            this.Text = "PagInicialResp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFaltasResp;
        private System.Windows.Forms.Button buttonNotasResp;
        private System.Windows.Forms.Button buttonBoletoResp;
        private System.Windows.Forms.Button buttonHorarioResp;
    }
}