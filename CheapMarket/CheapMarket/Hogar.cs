﻿using CheapMarket;
using MySql.Data.MySqlClient;
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

namespace Diseño
{
    public partial class Hogar : Form
    {
        public Hogar()
        {
            InitializeComponent();
            CargarProductos();
            if (Sesion.Invitado)
            {
                label1.Text = "Invitado";
            }
            else
            {
                label1.Text = Sesion.NombreUsu;
            }
        }

        //Metodos para cargar los productos en el datagrid
        private void CargarProductos()
        {
            dgvHogar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string consulta = String.Format("SELECT Nombre, Precio, Descripcion FROM producto where Categoria='HOGAR'");

            if (ConexionBD.AbrirConexion())
            {
                dgvHogar.DataSource = Productos.CargarProductos2(ConexionBD.Conexion, consulta);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
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
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            CheapMarket.Categorias categorias = new CheapMarket.Categorias();
            categorias.Show();
            this.Hide();
        }
        private void btnCarniceria_Click(object sender, EventArgs e)
        {
            Carniceria carniceria = new Carniceria();
            carniceria.Show();
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

        //Metodo para agregar productos al carrito
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Sesion.Invitado)
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            }
            else
            {
                if (ConexionBD.AbrirConexion())
                {
                    if (Utilidades.ComprobarProducto(ConexionBD.Conexion, dgvHogar.CurrentRow.Cells[0].Value.ToString()))
                    {
                        ConexionBD.CerrarConexion();

                        string dni = Sesion.NifUsu;
                        string nombre = dgvHogar.CurrentRow.Cells[0].Value.ToString();
                        double precio = double.Parse(dgvHogar.CurrentRow.Cells[1].Value.ToString());
                        int cantAdd = Decimal.ToInt32(cantidad.Value);
                        int cantCart = 0;

                        if (ConexionBD.AbrirConexion())
                        {
                            cantCart = Utilidades.CalcularCantidad(ConexionBD.Conexion, nombre, dni);
                            ConexionBD.CerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }

                        if (MessageBox.Show($"El producto ya esta en tu carrito. Actualmente tienes {cantCart} y quieres añadir {cantAdd} mas. " +
                            $"¿Quieres añadir dicha cantidad?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int cant = cantAdd + cantCart;
                            double importe = cant * precio;

                            if (ConexionBD.AbrirConexion())
                            {
                                string consulta = String.Format($"UPDATE carritotemporal SET Importe='{importe}', Cantidad={cant} WHERE DniCliente LIKE '{dni}' AND NomProducto LIKE '{nombre}'");
                                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                                MySqlDataReader reader = comando.ExecuteReader();
                                MessageBox.Show("Producto actualizado correctamente.");
                                ConexionBD.CerrarConexion();
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                    }
                    else
                    {
                        ConexionBD.CerrarConexion();

                        int cant = Decimal.ToInt32(cantidad.Value);
                        string dni = Sesion.NifUsu;
                        string nombre = dgvHogar.CurrentRow.Cells[0].Value.ToString();
                        double precio = double.Parse(dgvHogar.CurrentRow.Cells[1].Value.ToString());
                        double importe = cant * precio;


                        string consulta = String.Format($"INSERT INTO carritotemporal (DniCliente, NomProducto, Cantidad, Importe) VALUES ('{dni}', '{nombre}', '{cant}', '{importe}');");

                        if (ConexionBD.AbrirConexion())
                        {
                            CarritoTemporal.AgregarAlCarrito(ConexionBD.Conexion, consulta);
                            MessageBox.Show("Producto agregado correctamente");
                            cantidad.Value = 1;
                            ConexionBD.CerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                    }

                    ConexionBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }

            }

        }

        //Metodo para ver imagen del producto
        private void dgvHogar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string producto = dgvHogar.CurrentRow.Cells[0].Value.ToString();

            //Imagen
            string consulta2 = String.Format($"SELECT Imagen FROM producto where Nombre='{producto}'");

            if (ConexionBD.AbrirConexion())
            {
                pcbImagen.Image = Productos.ImagenProducto(ConexionBD.Conexion, consulta2);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        //Metodo para filtrar productos
        private void pcbLupa_Click(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                dgvHogar.DataSource = Productos.FiltrarProductos(ConexionBD.Conexion, "HOGAR", txtBuscar.Text);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        //Botones redes
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

        private void Hogar_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Idioma.idioma);
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            btnCarniceria.Text = CheapMarket.Recursos.StringRecursos.Carnicería;
            btnPescaderia.Text = CheapMarket.Recursos.StringRecursos.Pescadería;
            btnFruteria.Text = CheapMarket.Recursos.StringRecursos.Frutería;
            btnVerduleria.Text = CheapMarket.Recursos.StringRecursos.Verdulería;
            btnFiambres.Text = CheapMarket.Recursos.StringRecursos.Fiambres;
            btnHelados.Text = CheapMarket.Recursos.StringRecursos.Helados;
            btnComidaPrep.Text = CheapMarket.Recursos.StringRecursos.Comidas_Preparadas;
            btnBebidas.Text = CheapMarket.Recursos.StringRecursos.Bebidas;
            btnPanaderia.Text = CheapMarket.Recursos.StringRecursos.Panadería;
            btnSnacks.Text = CheapMarket.Recursos.StringRecursos.Snacks;
            btnHigiene.Text = CheapMarket.Recursos.StringRecursos.Higiene;
            btnHogar.Text = CheapMarket.Recursos.StringRecursos.Hogar;
            lblCantidad.Text = CheapMarket.Recursos.StringRecursos.Cantidad;
            label3.Text = CheapMarket.Recursos.StringRecursos.Supermercado;
            btnAgregar.Text = CheapMarket.Recursos.StringRecursos.Agregar;
        }
    }
}