namespace ParqueoUPC.UI
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBusCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.rbtRegular = new System.Windows.Forms.RadioButton();
            this.rbtAbonado = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.CbNumeroEspacio = new System.Windows.Forms.ComboBox();
            this.espacioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parqueoUPCDataSet = new ParqueoUPC.UI.ParqueoUPCDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.espacioTableAdapter = new ParqueoUPC.UI.ParqueoUPCDataSetTableAdapters.EspacioTableAdapter();
            this.pngClienteRegistrado = new System.Windows.Forms.Panel();
            this.CbClienteBuscar = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parqueoUPCDataSetCLiente = new ParqueoUPC.UI.ParqueoUPCDataSetCLiente();
            this.parqueoUPCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parqueoUPCDataSet1 = new ParqueoUPC.UI.ParqueoUPCDataSet1();
            this.parqueoUPCDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new ParqueoUPC.UI.ParqueoUPCDataSetCLienteTableAdapters.ClienteTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.espacioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pngClienteRegistrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSetCLiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre :";
            // 
            // lblBusCliente
            // 
            this.lblBusCliente.AutoSize = true;
            this.lblBusCliente.Location = new System.Drawing.Point(377, 122);
            this.lblBusCliente.Name = "lblBusCliente";
            this.lblBusCliente.Size = new System.Drawing.Size(75, 13);
            this.lblBusCliente.TabIndex = 20;
            this.lblBusCliente.Text = "Buscar Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellidos :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tipo de Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "DNI :";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(135, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(135, 174);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 29;
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(380, 327);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(86, 41);
            this.btnAlquilar.TabIndex = 31;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtRegular
            // 
            this.rbtRegular.AutoSize = true;
            this.rbtRegular.Location = new System.Drawing.Point(135, 124);
            this.rbtRegular.Name = "rbtRegular";
            this.rbtRegular.Size = new System.Drawing.Size(62, 17);
            this.rbtRegular.TabIndex = 32;
            this.rbtRegular.TabStop = true;
            this.rbtRegular.Text = "Regular";
            this.rbtRegular.UseVisualStyleBackColor = true;
            // 
            // rbtAbonado
            // 
            this.rbtAbonado.AutoSize = true;
            this.rbtAbonado.Location = new System.Drawing.Point(203, 124);
            this.rbtAbonado.Name = "rbtAbonado";
            this.rbtAbonado.Size = new System.Drawing.Size(68, 17);
            this.rbtAbonado.TabIndex = 33;
            this.rbtAbonado.TabStop = true;
            this.rbtAbonado.Text = "Abonado";
            this.rbtAbonado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Numero de Espacio :";
            // 
            // CbNumeroEspacio
            // 
            this.CbNumeroEspacio.DataSource = this.espacioBindingSource;
            this.CbNumeroEspacio.DisplayMember = "EspacioId";
            this.CbNumeroEspacio.FormattingEnabled = true;
            this.CbNumeroEspacio.Location = new System.Drawing.Point(497, 206);
            this.CbNumeroEspacio.Name = "CbNumeroEspacio";
            this.CbNumeroEspacio.Size = new System.Drawing.Size(121, 21);
            this.CbNumeroEspacio.TabIndex = 35;
            this.CbNumeroEspacio.ValueMember = "EspacioId";
            // 
            // espacioBindingSource
            // 
            this.espacioBindingSource.DataMember = "Espacio";
            this.espacioBindingSource.DataSource = this.parqueoUPCDataSet;
            // 
            // parqueoUPCDataSet
            // 
            this.parqueoUPCDataSet.DataSetName = "ParqueoUPCDataSet";
            this.parqueoUPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Fecha Inicial :";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CustomFormat = "dd-MM-yyyy-hh-mm";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(497, 163);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaInicial.TabIndex = 37;
            this.dtpFechaInicial.Value = new System.DateTime(2015, 4, 24, 0, 0, 0, 0);
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lblUsuarios);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 66);
            this.panel1.TabIndex = 38;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(109, 19);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(165, 29);
            this.lblUsuarios.TabIndex = 15;
            this.lblUsuarios.Text = "Realizar Ventas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // espacioTableAdapter
            // 
            this.espacioTableAdapter.ClearBeforeFill = true;
            // 
            // pngClienteRegistrado
            // 
            this.pngClienteRegistrado.Controls.Add(this.label1);
            this.pngClienteRegistrado.Controls.Add(this.txtNombre);
            this.pngClienteRegistrado.Controls.Add(this.label3);
            this.pngClienteRegistrado.Controls.Add(this.txtApellido);
            this.pngClienteRegistrado.Controls.Add(this.rbtRegular);
            this.pngClienteRegistrado.Controls.Add(this.rbtAbonado);
            this.pngClienteRegistrado.Controls.Add(this.label4);
            this.pngClienteRegistrado.Controls.Add(this.txtDNI);
            this.pngClienteRegistrado.Controls.Add(this.label5);
            this.pngClienteRegistrado.Location = new System.Drawing.Point(21, 86);
            this.pngClienteRegistrado.Name = "pngClienteRegistrado";
            this.pngClienteRegistrado.Size = new System.Drawing.Size(300, 282);
            this.pngClienteRegistrado.TabIndex = 39;
            // 
            // CbClienteBuscar
            // 
            this.CbClienteBuscar.DataSource = this.clienteBindingSource;
            this.CbClienteBuscar.DisplayMember = "Dni";
            this.CbClienteBuscar.FormattingEnabled = true;
            this.CbClienteBuscar.Location = new System.Drawing.Point(497, 122);
            this.CbClienteBuscar.Name = "CbClienteBuscar";
            this.CbClienteBuscar.Size = new System.Drawing.Size(121, 21);
            this.CbClienteBuscar.TabIndex = 40;
            this.CbClienteBuscar.ValueMember = "ClienteId";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.parqueoUPCDataSetCLiente;
            // 
            // parqueoUPCDataSetCLiente
            // 
            this.parqueoUPCDataSetCLiente.DataSetName = "ParqueoUPCDataSetCLiente";
            this.parqueoUPCDataSetCLiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parqueoUPCDataSetBindingSource
            // 
            this.parqueoUPCDataSetBindingSource.DataSource = this.parqueoUPCDataSet;
            this.parqueoUPCDataSetBindingSource.Position = 0;
            // 
            // parqueoUPCDataSet1
            // 
            this.parqueoUPCDataSet1.DataSetName = "ParqueoUPCDataSet1";
            this.parqueoUPCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parqueoUPCDataSet1BindingSource
            // 
            this.parqueoUPCDataSet1BindingSource.DataSource = this.parqueoUPCDataSet1;
            this.parqueoUPCDataSet1BindingSource.Position = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(497, 327);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 41);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 400);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.CbClienteBuscar);
            this.Controls.Add(this.pngClienteRegistrado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.CbNumeroEspacio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBusCliente);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.espacioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pngClienteRegistrado.ResumeLayout(false);
            this.pngClienteRegistrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSetCLiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueoUPCDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBusCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.RadioButton rbtRegular;
        private System.Windows.Forms.RadioButton rbtAbonado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbNumeroEspacio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ParqueoUPCDataSet parqueoUPCDataSet;
        private System.Windows.Forms.BindingSource espacioBindingSource;
        private ParqueoUPCDataSetTableAdapters.EspacioTableAdapter espacioTableAdapter;
        private System.Windows.Forms.Panel pngClienteRegistrado;
        private System.Windows.Forms.ComboBox CbClienteBuscar;
        private System.Windows.Forms.BindingSource parqueoUPCDataSetBindingSource;
        private ParqueoUPCDataSet1 parqueoUPCDataSet1;
        private System.Windows.Forms.BindingSource parqueoUPCDataSet1BindingSource;
        private ParqueoUPCDataSetCLiente parqueoUPCDataSetCLiente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ParqueoUPCDataSetCLienteTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
    }
}