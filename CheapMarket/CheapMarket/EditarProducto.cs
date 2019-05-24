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
        ConexionBD conexion = new ConexionBD();
        int codigo;
        public EditarProducto()
        {
            InitializeComponent();
            ControlesInicio();

            if (ConexionBD.AbrirConexion())
            {
                List<Productos> productos = new List<Productos>();
                string consulta = string.Format("SELECT Codigo,Nombre,Precio,Categoria,Descripcion,Informacion FROM producto;");
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
                    consulta = String.Format("Select * FROM producto WHERE Codigo='{0}';", codigo);
                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtNombre.Text = reader.GetString(1);
                            txtPrecio.Text = Convert.ToString(reader.GetDouble(2));
                            cmbCategoria.Text = reader.GetString(3);
                            txtDescripcion.Text = reader.GetString(4);
                            try
                            {
                                txtInformacionNutritiva.Text = reader.GetString(5);
                            }
                            catch (Exception)
                            {

                                
                            }
                            
                        }

                        ControlesEditar();
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
            int res;
            DialogResult respuesta = MessageBox.Show("Modificar producto?", "Modificar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                if (ConexionBD.AbrirConexion())
                {
                    if (!NombreRepetido(txtNombre.Text))
                    {
                        if (txtInformacionNutritiva.Text == "" || txtInformacionNutritiva.Text == null)
                        {
                            res = admin.EditarProducto(ConexionBD.Conexion, codigo, txtNombre.Text, Convert.ToDouble(txtPrecio.Text), txtDescripcion.Text, cmbCategoria.Text);
                        }
                        else
                        {
                            res = admin.EditarProducto(ConexionBD.Conexion, codigo, txtNombre.Text, Convert.ToDouble(txtPrecio.Text), txtDescripcion.Text, cmbCategoria.Text, txtInformacionNutritiva.Text);
                            MessageBox.Show("El producto ha sido modificado con éxito");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya hay un producto en la base de datos con este nombre, introduce otro");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la base de datos");
                }
                ConexionBD.CerrarConexion();
            }

            cmbCategoria.Text = "";
            txtDescripcion.Clear();
            txtInformacionNutritiva.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlesInicio();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                if (cmbFiltrar.Text != "")
                {
                    List<Productos> productos = new List<Productos>();
                    string consulta = string.Format("Select * from producto WHERE categoria like '{0}';", cmbFiltrar.Text);
                    productos = Administrador.BuscarProducto(ConexionBD.Conexion, consulta);
                    dtgProductos.DataSource = productos;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna categoría");
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

        }

        private void btnEliminarFiltros_Click_1(object sender, EventArgs e)
        {
            if (ConexionBD.AbrirConexion())
            {
                List<Productos> productos = new List<Productos>();
                string consulta = string.Format("Select * from producto;");
                productos = Administrador.BuscarProducto(ConexionBD.Conexion, consulta);
                dtgProductos.DataSource = productos;
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la base de datos");
            }
            ConexionBD.CerrarConexion();
        }

        private void ControlesInicio()
        {
            cmbCategoria.Text = "";
            txtDescripcion.Clear();
            txtInformacionNutritiva.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCodigo.Clear();
            txtCodigo.Visible = true;
            txtNombre.Visible = false;
            txtPrecio.Visible = false;
            txtInformacionNutritiva.Visible = false;
            txtDescripcion.Visible = false;
            cmbCategoria.Visible = false;
            lblCodigo.Visible = true;
            lblCategoria.Visible = false;
            lblDescripcion.Visible = false;
            lblInformacionNutritiva.Visible = false;
            lblNombre.Visible = false;
            lblPrecio.Visible = false;
            btnVolver.Visible = false;
            btnEliminar.Visible = false;
            btnBuscar.Visible = true;
            dtgProductos.Visible = true;
        }

        private void ControlesEditar()
        {
            txtCodigo.Visible = false;
            lblCodigo.Visible = false;
            txtNombre.Visible = true;
            txtPrecio.Visible = true;
            txtInformacionNutritiva.Visible = true;
            txtDescripcion.Visible = true;
            cmbCategoria.Visible = true;
            lblCategoria.Visible = true;
            lblDescripcion.Visible = true;
            lblInformacionNutritiva.Visible = true;
            lblNombre.Visible = true;
            lblPrecio.Visible = true;
            btnVolver.Visible = true;
            btnEliminar.Visible = true;
            btnBuscar.Visible = false;
            dtgProductos.Visible = false;
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
            for (int i = 0; i < productos.Count-1; i++)
            {
                if (productos[i].Nombre == nombre)
                {
                    return true;
                }
            }
            return repetido;
        }
    }
}
