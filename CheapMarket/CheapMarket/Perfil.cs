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
    public partial class Perfil : Form
    {
        private string comentario;
        public string Comentario { set { comentario = value; lblUsuario.Text = comentario; } }

        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {

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
            Categorias categorias = new Categorias();
            categorias.Comentario = lblUsuario.Text;
            categorias.Show();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Promociones promociones = new Promociones();
            promociones.Comentario = lblUsuario.Text;
            promociones.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
