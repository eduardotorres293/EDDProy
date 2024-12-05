using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class MezclaDirecta
    {
        public static Listas FuncionMezclaDirecta(Listas lista)
        {
            // Caso base: si la lista tiene 0 o 1 elemento, ya está ordenada
            if (lista.tamaño <= 1)
            {
                return lista;
            }

            // Se divide la lista en dos mitades, izquierda y derecha
            Listas izquierda = new Listas();
            Listas derecha = new Listas();

            // Se llama a la funcion DividirLista para dividir la lista en dos partes
            DividirLista(lista, izquierda, derecha);

            // Las dos sublistas son ordenadas recursivamente
            izquierda = FuncionMezclaDirecta(izquierda);
            derecha = FuncionMezclaDirecta(derecha);

            // Y se vuelven a mezclar las dos sublistas, ya ordenadas
            return Mezclar(izquierda, derecha);
        }

        // Esta funcion divide la lista dada por dos sublistas, una izquierda y otra derecha
        private static void DividirLista(Listas lista, Listas izquierda, Listas derecha)
        {
            // Se calcula el punto medio de la lista al dividirlo entre 2
            int mitad = lista.tamaño / 2;
            Nodo actual = lista.inicio; // Se empieza desde el primer nodo
            int contador = 1;

            // Se dividen las primeras mitades a la lista izquierda
            while (contador <= mitad)
            {
                izquierda.InsertBase(actual.Valor); // Se inserta el valor del nodo actual
                actual = actual.sig; // Y se avanza al siguiente nodo
                contador++;
            }

            // Los restantes se insertan en la lista derecha
            while (actual != null)
            {
                derecha.InsertBase(actual.Valor); // Aquí tambien se inserta el valor del nodo actual
                actual = actual.sig; // Y se avanza al siguiente
            }
        }

        // Esta funcion es la que permite la mezcla entre los dos elementos
        // haciendólo de vuelta a una lista ordenada
        private static Listas Mezclar(Listas izquierda, Listas derecha)
        {
            Listas listaOrdenada = new Listas(); // Esta lista es la que tendrá los valores mezclados
            Nodo nodoIzq = izquierda.inicio; // Se usa el primer nodo izquierdo
            Nodo nodoDer = derecha.inicio; // Se usa el primer nodo derecho

            // Mientras ambas listas tengan elementos por procesar se hace un while
            while (nodoIzq != null && nodoDer != null)
            {
                // Primero se comparan los valores de los nodos actuales en ambas listas
                if (string.Compare(nodoIzq.Valor, nodoDer.Valor) < 0)
                {
                    // Se inserta el valor en la base
                    listaOrdenada.InsertBase(nodoIzq.Valor);
                    // Y luego se avanza al siguiente nodo
                    nodoIzq = nodoIzq.sig;
                }
                else
                {
                    // Se inserta el valor en la base
                    listaOrdenada.InsertBase(nodoDer.Valor);
                    // Se avanza al siguiente nodo
                    nodoDer = nodoDer.sig;
                }
            }

            // Si quedan elementos en la lista izquierda se agregan en la lista ordenada
            while (nodoIzq != null)
            {
                listaOrdenada.InsertBase(nodoIzq.Valor); // Se inserta el valor en la lista ordenada
                nodoIzq = nodoIzq.sig; // Se avanza al siguiente nodo
            }

            // Si quedan elementos en la lista derecha se agregan
            while (nodoDer != null)
            {
                listaOrdenada.InsertBase(nodoDer.Valor); // Se inserta el valor en la lista ordenada
                nodoDer = nodoDer.sig; // Se avanza al siguiente nodo
            }

            return listaOrdenada; // Como paso final se regresa completa la lista ordenada
        }
    }
}
