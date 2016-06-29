using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo
    {
        private int codigo;
        private double precio;
        private string nombre;
        private int stock;


        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public Articulo() { }

        public Articulo(int pCodigo, string pNombre, double pPrecio, int pStock)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Precio = pPrecio;
            Stock = pStock;
        }
    }
}
