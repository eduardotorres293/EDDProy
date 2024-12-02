using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListaCircularDoble
    {
        // Nodo que apunta al último elemento de la lista
        private NodoDoble ultimo;
        // Contador del tamaño de la lista
        private int tamaño;

        public ListaCircularDoble()
        {
            ultimo = null;
            tamaño = 0;
        }

        // Funcion que permite comprobar si la lista esta vacía
        public bool estaVacio()
        {
            return ultimo == null;
        }

        // Función search, utilizada y referenciada con anterioridad

        public string Search(string valorBuscado)
        {
            if (estaVacio())
            {
                return string.Empty;
            }

            NodoDoble aux = ultimo.sig;
            int posicion = 1;
            StringBuilder posiciones = new StringBuilder();


            // Se utiliza el do ya que es el que mejor respeta la funcionalidad de listas circulares
            // permitiendo hacer toda una instruccion con el valor ultimo referenciado
            do
            {
                if (aux.Valor == valorBuscado)
                {
                    if (posiciones.Length > 0)
                    {
                        posiciones.Append(", ");
                    }
                    posiciones.Append(posicion.ToString());
                }
                aux = aux.sig;
                posicion++;
            } while (aux != ultimo.sig);

            return posiciones.ToString();
        }
        // Funcion que permite insertar un elemento en la parte superior de la lista

        public void InsertTop(string valor)
        {
            NodoDoble nuevoNodoDoble = new NodoDoble(valor);

            // Primero se verifica que no este vacio
            if (estaVacio())
            {
                // Se asigna el ultimo nodo como el nuevo nodo
                ultimo = nuevoNodoDoble;
                // El siguiente del ultimo apunta a si mismo
                ultimo.sig = nuevoNodoDoble;
                // Y el anterior igual, se apunta a si mismo
                ultimo.ant = nuevoNodoDoble;
            }
            else
            {
                nuevoNodoDoble.sig = ultimo.sig;
                nuevoNodoDoble.ant = ultimo;
                ultimo.sig.ant = nuevoNodoDoble;
                ultimo.sig = nuevoNodoDoble;
            }
            tamaño++; // Se incrementa el tamaño de la lista
        }

        // Funcion para insertar en la base
        public void InsertBase(string valor)
        {
            // Se asigna el valor a insertar
            InsertTop(valor);
            // El siguiente dato del ultimo se referencia a si mismo
            ultimo = ultimo.sig;
        }

        // Funcion para insertar un elemento en la posicion deseada
        public void InsertCenter(string valor, int posicion)
        {
            // Verifica si la posición es válida (entre 1 y tamaño + 1)
            if (posicion < 1 || posicion > tamaño + 1)
            {
                MessageBox.Show("Posición inválida");
                return; // Sale si la posición no es válida
            }

            NodoDoble nuevoNodoDoble = new NodoDoble(valor); // Crea un nuevo nodo con el valor proporcionado

            // Si la posición es 1, inserta en la parte superior
            if (posicion == 1)
            {
                InsertTop(valor);
            }
            // Si la posición es tamaño + 1, inserta en la parte inferior
            else if (posicion == tamaño + 1)
            {
                InsertBase(valor);
            }
            else
            {
                NodoDoble aux = ultimo.sig; // Comienza desde el primer nodo
                                            // Navega hasta el nodo anterior a la posición deseada
                for (int i = 1; i < posicion - 1; i++)
                {
                    aux = aux.sig; // Avanza al siguiente nodo
                }

                // Conecta el nuevo nodo en la posición deseada
                nuevoNodoDoble.sig = aux.sig; // El siguiente del nuevo nodo apunta al siguiente del auxiliar
                nuevoNodoDoble.ant = aux; // El anterior del nuevo nodo apunta al auxiliar
                aux.sig.ant = nuevoNodoDoble; // El anterior del siguiente nodo apunta al nuevo nodo
                aux.sig = nuevoNodoDoble; // El auxiliar ahora apunta al nuevo nodo
                tamaño++; // Incrementa el tamaño de la lista
            }
        }

        public void DeleteBase()
        {
            // Verifica si la lista está vacía
            if (estaVacio())
            {
                MessageBox.Show("La lista está vacía");
                return; // Sale si la lista está vacía
            }
            // Si hay solo un nodo, lo elimina
            if (ultimo.sig == ultimo)
            {
                ultimo = null; // Establece último a null, la lista queda vacía
            }
            else
            {
                // Este nodo anterior solo es el penultimo termino
                NodoDoble anterior = ultimo.ant;
                anterior.sig = ultimo.sig;
                ultimo.sig.ant = anterior;
                NodoDoble eliminar = ultimo;
                eliminar.sig = null;
                eliminar.ant = null;
                eliminar = null;
                ultimo = anterior;
            }
            tamaño--; // Decrementa el tamaño de la lista
        }

        public void DeleteTop()
        {
            // Verifica si la lista está vacía
            if (estaVacio())
            {
                MessageBox.Show("La lista está vacía");
                return; // Sale si la lista está vacía
            }
            // Si hay solo un nodo, lo elimina
            if (ultimo.sig == ultimo)
            {
                ultimo = null; // Establece último a null, la lista queda vacía
            }
            else
            {
                NodoDoble primero = ultimo.sig;
                ultimo.sig = primero.sig;
                primero.sig.ant = ultimo;
                primero.sig = null;
                primero.ant = null;
            }
            tamaño--; // Se reduce el tamaño de la lista
        }

        public void DeleteCenter(int posicion)
        {
            // Verifica si la posición es válida (entre 1 y tamaño)
            if (posicion < 1 || posicion > tamaño)
            {
                MessageBox.Show("Posición inválida");
                return; // Sale si la posición no es válida
            }

            // Si la posición es 1, llama a DeleteTop
            if (posicion == 1)
            {
                DeleteTop();
            }
            // Si la posición es tamaño, llama a DeleteBase
            else if (posicion == tamaño)
            {
                DeleteBase();
            }
            else
            {
                NodoDoble aux = ultimo.sig; // Comienza desde el primer nodo
                                            // Navega hasta el nodo anterior a la posición deseada
                for (int i = 1; i < posicion - 1; i++)
                {
                    aux = aux.sig; // Avanza al siguiente nodo
                }
                NodoDoble eliminar = aux.sig;
                aux.sig = aux.sig.sig; // El nodo anterior apunta al siguiente del que se elimina
                aux.sig.ant = aux; // auxiza el anterior del nuevo siguiente
                eliminar.sig = null;
                eliminar.ant = null;
                tamaño--; // Decrementa el tamaño de la lista
            }
        }

        // Función para vaciar toda la lista
        public bool Vaciar()
        {
            if (estaVacio())
            {
                return false;
            }
            NodoDoble aux = ultimo.sig;
            // Lo mismo que con la lista circular simple, utilice do ya que suelen usarlo como base para cualquier lista circular
            // debido a su propiedad que permite crear las instrucciones hasta que se cumpla
            // un termino (el while)
            do
            {
                NodoDoble siguiente = aux.sig;
                aux.sig = null;
                aux.ant = null;
                aux = siguiente;
            } while (aux != ultimo.sig);

            ultimo = null;
            tamaño = 0;
            return true;
        }

        // El llamado recorrer(), lo que permite que esta lista sea dinamica
        public string Mostrar()
        {
            if (estaVacio())
            {
                return null;
            }

            NodoDoble aux = ultimo.sig;
            StringBuilder res = new StringBuilder();

            do
            {
                res.Append(aux.Valor + Environment.NewLine);
                aux = aux.sig;
            } while (aux != ultimo.sig);

            return res.ToString().TrimEnd();
        }

        public int Total()
        {
            return tamaño;
        }
    }
}
