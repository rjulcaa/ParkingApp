namespace ParqueoUPC.UI
{
    partial class FrmAdminEspacios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminEspacios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brtAbajo = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnInsertaEspacio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAumentarPiso = new System.Windows.Forms.Button();
            this.lblPisoi = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imgAutoS = new System.Windows.Forms.PictureBox();
            this.imgAutoC = new System.Windows.Forms.PictureBox();
            this.ntnEliminarEspacio = new System.Windows.Forms.Button();
            this.btnEliminarPiso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAutoS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAutoC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 56);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(185, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(211, 29);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Administra Espacios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // brtAbajo
            // 
            this.brtAbajo.Image = ((System.Drawing.Image)(resources.GetObject("brtAbajo.Image")));
            this.brtAbajo.Location = new System.Drawing.Point(45, 471);
            this.brtAbajo.Name = "brtAbajo";
            this.brtAbajo.Size = new System.Drawing.Size(55, 47);
            this.brtAbajo.TabIndex = 1;
            this.brtAbajo.UseVisualStyleBackColor = true;
            this.brtAbajo.Click += new System.EventHandler(this.brtAbajo_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Image = ((System.Drawing.Image)(resources.GetObject("btnArriba.Image")));
            this.btnArriba.Location = new System.Drawing.Point(45, 418);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(55, 47);
            this.btnArriba.TabIndex = 0;
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnInsertaEspacio
            // 
            this.btnInsertaEspacio.Location = new System.Drawing.Point(34, 24);
            this.btnInsertaEspacio.Name = "btnInsertaEspacio";
            this.btnInsertaEspacio.Size = new System.Drawing.Size(75, 64);
            this.btnInsertaEspacio.TabIndex = 2;
            this.btnInsertaEspacio.Text = "InsertaEspacio";
            this.btnInsertaEspacio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInsertaEspacio.UseVisualStyleBackColor = true;
            this.btnInsertaEspacio.Click += new System.EventHandler(this.btnInsertaEspacio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnEliminarPiso);
            this.panel2.Controls.Add(this.ntnEliminarEspacio);
            this.panel2.Controls.Add(this.btnAumentarPiso);
            this.panel2.Controls.Add(this.btnInsertaEspacio);
            this.panel2.Controls.Add(this.brtAbajo);
            this.panel2.Controls.Add(this.btnArriba);
            this.panel2.Location = new System.Drawing.Point(867, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 539);
            this.panel2.TabIndex = 9;
            // 
            // btnAumentarPiso
            // 
            this.btnAumentarPiso.Location = new System.Drawing.Point(34, 257);
            this.btnAumentarPiso.Name = "btnAumentarPiso";
            this.btnAumentarPiso.Size = new System.Drawing.Size(75, 64);
            this.btnAumentarPiso.TabIndex = 3;
            this.btnAumentarPiso.Text = "Aumentar Piso";
            this.btnAumentarPiso.UseVisualStyleBackColor = true;
            this.btnAumentarPiso.Click += new System.EventHandler(this.btnAumentarPiso_Click);
            // 
            // lblPisoi
            // 
            this.lblPisoi.AutoSize = true;
            this.lblPisoi.Location = new System.Drawing.Point(767, 516);
            this.lblPisoi.Name = "lblPisoi";
            this.lblPisoi.Size = new System.Drawing.Size(35, 13);
            this.lblPisoi.TabIndex = 10;
            this.lblPisoi.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.imgAutoS);
            this.panel3.Controls.Add(this.imgAutoC);
            this.panel3.Controls.Add(this.lblPisoi);
            this.panel3.Location = new System.Drawing.Point(12, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 539);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            this.panel3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDoubleClick);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // imgAutoS
            // 
            this.imgAutoS.BackColor = System.Drawing.Color.Transparent;
            this.imgAutoS.Image = ((System.Drawing.Image)(resources.GetObject("imgAutoS.Image")));
            this.imgAutoS.Location = new System.Drawing.Point(374, 244);
            this.imgAutoS.Name = "imgAutoS";
            this.imgAutoS.Size = new System.Drawing.Size(168, 64);
            this.imgAutoS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgAutoS.TabIndex = 12;
            this.imgAutoS.TabStop = false;
            this.imgAutoS.Visible = false;
            // 
            // imgAutoC
            // 
            this.imgAutoC.BackColor = System.Drawing.Color.Transparent;
            this.imgAutoC.Image = ((System.Drawing.Image)(resources.GetObject("imgAutoC.Image")));
            this.imgAutoC.Location = new System.Drawing.Point(404, 102);
            this.imgAutoC.Name = "imgAutoC";
            this.imgAutoC.Size = new System.Drawing.Size(192, 60);
            this.imgAutoC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgAutoC.TabIndex = 11;
            this.imgAutoC.TabStop = false;
            this.imgAutoC.Visible = false;
            // 
            // ntnEliminarEspacio
            // 
            this.ntnEliminarEspacio.Location = new System.Drawing.Point(34, 114);
            this.ntnEliminarEspacio.Name = "ntnEliminarEspacio";
            this.ntnEliminarEspacio.Size = new System.Drawing.Size(75, 66);
            this.ntnEliminarEspacio.TabIndex = 4;
            this.ntnEliminarEspacio.Text = "Eliminar Espacios";
            this.ntnEliminarEspacio.UseVisualStyleBackColor = true;
            this.ntnEliminarEspacio.Click += new System.EventHandler(this.ntnEliminarEspacio_Click);
            // 
            // btnEliminarPiso
            // 
            this.btnEliminarPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPiso.Location = new System.Drawing.Point(34, 340);
            this.btnEliminarPiso.Name = "btnEliminarPiso";
            this.btnEliminarPiso.Size = new System.Drawing.Size(75, 56);
            this.btnEliminarPiso.TabIndex = 5;
            this.btnEliminarPiso.Text = "Eliminar  Piso Superiro";
            this.btnEliminarPiso.UseVisualStyleBackColor = true;
            // 
            // FrmAdminEspacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1046, 659);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdminEspacios";
            this.Text = "FrmAdminEspacios";
            this.Load += new System.EventHandler(this.FrmAdminEspacios_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmAdminEspacios_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAutoS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAutoC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button brtAbajo;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnInsertaEspacio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAumentarPiso;
        private System.Windows.Forms.Label lblPisoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox imgAutoS;
        private System.Windows.Forms.PictureBox imgAutoC;
        private System.Windows.Forms.Button btnEliminarPiso;
        private System.Windows.Forms.Button ntnEliminarEspacio;
    }
}