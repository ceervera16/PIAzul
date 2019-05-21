namespace CheapMarket
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnContacto = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnTwitter = new System.Windows.Forms.PictureBox();
            this.btnInstagram = new System.Windows.Forms.PictureBox();
            this.btnPagina = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.lblInvitado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnContacto)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "¡Welcome!",
            "¡Bienvenido!"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(613, 94);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(121, 25);
            this.comboBoxIdioma.TabIndex = 5;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(262, 112);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(192, 23);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(262, 196);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(119, 23);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Contaseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(262, 225);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(284, 37);
            this.txtContraseña.TabIndex = 9;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnEntrar.Location = new System.Drawing.Point(262, 272);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(119, 40);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnRegistar.Location = new System.Drawing.Point(320, 382);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(175, 40);
            this.btnRegistar.TabIndex = 11;
            this.btnRegistar.Text = "REGÍSTRATE";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.ForeColor = System.Drawing.Color.Black;
            this.lblNuevo.Location = new System.Drawing.Point(349, 352);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(112, 21);
            this.lblNuevo.TabIndex = 12;
            this.lblNuevo.Text = "¿Eres nuevo?";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(533, 17);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(203, 20);
            this.lblPregunta.TabIndex = 15;
            this.lblPregunta.Text = "¿Tienes dudas? ¡Llámanos!";
            // 
            // btnContacto
            // 
            this.btnContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnContacto.Image = global::CheapMarket.Properties.Resources.speech_bubble;
            this.btnContacto.Location = new System.Drawing.Point(484, 5);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(43, 42);
            this.btnContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnContacto.TabIndex = 14;
            this.btnContacto.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pcbLogo);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 209);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supermercado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "CheapMarket";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(13, -18);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(166, 172);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 8;
            this.pcbLogo.TabStop = false;
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnTwitter.Image = ((System.Drawing.Image)(resources.GetObject("btnTwitter.Image")));
            this.btnTwitter.Location = new System.Drawing.Point(257, 5);
            this.btnTwitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(43, 42);
            this.btnTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTwitter.TabIndex = 19;
            this.btnTwitter.TabStop = false;
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnInstagram.Image = ((System.Drawing.Image)(resources.GetObject("btnInstagram.Image")));
            this.btnInstagram.Location = new System.Drawing.Point(319, 5);
            this.btnInstagram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(43, 42);
            this.btnInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInstagram.TabIndex = 18;
            this.btnInstagram.TabStop = false;
            // 
            // btnPagina
            // 
            this.btnPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnPagina.Image")));
            this.btnPagina.Location = new System.Drawing.Point(194, 5);
            this.btnPagina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPagina.Name = "btnPagina";
            this.btnPagina.Size = new System.Drawing.Size(43, 42);
            this.btnPagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPagina.TabIndex = 17;
            this.btnPagina.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(182, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 54);
            this.panel1.TabIndex = 20;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(262, 149);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(323, 37);
            this.txtCorreo.TabIndex = 7;
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.SeaShell;
            this.btnPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnPassword.Image")));
            this.btnPassword.Location = new System.Drawing.Point(549, 225);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(35, 34);
            this.btnPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPassword.TabIndex = 21;
            this.btnPassword.TabStop = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(205, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Bienvenido a Cheap Market";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(608, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Idioma:";
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.Location = new System.Drawing.Point(9, 389);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(129, 40);
            this.btnAdministracion.TabIndex = 24;
            this.btnAdministracion.Text = "ADMIN";
            this.btnAdministracion.UseVisualStyleBackColor = true;
            // 
            // lblInvitado
            // 
            this.lblInvitado.AutoSize = true;
            this.lblInvitado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvitado.ForeColor = System.Drawing.Color.Black;
            this.lblInvitado.Location = new System.Drawing.Point(409, 282);
            this.lblInvitado.Name = "lblInvitado";
            this.lblInvitado.Size = new System.Drawing.Size(175, 21);
            this.lblInvitado.TabIndex = 25;
            this.lblInvitado.Text = "Entrar como invitado";
            this.lblInvitado.Click += new System.EventHandler(this.lblInvitado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(741, 438);
            this.Controls.Add(this.lblInvitado);
            this.Controls.Add(this.btnAdministracion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnTwitter);
            this.Controls.Add(this.btnInstagram);
            this.Controls.Add(this.btnPagina);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btnContacto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.PictureBox btnContacto;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.PictureBox btnTwitter;
        private System.Windows.Forms.PictureBox btnInstagram;
        private System.Windows.Forms.PictureBox btnPagina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.PictureBox btnPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Label lblInvitado;
    }
}

