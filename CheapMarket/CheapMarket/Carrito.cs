using Diseño;
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
using System.Windows.Forms;
using CheapMarket.Recursos;
using System.Globalization;
using System.Threading;

namespace CheapMarket
{
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
            if (Sesion.Invitado)
            {
                lblUsuario.Text = "Invitado";
            }
            else
            {
                lblUsuario.Text = Sesion.NombreUsu;
            }
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            CargarCarrito();
            ImporteTotal();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Idioma.idioma);
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            // BOTONES LATERAL IZQUIERDO
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
            lblCantidad.Text = CheapMarket.Recursos.StringRecursos.Cantidad_a_eliminar;
            label4.Text = CheapMarket.Recursos.StringRecursos.Supermercado;
            lblLista.Text = CheapMarket.Recursos.StringRecursos.Lista;
            lblEliminar.Text = CheapMarket.Recursos.StringRecursos.Doble_click_en_un_producto;
            btnVaciar.Text = CheapMarket.Recursos.StringRecursos.VACIAR_CARRITO;
            btnFinalizarPedido.Text = CheapMarket.Recursos.StringRecursos.FINALIZAR_COMPRA;
            lblMetodo.Text = CheapMarket.Recursos.StringRecursos.ELIGE_METODO_DE_PAGO;
            rdbTarjeta.Text = CheapMarket.Recursos.StringRecursos.TARJETA_DE_CREDITO;
        }

        //Metodos

        //Metodo para cargar el carrito del cliente
        private void CargarCarrito()
        {
            string consulta = String.Format($"SELECT NomProducto, Cantidad, Importe FROM carritotemporal where DniCliente LIKE '{Sesion.NifUsu}'");

            if (ConexionBD.AbrirConexion())
            {
                dtgCarrito.DataSource = CarritoTemporal.CargarCarrito(ConexionBD.Conexion, consulta);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        //Metodo para calcular el importe del carrito
        private void ImporteTotal()
        {
            if (dtgCarrito.Rows.Count > 0)
            {
                double total = 0;

                for (int i = 0; i < dtgCarrito.Rows.Count; i++)
                {
                    total = total + double.Parse(dtgCarrito.Rows[i].Cells[2].Value.ToString());
                }
                total = Math.Round(total, 2);
                lblTotal.Text = "Total:    " + total + "€";
            }
            else
            {
                lblTotal.Text = "Total:    ";
            }

        }

        //Botones

        //Boton para vaciar el carrito
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea vaciar el carrito?", "Vaciar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ConexionBD.AbrirConexion())
                {
                    dtgCarrito.DataSource = CarritoTemporal.VaciarCarrito(ConexionBD.Conexion, Sesion.NifUsu);

                    ConexionBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }

                CargarCarrito();
                lblTotal.Text = "Total:    ";
            }
        }

        //Metodo para final la compra
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            //Cargo el datagrid con todos los productos por si el cliente ha realizado alguna busqueda
            ConexionBD.AbrirConexion();
            dtgCarrito.DataSource = CarritoTemporal.FiltrarCarrito(ConexionBD.Conexion, "");
            ConexionBD.CerrarConexion();

            string metodoPago = "";
            DateTime fecha = DateTime.Now;
            string dni = Sesion.NifUsu;

            if (rdbVisa.Checked)
            {
                metodoPago = "Visa";
            } else if (rdbTarjeta.Checked)
            {
                metodoPago = "Tarjeta";
            } else if (rdbMastercard.Checked)
            {
                metodoPago = "Mastercard";
            } else if (rdbPaypal.Checked)
            {
                metodoPago = "PayPal";
            }

            ConexionBD.AbrirConexion();

            if (CarritoTemporal.ComprobarCarrito(ConexionBD.Conexion))
            {
                ConexionBD.CerrarConexion();
                if (MessageBox.Show("¿Seguro que desea realizar la compra? No podrá modificarla después.", "Comprar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Añado los productos del carrito a la tabla compra
                    for (int i = 0; i < dtgCarrito.Rows.Count; i++)
                    {
                        int codigoProducto;
                        string nombreProducto = dtgCarrito.Rows[i].Cells[0].Value.ToString();
                        int cantidadProducto = int.Parse(dtgCarrito.Rows[i].Cells[1].Value.ToString());

                        ConexionBD.AbrirConexion();
                        codigoProducto = Productos.CodigoProducto(ConexionBD.Conexion, nombreProducto);
                        ConexionBD.CerrarConexion();

                        ConexionBD.AbrirConexion();
                        string consultaInsert = String.Format("INSERT INTO compra (Fecha, DniCliente, CodProducto, Cantidad, Metodo) VALUES ('{0}','{1}','{2}','{3}','{4}');", fecha.ToString("yyyy-MM-dd HH:mm:ss"), dni, codigoProducto, cantidadProducto, metodoPago);
                        MySqlCommand comando = new MySqlCommand(consultaInsert, ConexionBD.Conexion);
                        MySqlDataReader reader = comando.ExecuteReader();
                        ConexionBD.CerrarConexion();
                    }

                    //Muestro mensaje indicando que la compra se ha realizado correctamente
                    MessageBox.Show("Compra realizada correctamente. Le enviaremos su pedido lo antes posible.");

                    //Pregunto al cliente si quiere vaciar el carrito
                    if (MessageBox.Show("¿Quieres vaciar el carrito?", "Vaciar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ConexionBD.AbrirConexion();
                        CarritoTemporal.VaciarCarrito(ConexionBD.Conexion, Sesion.NifUsu);
                        ConexionBD.CerrarConexion();
                    }
                    CargarCarrito();
                    ImporteTotal();
                }
            }
            else
            {
                MessageBox.Show("No tienes ningun producto en tu carrito.");
                ConexionBD.CerrarConexion();
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

        private void btnCarniceria_Click(object sender, EventArgs e)
        {
            Carniceria carniceria = new Carniceria();
            carniceria.Show();
            this.Hide();
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
        }

        private void pcbLupa_Click(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                dtgCarrito.DataSource = CarritoTemporal.FiltrarCarrito(ConexionBD.Conexion, txtBuscar.Text);

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        //Metodo para eliminar productos del carrito
        private void dtgCarrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dtgCarrito.CurrentRow.Cells[0].Value.ToString();
            int cantidadEliminar = Decimal.ToInt32(cantidad.Value);
            int cantCart = int.Parse(dtgCarrito.CurrentRow.Cells[1].Value.ToString());

            if (cantidadEliminar > cantCart)
            {
                MessageBox.Show("No tienes tanta cantidad de ese producto en el carrito");
            }
            else if (cantidadEliminar == cantCart)
            {
                if (MessageBox.Show("Se eliminaran todas las cantidades ¿Seguro que desea eliminar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string consulta = String.Format($"DELETE FROM carritotemporal WHERE DniCliente LIKE '{Sesion.NifUsu}' AND NomProducto LIKE '{nombre}'");

                    ConexionBD.AbrirConexion();

                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    MySqlDataReader reader = comando.ExecuteReader();

                    ConexionBD.CerrarConexion();

                    cantidad.Value = 1;
                    CargarCarrito();
                    ImporteTotal();
                }
            }
            else
            {
                int nuevaCantidad = cantCart - cantidadEliminar;
                double precio = 0;

                if (MessageBox.Show($"Te quedaras con {nuevaCantidad} unidad(es) en el carrito ¿Seguro que desea eliminar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ConexionBD.AbrirConexion();
                    precio = Productos.CalcularPrecio(ConexionBD.Conexion, nombre);
                    ConexionBD.CerrarConexion();

                    double nuevoImporte = nuevaCantidad * precio;
                    nuevoImporte = Math.Round(nuevoImporte, 2);
                    string consulta = String.Format($"UPDATE carritotemporal SET Cantidad='{nuevaCantidad}', Importe='{nuevoImporte}' WHERE DniCliente LIKE '{Sesion.NifUsu}' AND NomProducto LIKE '{nombre}'");

                    ConexionBD.AbrirConexion();

                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    MySqlDataReader reader = comando.ExecuteReader();

                    ConexionBD.CerrarConexion();
                }

                cantidad.Value = 1;
                CargarCarrito();
                ImporteTotal();
            }
        }

        //Botones redes sociales
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
    }
    
}
