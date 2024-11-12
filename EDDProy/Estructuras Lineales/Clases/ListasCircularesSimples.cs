using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListaCircular
    {
        // Nodo que apunta al último elemento de la lista
        private Nodo ultimo;
        // Contador del tamaño de la lista
        private int tamaño;
        public ListaCircular()
        {
            ultimo = null;
            tamaño = 0;
        }

        // Método que verifica si la lista está vacía
        public bool estaVacio()
        {
            return ultimo == null;
        }

        // Método para buscar un valor en la lista circular
        public string Search(string valorBuscado)
        {
            if (estaVacio())
            {
                return string.Empty; // Retorna un string vacío si la lista está vacía
            }

            Nodo aux = ultimo.sig; // Comienza desde el primer nodo
            int posicion = 1;
            StringBuilder posiciones = new StringBuilder();

            // Recorre la lista para buscar coincidencias mediante el uso de do, que ayuda
            // a ejecutar una instrucción
            do
            {
                if (aux.Valor == valorBuscado)
                {
                    if (posiciones.Length > 0) // Si ya hay posiciones, añade una coma
                    {
                        posiciones.Append(", ");
                    }
                    posiciones.Append(posicion.ToString()); // Añade la posición encontrada
                }
                aux = aux.sig;
                posicion++;
            }
            while (aux != ultimo.sig); // Repite hasta volver al inicio de la lista

            return posiciones.ToString(); // Retorna las posiciones encontradas
        }

        // Método para insertar un nodo en la cabeza de la lista
        public void InsertTop(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

            if (estaVacio()) // Si la lista está vacía
            {
                ultimo = nuevoNodo;
                ultimo.sig = nuevoNodo; // El nodo apunta a sí mismo
            }
            else
            {
                nuevoNodo.sig = ultimo.sig;
                ultimo.sig = nuevoNodo; // Inserta al inicio de la lista
            }
            tamaño++;
        }

        // Método para insertar un nodo en la base de la lista (última posición)
        public void InsertBase(string valor)
        {
            InsertTop(valor); // Usa el método InsertTop
            ultimo = ultimo.sig; // Actualiza el nodo "último"
        }

        // Método para insertar un nodo en una posición específica
        public void InsertCenter(string valor, int posicion)
        {
            if (posicion < 1 && posicion > tamaño + 1)
            {
                MessageBox.Show("Posición inválida");
                return;
            }

            Nodo nuevoNodo = new Nodo(valor);

            if (posicion == 1) // Insertar al inicio
            {
                InsertTop(valor);
            }
            else if (posicion == tamaño + 1) // Insertar al final
            {
                InsertBase(valor);
            }
            else
            {
                Nodo aux = ultimo.sig;
                for (int i = 1; i < posicion - 1; i++)
                {
                    aux = aux.sig;
                }

                // Inserta el nuevo nodo en la posición deseada
                nuevoNodo.sig = aux.sig;
                aux.sig = nuevoNodo;
                tamaño++;
            }
        }

        // Método para eliminar el nodo en la base (última posición)
        public void DeleteBase()
        {
            if (estaVacio())
            {
                MessageBox.Show("La lista está vacía");
                return;
            }
            if (ultimo.sig == ultimo) // Solo hay un nodo en la lista
            {
                Nodo aux = ultimo;
                ultimo = null;
                aux = null;
            }
            else
            {
                Nodo aux = ultimo.sig;
                while (aux.sig != ultimo)
                {
                    aux = aux.sig;
                }
                Nodo eliminar = ultimo;
                aux.sig = ultimo.sig; // Elimina el último nodo
                ultimo = aux;

                eliminar.sig = null;
                eliminar = null;
            }
            tamaño--;
        }

        // Método para eliminar el nodo en la cabeza (primera posición)
        public void DeleteTop()
        {
            if (estaVacio())
            {
                MessageBox.Show("La lista está vacía");
                return;
            }
            if (ultimo.sig == ultimo)
            {
                Nodo aux = ultimo;
                ultimo = null;
                aux = null;
            }
            else
            {
                Nodo eliminar = ultimo.sig;
                ultimo.sig = ultimo.sig.sig;
                eliminar.sig = null;
                eliminar = null;
            }
            tamaño--;
        }

        // Método para eliminar un nodo en una posición específica
        public void DeleteCenter(int posicion)
        {
            if (posicion < 1 && posicion > tamaño)
            {
                MessageBox.Show("Posición inválida");
                return;
            }

            if (posicion == 1) // Eliminar en la primera posición
            {
                DeleteTop();
            }
            else if (posicion == tamaño) // Eliminar en la última posición
            {
                DeleteBase();
            }
            else
            {
                Nodo aux = ultimo.sig;
                for (int i = 1; i < posicion - 1; i++)
                {
                    aux = aux.sig;
                }
                Nodo eliminar = aux.sig;
                aux.sig = aux.sig.sig;
                eliminar.sig = null;
                eliminar = null;
                tamaño--;
            }
        }

        // Método para vaciar toda la lista circular
        public bool Vaciar()
        {
            if (estaVacio())
            {
                return false;
            }

            Nodo aux = ultimo.sig;

            do
            {
                Nodo sig = aux.sig;
                aux.sig = null;
                aux = sig;
            } while (aux != ultimo.sig);

            ultimo = null;
            tamaño = 0;
            return true;
        }

        // Método que muestra los elementos de la lista
        public string Mostrar()
        {
            if (estaVacio())
            {
                return null;
            }

            Nodo aux = ultimo.sig;
            StringBuilder res = new StringBuilder();

            // Recorre y agrega los valores de los nodos
            do
            {
                res.Append(aux.Valor + Environment.NewLine);
                aux = aux.sig;
            } while (aux != ultimo.sig);

            return res.ToString().TrimEnd(); // Retorna la lista de valores
        }

        // Devuelve el total de elementos en la lista
        public int Total()
        {
            return tamaño;
        }
    }
}
