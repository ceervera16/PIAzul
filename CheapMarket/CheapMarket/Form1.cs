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
    public partial class Form1 : Form
    {
        bool pass = true;
        ConexionBD bdatos = new ConexionBD();
        public Form1()
        {
            InitializeComponent();
            comboBoxIdioma.SelectedIndex = 1;
            Sesion.Invitado = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro Registro = new Registro();
            Registro.ShowDialog();
            this.Hide();
        }

        //Boton para hacer visible/invisible la contraseña
        private void btnPassword_Click(object sender, EventArgs e)
        {        
            if (pass)
            {
                txtContraseña.PasswordChar = '\0';
                pass = false;
            } else
            {
                txtContraseña.PasswordChar = '*';
                pass = true;
            }
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length == 0)
            {
                MessageBox.Show("Introduce una contraseña");
            } else
            {
                if (Utilidades.ComprobarCorreo(txtCorreo.Text))
                {
                    try
                    {
                        if (ConexionBD.AbrirConexion())
                        {
                            if (Utilidades.IniciarSesion(ConexionBD.Conexion, txtCorreo.Text, txtContraseña.Text))
                            {
                                this.Hide();
                                Categorias categorias = new Categorias(txtCorreo.Text);
                                categorias.Show();
                            }
                            else
                            {
                                MessageBox.Show("El correo o la contraseña no son correctos.");
                                txtContraseña.Clear();
                            }

                            ConexionBD.CerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                    }
                    finally
                    {
                        ConexionBD.CerrarConexion();
                    }
                }
                else
                {
                    MessageBox.Show("Correo incorrecto");
                }
            }
        }

        private void lblInvitado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sesion.Invitado = true;
            Categorias categorias = new Categorias();
            categorias.Show();
        }

        private void btnPagina_Click(object sender, EventArgs e)
        {
            Process.Start("https://cheapmarket123.000webhostapp.com/index.html");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/CheapMarket_");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/CheapMarket_1/");
        }

        private void lblPregunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-Mail: supermercadoscheapmarket@gmail.com\nTeléfono: 900 101 112");
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "cheapmarket@gmail.com" && txtContraseña.Text == "admin")
            {
                this.Hide();
                Administracion administracion = new Administracion();
                administracion.Show();
            } else
            {
                MessageBox.Show("Usuario incorrecto para acceder a esta función");
            }
        }

        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (comboBoxIdioma.Text)
            {
                case "¡Bienvenido!":
                    {
                        cultura = "ES-ES";
                        Idioma.idioma = "ES-ES";
                        break;
                    }
                case "Welcome!":
                    {
                        cultura = "EN-GB";
                        Idioma.idioma = "EN-GB";
                        break;
                    }
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();

        }

        private void Form1_Load(object sender, EventArgs e)
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
        private void AplicarIdioma()
        {
            lblPregunta.Text = Recursos.StringRecursos.Tienes_dudas_Llamanos;
            label1.Text = Recursos.StringRecursos.Bienvenido_a_Cheap_Market;
            label3.Text = Recursos.StringRecursos.Supermercado;
            lblCorreo.Text = Recursos.StringRecursos.Correo_Electrónico;
            lblContraseña.Text = Recursos.StringRecursos.Contraseña;
            lblInvitado.Text = Recursos.StringRecursos.Entrar_como_invitado;
            lblNuevo.Text = Recursos.StringRecursos.Eres_nuevo;
            btnEntrar.Text = Recursos.StringRecursos.btn_Entrar;
            btnRegistar.Text = Recursos.StringRecursos.btn_Registrate;
            btnAdministracion.Text = Recursos.StringRecursos.btn_Admin;
            label4.Text = Recursos.StringRecursos.Idioma;
        }
    }
}
