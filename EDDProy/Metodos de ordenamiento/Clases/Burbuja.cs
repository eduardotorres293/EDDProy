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
        // Método de ordenamiento burbuja optimizado usando listas ligadas
        public static void FuncionBurbuja(Listas lista)
        {
            if (lista.estaVacio())
                return;

            bool intercambios;
            Nodo numPasada = lista.inicio;

            // Mientras haya nodos por comparar
            while (numPasada != null && numPasada.sig != null)
            {
                intercambios = false;
                Nodo actual = lista.inicio;

                // Realizamos las comparaciones de los nodos
                while (actual.sig != null)
                {
                    if (int.Parse(actual.Valor) > int.Parse(actual.sig.Valor))
                    {
                        // Intercambiamos los valores de los nodos
                        string temp = actual.Valor;
                        actual.Valor = actual.sig.Valor;
                        actual.sig.Valor = temp;

                        intercambios = true;
                    }
                    actual = actual.sig;
                }

                // Si no se hicieron intercambios, el ordenamiento ha terminado
                if (!intercambios)
                    break;

                numPasada = numPasada.sig;
            }
        }
    }
}
