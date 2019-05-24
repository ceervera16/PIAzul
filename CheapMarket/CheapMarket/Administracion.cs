using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheapMarket.Recursos;
using System.Globalization;
using System.Threading;


namespace CheapMarket
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Idioma.idioma);
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            btnInsertar.Text = CheapMarket.Recursos.StringRecursos.Insertar_Producto;
            btnEditar.Text = CheapMarket.Recursos.StringRecursos.Editar_Producto;
            btnEliminar.Text = CheapMarket.Recursos.StringRecursos.Eliminar_Producto;
            label3.Text = CheapMarket.Recursos.StringRecursos.Supermercado;
            lblIntro.Text = CheapMarket.Recursos.StringRecursos.Administración;
            lblPregunta.Text = CheapMarket.Recursos.StringRecursos.Tienes_dudas_Llamanos;
            btnSalir.Text = CheapMarket.Recursos.StringRecursos.VOLVER_A_INICIO;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            AñadirProducto add = new AñadirProducto();
            add.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProducto editar = new EditarProducto();
            editar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarProducto elim = new EliminarProducto();
            elim.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form1 inicio = new Form1();
                inicio.Show();
            }
        }
    }
}
