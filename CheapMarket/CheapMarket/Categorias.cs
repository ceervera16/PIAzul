using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheapMarket.Recursos;
using System.Globalization;
using System.Threading;

using System.Windows.Forms;

namespace CheapMarket
{
    public partial class Categorias : Form
    {
        ConexionBD bdatos = new ConexionBD();

        public Categorias()
        {
            InitializeComponent();
            if (Sesion.Invitado)
            {
                label1.Text = "Invitado";
            } else
            {
                label1.Text = Sesion.NombreUsu;
            }
        }

        public Categorias(string correo)
        {
            InitializeComponent();

            //Averiguo el nombre del usuario
            if (ConexionBD.AbrirConexion())
            {
                Sesion.NombreUsu = Sesion.NombreUsuario(ConexionBD.Conexion, correo);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }

            //Averiguo el nif del usuario
            if (ConexionBD.AbrirConexion())
            {
                Sesion.NifUsu = Sesion.NifUsuario(ConexionBD.Conexion, correo);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }

            label1.Text = Sesion.NombreUsu;
        }

        //Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Application.ExitThread();
            }
        }

        private void ptbCarniceria_Click(object sender, EventArgs e)
        {
            Diseño.Carniceria carniceria = new Diseño.Carniceria();
            carniceria.Show();
            this.Hide();
        }

        private void ptbPescaderia_Click(object sender, EventArgs e)
        {
            Diseño.Pescaderia pescaderia = new Diseño.Pescaderia();
            pescaderia.Show();
            this.Hide();
        }

        private void ptbFruteria_Click(object sender, EventArgs e)
        {
            Diseño.Fruteria fruteria = new Diseño.Fruteria();
            fruteria.Show();
            this.Hide();
        }

        private void ptbVerduleria_Click(object sender, EventArgs e)
        {
            Diseño.Verduleria verduleria = new Diseño.Verduleria();
            verduleria.Show();
            this.Hide();
        }

        private void ptbFiambres_Click(object sender, EventArgs e)
        {
            Diseño.Fiambre fiambre = new Diseño.Fiambre();
            fiambre.Show();
            this.Hide();
        }

        private void ptbHelados_Click(object sender, EventArgs e)
        {
            Diseño.Helados helados = new Diseño.Helados();
            helados.Show();
            this.Hide();
        }

        private void ptbBebidas_Click(object sender, EventArgs e)
        {
            Diseño.Bebidas bebidas = new Diseño.Bebidas();
            bebidas.Show();
            this.Hide();
        }

        private void ptbPreparadas_Click(object sender, EventArgs e)
        {
            Diseño.Preparadas preparadas = new Diseño.Preparadas();
            preparadas.Show();
            this.Hide();
        }

        private void ptbPanaderia_Click(object sender, EventArgs e)
        {
            Diseño.Panaderia panaderia = new Diseño.Panaderia();
            panaderia.Show();
            this.Hide();
        }

        private void ptbSnacks_Click(object sender, EventArgs e)
        {
            Diseño.Snacks snacks = new Diseño.Snacks();
            snacks.Show();
            this.Hide();
        }

        private void ptbHigiene_Click(object sender, EventArgs e)
        {
            Diseño.Higiene higiene = new Diseño.Higiene();
            higiene.Show();
            this.Hide();
        }

        private void ptbHogar_Click(object sender, EventArgs e)
        {
            Diseño.Hogar hogar = new Diseño.Hogar();
            hogar.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (Sesion.Invitado)
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            } else
            {
                Perfil perfil = new Perfil();
                perfil.Show();
                this.Hide();
            }

        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (Sesion.Invitado)
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            }
            else
            {
                Carrito carrito = new Carrito();
                carrito.Show();
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

        private void Categorias_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Idioma.idioma);
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            label3.Text = Recursos.StringRecursos.Supermercado;
            lblPescaderia.Text = Recursos.StringRecursos.Pescadería;
            lblFruteria.Text = Recursos.StringRecursos.Frutería;
            lblCarniceria.Text = Recursos.StringRecursos.Carnicería;
            lblPanaderia.Text = Recursos.StringRecursos.Panadería;
            lblVerduleria.Text = Recursos.StringRecursos.Verdulería;
            lblFiambres.Text = Recursos.StringRecursos.Fiambres;
            lblHelados.Text = Recursos.StringRecursos.Helados;
            lblBebidas.Text = Recursos.StringRecursos.Bebidas;
            lblPreparadas.Text = Recursos.StringRecursos.Comidas_Preparadas;
            lblPanaderia.Text = Recursos.StringRecursos.Panadería;
            lbSnacks.Text = Recursos.StringRecursos.Snacks;
            lblHigiene.Text = Recursos.StringRecursos.Higiene;
            lblHogar.Text = Recursos.StringRecursos.Hogar;

        }

    }
}
