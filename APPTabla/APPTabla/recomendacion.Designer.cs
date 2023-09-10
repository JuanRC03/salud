namespace APPTabla
{
    partial class recomendacion
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lr2 = new System.Windows.Forms.Label();
            this.lr1 = new System.Windows.Forms.Label();
            this.lmc = new System.Windows.Forms.Label();
            this.lnom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(293, 389);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(174, 39);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = "Salir";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Recomendación";
            // 
            // lr2
            // 
            this.lr2.AutoSize = true;
            this.lr2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr2.Location = new System.Drawing.Point(55, 168);
            this.lr2.Name = "lr2";
            this.lr2.Size = new System.Drawing.Size(0, 20);
            this.lr2.TabIndex = 18;
            // 
            // lr1
            // 
            this.lr1.AutoSize = true;
            this.lr1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr1.Location = new System.Drawing.Point(55, 137);
            this.lr1.Name = "lr1";
            this.lr1.Size = new System.Drawing.Size(0, 18);
            this.lr1.TabIndex = 17;
            // 
            // lmc
            // 
            this.lmc.AutoSize = true;
            this.lmc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmc.Location = new System.Drawing.Point(54, 100);
            this.lmc.Name = "lmc";
            this.lmc.Size = new System.Drawing.Size(0, 20);
            this.lmc.TabIndex = 35;
            // 
            // lnom
            // 
            this.lnom.AutoSize = true;
            this.lnom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnom.Location = new System.Drawing.Point(55, 63);
            this.lnom.Name = "lnom";
            this.lnom.Size = new System.Drawing.Size(0, 20);
            this.lnom.TabIndex = 36;
            // 
            // recomendacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 456);
            this.Controls.Add(this.lnom);
            this.Controls.Add(this.lmc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lr1);
            this.Controls.Add(this.lr2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recomendacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recomendacion";
            this.Load += new System.EventHandler(this.recomendacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lr2;
        private System.Windows.Forms.Label lr1;
        private System.Windows.Forms.Label lmc;
        private System.Windows.Forms.Label lnom;
    }
}