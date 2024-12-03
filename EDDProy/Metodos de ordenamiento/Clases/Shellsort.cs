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
            Nodo actual = lista.inicio;
            int tamaño = lista.Total();
            int[] valores = new int[tamaño];
            int index = 0;

            // Extraemos los valores de la lista enlazada y los almacenamos en el arreglo
            while (actual != null)
            {
                if (int.TryParse(actual.Valor, out int valor))
                {
                    valores[index++] = valor;
                }
                actual = actual.sig;
            }

            // Aplicamos el algoritmo Shell Sort al array de enteros
            int gap = tamaño / 2;
            while (gap > 0)
            {
                for (int i = gap; i < tamaño; i++)
                {
                    int temp = valores[i];
                    int j = i;

                    // Realizamos la comparación e intercambio con el gap
                    while (j >= gap && valores[j - gap] > temp)
                    {
                        valores[j] = valores[j - gap];
                        j -= gap;
                    }

                    valores[j] = temp;
                }

                gap /= 2; // Reducimos el tamaño del gap
            }
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
