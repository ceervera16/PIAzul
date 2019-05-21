using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CheapMarket
{
    public partial class AñadirProducto : Form
    {
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

            if (txtCategoria.Text == "")
            {
                errorProvider1.SetError(txtCategoria, "Este campo es obligatório");
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
            if (ConexionBD.AbrirConexion())
            {
                if (comprobarVacios())
                {
                    DialogResult respuesta = MessageBox.Show("Insertar producto?", "Insertar", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = false;
                        Administrador admin = new Administrador();
                        Productos prod = new Productos();
                        List<int> lista = new List<int>();
                        int exito;

                        prod.Nombre = txtNombre.Text;
                        try
                        {
                            prod.Precio = Convert.ToDouble(txtPrecio.Text);
                            ok = true;
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        prod.Categoria = txtCategoria.Text;
                        prod.Descripcion = txtDescripcion.Text;
                        prod.Info = txtInformacionNutritiva.Text;

                        if (ok)
                        {
                            MySqlCommand commando = new MySqlCommand("SELECT Codigo FROM productos", ConexionBD.Conexion);
                            MySqlDataReader reader = commando.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    lista.Add(reader.GetInt32(0));
                                }
                            }

                            prod.Codigo = lista[lista.Count - 1] + 1;

                            exito = admin.AgregarProducto(ConexionBD.Conexion, prod);
                            if (exito > 0)
                            {
                                MessageBox.Show("Producto insertado");
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido insertar el producto");
                            }
                            txtNombre.Clear();
                            txtCategoria.Clear();
                            txtDescripcion.Clear();
                            txtDescripcion.Clear();
                            txtPrecio.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Precio no valido");
                        }
                    }
                }
                ConexionBD.CerrarConexion();
            }
        }
    }
}
