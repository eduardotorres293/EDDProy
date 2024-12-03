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
            int n = a.Length;

            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            for (int pos = 1; max / pos > 0; pos *= 10)
            {
                CountSort(a, n, pos);
            }
        }

        private static void CountSort(int[] a, int n, int pos)
        {
            int[] count = new int[10];
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                count[(a[i] / pos) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(a[i] / pos) % 10] - 1] = a[i];
                count[(a[i] / pos) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                a[i] = output[i];
            }
        }
    }
}
