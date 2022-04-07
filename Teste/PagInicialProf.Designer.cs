namespace SistemaSENAI
{
    partial class PagInicialProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagInicialProf));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonHorario = new System.Windows.Forms.Button();
            this.buttonRegPresc = new System.Windows.Forms.Button();
            this.buttonRegNotas = new System.Windows.Forms.Button();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(705, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 331);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonHorario
            // 
            this.buttonHorario.BackColor = System.Drawing.Color.DarkRed;
            this.buttonHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonHorario.ForeColor = System.Drawing.Color.Coral;
            this.buttonHorario.Location = new System.Drawing.Point(0, 98);
            this.buttonHorario.Name = "buttonHorario";
            this.buttonHorario.Size = new System.Drawing.Size(166, 68);
            this.buttonHorario.TabIndex = 1;
            this.buttonHorario.Text = "HORÁRIO";
            this.buttonHorario.UseVisualStyleBackColor = false;
            this.buttonHorario.Click += new System.EventHandler(this.buttonHorario_Click);
            // 
            // buttonRegPresc
            // 
            this.buttonRegPresc.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRegPresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRegPresc.ForeColor = System.Drawing.Color.Coral;
            this.buttonRegPresc.Location = new System.Drawing.Point(0, 172);
            this.buttonRegPresc.Name = "buttonRegPresc";
            this.buttonRegPresc.Size = new System.Drawing.Size(166, 68);
            this.buttonRegPresc.TabIndex = 2;
            this.buttonRegPresc.Text = "REGISTRAR\r\nPRESENÇA";
            this.buttonRegPresc.UseVisualStyleBackColor = false;
            this.buttonRegPresc.Click += new System.EventHandler(this.buttonRegPresc_Click);
            // 
            // buttonRegNotas
            // 
            this.buttonRegNotas.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRegNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRegNotas.ForeColor = System.Drawing.Color.Coral;
            this.buttonRegNotas.Location = new System.Drawing.Point(0, 246);
            this.buttonRegNotas.Name = "buttonRegNotas";
            this.buttonRegNotas.Size = new System.Drawing.Size(166, 68);
            this.buttonRegNotas.TabIndex = 3;
            this.buttonRegNotas.Text = "REGISTRAR NOTAS";
            this.buttonRegNotas.UseVisualStyleBackColor = false;
            this.buttonRegNotas.Click += new System.EventHandler(this.buttonRegNotas_Click);
            // 
            // buttonPlan
            // 
            this.buttonPlan.BackColor = System.Drawing.Color.DarkRed;
            this.buttonPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonPlan.ForeColor = System.Drawing.Color.Coral;
            this.buttonPlan.Location = new System.Drawing.Point(0, 320);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(166, 68);
            this.buttonPlan.TabIndex = 4;
            this.buttonPlan.Text = "PLANEJAR\r\nAULAS";
            this.buttonPlan.UseVisualStyleBackColor = false;
            this.buttonPlan.Click += new System.EventHandler(this.buttonPlan_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(160, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 271);
            this.label1.TabIndex = 9;
            this.label1.Text = "Portal do Professor";
            // 
            // PagInicialProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(907, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPlan);
            this.Controls.Add(this.buttonRegNotas);
            this.Controls.Add(this.buttonRegPresc);
            this.Controls.Add(this.buttonHorario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PagInicialProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.PagInicialProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHorario;
        private System.Windows.Forms.Button buttonRegPresc;
        private System.Windows.Forms.Button buttonRegNotas;
        private System.Windows.Forms.Button buttonPlan;
        private System.Windows.Forms.Label label1;
    }
}