 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados.EjemploFiltrado
{
    public static class ListExtension
    {
        public static List<T> Filtrar<T>(this List<T> lista, DelegadoCriterio<T> criterioDeFiltrado)
        {
            List<T> listaFiltrada = new List<T>();

            foreach (T item in lista)
            {
                if (criterioDeFiltrado(item))
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

        // Usando Delegados Predefinidos // En este caso Predicate
        public static List<T> Filtrar<T>(this List<T> lista, Predicate<T> criterioDeFiltrado)
        {
            List<T> listaFiltrada = new List<T>();

            foreach (T item in lista)
            {
                if (criterioDeFiltrado(item))
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

        // Usando Delegados Predefinidos // En este caso Func
        public static List<T> Filtrar<T>(this List<T> lista, Func<T, bool> criterioDeFiltrado)
        {
            List<T> listaFiltrada = new List<T>();

            foreach (T item in lista)
            {
                if (criterioDeFiltrado(item))
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }
    }
}
