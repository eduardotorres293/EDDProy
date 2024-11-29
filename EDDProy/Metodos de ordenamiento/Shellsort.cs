using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class Shellsort
    {
        static void ShellSort(int[] intArreglo)
        {
            int MAX = intArreglo.Length;
            int intervalo, i, valorAInsertar, posicionActual;

            for (intervalo = MAX / 2; intervalo > 0; intervalo /= 2)
            {
                for (i = intervalo; i < MAX; i++)
                {
                    valorAInsertar = intArreglo[i];
                    posicionActual = i;

                    while (posicionActual >= intervalo && intArreglo[posicionActual - intervalo] > valorAInsertar)
                    {
                        intArreglo[posicionActual] = intArreglo[posicionActual - intervalo];

                        posicionActual -= intervalo;
                    }
                    if (posicionActual != i)
                    {
                        intArreglo[posicionActual] = valorAInsertar;
                    }
                }
            }
        }
    }
}
