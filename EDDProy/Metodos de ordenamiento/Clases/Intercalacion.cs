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
        public Listas FuncionIntercalacion(Listas lista1, Listas lista2)
        {
            // Se crea una nueva lista que será donde se almacenará la lista ya intercalada
            Listas listaIntercalada = new Listas();
            Nodo nodo1 = lista1.inicio; // Se usa el primer nodo de la lista 1
            Nodo nodo2 = lista2.inicio; // Se usa el primer nodo de la lista 2

            // Mientras ambos nodos no sean nulos, se comparan los valores
            while (nodo1 != null && nodo2 != null)
            {
                if (int.Parse(nodo1.Valor) < int.Parse(nodo2.Valor))
                {
                    listaIntercalada.InsertBase(nodo1.Valor); // Se inserta en la base de la lista intercalada
                    nodo1 = nodo1.sig; // Se mueve al siguiente nodo de la lista 1
                }
                else
                {
                    // Si el valor del nodo 2 es menor o igual se inserta el nodo de la segunda lista en la lista final
                    listaIntercalada.InsertBase(nodo2.Valor); // Se inserta el valor en la base
                    nodo2 = nodo2.sig; // Se mueve al siguiente nodo de la lista 1
                }
            }
            // Si aún quedan elementos en la lista 1, se insertarán todos en la lista intercalada (sin importar que no haya orden)
            while (nodo1 != null)
            {
                // Se inserta el valor del nodo 1 en la lista intercalada
                listaIntercalada.InsertBase(nodo1.Valor);
                nodo1 = nodo1.sig; // Se mueve al siguiente valor
            }
            // Lo mismo, si hay algún elemento sobrante en la lista 2, se insertará el resto
            while (nodo2 != null)
            {
                // Se inserta el valor del nodo 2 en la lista intercalada
                listaIntercalada.InsertBase(nodo2.Valor);
                nodo2 = nodo2.sig; // Se mueve al siguiente valor
            }
            // Se regresa la lista ya intercalada y ordenada
            return listaIntercalada;
        }
    }
}
