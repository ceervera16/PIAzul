using CheapMarket;
using MySql.Data.MySqlClient;
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
    public partial class Helados : Form
    {
        public Helados()
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

        private void CargarProductos()
        {
            dgvHelados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string consulta = String.Format("SELECT Nombre, Precio, Descripcion FROM producto where Categoria='HELADOS'");

            if (ConexionBD.AbrirConexion())
            {
                dgvHelados.DataSource = Utilidades.CargarProductos2(ConexionBD.Conexion, consulta);

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

        private void dgvHelados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string producto = dgvHelados.CurrentRow.Cells[0].Value.ToString();

            string consulta = String.Format($"SELECT Informacion FROM producto where Nombre='{producto}'");

            if (ConexionBD.AbrirConexion())
            {
                txtInfo.Text = Utilidades.InfoProducto(ConexionBD.Conexion, consulta);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }

            //Imagen
            string consulta2 = String.Format($"SELECT Imagen FROM producto where Nombre='{producto}'");

            if (ConexionBD.AbrirConexion())
            {
                pcbImagen.Image = Utilidades.ImagenProducto(ConexionBD.Conexion, consulta2);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

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
                    if (Utilidades.ComprobarProducto(ConexionBD.Conexion, dgvHelados.CurrentRow.Cells[0].Value.ToString()))
                    {
                        ConexionBD.CerrarConexion();

                        string dni = Sesion.NifUsu;
                        string nombre = dgvHelados.CurrentRow.Cells[0].Value.ToString();
                        double precio = double.Parse(dgvHelados.CurrentRow.Cells[1].Value.ToString());
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
                    }
                    else
                    {
                        ConexionBD.CerrarConexion();

                        int cant = Decimal.ToInt32(cantidad.Value);
                        string dni = Sesion.NifUsu;
                        string nombre = dgvHelados.CurrentRow.Cells[0].Value.ToString();
                        double precio = double.Parse(dgvHelados.CurrentRow.Cells[1].Value.ToString());
                        double importe = cant * precio;


                        string consulta = String.Format($"INSERT INTO carritotemporal (DniCliente, NomProducto, Cantidad, Importe) VALUES ('{dni}', '{nombre}', '{cant}', '{importe}');");

                        if (ConexionBD.AbrirConexion())
                        {
                            Utilidades.AgregarAlCarrito(ConexionBD.Conexion, consulta).ToString();
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

        private void pcbLupa_Click(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                dgvHelados.DataSource = Utilidades.FiltrarProductos(ConexionBD.Conexion, "HELADOS", txtBuscar.Text);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }
    }
}
