namespace CheapMarket
{
    partial class EditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProducto));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTwitter = new System.Windows.Forms.PictureBox();
            this.btnInstagram = new System.Windows.Forms.PictureBox();
            this.btnPagina = new System.Windows.Forms.PictureBox();
            this.btnContacto = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblInformacionNutritiva = new System.Windows.Forms.Label();
            this.txtInformacionNutritiva = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarFiltros = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltos = new System.Windows.Forms.Label();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(380, 140);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(137, 37);
            this.lblCodigo.TabIndex = 81;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(386, 182);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(482, 52);
            this.txtCodigo.TabIndex = 80;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnEliminar.Location = new System.Drawing.Point(890, 585);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(201, 80);
            this.btnEliminar.TabIndex = 79;
            this.btnEliminar.Text = "Editar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.Black;
            this.lblIntro.Location = new System.Drawing.Point(308, 103);
            this.lblIntro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(245, 37);
            this.lblIntro.TabIndex = 78;
            this.lblIntro.Text = "Editar producto";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pcbLogo);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 322);
            this.panel3.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supermercado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "CheapMarket";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(20, -28);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(249, 265);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 8;
            this.pcbLogo.TabStop = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(800, 26);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(306, 29);
            this.lblPregunta.TabIndex = 72;
            this.lblPregunta.Text = "¿Tienes dudas? ¡Llámanos!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(273, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 83);
            this.panel1.TabIndex = 77;
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnTwitter.Image = ((System.Drawing.Image)(resources.GetObject("btnTwitter.Image")));
            this.btnTwitter.Location = new System.Drawing.Point(386, 8);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(64, 65);
            this.btnTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTwitter.TabIndex = 76;
            this.btnTwitter.TabStop = false;
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnInstagram.Image = ((System.Drawing.Image)(resources.GetObject("btnInstagram.Image")));
            this.btnInstagram.Location = new System.Drawing.Point(478, 8);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(64, 65);
            this.btnInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInstagram.TabIndex = 75;
            this.btnInstagram.TabStop = false;
            // 
            // btnPagina
            // 
            this.btnPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnPagina.Image")));
            this.btnPagina.Location = new System.Drawing.Point(291, 8);
            this.btnPagina.Name = "btnPagina";
            this.btnPagina.Size = new System.Drawing.Size(64, 65);
            this.btnPagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPagina.TabIndex = 74;
            this.btnPagina.TabStop = false;
            // 
            // btnContacto
            // 
            this.btnContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnContacto.Image = global::CheapMarket.Properties.Resources.speech_bubble;
            this.btnContacto.Location = new System.Drawing.Point(726, 8);
            this.btnContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(64, 65);
            this.btnContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnContacto.TabIndex = 71;
            this.btnContacto.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(380, 446);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(197, 37);
            this.lblDescripcion.TabIndex = 91;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(386, 486);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(482, 52);
            this.txtDescripcion.TabIndex = 90;
            this.txtDescripcion.Visible = false;
            // 
            // lblInformacionNutritiva
            // 
            this.lblInformacionNutritiva.AutoSize = true;
            this.lblInformacionNutritiva.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionNutritiva.ForeColor = System.Drawing.Color.Black;
            this.lblInformacionNutritiva.Location = new System.Drawing.Point(380, 545);
            this.lblInformacionNutritiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformacionNutritiva.Name = "lblInformacionNutritiva";
            this.lblInformacionNutritiva.Size = new System.Drawing.Size(325, 37);
            this.lblInformacionNutritiva.TabIndex = 89;
            this.lblInformacionNutritiva.Text = "Información nutritiva:";
            this.lblInformacionNutritiva.Visible = false;
            // 
            // txtInformacionNutritiva
            // 
            this.txtInformacionNutritiva.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacionNutritiva.Location = new System.Drawing.Point(386, 585);
            this.txtInformacionNutritiva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInformacionNutritiva.Name = "txtInformacionNutritiva";
            this.txtInformacionNutritiva.Size = new System.Drawing.Size(482, 52);
            this.txtInformacionNutritiva.TabIndex = 88;
            this.txtInformacionNutritiva.Visible = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(380, 348);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(173, 37);
            this.lblCategoria.TabIndex = 87;
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.Visible = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(380, 243);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(117, 37);
            this.lblPrecio.TabIndex = 85;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(386, 283);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(482, 52);
            this.txtPrecio.TabIndex = 84;
            this.txtPrecio.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(380, 140);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(143, 37);
            this.lblNombre.TabIndex = 83;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(386, 182);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(482, 52);
            this.txtNombre.TabIndex = 82;
            this.txtNombre.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnBuscar.Location = new System.Drawing.Point(890, 583);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(201, 82);
            this.btnBuscar.TabIndex = 92;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnVolver.Location = new System.Drawing.Point(154, 588);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(201, 72);
            this.btnVolver.TabIndex = 93;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarFiltros
            // 
            this.btnEliminarFiltros.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEliminarFiltros.Location = new System.Drawing.Point(18, 426);
            this.btnEliminarFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarFiltros.Name = "btnEliminarFiltros";
            this.btnEliminarFiltros.Size = new System.Drawing.Size(130, 77);
            this.btnEliminarFiltros.TabIndex = 98;
            this.btnEliminarFiltros.Text = "Eliminar filtros";
            this.btnEliminarFiltros.UseVisualStyleBackColor = true;
            this.btnEliminarFiltros.Click += new System.EventHandler(this.btnEliminarFiltros_Click_1);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnFiltrar.Location = new System.Drawing.Point(153, 426);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(130, 77);
            this.btnFiltrar.TabIndex = 97;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblFiltos
            // 
            this.lblFiltos.AutoSize = true;
            this.lblFiltos.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltos.ForeColor = System.Drawing.Color.Black;
            this.lblFiltos.Location = new System.Drawing.Point(8, 345);
            this.lblFiltos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltos.Name = "lblFiltos";
            this.lblFiltos.Size = new System.Drawing.Size(104, 37);
            this.lblFiltos.TabIndex = 96;
            this.lblFiltos.Text = "Filtros:";
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Items.AddRange(new object[] {
            "BEBIDAS",
            "CARNICERIA",
            "PESCADERIA",
            "FRUTERIA",
            "VERDULERIA",
            "FIAMBRES",
            "COMIDAS PREPARADAS",
            "HELADOS",
            "HOGAR",
            "HIGIENE",
            "SNACKS",
            "PANADERIA"});
            this.cmbFiltrar.Location = new System.Drawing.Point(14, 385);
            this.cmbFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(268, 28);
            this.cmbFiltrar.TabIndex = 95;
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(314, 251);
            this.dtgProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.Size = new System.Drawing.Size(777, 292);
            this.dtgProductos.TabIndex = 94;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "BEBIDAS",
            "CARNICERIA",
            "PESCADERIA",
            "FRUTERIA",
            "VERDULERIA",
            "FIAMBRES",
            "COMIDAS PREPARADAS",
            "HELADOS",
            "HOGAR",
            "HIGIENE",
            "SNACKS",
            "PANADERIA"});
            this.cmbCategoria.Location = new System.Drawing.Point(386, 385);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(482, 51);
            this.cmbCategoria.TabIndex = 99;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnSalir.Location = new System.Drawing.Point(18, 588);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 72);
            this.btnSalir.TabIndex = 100;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1112, 674);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnEliminarFiltros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFiltos);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblInformacionNutritiva);
            this.Controls.Add(this.txtInformacionNutritiva);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.btnTwitter);
            this.Controls.Add(this.btnInstagram);
            this.Controls.Add(this.btnPagina);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarProducto";
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.PictureBox btnTwitter;
        private System.Windows.Forms.PictureBox btnInstagram;
        private System.Windows.Forms.PictureBox btnPagina;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.PictureBox btnContacto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblInformacionNutritiva;
        private System.Windows.Forms.TextBox txtInformacionNutritiva;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminarFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFiltos;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnSalir;
    }
}