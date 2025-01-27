namespace MSistemaAsistencia.Msm_Forms
{
    partial class Frm_Advertencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Advertencia));
            this.Lbl_Msm1 = new System.Windows.Forms.Label();
            this.lbl_Nomalgo = new System.Windows.Forms.Label();
            this.btn_acept = new System.Windows.Forms.Button();
            this.pnl_titles = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Msm1
            // 
            this.Lbl_Msm1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Msm1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Msm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_Msm1.Location = new System.Drawing.Point(111, 150);
            this.Lbl_Msm1.Name = "Lbl_Msm1";
            this.Lbl_Msm1.Size = new System.Drawing.Size(263, 69);
            this.Lbl_Msm1.TabIndex = 30;
            this.Lbl_Msm1.Text = "¿Estas seguro de \r\nCerrar el Sistema?\r\n o no lo estas";
            this.Lbl_Msm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Nomalgo
            // 
            this.lbl_Nomalgo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nomalgo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nomalgo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_Nomalgo.Location = new System.Drawing.Point(33, 97);
            this.lbl_Nomalgo.Name = "lbl_Nomalgo";
            this.lbl_Nomalgo.Size = new System.Drawing.Size(414, 36);
            this.lbl_Nomalgo.TabIndex = 29;
            this.lbl_Nomalgo.Text = "Advertencia";
            this.lbl_Nomalgo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_acept
            // 
            this.btn_acept.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_acept.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acept.ForeColor = System.Drawing.Color.White;
            this.btn_acept.Location = new System.Drawing.Point(133, 237);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(227, 54);
            this.btn_acept.TabIndex = 29;
            this.btn_acept.Text = "Aceptar";
            this.btn_acept.UseVisualStyleBackColor = false;
            this.btn_acept.Click += new System.EventHandler(this.btn_acept_Click);
            // 
            // pnl_titles
            // 
            this.pnl_titles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titles.Location = new System.Drawing.Point(0, 0);
            this.pnl_titles.Name = "pnl_titles";
            this.pnl_titles.Size = new System.Drawing.Size(480, 42);
            this.pnl_titles.TabIndex = 32;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(208, 30);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(64, 64);
            this.PictureBox1.TabIndex = 28;
            this.PictureBox1.TabStop = false;
            // 
            // Frm_Advertencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 334);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.pnl_titles);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.Lbl_Msm1);
            this.Controls.Add(this.lbl_Nomalgo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Advertencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Advertencia";
            this.Load += new System.EventHandler(this.Frm_Advertencia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Advertencia_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Advertencia_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label Lbl_Msm1;
        internal System.Windows.Forms.Label lbl_Nomalgo;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Panel pnl_titles;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}