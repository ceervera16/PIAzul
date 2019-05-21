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
            dtgProductos.Visible = true;

            if (ConexionBD.AbrirConexion())
            {
                List<Productos> productos = new List<Productos>();
                string consulta = string.Format("SELECT * FROM Productos");
                productos = Administrador.BuscarProducto(ConexionBD.Conexion, consulta);
                dtgProductos.DataSource = productos;
                ConexionBD.CerrarConexion();
            }
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                
                bool ok = true;
                int codigo;
                string consulta;
                if (dtgProductos.SelectedRows.Count == 1)
                {
                    codigo = (int)dtgProductos.CurrentRow.Cells[0].Value;
                }
                else
                {
                    try
                    {
                        codigo = Convert.ToInt32(txtCodigo.Text);
                    }
                    catch (Exception)
                    {
                        ok = false;
                        throw;
                    }
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
                        dtgProductos.Visible = false;
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
                ConexionBD.CerrarConexion();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            int exito;
            DialogResult respuesta = MessageBox.Show("Modificar producto?", "Modificar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                if (ConexionBD.AbrirConexion())
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
                ConexionBD.CerrarConexion();
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
            dtgProductos.Visible = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.Text != "")
            {
                List<Productos> productos = new List<Productos>();
                string consulta = string.Format("Select * from Productos WHERE categoria like '{0}'", cmbFiltrar.Text);
                productos = Administrador.BuscarProducto(ConexionBD.Conexion, consulta);
                dtgProductos.DataSource = productos;
            }
        }

        private void btnEliminarFiltros_Click(object sender, EventArgs e)
        {

        }
    }
}
