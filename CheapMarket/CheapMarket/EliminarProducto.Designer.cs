namespace CheapMarket
{
    partial class EliminarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarProducto));
            this.lblCodigo = new System.Windows.Forms.Label();
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.lblFiltos = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEliminarFiltros = new System.Windows.Forms.Button();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
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
            this.lblCodigo.Location = new System.Drawing.Point(12, 534);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(137, 37);
            this.lblCodigo.TabIndex = 70;
            this.lblCodigo.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnEliminar.Location = new System.Drawing.Point(892, 583);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(201, 72);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.lblIntro.Size = new System.Drawing.Size(271, 37);
            this.lblIntro.TabIndex = 67;
            this.lblIntro.Text = "Eliminar Producto";
            this.lblIntro.Click += new System.EventHandler(this.lblIntro_Click);
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
            this.panel3.TabIndex = 62;
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
            this.lblPregunta.TabIndex = 61;
            this.lblPregunta.Text = "¿Tienes dudas? ¡Llámanos!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(273, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 83);
            this.panel1.TabIndex = 66;
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnTwitter.Image = ((System.Drawing.Image)(resources.GetObject("btnTwitter.Image")));
            this.btnTwitter.Location = new System.Drawing.Point(386, 8);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(64, 65);
            this.btnTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTwitter.TabIndex = 65;
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
            this.btnInstagram.TabIndex = 64;
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
            this.btnPagina.TabIndex = 63;
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
            this.btnContacto.TabIndex = 60;
            this.btnContacto.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 574);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(248, 52);
            this.txtCodigo.TabIndex = 69;
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
            this.cmbFiltrar.Location = new System.Drawing.Point(14, 366);
            this.cmbFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(268, 28);
            this.cmbFiltrar.TabIndex = 72;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFiltos
            // 
            this.lblFiltos.AutoSize = true;
            this.lblFiltos.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltos.ForeColor = System.Drawing.Color.Black;
            this.lblFiltos.Location = new System.Drawing.Point(8, 326);
            this.lblFiltos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltos.Name = "lblFiltos";
            this.lblFiltos.Size = new System.Drawing.Size(104, 37);
            this.lblFiltos.TabIndex = 73;
            this.lblFiltos.Text = "Filtros:";
            this.lblFiltos.Click += new System.EventHandler(this.lblFiltos_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnFiltrar.Location = new System.Drawing.Point(153, 408);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(130, 77);
            this.btnFiltrar.TabIndex = 74;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnEliminarFiltros
            // 
            this.btnEliminarFiltros.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEliminarFiltros.Location = new System.Drawing.Point(18, 408);
            this.btnEliminarFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarFiltros.Name = "btnEliminarFiltros";
            this.btnEliminarFiltros.Size = new System.Drawing.Size(130, 77);
            this.btnEliminarFiltros.TabIndex = 75;
            this.btnEliminarFiltros.Text = "Eliminar filtros";
            this.btnEliminarFiltros.UseVisualStyleBackColor = true;
            this.btnEliminarFiltros.Click += new System.EventHandler(this.btnEliminarFiltros_Click);
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(303, 143);
            this.dtgProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.Size = new System.Drawing.Size(790, 431);
            this.dtgProductos.TabIndex = 71;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnSalir.Location = new System.Drawing.Point(753, 583);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 72);
            this.btnSalir.TabIndex = 101;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 674);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarFiltros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFiltos);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.dtgProductos);
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
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
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
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Label lblFiltos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEliminarFiltros;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Button btnSalir;
    }
}