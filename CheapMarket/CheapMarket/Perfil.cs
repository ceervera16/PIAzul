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
using CheapMarket.Recursos;
using System.Globalization;
using System.Threading;

namespace CheapMarket
{
    public partial class Perfil : Form
    {

        public Perfil()
        {
            InitializeComponent();
            if (Sesion.Invitado)
            {
                lblUsuario.Text = "Invitado";
            }
            else
            {
                lblUsuario.Text = Sesion.NombreUsu;
            }
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Idioma.idioma);
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            label8.Text = Recursos.StringRecursos.Supermercado;
            label1.Text = Recursos.StringRecursos.Datos_Personales;
            label7.Text = Recursos.StringRecursos.Direccion_entrega;
            lblPregunta.Text = Recursos.StringRecursos.Tienes_dudas_Llamanos;
            button1.Text = Recursos.StringRecursos.Cerrar_sesion;
            lblNombre.Text = Recursos.StringRecursos.Nombre;
            lblApellidos.Text = Recursos.StringRecursos.Apellidos;
            lblCorreo.Text = Recursos.StringRecursos.Correo_Electrónico;
            lblContraseña.Text = Recursos.StringRecursos.Contraseña;
            lblRepetirContraseña.Text = Recursos.StringRecursos.Repetir_Contraseña;
            label6.Text = Recursos.StringRecursos.Direccion;
            label5.Text = Recursos.StringRecursos.Num_Piso_Puerta;
            label4.Text = Recursos.StringRecursos.Provincia;
            label3.Text = Recursos.StringRecursos.Localidad;
            label2.Text = Recursos.StringRecursos.Codigo_Postal;
            lblTelefono.Text = Recursos.StringRecursos.Telefono;
            btnGuardarCambios.Text = Recursos.StringRecursos.Guardar_cambios;

        }

        //Metodos

        //Metodo para validar que todos los son correctos
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

            return ok;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Application.ExitThread();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            Promociones promociones = new Promociones();
            promociones.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
        }

        //Metodo para cargar los datos del usuario
        private void CargarDatos()
        {
            if (ConexionBD.AbrirConexion())
            {
                List<string> usu = Usuario.CargarDatos2(ConexionBD.Conexion);

                //Añado los valores que tiene actualmente
                txtNombre.Text = usu[1];
                txtApellidos.Text = usu[2];
                txtCorreo.Text = usu[3];
                txtPass1.Text = usu[4];
                txtPass2.Text = "";
                txtTelefono.Text = usu[5];
                txtProvincia.Text = usu[7];
                txtLocalidad.Text = usu[8];                
                txtDireccion.Text = usu[9];                
                txtCodigoPostal.Text = usu[10];
                txtNum.Text = usu[12];
                txtPiso.Text = usu[12];
                txtPuerta.Text = usu[13];

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
           
        }

        //Metodo para guardar cambios realizados en el perfil
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (ValidarDatos()) //Compruebo que todos los datos son validos
            {
                if (txtPass1.Text == txtPass2.Text) //Compruebo que ambas contraseñas coindicen
                {
                    ConexionBD.AbrirConexion();

                    if (MessageBox.Show("¿Seguro que quieres guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //Creo el usuario
                        Usuario usu = new Usuario(Sesion.NifUsu, txtNombre.Text, txtApellidos.Text, txtCorreo.Text, txtPass1.Text,
                            int.Parse(txtTelefono.Text), txtProvincia.Text, txtLocalidad.Text, txtDireccion.Text, int.Parse(txtCodigoPostal.Text),
                            int.Parse(txtNum.Text), int.Parse(txtPiso.Text), int.Parse(txtPuerta.Text));

                        ConexionBD.CerrarConexion();
                        ConexionBD.AbrirConexion();

                        Usuario.EditarUsuario(ConexionBD.Conexion, usu);
                        MessageBox.Show("Cambios realizados correctamente. Debes iniciar sesión para actualizar.");
                        ConexionBD.CerrarConexion();

                        this.Hide();
                        Form1 inicio = new Form1();
                        inicio.Show();
                    }
                    else
                    {
                        ConexionBD.CerrarConexion();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
            }
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
