using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class Intercalacion
    {
        
        public Listas IntercalarListas(Listas lista1, Listas lista2)
        {
            Listas listaIntercalada = new Listas();
            Nodo nodo1 = lista1.inicio;
            Nodo nodo2 = lista2.inicio;

            while (nodo1 != null && nodo2 != null)
            {
                if (int.Parse(nodo1.Valor) < int.Parse(nodo2.Valor))
                {
                    listaIntercalada.InsertBase(nodo1.Valor); // Insertamos en la base de la lista intercalada
                    nodo1 = nodo1.sig;
                }
                else
                {
                    listaIntercalada.InsertBase(nodo2.Valor);
                    nodo2 = nodo2.sig;
                }
            }
            while (nodo1 != null)
            {
                listaIntercalada.InsertBase(nodo1.Valor);
                nodo1 = nodo1.sig;
            }
            while (nodo2 != null)
            {
                listaIntercalada.InsertBase(nodo2.Valor);
                nodo2 = nodo2.sig;
            }

            return listaIntercalada;
        }
    }
}
