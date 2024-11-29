using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad
{
    public class Exponencial
    {
        public double Exponente(double x, int n, out int numOperaciones)
        {
            numOperaciones = 0;
            return funcionExpo(x, n, ref numOperaciones);
        }

        public double funcionExpo(double x, int n, ref int numOperaciones)
        {
            numOperaciones++;

            // Caso base: cualquier número elevado a la potencia 0 es 1
            if (n == 0)
            {
                return 1;
            }

            // Si el exponente es par, utilizamos el algoritmo de exponenciación rápida
            else if (n % 2 == 0)
            {
                double half = funcionExpo(x, n / 2, ref numOperaciones);
                return half * half;
            }
            // Si el exponente es impar, hacemos la multiplicación por x
            else
            {
                return x * funcionExpo(x, n - 1, ref numOperaciones);
            }
        }
    }
}
