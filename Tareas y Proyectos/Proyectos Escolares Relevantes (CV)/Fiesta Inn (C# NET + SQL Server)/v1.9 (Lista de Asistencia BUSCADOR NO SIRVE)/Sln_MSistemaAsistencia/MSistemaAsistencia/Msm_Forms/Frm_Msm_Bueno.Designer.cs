namespace MSistemaAsistencia.Msm_Forms
{
    partial class Frm_Msm_Bueno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Msm_Bueno));
            this.pnl_titles = new System.Windows.Forms.Panel();
            this.Lbl_msm1 = new System.Windows.Forms.Label();
            this.Lbl_TituPrinci = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_acept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titles
            // 
            this.pnl_titles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titles.Location = new System.Drawing.Point(0, 0);
            this.pnl_titles.Name = "pnl_titles";
            this.pnl_titles.Size = new System.Drawing.Size(491, 42);
            this.pnl_titles.TabIndex = 0;
            // 
            // Lbl_msm1
            // 
            this.Lbl_msm1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_msm1.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_msm1.Location = new System.Drawing.Point(2, 144);
            this.Lbl_msm1.Name = "Lbl_msm1";
            this.Lbl_msm1.Size = new System.Drawing.Size(487, 59);
            this.Lbl_msm1.TabIndex = 35;
            this.Lbl_msm1.Text = "¿Quieres Quitarlo del Carrito?";
            this.Lbl_msm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_TituPrinci
            // 
            this.Lbl_TituPrinci.AutoSize = true;
            this.Lbl_TituPrinci.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituPrinci.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_TituPrinci.Location = new System.Drawing.Point(88, 98);
            this.Lbl_TituPrinci.Name = "Lbl_TituPrinci";
            this.Lbl_TituPrinci.Size = new System.Drawing.Size(317, 36);
            this.Lbl_TituPrinci.TabIndex = 34;
            this.Lbl_TituPrinci.Text = "Proceso Completado";
            this.Lbl_TituPrinci.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(213, 31);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(64, 64);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 33;
            this.PictureBox1.TabStop = false;
            // 
            // btn_acept
            // 
            this.btn_acept.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_acept.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_acept.ForeColor = System.Drawing.Color.White;
            this.btn_acept.Location = new System.Drawing.Point(129, 206);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(227, 54);
            this.btn_acept.TabIndex = 36;
            this.btn_acept.Text = "Aceptar";
            this.btn_acept.UseVisualStyleBackColor = false;
            this.btn_acept.Click += new System.EventHandler(this.btn_acept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Color del Botón:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "red = 154;";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "green = 205;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "blue = 50;";
            // 
            // Frm_Msm_Bueno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.Lbl_msm1);
            this.Controls.Add(this.Lbl_TituPrinci);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.pnl_titles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Msm_Bueno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Msm_Bueno";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Msm_Bueno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titles;
        internal System.Windows.Forms.Label Lbl_msm1;
        internal System.Windows.Forms.Label Lbl_TituPrinci;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}