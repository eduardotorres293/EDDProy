using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_busqueda.Clases
{
    public class BusquedaBinaria
    {
        // Esta función binaria no es recursiva, por lo que utilizo whiles e if. Para su versión recursiva
        // está el formulario Binario
        public static int FuncionBinaria(int[] arreglo, int elemento)
        {
            // Se definen dos punteros, izquierda y derecha, que indican los límites del subarreglo a buscar
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            // Mientras el rango de búsqueda no se haya reducido a un solo elemento
            while (izquierda <= derecha)
            {
                // Se calcula el indice del elemento central del subarreglo
                int medio = (izquierda + derecha) / 2;

                // Si se encuentra el elemento en el centro, se retorna el índice
                if (arreglo[medio] == elemento)
                {
                    return medio; // El índice es devuelto
                }
                // Si el elemento es mayor que el valor del centro, se busca en la mitad derecha
                else if (arreglo[medio] < elemento)
                {
                    // Se modifica el límite izquierdo para buscar en la derecha
                    izquierda = medio + 1;
                }
                // Si en cambio es menor, se busca en la mitad izquierda
                else
                {
                    // Se modifica el límite derecho para buscar en la izquierda
                    derecha = medio - 1;
                }
            }
            // Si el elemento no se encuentra en el arreglo, devolvemos -1, que significa que no se encontró el elemento
            return -1;
        }
    }
}
