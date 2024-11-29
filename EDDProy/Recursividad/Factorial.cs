using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad
{
    public class Factorial
    {
        public long factorial(int n, out int numOperaciones)
        {
            numOperaciones = 0;
            return funcionFactorial(n, ref numOperaciones);
        }

        private long funcionFactorial(int n, ref int numOperaciones)
        {
            numOperaciones++;

            // Caso base: Si n es 0 o 1, el factorial es 1
            if (n == 0 || n == 1)
            {
                return 1;
            }

            // Caso recursivo: funcion el factorial de n-1 y multiplicar por n
            return n * funcionFactorial(n - 1, ref numOperaciones);
        }
    }
}
