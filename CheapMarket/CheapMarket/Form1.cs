using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
