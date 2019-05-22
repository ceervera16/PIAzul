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
            this.Hide();
            CheapMarket.Categorias categorias = new CheapMarket.Categorias();
            categorias.Show();
        }
        private void btnCarniceria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carniceria carniceria = new Carniceria();
            carniceria.Show();
        }
        private void btnPescaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pescaderia pescaderia = new Pescaderia();
            pescaderia.Show();
        }

        private void btnFruteria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruteria fruteria = new Fruteria();
            fruteria.Show();
        }

        private void btnVerduleria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Verduleria verduleria = new Verduleria();
            verduleria.Show();
        }

        private void btnFiambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fiambre fiambre = new Fiambre();
            fiambre.Show();
        }

        private void btnHelados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Helados helados = new Helados();
            helados.Show();
        }

        private void btnComidaPrep_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preparadas preparadas = new Preparadas();
            preparadas.Show();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }

        private void btnPanaderia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panaderia panaderia = new Panaderia();
            panaderia.Show();
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snacks snacks = new Snacks();
            snacks.Show();
        }

        private void btnHigiene_Click(object sender, EventArgs e)
        {
            this.Hide();
            Higiene higiene = new Higiene();
            higiene.Show();
        }

        private void btnHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hogar hogar = new Hogar();
            hogar.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (Sesion.Invitado)
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            }
            else
            {
                this.Hide();
                Perfil perfil = new Perfil();
                perfil.Show();
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
                        MessageBox.Show("El producto ya esta en tu carrito");
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
                        ConexionBD.CerrarConexion();

                        int cant = Decimal.ToInt32(cantidad.Value);
                        string dni = Sesion.NifUsu;
                        string nombre = dgvHelados.CurrentRow.Cells[0].Value.ToString();
                        double precio = double.Parse(dgvHelados.CurrentRow.Cells[1].Value.ToString());
                        double importe = cant * precio;


                        string consulta = String.Format($"INSERT INTO carritotemporal (DniCliente, NomProducto, Cantidad, Importe) VALUES ('{dni}', '{nombre}', '{cant}', '{importe}');");

                        if (ConexionBD.AbrirConexion())
                        {
                            txtInfo.Text = Utilidades.AgregarAlCarrito(ConexionBD.Conexion, consulta).ToString();
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
    }
}
