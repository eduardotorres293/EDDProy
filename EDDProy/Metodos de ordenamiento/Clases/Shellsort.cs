using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class Shellsort
    {
        public static void FuncionShellSort(Listas lista)
        {
            Nodo actual = lista.inicio; // Este nodo señala el inicio de la lista
            int tamaño = lista.Total(); // Se obtiene el tamaño total de la lista
            int[] valores = new int[tamaño]; // Se crea un arreglo de enteros con el tamaño de la lista
            int index = 0; // Se inicia el indice en 0

            // Se extraen los valores y se almacenan en un arreglo
            while (actual != null)
            {
                if (int.TryParse(actual.Valor, out int valor))
                {
                    valores[index++] = valor;
                }
                actual = actual.sig; // Se avanza al siguiente nodo de la lista
            }

            // Se aplica el algoritmo shell sort al arreglo de enteros
            int gap = tamaño / 2;
            while (gap > 0)
            {
                // Se realiza la ordenación con el gap actual
                for (int i = gap; i < tamaño; i++)
                {
                    // Se guarda el valor actual que se va a insertar
                    int temp = valores[i];
                    int j = i;

                    // Se realiza un intercambio y comparación
                    while (j >= gap && valores[j - gap] > temp)
                    {
                        valores[j] = valores[j - gap]; // Se mueven los elementos a la derecha
                        j -= gap; // Se vanaza el indice j hacia la izquierda
                    }
                    // Se coloca el valor en la posición
                    valores[j] = temp;
                }

                gap /= 2; // Se reduce el tamaño del gap al dividirse entre dos en cada pasada
            }
            // Se vuelven a colocar los valores ordenados de vuelta en la lista enlazada
            actual = lista.inicio;
            foreach (int valor in valores)
            {
                if (actual != null)
                {
                    actual.Valor = valor.ToString();
                    actual = actual.sig;
                }
            }
        }
    }
}
