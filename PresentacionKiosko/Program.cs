using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionKiosko
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase articulo
            Entidades.Articulo[] objEntidadesArticulo = new Entidades.Articulo[3];

            // Mostrar en pantalla el valor de las propiedades
            string tempNombre;
            double tempPrecio;
            int tempCodigo;

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese nombre del articulo: ");
                tempNombre = Console.ReadLine();
                Console.Write("Ingrese el precio: ");
                tempPrecio = Convert.ToDouble(Console.ReadLine());
                tempCodigo = i + 1;
                objEntidadesArticulo[i] = new Entidades.Articulo(tempCodigo, tempNombre, tempPrecio, 0);
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nombre: {0}", objEntidadesArticulo[i].Nombre);
                Console.WriteLine("Precio: {0}", objEntidadesArticulo[i].Precio);
            }

            Console.ReadKey();
        }
    }
}
