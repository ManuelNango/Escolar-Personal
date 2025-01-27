namespace MSistemaAsistencia.Personal
{
    partial class Frm_Registro_Personal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registro_Personal));
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.Pic_persona = new System.Windows.Forms.PictureBox();
            this.txtIdPersona = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fechaNaci = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lineR = new System.Windows.Forms.Panel();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.cbo_cargo = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_titu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titu.Controls.Add(this.label1);
            this.pnl_titu.Controls.Add(this.btn_Salir);
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(723, 50);
            this.pnl_titu.TabIndex = 0;
            this.pnl_titu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titu_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE PERSONAL";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Salir.Location = new System.Drawing.Point(679, 8);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(32, 32);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            this.btn_Salir.MouseEnter += new System.EventHandler(this.btn_Salir_MouseEnter);
            this.btn_Salir.MouseLeave += new System.EventHandler(this.btn_Salir_MouseLeave);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(117, 518);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(239, 49);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(394, 518);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(239, 49);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Pic_persona
            // 
            this.Pic_persona.Image = ((System.Drawing.Image)(resources.GetObject("Pic_persona.Image")));
            this.Pic_persona.Location = new System.Drawing.Point(441, 68);
            this.Pic_persona.Name = "Pic_persona";
            this.Pic_persona.Size = new System.Drawing.Size(231, 233);
            this.Pic_persona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_persona.TabIndex = 3;
            this.Pic_persona.TabStop = false;
            this.Pic_persona.Click += new System.EventHandler(this.Pic_persona_Click);
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.BackColor = System.Drawing.Color.White;
            this.txtIdPersona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPersona.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersona.ForeColor = System.Drawing.Color.Silver;
            this.txtIdPersona.Location = new System.Drawing.Point(101, 76);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(210, 19);
            this.txtIdPersona.TabIndex = 4;
            this.txtIdPersona.Text = "ID Personal";
            this.txtIdPersona.Enter += new System.EventHandler(this.txtIdPersona_Enter);
            this.txtIdPersona.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdPersona_KeyDown);
            this.txtIdPersona.Leave += new System.EventHandler(this.txtIdPersona_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(101, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 1);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(65, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 24);
            this.label8.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(65, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 24);
            this.label6.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(65, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(65, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(65, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 48;
            // 
            // dtp_fechaNaci
            // 
            this.dtp_fechaNaci.Location = new System.Drawing.Point(450, 322);
            this.dtp_fechaNaci.Name = "dtp_fechaNaci";
            this.dtp_fechaNaci.Size = new System.Drawing.Size(222, 20);
            this.dtp_fechaNaci.TabIndex = 57;
            this.dtp_fechaNaci.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(420, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 24);
            this.label9.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(101, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 1);
            this.panel2.TabIndex = 60;
            // 
            // txt_Dni
            // 
            this.txt_Dni.BackColor = System.Drawing.Color.White;
            this.txt_Dni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dni.ForeColor = System.Drawing.Color.Silver;
            this.txt_Dni.Location = new System.Drawing.Point(101, 120);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(210, 19);
            this.txt_Dni.TabIndex = 59;
            this.txt_Dni.Text = "CURP";
            this.txt_Dni.TextChanged += new System.EventHandler(this.txt_Dni_TextChanged_1);
            this.txt_Dni.Enter += new System.EventHandler(this.txt_Dni_Enter);
            this.txt_Dni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Dni_KeyDown);
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            this.txt_Dni.Leave += new System.EventHandler(this.txt_Dni_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(101, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 1);
            this.panel3.TabIndex = 62;
            // 
            // txt_nombres
            // 
            this.txt_nombres.BackColor = System.Drawing.Color.White;
            this.txt_nombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.ForeColor = System.Drawing.Color.Silver;
            this.txt_nombres.Location = new System.Drawing.Point(101, 164);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(271, 19);
            this.txt_nombres.TabIndex = 61;
            this.txt_nombres.Text = "Nombre Completo";
            this.txt_nombres.Enter += new System.EventHandler(this.txt_nombres_Enter);
            this.txt_nombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nombres_KeyDown);
            this.txt_nombres.Leave += new System.EventHandler(this.txt_nombres_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(101, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 1);
            this.panel4.TabIndex = 64;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.White;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Silver;
            this.txt_direccion.Location = new System.Drawing.Point(101, 210);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(271, 19);
            this.txt_direccion.TabIndex = 63;
            this.txt_direccion.Text = "RFC";
            this.txt_direccion.Enter += new System.EventHandler(this.txt_direccion_Enter);
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_KeyPress);
            this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(101, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 1);
            this.panel5.TabIndex = 66;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.White;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Silver;
            this.txt_correo.Location = new System.Drawing.Point(101, 260);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(271, 19);
            this.txt_correo.TabIndex = 65;
            this.txt_correo.Text = "Correo electrónico";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(101, 333);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 1);
            this.panel6.TabIndex = 70;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.White;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.Silver;
            this.txt_telefono.Location = new System.Drawing.Point(101, 312);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(271, 19);
            this.txt_telefono.TabIndex = 69;
            this.txt_telefono.Text = "Teléfono";
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_Enter);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // lineR
            // 
            this.lineR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lineR.BackColor = System.Drawing.Color.Teal;
            this.lineR.Location = new System.Drawing.Point(0, 49);
            this.lineR.Name = "lineR";
            this.lineR.Size = new System.Drawing.Size(723, 2);
            this.lineR.TabIndex = 71;
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbo_sexo.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbo_sexo.Location = new System.Drawing.Point(101, 364);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(201, 28);
            this.cbo_sexo.TabIndex = 72;
            this.cbo_sexo.SelectedIndexChanged += new System.EventHandler(this.cbo_sexo_SelectedIndexChanged);
            // 
            // cbo_rol
            // 
            this.cbo_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rol.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbo_rol.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.Location = new System.Drawing.Point(101, 408);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(201, 28);
            this.cbo_rol.TabIndex = 73;
            // 
            // cbo_cargo
            // 
            this.cbo_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cargo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbo_cargo.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_cargo.FormattingEnabled = true;
            this.cbo_cargo.Items.AddRange(new object[] {
            "C",
            "S"});
            this.cbo_cargo.Location = new System.Drawing.Point(101, 452);
            this.cbo_cargo.Name = "cbo_cargo";
            this.cbo_cargo.Size = new System.Drawing.Size(201, 28);
            this.cbo_cargo.TabIndex = 74;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(65, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(71, 456);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 78;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(308, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(308, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(308, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Cargo";
            // 
            // Frm_Registro_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 599);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbo_cargo);
            this.Controls.Add(this.cbo_rol);
            this.Controls.Add(this.cbo_sexo);
            this.Controls.Add(this.lineR);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_fechaNaci);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIdPersona);
            this.Controls.Add(this.Pic_persona);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pnl_titu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Registro_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Personal";
            this.Load += new System.EventHandler(this.Frm_Registro_Personal_Load);
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titu;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.PictureBox Pic_persona;
        private System.Windows.Forms.TextBox txtIdPersona;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fechaNaci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Panel lineR;
        private System.Windows.Forms.ComboBox cbo_sexo;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.ComboBox cbo_cargo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}