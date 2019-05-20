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
    public partial class Categorias : Form
    {
        ConexionBD bdatos = new ConexionBD();

        private string comentario;
        private string correo;
        public string Comentario { set { comentario = value; label1.Text = comentario; } }
        public string Correo
        {
            set {
                correo = value;
                if (ConexionBD.AbrirConexion())
                {
                    label1.Text = Utilidades.NombreUsuario(ConexionBD.Conexion, correo);

                    ConexionBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    ConexionBD.CerrarConexion();
                }
            }
        }

        public Categorias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ptbCarniceria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Carniceria carniceria = new Diseño.Carniceria();
            carniceria.Comentario = label1.Text;
            carniceria.Show();
        }

        private void ptbPescaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Pescaderia pescaderia = new Diseño.Pescaderia();
            pescaderia.Comentario = label1.Text;
            pescaderia.Show();
        }

        private void ptbFruteria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Fruteria fruteria = new Diseño.Fruteria();
            fruteria.Comentario = label1.Text;
            fruteria.Show();
        }

        private void ptbVerduleria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Verduleria verduleria = new Diseño.Verduleria();
            verduleria.Comentario = label1.Text;
            verduleria.Show();
        }

        private void ptbFiambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Fiambre fiambre = new Diseño.Fiambre();
            fiambre.Comentario = label1.Text;
            fiambre.Show();
        }

        private void ptbHelados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Helados helados = new Diseño.Helados();
            helados.Comentario = label1.Text;
            helados.Show();
        }

        private void ptbBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Bebidas bebidas = new Diseño.Bebidas();
            bebidas.Comentario = label1.Text;
            bebidas.Show();
        }

        private void ptbPreparadas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Preparadas preparadas = new Diseño.Preparadas();
            preparadas.Comentario = label1.Text;
            preparadas.Show();
        }

        private void ptbPanaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Panaderia panaderia = new Diseño.Panaderia();
            panaderia.Comentario = label1.Text;
            panaderia.Show();
        }

        private void ptbSnacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Snacks snacks = new Diseño.Snacks();
            snacks.Comentario = label1.Text;
            snacks.Show();
        }

        private void ptbHigiene_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Higiene higiene = new Diseño.Higiene();
            higiene.Comentario = label1.Text;
            higiene.Show();
        }

        private void ptbHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Hogar hogar = new Diseño.Hogar();
            hogar.Comentario = label1.Text;
            hogar.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (comentario == "Invitado")
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            } else
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
