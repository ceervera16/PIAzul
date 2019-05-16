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
            carniceria.Show();
        }

        private void ptbPescaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Pescaderia pescaderia = new Diseño.Pescaderia();
            pescaderia.Show();
        }

        private void ptbFruteria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Fruteria fruteria = new Diseño.Fruteria();
            fruteria.Show();
        }

        private void ptbVerduleria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Carniceria carniceria = new Diseño.Carniceria();
            carniceria.Show();
        }

        private void ptbFiambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Fiambre fiambre = new Diseño.Fiambre();
            fiambre.Show();
        }

        private void ptbHelados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Helados helados = new Diseño.Helados();
            helados.Show();
        }

        private void ptbBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Bebidas bebidas = new Diseño.Bebidas();
            bebidas.Show();
        }

        private void ptbPreparadas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Preparadas preparadas = new Diseño.Preparadas();
            preparadas.Show();
        }

        private void ptbPanaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Panaderia panaderia = new Diseño.Panaderia();
            panaderia.Show();
        }

        private void ptbSnacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Snacks snacks = new Diseño.Snacks();
            snacks.Show();
        }

        private void ptbHigiene_Click(object sender, EventArgs e)
        {
            this.Hide();
             Diseño.Higiene higiene = new Diseño.Higiene();
            higiene.Show();
        }

        private void ptbHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diseño.Hogar hogar = new Diseño.Hogar();
            hogar.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfil = new Perfil();
            perfil.Show();
        }
    }
}
