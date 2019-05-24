using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CheapMarket
{
    public partial class AñadirProducto : Form
    {
        ConexionBD conexion = new ConexionBD();
        public AñadirProducto()
        {
            InitializeComponent();
        }

        private void AñadirProducto_Load(object sender, EventArgs e)
        {

        }

        private bool comprobarVacios()
        {
            bool ok = true;

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Este campo es obligatório");
                ok = false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtPrecio.Text == "")
            {
                errorProvider1.SetError(txtPrecio, "Este campo es obligatório");
                ok = false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cmbCategoria.Text == "")
            {
                errorProvider1.SetError(cmbCategoria, "Este campo es obligatório");
                ok = false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "Este campo es obligatório");
                ok = false;
            }
            else
            {
                errorProvider1.Clear();
            }
            return ok;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtInformacionNutritiva.Text.Length == 0)
            {
                txtInformacionNutritiva.Text = " ";
            }

            if (ConexionBD.AbrirConexion())
            {
                if (comprobarVacios())
                {
                    DialogResult respuesta = MessageBox.Show("¿Insertar producto?", "Insertar", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = false;
                        Administrador admin = new Administrador();
                        Productos prod = new Productos();
                        List<int> lista = new List<int>();
                        int res;

                        prod.Nombre = txtNombre.Text;
                        try
                        {
                            prod.Precio = Convert.ToDouble(txtPrecio.Text);
                            ok = true;
                        }
                        catch (Exception)
                        {

                            
                        }

                        prod.Categoria = cmbCategoria.Text;
                        prod.Descripcion = txtDescripcion.Text;
                        prod.Info = txtInformacionNutritiva.Text;
                        prod.Foto = pctFoto.Image;

                        if (ok)
                        {
                            if (!NombreRepetido(prod.Nombre))
                            {
                                MySqlCommand commando = new MySqlCommand("SELECT Codigo FROM producto ORDER BY Codigo;", ConexionBD.Conexion);
                                MySqlDataReader reader = commando.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        lista.Add(reader.GetInt32(0));
                                    }
                                }
                                reader.Close();
                                prod.Codigo = lista[lista.Count - 1] + 1;

                                res = admin.AgregarProducto(ConexionBD.Conexion, prod);
                                if (res > 0)
                                {
                                    MessageBox.Show("Producto insertado");
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido insertar el producto");
                                }
                                txtNombre.Clear();
                                cmbCategoria.Text = "";
                                txtDescripcion.Clear();
                                txtDescripcion.Clear();
                                txtPrecio.Clear();
                                pctFoto.Image = pcbLogo.Image;
                            }
                            else
                            {
                                MessageBox.Show("Ya hay un producto en la base de datos con este nombre, introduce otro");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Precio no válido");
                        }
                    }
                }
                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la base de datos");
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargaImagen = new OpenFileDialog();
            cargaImagen.InitialDirectory = "C:\\";
            cargaImagen.Filter = "JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (cargaImagen.ShowDialog() == DialogResult.OK)
            {
                pctFoto.ImageLocation = cargaImagen.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Salir del fromulario?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }

        private bool NombreRepetido(string nombre)
        {
            bool repetido = false;
            List<Productos> productos = new List<Productos>();
            productos = Administrador.BuscarProducto(ConexionBD.Conexion, "Select * from producto");
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Nombre == nombre)
                {
                    repetido = true;
                }
            }
            return repetido;
        }
    }
}
