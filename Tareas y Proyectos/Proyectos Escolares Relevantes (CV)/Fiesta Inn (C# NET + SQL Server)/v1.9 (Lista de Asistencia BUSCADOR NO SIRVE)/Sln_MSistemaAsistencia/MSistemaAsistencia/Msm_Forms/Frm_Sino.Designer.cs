namespace MSistemaAsistencia.Msm_Forms
{
    partial class Frm_Sino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sino));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_msm1 = new System.Windows.Forms.Label();
            this.lbl_Nomalgo = new System.Windows.Forms.Label();
            this.btn_si = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_msm1
            // 
            this.Lbl_msm1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_msm1.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_msm1.Location = new System.Drawing.Point(130, 117);
            this.Lbl_msm1.Name = "Lbl_msm1";
            this.Lbl_msm1.Size = new System.Drawing.Size(379, 108);
            this.Lbl_msm1.TabIndex = 29;
            this.Lbl_msm1.Text = "¿Quieres Cerrar el Programa?";
            this.Lbl_msm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Nomalgo
            // 
            this.lbl_Nomalgo.AutoSize = true;
            this.lbl_Nomalgo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nomalgo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Nomalgo.Location = new System.Drawing.Point(161, 30);
            this.lbl_Nomalgo.Name = "lbl_Nomalgo";
            this.lbl_Nomalgo.Size = new System.Drawing.Size(202, 36);
            this.lbl_Nomalgo.TabIndex = 28;
            this.lbl_Nomalgo.Text = "¿Seguro (a) ?";
            this.lbl_Nomalgo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Nomalgo_MouseMove);
            // 
            // btn_si
            // 
            this.btn_si.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_si.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_si.ForeColor = System.Drawing.Color.White;
            this.btn_si.Location = new System.Drawing.Point(84, 275);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(157, 48);
            this.btn_si.TabIndex = 31;
            this.btn_si.Text = "Si";
            this.btn_si.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_si.UseVisualStyleBackColor = false;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.Color.IndianRed;
            this.btn_no.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_no.ForeColor = System.Drawing.Color.White;
            this.btn_no.Location = new System.Drawing.Point(281, 275);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(157, 48);
            this.btn_no.TabIndex = 32;
            this.btn_no.Text = "NO";
            this.btn_no.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_no.UseVisualStyleBackColor = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // Frm_Sino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 347);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_msm1);
            this.Controls.Add(this.lbl_Nomalgo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Sino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Sino";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Lbl_msm1;
        internal System.Windows.Forms.Label lbl_Nomalgo;
        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Button btn_no;
    }
}