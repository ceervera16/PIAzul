using CheapMarket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class Panaderia : Form
    {
        private string comentario;
        public string Comentario { set { comentario = value; label1.Text = comentario; } }

        public Panaderia()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            string consulta = String.Format("SELECT Nombre, Precio, Descripcion FROM producto where Categoria='PANADERIA'");

            if (ConexionBD.AbrirConexion())
            {
                dgvPanaderia.DataSource = Utilidades.CargarProductos2(ConexionBD.Conexion, consulta);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheapMarket.Categorias categorias = new CheapMarket.Categorias();
            categorias.Comentario = label1.Text;
            categorias.Show();
        }
        private void btnCarniceria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carniceria carniceria = new Carniceria();
            carniceria.Comentario = label1.Text;
            carniceria.Show();
        }
        private void btnPescaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pescaderia pescaderia = new Pescaderia();
            pescaderia.Comentario = label1.Text;
            pescaderia.Show();
        }

        private void btnFruteria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruteria fruteria = new Fruteria();
            fruteria.Comentario = label1.Text;
            fruteria.Show();
        }

        private void btnVerduleria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Verduleria verduleria = new Verduleria();
            verduleria.Comentario = label1.Text;
            verduleria.Show();
        }

        private void btnFiambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fiambre fiambre = new Fiambre();
            fiambre.Comentario = label1.Text;
            fiambre.Show();
        }

        private void btnHelados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Helados helados = new Helados();
            helados.Comentario = label1.Text;
            helados.Show();
        }

        private void btnComidaPrep_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preparadas preparadas = new Preparadas();
            preparadas.Comentario = label1.Text;
            preparadas.Show();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }

        private void btnPanaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panaderia panaderia = new Panaderia();
            panaderia.Comentario = label1.Text;
            panaderia.Show();
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snacks snacks = new Snacks();
            snacks.Comentario = label1.Text;
            snacks.Show();
        }

        private void btnHigiene_Click(object sender, EventArgs e)
        {
            this.Hide();
            Higiene higiene = new Higiene();
            higiene.Comentario = label1.Text;
            higiene.Show();
        }

        private void btnHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hogar hogar = new Hogar();
            hogar.Comentario = label1.Text;
            hogar.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (comentario == "Invitado")
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            }
            else
            {
                this.Hide();
                Perfil perfil = new Perfil();
                perfil.Comentario = label1.Text;
                perfil.Show();
            }
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (comentario == "Invitado")
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            }
            else
            {
                this.Hide();
                Carrito carrito = new Carrito();
                carrito.Comentario = label1.Text;
                carrito.Show();
            }
        }
    }
}
