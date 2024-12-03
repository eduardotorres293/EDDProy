using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_busqueda.Clases
{
    public class BusquedaBinaria
    {
        public static int FuncionBinaria(int[] arreglo, int elemento)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (arreglo[medio] == elemento)
                {
                    return medio;
                }
                else if (arreglo[medio] < elemento)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            return -1;
        }
    }
}
