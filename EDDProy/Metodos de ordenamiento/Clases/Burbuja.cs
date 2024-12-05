using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class Burbuja
    {
        public static void FuncionBurbuja(Listas lista)
        {
            // Primero se verifica que la lista no este vacia
            if (lista.estaVacio())
                return;

            // Esto sirve como comprobacion de si hubo algún intercambio en la pasada
            // (pasada se refiere a la rutina hecha por el código)
            bool intercambios;
            Nodo numPasada = lista.inicio; // Se crea un nodo que marca el inicio de cada pasada (rutina)

            // Mientras haya nodos por comparar se realiza un while
            while (numPasada != null && numPasada.sig != null)
            {
                intercambios = false; // Permanece en falso hasta que no haya mas intercambios
                Nodo actual = lista.inicio; // Este nodo recorre la lista en cada pasada

                // Se hacen comparaciones entre nodos consecutivos
                while (actual.sig != null)
                {
                    // Se compara el valor del nodo actual con el siguiente nodo
                    if (int.Parse(actual.Valor) > int.Parse(actual.sig.Valor))
                    {
                        string temp = actual.Valor; // Se guarda temporalmente el valor actual
                        actual.Valor = actual.sig.Valor; // Se asigna el valor del siguiente nodo al nodo actual
                        actual.sig.Valor = temp; // El valor guardado se asigna al siguiente nodo

                        intercambios = true; // Se indica que si hubo un intercambio
                    }
                    actual = actual.sig; // Se avanza al siguiente nodo
                }

                // Si no se hicieron intercambios, el ordenamiento ha terminado o ya está ordenado
                if (!intercambios)
                    break; // Se detiene el proceso de ordenamiento

                numPasada = numPasada.sig; // Se avanza a la siguiente pasada de comparaciones
            }
        }
    }
}
