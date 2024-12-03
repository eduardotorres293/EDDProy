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
        // Función para realizar el merge sort
        public static Listas FuncionMezclaDirecta(Listas lista)
        {
            // Caso base: si la lista tiene 0 o 1 elemento, ya está ordenada
            if (lista.tamaño <= 1)
            {
                return lista;
            }

            // Dividir la lista en dos mitades
            Listas izquierda = new Listas();
            Listas derecha = new Listas();

            // Rellenamos las dos sublistas
            DividirLista(lista, izquierda, derecha);

            // Ordenamos recursivamente las dos sublistas
            izquierda = FuncionMezclaDirecta(izquierda);
            derecha = FuncionMezclaDirecta(derecha);

            // Fusionamos las dos sublistas ordenadas
            return Mezclar(izquierda, derecha);
        }

        // Función para dividir la lista en dos mitades
        private static void DividirLista(Listas lista, Listas izquierda, Listas derecha)
        {
            int mitad = lista.tamaño / 2;
            Nodo actual = lista.inicio;
            int contador = 1;

            // Dividimos los nodos en la lista de la izquierda
            while (contador <= mitad)
            {
                izquierda.InsertBase(actual.Valor);
                actual = actual.sig;
                contador++;
            }

            // Dividimos los nodos restantes en la lista de la derecha
            while (actual != null)
            {
                derecha.InsertBase(actual.Valor);
                actual = actual.sig;
            }
        }

        // Función para fusionar dos listas ordenadas
        private static Listas Mezclar(Listas izquierda, Listas derecha)
        {
            Listas listaOrdenada = new Listas();
            Nodo nodoIzq = izquierda.inicio;
            Nodo nodoDer = derecha.inicio;

            // Fusionamos las listas ordenadas
            while (nodoIzq != null && nodoDer != null)
            {
                if (string.Compare(nodoIzq.Valor, nodoDer.Valor) < 0)
                {
                    listaOrdenada.InsertBase(nodoIzq.Valor);
                    nodoIzq = nodoIzq.sig;
                }
                else
                {
                    listaOrdenada.InsertBase(nodoDer.Valor);
                    nodoDer = nodoDer.sig;
                }
            }

            // Si quedan elementos en la lista izquierda, los agregamos
            while (nodoIzq != null)
            {
                listaOrdenada.InsertBase(nodoIzq.Valor);
                nodoIzq = nodoIzq.sig;
            }

            // Si quedan elementos en la lista derecha, los agregamos
            while (nodoDer != null)
            {
                listaOrdenada.InsertBase(nodoDer.Valor);
                nodoDer = nodoDer.sig;
            }

            return listaOrdenada;
        }
    }
}
