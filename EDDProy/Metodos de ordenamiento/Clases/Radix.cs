using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class Radix
    {
        // Aquí tambien hice uso de arreglos en lugar de la lista para no dificultar el codigo
        public static void FuncionRadix(int[] a)
        {
            // Se obtiene la longitud del arreglo
            int n = a.Length;
            // Se encuentra el valor máximo del arreglo de acuerdo a su longitud
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i]; // Se actualiza el valor máximo encontrado
                }
            }

            // Se realiza un ciclo por cada posición del número
            for (int pos = 1; max / pos > 0; pos *= 10)
            {
                CountSort(a, n, pos); // Se llama la función countsort que permite ordenar con números especificos
            }
        }

        // Esta función permite ordenar con números especificos (como se dijo con anterioridad)
        private static void CountSort(int[] a, int n, int pos)
        {
            // Se inicia el conteo con 10, representando del 0 al 9
            int[] count = new int[10];
            int[] output = new int[n]; // Aquí se almacenan los numeros ordenados

            // Se cuenta cada digito extraido de pos
            for (int i = 0; i < n; i++)
            {
                count[(a[i] / pos) % 10]++; // Se extrae el digito en la posición pos
            }

            // Se modifica el arreglo de conteno para almacenar las posiciones acumuladas
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1]; // Se hace una suma para encontrar la posicion cada digito
            }

            // Se construye el arreglo ordenado utilizando el conteo del paso anterior
            // recorriendo el arreglo de derecha a izquierda para tener estabilidad
            for (int i = n - 1; i >= 0; i--)
            {
                // Se coloca el número en su posición final dentro del arreglo output (salida)
                output[count[(a[i] / pos) % 10] - 1] = a[i];
                count[(a[i] / pos) % 10]--; // Se reduce el contador para los siguientes conteos
            }
            // Se copian los valores ordenados de vuelta al arreglo original para poder ser mostrado
            for (int i = 0; i < n; i++)
            {
                a[i] = output[i];
            }
        }
    }
}
