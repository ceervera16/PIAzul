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
        private string comentario;
        public string Comentario { set { comentario = value; lblUsuario.Text = comentario; } }

        public Carrito()
        {
            InitializeComponent();
        }

        private void Carrito_Load(object sender, EventArgs e)
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
            this.Hide();
            Carniceria carniceria = new Carniceria();
            carniceria.Comentario = lblUsuario.Text;
            carniceria.Show();
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categorias categorias = new Categorias();
            categorias.Comentario = lblUsuario.Text;
            categorias.Show();
        }

        private void btnPescaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pescaderia pescaderia = new Pescaderia();
            pescaderia.Comentario = lblUsuario.Text;
            pescaderia.Show();
        }

        private void btnFruteria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruteria fruteria = new Fruteria();
            fruteria.Comentario = lblUsuario.Text;
            fruteria.Show();
        }

        private void btnVerduleria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Verduleria verduleria = new Verduleria();
            verduleria.Comentario = lblUsuario.Text;
            verduleria.Show();
        }

        private void btnFiambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fiambre fiambre = new Fiambre();
            fiambre.Comentario = lblUsuario.Text;
            fiambre.Show();
        }

        private void btnHelados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Helados helados = new Helados();
            helados.Comentario = lblUsuario.Text;
            helados.Show();
        }

        private void btnComidaPrep_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preparadas preparadas = new Preparadas();
            preparadas.Comentario = lblUsuario.Text;
            preparadas.Show();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas();
            bebidas.Comentario = lblUsuario.Text;
            bebidas.Show();
        }

        private void btnPanaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panaderia panaderia = new Panaderia();
            panaderia.Comentario = lblUsuario.Text;
            panaderia.Show();
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snacks snacks = new Snacks();
            snacks.Comentario = lblUsuario.Text;
            snacks.Show();
        }

        private void btnHigiene_Click(object sender, EventArgs e)
        {
            this.Hide();
            Higiene higiene = new Higiene();
            higiene.Comentario = lblUsuario.Text;
            higiene.Show();
        }

        private void btnHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hogar hogar = new Hogar();
            hogar.Comentario = lblUsuario.Text;
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
                perfil.Comentario = lblUsuario.Text;
                perfil.Show();
            }
        }
    }
    
}
