using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListaDoble
    {
        // Primer NodoDoble
        private NodoDoble inicio;
        // Ultimo NodoDoble
        private NodoDoble cola;
        private int tamaño;

        public ListaDoble()
        {
            inicio = null;
            cola = null;
            tamaño = 0;
        }

        public bool estaVacio()
        {
            return inicio == null;
        }

        // Funcion de busqueda, haciendo un recorrido doble para buscar el elemento especifico
        public string Search(string valorBuscado)
        {
            StringBuilder posiciones = new StringBuilder(); // StringBuilder para acumular posiciones

            if (inicio == null)
            {
                return posiciones.ToString(); // Retorna un string vacío si la lista está vacía
            }

            NodoDoble actual = inicio;
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

        // Funcion que permite insertar en el tope de la lista
        public void InsertTop(string valor)
        {
            NodoDoble newNodoDoble = new NodoDoble(valor);

            if (inicio == null)
            {
                inicio = newNodoDoble;
                cola = newNodoDoble;
            }
            else
            {
                newNodoDoble.sig = inicio;
                inicio.ant = newNodoDoble;
                inicio = newNodoDoble;
            }
            tamaño++;
        }
        // Funcion que permite insertar un elemento en la base de la lista
        public void InsertBase(string valor)
        {
            NodoDoble newNodoDoble = new NodoDoble(valor);

            if (inicio == null)
            {
                inicio = newNodoDoble;
                cola = newNodoDoble;
            }
            else
            {
                cola.sig = newNodoDoble;
                newNodoDoble.ant = cola;
                cola = newNodoDoble;
            }
            tamaño++;
        }

        // Funcion que permite insertar un elemento en una posicion especifica
        public void InsertCenter(string valor, int posicion)
        {
            if (posicion < 1 && posicion > tamaño + 1)
            {
                MessageBox.Show("Posición inválida");
                return;
            }

            NodoDoble newNodoDoble = new NodoDoble(valor);

            if (posicion == 1)
            {
                InsertTop(valor);
            }
            else if (posicion == tamaño + 1) // Agregar en la parte inferior
            {
                // Aquí se vuelve a llamar a insertBase, ya que cumple una funcion parecida a insert 
                InsertBase(valor);
            }
            else
            {
                NodoDoble actual = inicio;
                for (int i = 1; i < posicion - 1; i++)
                {
                    actual = actual.sig;
                }

                newNodoDoble.sig = actual.sig;
                newNodoDoble.ant = actual;

                if (actual.sig != null) // Si no estamos insertando al final
                {
                    actual.sig.ant = newNodoDoble;
                }
                actual.sig = newNodoDoble;
                tamaño++;
            }
        }

        // Funcion que permite borrar el elemento de la base
        public void DeleteBase()
        {
            if (cola == null)
            {
                MessageBox.Show("La lista está vacía");
                return;
            }
            if (inicio == cola)
            {
                inicio = null;
                cola = null;
            }
            else
            {
                NodoDoble eliminar = cola;
                cola = cola.ant;
                cola.sig = null;
                eliminar.ant = null;
                eliminar.sig = null;
            }
            tamaño--;
        }

        public void DeleteTop()
        {
            if (inicio == null)
            {
                MessageBox.Show("La lista está vacía");
                return;
            }
            if (inicio == cola)
            {
                inicio = null;
                cola = null;
            }
            else
            {
                NodoDoble eliminar = inicio;
                inicio = inicio.sig;
                inicio.ant = null;
                eliminar.sig = null;
                eliminar.ant = null;
            }
            tamaño--;
        }

        // Funcion deletecenter, quien elimina una parte especifica de la lista
        public void DeleteCenter(int posicion)
        {
            // Se añade && que da el significado de "Or", para referirse a que si sucede una cosa
            // u otra
            if (posicion < 1 && posicion > tamaño)
            {
                MessageBox.Show("Posicion inválida");
                return;
            }
            if (posicion == 1)
            {
                DeleteTop(); // Se llama a deleteTop para ahorrar código y no ser redundante
            }
            else if (posicion == tamaño)
            {
                DeleteBase(); // Se rehusa el codigo al llamar el deleteBase por la condición
            }
            else
            {
                NodoDoble actual = inicio;
                for (int i = 1; i < posicion; i++)
                {
                    actual = actual.sig; // Llegamos al NodoDoble que queremos eliminar
                }

                // Ajustamos las referencias para eliminar el NodoDoble
                actual.ant.sig = actual.sig;  // NodoDoble anterior apunta al siguiente
                if (actual.sig != null)
                {
                    actual.sig.ant = actual.ant;  // NodoDoble siguiente apunta al anterior
                }
                actual.sig = null;  // Eliminamos la referencia al siguiente NodoDoble
                actual.ant = null;  // Eliminamos la referencia al NodoDoble anterior
            }
        }

        // Función vaciar, quien vacia en su totalidad la lista
        public bool Vaciar()
        {
            if (estaVacio())
            {
                return false;
            }
            NodoDoble actual = inicio;
            while (actual != null)
            {
                actual.sig = null;
                actual.ant = null;
                actual = actual.sig;
            }

            inicio = null;
            cola = null;
            tamaño = 0;

            return true;
        }


        // Tambien llamada funcion recorrer, es quien muestra de forma dinamica toda la lista
        public string Mostrar()
        {
            if (inicio == null)
            {
                return null;
            }

            NodoDoble actual = inicio;
            StringBuilder res = new StringBuilder();

            while (actual != null)
            {
                res.Append(actual.Valor + Environment.NewLine);
                actual = actual.sig;
            }
            return res.ToString().TrimEnd();
        }

        // El total de elementos presente en la lista
        public int Total()
        {
            return tamaño;
        }
    }
}
