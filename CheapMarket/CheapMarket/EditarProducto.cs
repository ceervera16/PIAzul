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
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
            txtNombre.Visible = false;
            txtPrecio.Visible = false;
            txtInformacionNutritiva.Visible = false;
            txtDescripcion.Visible = false;
            txtCategoria.Visible = false;
            lblCategoria.Visible = false;
            lblDescripcion.Visible = false;
            lblInformacionNutritiva.Visible = false;
            lblNombre.Visible = false;
            lblPrecio.Visible = false;
            btnVolver.Visible = false;
            btnEliminar.Visible = false;
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool ok = false;
            int codigo;
            string consulta;
            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
                ok = true;
            }
            catch (Exception)
            {

                throw;
            }

            if (ok)
            {
                consulta = String.Format("Select Nombre,Precio,Descripcion,Categoria,InformacionNutritiva FROM productos WHERE codigo='{0}'", codigo);
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtNombre.Text = reader.GetString(0);
                        txtPrecio.Text = Convert.ToString(reader.GetDouble(1));
                        txtDescripcion.Text = reader.GetString(2);
                        txtCategoria.Text = reader.GetString(3);
                        txtInformacionNutritiva.Text = reader.GetString(4);
                    }
                    txtCodigo.Visible = false;
                    lblCodigo.Visible = false;
                    txtNombre.Visible = true;
                    txtPrecio.Visible = true;
                    txtInformacionNutritiva.Visible = true;
                    txtDescripcion.Visible = true;
                    txtCategoria.Visible = true;
                    lblCategoria.Visible = true;
                    lblDescripcion.Visible = true;
                    lblInformacionNutritiva.Visible = true;
                    lblNombre.Visible = true;
                    lblPrecio.Visible = true;
                    btnVolver.Visible = true;
                    btnEliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Código no válido");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            int exito;
            DialogResult respuesta = MessageBox.Show("Modificar producto?", "Modificar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                exito = admin.EditarProducto(ConexionBD.Conexion, Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToDouble(txtPrecio.Text), txtDescripcion.Text, txtCategoria.Text, txtInformacionNutritiva.Text);
                if (exito > 0)
                {
                    MessageBox.Show("El producto ha sido modificado con éxito");
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el producto");
                }
            }

            txtCategoria.Clear();
            txtDescripcion.Clear();
            txtInformacionNutritiva.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtDescripcion.Clear();
            txtInformacionNutritiva.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCodigo.Clear();

            txtCategoria.Visible = false;
            txtDescripcion.Visible = false;
            txtInformacionNutritiva.Visible = false;
            txtNombre.Visible = false;
            txtPrecio.Visible = false;
            txtCodigo.Visible = true;
            lblCategoria.Visible = false;
            lblDescripcion.Visible = false;
            lblInformacionNutritiva.Visible = false;
            lblNombre.Visible = false;
            lblPrecio.Visible = false;
            lblCodigo.Visible = true;
        }
    }
}
