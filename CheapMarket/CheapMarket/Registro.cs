using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    ConexionBD.AbrirConexion();

                    if (Utilidades.ExisteUsuario(ConexionBD.Conexion, txtCorreo.Text))
                    {
                        MessageBox.Show("Ya existe un usuario con ese correo.");
                        ConexionBD.CerrarConexion();
                    }
                    else
                    {
                        ConexionBD.CerrarConexion();
                        ConexionBD.AbrirConexion();

                        if (Utilidades.ExisteUsuario2(ConexionBD.Conexion, txtDNI.Text))
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

                            Utilidades.AgregarUsuario(ConexionBD.Conexion, usu);
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
    }
}
