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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void lblIntro_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Eliminar producto?, se eliminará este producto de todos los carritos temporales", "Eliminar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Administrador admin = new Administrador();
                int codigo;
                bool ok = false;
                try
                {
                    codigo = Convert.ToInt32(txtCodigo.Text);
                    ok = true;
                }
                catch (Exception)
                {

                    throw;
                }

                if (ok)
                {
                    int exito = admin.BorrarProducto(ConexionBD.Conexion, codigo);
                    if (exito > 0)
                    {
                        MessageBox.Show("Producto eliminado");
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Código incorrecto");
                }
                
            }

        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
