using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Articulo articulo1 = new Entidades.Articulo(1, "Alfajor", 10.00, 4);

            Entidades.Articulo articulo2 = new Entidades.Articulo(2, "Lays", 26.00, 4);

            Entidades.Articulo articulo3 = new Entidades.Articulo(3, "TicTac", 8.00, 4);

            Entidades.Articulo articulo4 = new Entidades.Articulo(4, "Gaseosa", 15.00, 4);

            List<Entidades.Articulo> listaArticulos = new List<Entidades.Articulo>();
            Logica.Articulo.Agregar(articulo1, listaArticulos);
            Logica.Articulo.Agregar(articulo2, listaArticulos);
            Logica.Articulo.Agregar(articulo3, listaArticulos);
            Logica.Articulo.Agregar(articulo4, listaArticulos);

            Console.WriteLine("Promedio: {0}", Logica.Articulo.CalcularPromedio(listaArticulos));

            Console.WriteLine("Articulos en la lista: ");
            foreach(var art in listaArticulos)
            {
                Console.WriteLine(art.Nombre);
            }
            Console.WriteLine("\nArticulos que superan el promedio: ");
            foreach(var art in Logica.Articulo.GetMayoresPromedio(listaArticulos))
            {
                Console.WriteLine(art.Nombre);
            }

            int opcion = 0;
            double tempPrecio;
            Console.Write("Ingrese codigo del producto: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            tempPrecio = Logica.Articulo.DevolverPrecio(opcion, listaArticulos);

            if (tempPrecio == -1)
                Console.WriteLine("No existe articulo con ese codigo.");
            else
                Console.WriteLine("El precio es: {0}", tempPrecio);

            Console.ReadKey();
        }
    }
}
