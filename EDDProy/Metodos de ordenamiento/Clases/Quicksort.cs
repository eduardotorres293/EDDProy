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
        // Aquí utilicé int[] (arreglo) para quicksort porque el codigo se iba a complicar si utilizaba las listas
        public static void FuncionQuicksort(int[] A, int inf, int sup)
        {
            // Si el indice inferior es mayor o igual al superior significa que ya está ordenado
            if (inf >= sup)
                return;

            int i = inf; // Se iniciliazan los indices para las particiones, siendo i
            int j = sup; // y j
            int x = A[(inf + sup) / 2]; // Esta es la elección del pivote, siendo el del medio del arreglo

            while (i <= j)
            {
                // Buscar un elemento en la izquierda que sea mayor que el pivote
                while (A[i] < x)
                    i++;

                // Buscar un elemento en la derecha que sea menor que el pivote
                while (A[j] > x)
                    j--;

                // Si los índices no se han cruzado, se intercambian los elementos
                if (i <= j)
                {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++; // Se aumenta i para que apunte al siguiente elemento
                    j--; // Y se reduce j para que apunte al anterior
                }
            }

            // Llamadas recursivas para ordenar las sublistas, siendo esta la sublista izquierda
            if (inf < j)
            {
                FuncionQuicksort(A, inf, j); // Va desde inf hasta j
            }
            // Y esta la sublista derecha
            if (i < sup)
            {
                FuncionQuicksort(A, i, sup); // Va desde i hasta sup
            }
        }

    }
}
