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

        public bool ErrorProvider()
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

            if (txtCorreo.Text.Length == 0)
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
                errorProvider1.SetError(txtTelefono, "El telefono no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtTelefono, null);
            }

            if (!int.TryParse(txtNum.Text, out cantidad) || txtNum.Text.Length > 3)
            {
                ok = false;
                errorProvider1.SetError(txtNum, "El numero de portal no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtNum, null);
            }

            if (!int.TryParse(txtPiso.Text, out cantidad) || txtPiso.Text.Length > 2)
            {
                ok = false;
                errorProvider1.SetError(txtPiso, "El numero de piso no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtPiso, null);
            }

            if (!int.TryParse(txtPuerta.Text, out cantidad) || txtPuerta.Text.Length > 3)
            {
                ok = false;
                errorProvider1.SetError(txtPuerta, "El numero de puerta no es correcto");
            }
            else
            {
                errorProvider1.SetError(txtPuerta, null);
            }

            return ok;
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (ErrorProvider())
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
        }
    }
}
