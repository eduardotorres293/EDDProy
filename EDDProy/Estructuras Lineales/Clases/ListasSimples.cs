using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class Listas
    {
        private Nodo inicio;
        private int tamaño;
        public Listas()
        {
            inicio = null;
            tamaño = 0;
        }
        // Funcion para verificar si la lista esta vacia
        public bool estaVacio()
        {
            return tamaño == 0;
        }

        // Función buscar, ahora devuelve un string con las posiciones donde se encontró el valor
        public string Search(string valorBuscado)
        {
            StringBuilder posiciones = new StringBuilder(); // StringBuilder para acumular posiciones

            if (inicio == null)
            {
                return posiciones.ToString(); // Retorna un string vacío si la lista está vacía
            }

            Nodo actual = inicio;
            int posicion = 1;

            // Recorre la lista y busca el valor
            while (actual != null)
            {
                if (actual.Valor == valorBuscado)
                {
                    if (posiciones.Length > 0) // Si ya hay posiciones, añade una coma
                    {
                        posiciones.Append(", ");
                    }
                    posiciones.Append(posicion); // Agrega la posición al StringBuilder
                }
                actual = actual.sig;
                posicion++;
            }

            return posiciones.ToString(); // Devuelve el string de posiciones encontradas
        }

        public void DeleteBase()
        {
            if (estaVacio())
            {
                MessageBox.Show("La lista está vacía");
                return;
            }

            if (inicio.sig == null)
            {
                inicio = null;
            }
            else
            {
                Nodo actual = inicio;
                while (actual.sig.sig != null)
                {
                    actual = actual.sig;
                }
                // Aqui se igualan a null para eliminar el dato
                actual.sig = null;
            }

            tamaño--;
        }

        // Función para borrar el tope de la lista
        public void DeleteTop()
        {
            if (estaVacio())
            {
                MessageBox.Show("La lista está vacía");
                return;
            }
            Nodo eliminar = inicio;
            inicio = inicio.sig;
            eliminar.sig = null;

            tamaño--;
        }

        // Función para borrar una posición específica
        public void DeleteCenter(int posicion)
        {
            posicion -= 1;

            if (posicion < 0 && posicion >= tamaño)
            {
                MessageBox.Show("Posición inválida");
                return;
            }

            if (posicion == 0)
            {
                DeleteTop();
            }
            else if (posicion == tamaño - 1)
            {
                DeleteBase();
            }
            else
            {
                Nodo actual = inicio;
                for (int i = 0; i < posicion - 1; i++)
                {
                    actual = actual.sig;
                }
                Nodo eliminar = actual.sig;
                actual.sig = eliminar.sig;
                eliminar.sig = null;
            }
            tamaño--;
        }

        // Función para insertar un elemento en la base
        public void InsertBase(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                Nodo actual = inicio;
                while (actual.sig != null)
                {
                    actual = actual.sig;
                }
                actual.sig = nuevoNodo;
            }
            tamaño++;
        }

        // Función para insertar un elemento en el tope
        public void InsertTop(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            nuevoNodo.sig = inicio;
            inicio = nuevoNodo;
            tamaño++;
        }

        // Función para insertar un elemento en la posición deseada
        public void InsertCenter(string valor, int posicion)
        {
            posicion -= 1;

            if (posicion < 0 && posicion > tamaño)
            {
                MessageBox.Show("Posición inválida");
                return;
            }

            Nodo nuevoNodo = new Nodo(valor);

            if (posicion == 0)
            {
                nuevoNodo.sig = inicio;
                inicio = nuevoNodo;
            }
            else
            {
                Nodo actual = inicio;
                for (int i = 0; i < posicion - 1; i++)
                {
                    actual = actual.sig;
                }
                nuevoNodo.sig = actual.sig;
                actual.sig = nuevoNodo;
            }
            tamaño++;
        }

        // Función de vaciar (para vaciar la lista)
        public bool Vaciar()
        {
            if (estaVacio())
            {
                return false;
            }
            Nodo actual = inicio;
            while (actual != null)
            {
                Nodo sig = actual.sig;
                actual.sig = null;
                actual.Valor = null;
                actual = sig;
            }
            inicio = null;
            tamaño = 0;
            return true;
        }

        // Función para mostrar los elementos dentro de la lista
        public string Mostrar()
        {
            if (estaVacio())
            {
                return null;
            }

            StringBuilder res = new StringBuilder();
            Nodo actual = inicio;
            while (actual != null)
            {
                res.Append(actual.Valor + Environment.NewLine);
                actual = actual.sig;
            }
            return res.ToString().TrimEnd();
        }

        // Esto muestra la cantidad total de elementos dentro de la lista
        public int Total()
        {
            return tamaño;
        }
    }
}
