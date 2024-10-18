using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales
{
    public class NodoBinario
    {
        public int Dato;
        public NodoBinario Izq;
        public NodoBinario Der;

        // Añadido constructor para el nodo, asi como  un objeto int Dato que permite
        // leer el dato de entrada
        // Estos cambios fueron vistos en clase
        public NodoBinario(int Dato)
        {
            this.Dato = Dato;
            this.Izq = null;
            this.Der = null;
        }
    }
}
