using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapMarket
{
    class Productos
    {
        //ATRIBUTOS
        private int codigo;
        private string nombre;
        private double precio;
        private string descripcion;
        private string categoria;
        private string info;
        private Image foto;

        //PROPIEDADES
        public int Codigo { get {return codigo; } set { codigo = value; } }
        public string Nombre { get {return nombre; } set { nombre = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public string Info { get { return info; } set { info = value; } }
        public Image Foto { get { return foto; } set { foto = value; } }
    }
}
