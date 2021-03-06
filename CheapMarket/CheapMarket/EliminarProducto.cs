﻿using System;
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
    public partial class EliminarProducto : Form
    {

        ConexionBD conexion = new ConexionBD();
        public EliminarProducto()
        {
            InitializeComponent();

            if (ConexionBD.AbrirConexion())
            {
                List<Productos> productos = new List<Productos>();
                string consulta = string.Format("SELECT Codigo,Nombre,Precio,Categoria,Descripcion,Informacion FROM producto");
                productos = Administrador.BuscarProducto(ConexionBD.Conexion, consulta);
                dtgProductos.DataSource = productos;
                ConexionBD.CerrarConexion();
            }
        }

        private void lblIntro_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgProductos.SelectedRows.Count == 1)
            {
                int codigo = (int)dtgProductos.CurrentRow.Cells[0].Value;

                DialogResult eliminacion = MessageBox.Show("¿Eliminar producto?, se eliminará este producto de todos los carritos", "Eliminar", MessageBoxButtons.YesNo);

                if (eliminacion == DialogResult.Yes)
                {
                    if (ConexionBD.AbrirConexion())
                    {
                        Administrador admin = new Administrador();
                        int resultado = admin.BorrarProducto(ConexionBD.Conexion, codigo);
                        MessageBox.Show("Se ha eliminado el producto");
                        ConexionBD.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("No se puede abrir la Base de Datos");
                    }
                }
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("¿Eliminar producto?, se eliminará este producto de todos los carritos", "Eliminar", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    Administrador admin = new Administrador();
                    int codigo = 0;
                    bool ok = false;
                    try
                    {
                        codigo = Convert.ToInt32(txtCodigo.Text);
                        ok = true;
                    }
                    catch (Exception)
                    {


                    }

                    if (ok)
                    {
                        if (ConexionBD.AbrirConexion())
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
                            ConexionBD.CerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la base de datos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Código incorrecto");
                    }
                }
            }
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Idioma.idioma);
            AplicarIdioma();

        }
        private void AplicarIdioma()
        {
            label3.Text = CheapMarket.Recursos.StringRecursos.Supermercado;
            lblIntro.Text = CheapMarket.Recursos.StringRecursos.Eliminar_Producto;
            btnEliminar.Text = CheapMarket.Recursos.StringRecursos.Eliminar;
            lblPregunta.Text = CheapMarket.Recursos.StringRecursos.Tienes_dudas_Llamanos;
            lblCodigo.Text = CheapMarket.Recursos.StringRecursos.Código;
            lblFiltos.Text = CheapMarket.Recursos.StringRecursos.Filtros_dospuntitos;
            btnEliminarFiltros.Text = CheapMarket.Recursos.StringRecursos.Eliminar_filtros;
            btnFiltrar.Text = CheapMarket.Recursos.StringRecursos.Filtrar;
            btnSalir.Text = CheapMarket.Recursos.StringRecursos.Salir;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                if (cmbFiltrar.Text != "")
                {
                    List<Productos> productos = new List<Productos>();
                    string consulta = string.Format("Select * from producto WHERE categoria like '{0}'", cmbFiltrar.Text);
                    productos = Administrador.BuscarProducto(ConexionBD.Conexion, consulta);
                    dtgProductos.DataSource = productos;
                }
                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la base de datos");
            }
        }

        private void btnEliminarFiltros_Click(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                List<Productos> productos = new List<Productos>();
                string consulta = string.Format("Select * from producto");
                productos = Administrador.BuscarProducto(ConexionBD.Conexion, consulta);
                dtgProductos.DataSource = productos;
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la base de datos");
            }
            ConexionBD.CerrarConexion();
        }

        private void lblFiltos_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Salir del formulario?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}
