using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class MezclaNatural
    {
        public static Listas Mezclar(Listas lista1, Listas lista2)
        {
            Listas mergedList = new Listas(); // Se crea una nueva lista la cual tendrá los elementos ordenados
            Nodo actual1 = lista1.inicio; // Se inicializan los nodos iniciales de las dos listas
            Nodo actual2 = lista2.inicio;

            while (actual1 != null && actual2 != null)
            {
                // Se comparan los valores de los nodos
                if (int.Parse(actual1.Valor) <= int.Parse(actual2.Valor))
                {
                    mergedList.InsertBase(actual1.Valor);  // Se inserta el valor de la primera lista
                    actual1 = actual1.sig; // Se avanza al siguiente nodo
                }
                else
                {
                    mergedList.InsertBase(actual2.Valor);  // Se inserta el valor de la segunda lista
                    actual2 = actual2.sig; // Se avanza al siguiente nodo
                }
            }

            // Si alguna lista tiene elementos restantes, los agregamos
            while (actual1 != null)
            {
                mergedList.InsertBase(actual1.Valor); // Se inserta el valor en la base de la lista 1
                actual1 = actual1.sig; // Se avanza al siguiente nodo
            }

            while (actual2 != null)
            {
                mergedList.InsertBase(actual2.Valor); // Se inserta el valor en la base de la lista 2
                actual2 = actual2.sig; // SE avanza al siguiente nodo
            }

            return mergedList;
        }

        public static List<Listas> IdentificarRuns(Listas list)
        {
            List<Listas> runs = new List<Listas>();  // Lista para almacenar todas las subsecuencias ordenadas.
            if (list.estaVacio()) return runs;

            Nodo actual = list.inicio;
            Listas subsecuencia = new Listas();
            subsecuencia.InsertBase(actual.Valor);  // Comienza una nueva subsecuencia ordenada.

            while (actual.sig != null)
            {
                if (int.Parse(actual.sig.Valor) >= int.Parse(actual.Valor))
                {
                    // La subsecuencia sigue siendo ordenada, añadiendose el siguiente valor.
                    subsecuencia.InsertBase(actual.sig.Valor);
                }
                else
                {
                    // Fin de la subsecuencia, se guarda y empieza una nueva.
                    runs.Add(subsecuencia);
                    subsecuencia = new Listas();
                    subsecuencia.InsertBase(actual.sig.Valor);
                }
                actual = actual.sig;
            }
            runs.Add(subsecuencia);  // Se añade la última subsecuencia.
            return runs;
        }

        public static Listas FuncionMezclaNatural(Listas list)
        {
            if (list.inicio == null || list.inicio.sig == null)
            {
                return list;  // Ya está ordenada
            }

            List<Listas> subsecuencias = IdentificarRuns(list);  // Obtener todas las subsecuencias ordenadas.

            while (subsecuencias.Count > 1)
            {
                Listas mergedList = Mezclar(subsecuencias[0], subsecuencias[1]);  // Se mezclan las dos primeras subsecuencias.
                subsecuencias.RemoveAt(0);  // Se eliminan las subsecuencias fusionadas.
                subsecuencias.RemoveAt(0);
                subsecuencias.Insert(0, mergedList);  // Se inserta la lista fusionada al principio de la lista de subsecuencias.
            }

            return subsecuencias[0];  // La lista ordenada final.
        }
    }
}
