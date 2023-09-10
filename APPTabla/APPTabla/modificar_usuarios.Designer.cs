namespace APPTabla
{
    partial class modificar_usuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txbnombre1 = new System.Windows.Forms.MaskedTextBox();
            this.c = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbpeso = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbedad1 = new System.Windows.Forms.MaskedTextBox();
            this.txbapellido = new System.Windows.Forms.MaskedTextBox();
            this.txbnombre = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gmodificar = new System.Windows.Forms.GroupBox();
            this.txttalla = new System.Windows.Forms.MaskedTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.guardar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gmodificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txbnombre1);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(89, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 100);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(142)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(190)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 30;
            this.btnbuscar.Location = new System.Drawing.Point(188, 52);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(123, 32);
            this.btnbuscar.TabIndex = 36;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txbnombre1
            // 
            this.txbnombre1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbnombre1.Location = new System.Drawing.Point(188, 20);
            this.txbnombre1.Mask = "9999999999";
            this.txbnombre1.Name = "txbnombre1";
            this.txbnombre1.Size = new System.Drawing.Size(143, 26);
            this.txbnombre1.TabIndex = 33;
            this.txbnombre1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbnombre1_MaskInputRejected);
            this.txbnombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbnombre1_KeyPress);
            this.txbnombre1.MouseHover += new System.EventHandler(this.txbnombre1_MouseHover);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(121, 20);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(67, 20);
            this.c.TabIndex = 17;
            this.c.Text = "Cédula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 30);
            this.label5.TabIndex = 40;
            this.label5.Text = "Modificar datos";
            // 
            // txbpeso
            // 
            this.txbpeso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbpeso.Location = new System.Drawing.Point(104, 138);
            this.txbpeso.Mask = "99999";
            this.txbpeso.Name = "txbpeso";
            this.txbpeso.Size = new System.Drawing.Size(48, 26);
            this.txbpeso.TabIndex = 41;
            this.txbpeso.ValidatingType = typeof(int);
            this.txbpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbpeso_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Peso (Kg):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(242, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Talla (cm):";
            // 
            // txbedad1
            // 
            this.txbedad1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbedad1.Location = new System.Drawing.Point(316, 65);
            this.txbedad1.Mask = "99999";
            this.txbedad1.Name = "txbedad1";
            this.txbedad1.Size = new System.Drawing.Size(46, 26);
            this.txbedad1.TabIndex = 35;
            this.txbedad1.ValidatingType = typeof(int);
            this.txbedad1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbedad_KeyPress);
            // 
            // txbapellido
            // 
            this.txbapellido.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbapellido.Location = new System.Drawing.Point(108, 99);
            this.txbapellido.Mask = "???????????????????????????????????????";
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(113, 26);
            this.txbapellido.TabIndex = 34;
            this.txbapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbapellido_KeyPress);
            // 
            // txbnombre
            // 
            this.txbnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbnombre.Location = new System.Drawing.Point(108, 63);
            this.txbnombre.Mask = "???????????????????????????????????????";
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(117, 26);
            this.txbnombre.TabIndex = 33;
            this.txbnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbnombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // gmodificar
            // 
            this.gmodificar.Controls.Add(this.txtCedula);
            this.gmodificar.Controls.Add(this.label4);
            this.gmodificar.Controls.Add(this.txttalla);
            this.gmodificar.Controls.Add(this.iconButton1);
            this.gmodificar.Controls.Add(this.guardar);
            this.gmodificar.Controls.Add(this.txbpeso);
            this.gmodificar.Controls.Add(this.label1);
            this.gmodificar.Controls.Add(this.txbedad1);
            this.gmodificar.Controls.Add(this.label2);
            this.gmodificar.Controls.Add(this.txbapellido);
            this.gmodificar.Controls.Add(this.label13);
            this.gmodificar.Controls.Add(this.txbnombre);
            this.gmodificar.Controls.Add(this.label3);
            this.gmodificar.Controls.Add(this.label12);
            this.gmodificar.Enabled = false;
            this.gmodificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmodificar.Location = new System.Drawing.Point(89, 149);
            this.gmodificar.Name = "gmodificar";
            this.gmodificar.Size = new System.Drawing.Size(516, 217);
            this.gmodificar.TabIndex = 44;
            this.gmodificar.TabStop = false;
            this.gmodificar.Text = "Datos a modificar";
            this.gmodificar.Enter += new System.EventHandler(this.gmodificar_Enter);
            // 
            // txttalla
            // 
            this.txttalla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttalla.Location = new System.Drawing.Point(319, 102);
            this.txttalla.Mask = "999";
            this.txttalla.Name = "txttalla";
            this.txttalla.Size = new System.Drawing.Size(48, 26);
            this.txttalla.TabIndex = 47;
            this.txttalla.ValidatingType = typeof(int);
            this.txttalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttalla_KeyPress_1);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(142)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(190)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(266, 176);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(123, 32);
            this.iconButton1.TabIndex = 44;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(142)))));
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(190)))));
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guardar.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.guardar.IconColor = System.Drawing.Color.Black;
            this.guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardar.IconSize = 30;
            this.guardar.Location = new System.Drawing.Point(129, 176);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(123, 32);
            this.guardar.TabIndex = 46;
            this.guardar.Text = "Guardar";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.AutoSize = true;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(112, 32);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(0, 20);
            this.txtCedula.TabIndex = 49;
            // 
            // modificar_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 378);
            this.Controls.Add(this.gmodificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modificar_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificar_usuarios";
            this.Load += new System.EventHandler(this.modificar_usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gmodificar.ResumeLayout(false);
            this.gmodificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.MaskedTextBox txbnombre1;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gmodificar;
        private FontAwesome.Sharp.IconButton guardar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label txtCedula;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox txbpeso;
        public System.Windows.Forms.MaskedTextBox txbedad1;
        public System.Windows.Forms.MaskedTextBox txbapellido;
        public System.Windows.Forms.MaskedTextBox txbnombre;
        public System.Windows.Forms.MaskedTextBox txttalla;
    }
}