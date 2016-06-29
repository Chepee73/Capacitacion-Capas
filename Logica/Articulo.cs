using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Articulo
    {
        // Metodos

        /// <summary>
        /// Metodo que agrega un articulo a la lista
        /// Autor: Cezar
        /// Fecha: 29/06/2016
        /// </summary>
        /// <param name="pArticulo">Articulo que se quiere agregar a la lista</param>
        /// <param name="pListaArticulos">Lista a la que se le agrega el articulo</param>
        public static void Agregar(Entidades.Articulo pArticulo, List<Entidades.Articulo> pListaArticulos)
        {
            pListaArticulos.Add(pArticulo);
        }

        /// <summary>
        /// Metodo que devuelve la cantidad de elemento que hay en una lista de articulos
        /// Autor: Cezar
        /// Fecha: 29/06/2016
        /// </summary>
        /// <param name="pListaArticulos">Lista de articulos</param>
        /// <returns></returns>
        public static int Cantidad(List<Entidades.Articulo> pListaArticulos)
        {
            int count;

            count = pListaArticulos.Count;

            return count;
        } 

        /// <summary>
        /// Metodo que devuelve el promedio de precios entre todos los articulos de una lista
        /// Autor: Cezar
        /// Fecha: 29/06/2016
        /// </summary>
        /// <param name="pListaArticulos">Lista de articulos</param>
        /// <returns></returns>

        public static double CalcularPromedio(List<Entidades.Articulo> pListaArticulos)
        {
            double promedio = 0;

            foreach(var articulo in pListaArticulos)
            {
                promedio += articulo.Precio;
            }
            promedio /= Cantidad(pListaArticulos);

            return promedio;
        }
        /// <summary>
        /// Este metodo devuelve una lista que contiene los articulos cuyo precio es mayor al promedio
        /// </summary>
        /// <param name="pListaArticulos">Lista de articulos</param>
        /// <returns>Lista de articulos con un precio mayor al promedio</returns>
        public static List<Entidades.Articulo> GetMayoresPromedio(List<Entidades.Articulo> pListaArticulos)
        {
            List<Entidades.Articulo> tempListaArticulos = new List<Entidades.Articulo>();
            double promedio = CalcularPromedio(pListaArticulos);

            foreach(var articulo in pListaArticulos)
            {
                if(articulo.Precio > promedio)
                {
                    tempListaArticulos.Add(articulo);
                }
            }
            return tempListaArticulos;
        }
    }
}
