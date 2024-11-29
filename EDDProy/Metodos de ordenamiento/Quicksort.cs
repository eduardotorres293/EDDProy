using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class Quicksort
    {
        static void quicksort(int[] A, int inf, int sup)
        {
            if (inf >= sup)
                return;

            int i = inf;
            int j = sup;
            int x = A[(inf + sup) / 2]; // Elemento pivote

            while (i <= j)
            {
                // Buscar un elemento en la izquierda que sea mayor que el pivote
                while (A[i] < x)
                    i++;

                // Buscar un elemento en la derecha que sea menor que el pivote
                while (A[j] > x)
                    j--;

                // Si los índices no se han cruzado, intercambiar los elementos
                if (i <= j)
                {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;
                    j--;
                }
            }

            // Llamadas recursivas para ordenar las sublistas
            if (inf < j)
            {
                quicksort(A, inf, j);
            }
            if (i < sup)
            {
                quicksort(A, i, sup);
            }
        }

    }
}
