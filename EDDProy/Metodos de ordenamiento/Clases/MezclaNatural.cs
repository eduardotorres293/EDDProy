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
            Listas mergedList = new Listas();
            Nodo actual1 = lista1.inicio;
            Nodo actual2 = lista2.inicio;

            while (actual1 != null && actual2 != null)
            {
                if (string.Compare(actual1.Valor, actual2.Valor) <= 0)
                {
                    mergedList.InsertBase(actual1.Valor); // Insertamos el valor de la primera lista
                    actual1 = actual1.sig;
                }
                else
                {
                    mergedList.InsertBase(actual2.Valor); // Insertamos el valor de la segunda lista
                    actual2 = actual2.sig;
                }
            }

            // Si alguna lista tiene elementos restantes, los agregamos
            while (actual1 != null)
            {
                mergedList.InsertBase(actual1.Valor);
                actual1 = actual1.sig;
            }

            while (actual2 != null)
            {
                mergedList.InsertBase(actual2.Valor);
                actual2 = actual2.sig;
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
                if (string.Compare(actual.sig.Valor, actual.Valor) >= 0)
                {
                    // La subsecuencia sigue siendo ordenada, añadimos el siguiente valor.
                    subsecuencia.InsertBase(actual.sig.Valor);
                }
                else
                {
                    // Fin de la subsecuencia, la guardamos y comenzamos una nueva.
                    runs.Add(subsecuencia);
                    subsecuencia = new Listas();
                    subsecuencia.InsertBase(actual.sig.Valor);
                }
                actual = actual.sig;
            }
            runs.Add(subsecuencia);  // Añadimos la última subsecuencia.
            return runs;
        }

        public static Listas FuncionMezclaNatural(Listas list)
        {
            List<Listas> subsecuencias = IdentificarRuns(list);  // Obtener todas las subsecuencias ordenadas.

            while (subsecuencias.Count > 1)
            {
                Listas mergedList = Mezclar(subsecuencias[0], subsecuencias[1]);  // Fusionamos las dos primeras subsecuencias.
                subsecuencias.RemoveAt(0);  // Eliminamos las subsecuencias fusionadas.
                subsecuencias.RemoveAt(0);
                subsecuencias.Insert(0, mergedList);  // Insertamos la lista fusionada al principio de la lista de subsecuencias.
            }

            return subsecuencias[0];  // La lista ordenada final.
        }
    }
}
