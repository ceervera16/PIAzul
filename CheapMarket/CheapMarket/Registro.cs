﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheapMarket.Recursos;
using System.Globalization;
using System.Threading;

namespace CheapMarket
{
    public partial class Registro : Form
    {
        ConexionBD bdatos = new ConexionBD();
        public Registro()
        {
            InitializeComponent();
            comboBoxIdioma.SelectedIndex = 1;
        }

        //Metodo para validar que todos los datos son correctos
        public bool ValidarDatos()
        {
            bool ok = true;

            if (txtNombre.Text.Length == 0)
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Introduce un nombre");
            }
            else
            {
                errorProvider1.SetError(txtNombre, null);
            }

            if (txtApellidos.Text.Length == 0)
            {
                ok = false;
                errorProvider1.SetError(txtApellidos, "Introduce apellidos");
            }
            else
            {
                errorProvider1.SetError(txtApellidos, null);
            }

            if (!Utilidades.NifCorrecto(txtDNI.Text))
            {
                ok = false;
                errorProvider1.SetError(txtDNI, "El DNI no es valido");
            }
            else
            {
                errorProvider1.SetError(txtDNI, null);
            }

            if (Utilidades.ComprobarCorreo(txtCorreo.Text) == false)
            {
                ok = false;
                errorProvider1.SetError(txtCorreo, "Correo incorrecto");
            }
            else
            {
                errorProvider1.SetError(txtCorreo, null);
            }

            if (txtPass1.Text.Length == 0)
            {
                ok = false;
                errorProvider1.SetError(txtPass1, "Introduce contraseña");
            }
            else
            {
                errorProvider1.SetError(txtPass1, null);
            }

            if (txtPass2.Text.Length == 0)
            {
                ok = false;
                errorProvider1.SetError(txtPass2, "Introduce contraseña");
            }
            else
            {
                errorProvider1.SetError(txtPass2, null);
            }

            if (txtDireccion.Text.Length == 0)
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Introduce dirección");
            }
            else
            {
                errorProvider1.SetError(txtDireccion, null);
            }

            if (txtProvincia.Text.Length == 0)
            {
                ok = false;
                errorProvider1.SetError(txtProvincia, "Introduce una provincia");
            }
            else
            {
                errorProvider1.SetError(txtProvincia, null);
            }

            if (txtLocalidad.Text.Length == 0)
            {
                ok = false;
                errorProvider1.SetError(txtLocalidad, "Introduce una localidad");
            }
            else
            {
                errorProvider1.SetError(txtLocalidad, null);
            }

            int cantidad;

            if (!int.TryParse(txtCodigoPostal.Text, out cantidad) || txtCodigoPostal.Text.Length != 5)
            {
                ok = false;
                errorProvider1.SetError(txtCodigoPostal, "El codigo postal no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtCodigoPostal, null);
            }

            if (!int.TryParse(txtTelefono.Text, out cantidad) || txtTelefono.Text.Length != 9)
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, "El teléfono no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtTelefono, null);
            }

            if (!int.TryParse(txtNum.Text, out cantidad) || txtNum.Text.Length > 3)
            {
                ok = false;
                errorProvider1.SetError(txtNum, "El número de portal no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtNum, null);
            }

            if (!int.TryParse(txtPiso.Text, out cantidad) || txtPiso.Text.Length > 2)
            {
                ok = false;
                errorProvider1.SetError(txtPiso, "El número de piso no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtPiso, null);
            }

            if (!int.TryParse(txtPuerta.Text, out cantidad) || txtPuerta.Text.Length > 3)
            {
                ok = false;
                errorProvider1.SetError(txtPuerta, "El número de puerta no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtPuerta, null);
            }

            if (chkTerminos.Checked == false)
            {
                ok = false;
                errorProvider1.SetError(chkTerminos, "Acepta los términos.");
            }
            else
            {
                errorProvider1.SetError(chkTerminos, null);
            }

            return ok;
        }

        //Metodo para realizar el registro
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    ConexionBD.AbrirConexion();

                    if (Usuario.ExisteUsuario(ConexionBD.Conexion, txtCorreo.Text))
                    {
                        MessageBox.Show("Ya existe un usuario con ese correo.");
                        ConexionBD.CerrarConexion();
                    }
                    else
                    {
                        ConexionBD.CerrarConexion();
                        ConexionBD.AbrirConexion();

                        if (Usuario.ExisteUsuario2(ConexionBD.Conexion, txtDNI.Text))
                        {
                            MessageBox.Show("Ya existe un usuario con ese DNI.");
                            ConexionBD.CerrarConexion();
                        }
                        else
                        {
                            //Creo el usuario
                            Usuario usu = new Usuario(txtDNI.Text, txtNombre.Text, txtApellidos.Text, txtCorreo.Text, txtPass1.Text,
                                int.Parse(txtTelefono.Text), txtProvincia.Text, txtLocalidad.Text, txtDireccion.Text, int.Parse(txtCodigoPostal.Text),
                                int.Parse(txtNum.Text), int.Parse(txtPiso.Text), int.Parse(txtPuerta.Text));

                            //Añado el usuario a la BD
                            ConexionBD.CerrarConexion();
                            ConexionBD.AbrirConexion();

                            Usuario.AgregarUsuario(ConexionBD.Conexion, usu);
                            MessageBox.Show("Usuario creado correctamente.");
                            ConexionBD.CerrarConexion();

                            this.Hide();
                            Form1 inicio = new Form1();
                            inicio.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
            }
        }

        //Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/CheapMarket_");
        }

        private void btnPagina_Click(object sender, EventArgs e)
        {
            Process.Start("https://cheapmarket123.000webhostapp.com/index.html");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/CheapMarket_1/");
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            if (Idioma.idioma == "ES-ES")
            {
                comboBoxIdioma.Text = "¡Bienvenido!";
            }
            else
            {
                comboBoxIdioma.Text = "Welcome!";
            }
            AplicarIdioma();
        }

        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (comboBoxIdioma.Text)
            {
                case "¡Bienvenido!":
                    {
                        cultura = "ES-ES";
                        break;
                    }
                case "Welcome!":
                    {
                        cultura = "EN-GB";
                        break;
                    }
            }

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblVolver.Text = Recursos.StringRecursos.Ya_tienes_cuenta;
            label1.Text = Recursos.StringRecursos.REGISTRATE;
            lblMensaje.Text = Recursos.StringRecursos.Y_consigue_100_puntos_gratis;
            lblNombre.Text = Recursos.StringRecursos.Nombre;
            lblApellidos.Text = Recursos.StringRecursos.Apellidos;
            lblCorreo.Text = Recursos.StringRecursos.Correo_Electrónico;
            lblContraseña.Text = Recursos.StringRecursos.Contraseña;
            lblRepetirContraseña.Text = Recursos.StringRecursos.Repetir_Contraseña;
            label6.Text = Recursos.StringRecursos.Direccion;
            label5.Text = Recursos.StringRecursos.Num_Piso_Puerta;
            label3.Text = Recursos.StringRecursos.Localidad;
            label4.Text = Recursos.StringRecursos.Provincia;
            label2.Text = Recursos.StringRecursos.Codigo_Postal;
            lblTelefono.Text = Recursos.StringRecursos.Telefono;
            chkTerminos.Text = Recursos.StringRecursos.He_leido_y_acepto_los_terminos;
            checkBox1.Text = Recursos.StringRecursos.Quiero_que_me_envien;
            btnRegistar.Text = Recursos.StringRecursos.btn_Registrate;
        }
    }
}
