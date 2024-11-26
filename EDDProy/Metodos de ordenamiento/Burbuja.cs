using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class Burbuja
    {
        // Método de ordenamiento burbuja optimizado
        static void OrdenamientoBurbujaCorto(int[] lista)
        {
            int n = lista.Length;
            bool intercambios;
            int numPasada = n - 1;

            // Mientras haya pasadas por realizar y se haya hecho al menos un intercambio
            while (numPasada > 0)
            {
                intercambios = false;

                // Realizamos las comparaciones
                for (int i = 0; i < numPasada; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        // Realizar el intercambio
                        int temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;

                        // Indicar que se hizo un intercambio
                        intercambios = true;
                    }
                }

                // Reducir la cantidad de elementos a verificar (los últimos ya están ordenados)
                numPasada--;

                // Si no se hicieron intercambios, el arreglo ya está ordenado
                if (!intercambios)
                    break;
            }
        }
    }
}
