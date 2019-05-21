using System;
using System.Collections.Generic;
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


        //PROPIEDADES
        public int Codigo { get {return codigo; } set { value=codigo; } }
        public string Nombre { get {return nombre; } set { value = nombre; } }
        public double Precio { get { return precio; } set { value = precio; } }
        public string Descripcion { get { return nombre; } set { value = nombre; } }
        public string Categoria { get { return categoria; } set { value = categoria; } }
        public string Info { get { return info; } set { value = info; } }

        //CONSTRUCTOR
        public Productos() { }
        public Productos(int codigo, string nombre, double precio, string descripcion, string categoria, string info)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.info = info;
        }

    }
}
