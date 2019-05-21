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
    public partial class Promociones : Form
    {
        public Promociones()
        {
            InitializeComponent();
            label1.Text = Sesion.NombreUsu;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheapMarket.Perfil perfil = new CheapMarket.Perfil();
            perfil.Show();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Invitado")
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            }
            else
            {
                this.Hide();
                Carrito carrito = new Carrito();
                carrito.Show();
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
    }
}
