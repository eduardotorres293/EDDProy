using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    // Clase nodo doble usada en listas dobles y listas circulares dobles, usando anterior como un nuevo objeto
    public class NodoDoble
    {
        public string Valor;
        public NodoDoble sig;
        public NodoDoble ant;
        public NodoDoble(string valor)
        {
            Valor = valor;
            sig = null;
            ant = null;
        }
    }
}
