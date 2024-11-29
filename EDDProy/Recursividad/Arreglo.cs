using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad
{
    public class SumaArreglos
    {
        public double SumaArreglo(double[] arreglo, out int numOperaciones)
        {
            numOperaciones = 0;
            return SumarArreglo(arreglo, ref numOperaciones);
        }

        public double SumarArreglo(double[] arreglo, ref int numOperaciones)
        {
            numOperaciones++;

            // Caso base: Si el arreglo está vacío, la suma es 0
            if (arreglo.Length == 0)
            {
                return 0;
            }

            // Caso recursivo: Sumar el primer elemento con la suma del resto del arreglo
            return arreglo[0] + SumarArreglo(SubArray(arreglo, 1), ref numOperaciones);
        }

        public double[] SubArray(double[] arreglo, int start)
        {
            // Crear un subarreglo a partir del índice especificado
            double[] result = new double[arreglo.Length - start];
            Array.Copy(arreglo, start, result, 0, result.Length);
            return result;
        }
    }
}
