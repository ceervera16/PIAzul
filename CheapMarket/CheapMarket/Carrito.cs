using Diseño;
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
    public partial class Carrito : Form
    {
        public Carrito()
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

        private void Carrito_Load(object sender, EventArgs e)
        {
            CargarCarrito();
            ImporteTotal();
        }

        //Metodos
        private void CargarCarrito()
        {
            string consulta = String.Format($"SELECT NomProducto, Cantidad, Importe FROM carritotemporal where DniCliente LIKE '{Sesion.NifUsu}'");

            if (ConexionBD.AbrirConexion())
            {
                dtgCarrito.DataSource = Utilidades.CargarCarrito(ConexionBD.Conexion, consulta);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        private void ImporteTotal()
        {
            if (dtgCarrito.Rows.Count > 0)
            {
                double total = 0;

                for (int i = 0; i < dtgCarrito.Rows.Count; i++)
                {
                    total = total + double.Parse(dtgCarrito.Rows[i].Cells[2].Value.ToString());
                }

                lblTotal.Text = "Total:    " + total + "€";
            }
            else
            {
                lblTotal.Text = "Total:    ";
            }

        }

        //Botones

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea vaciar el carrito?", "Vaciar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ConexionBD.AbrirConexion())
                {
                    dtgCarrito.DataSource = Utilidades.VaciarCarrito(ConexionBD.Conexion, Sesion.NifUsu);

                    ConexionBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }

                CargarCarrito();
                lblTotal.Text = "Total:    ";
            }
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCarniceria_Click(object sender, EventArgs e)
        {
            Carniceria carniceria = new Carniceria();
            carniceria.Show();
            this.Hide();
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void btnPescaderia_Click(object sender, EventArgs e)
        {
            Pescaderia pescaderia = new Pescaderia();
            pescaderia.Show();
            this.Hide();
        }

        private void btnFruteria_Click(object sender, EventArgs e)
        {
            Fruteria fruteria = new Fruteria();
            fruteria.Show();
            this.Hide();
        }

        private void btnVerduleria_Click(object sender, EventArgs e)
        {
            Verduleria verduleria = new Verduleria();
            verduleria.Show();
            this.Hide();
        }

        private void btnFiambres_Click(object sender, EventArgs e)
        {
            Fiambre fiambre = new Fiambre();
            fiambre.Show();
            this.Hide();
        }

        private void btnHelados_Click(object sender, EventArgs e)
        {
            Helados helados = new Helados();
            helados.Show();
            this.Hide();
        }

        private void btnComidaPrep_Click(object sender, EventArgs e)
        {
            Preparadas preparadas = new Preparadas();
            preparadas.Show();
            this.Hide();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
            this.Hide();
        }

        private void btnPanaderia_Click(object sender, EventArgs e)
        {
            Panaderia panaderia = new Panaderia();
            panaderia.Show();
            this.Hide();
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            Snacks snacks = new Snacks();
            snacks.Show();
            this.Hide();
        }

        private void btnHigiene_Click(object sender, EventArgs e)
        {
            Higiene higiene = new Higiene();
            higiene.Show();
            this.Hide();
        }

        private void btnHogar_Click(object sender, EventArgs e)
        {
            Hogar hogar = new Hogar();
            hogar.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (Sesion.Invitado)
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            }
            else
            {
                Perfil perfil = new Perfil();
                perfil.Show();
                this.Hide();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
        }

        private void pcbLupa_Click(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                dtgCarrito.DataSource = Utilidades.FiltrarCarrito(ConexionBD.Conexion, txtBuscar.Text);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }
    }
    
}
