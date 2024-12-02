using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    class Cola
    {
        private Nodo inicio;
        private Nodo fin;

        public Cola()
        {
            inicio = null;
            fin = null;
        }

        public bool estaVacio()
        {
            return inicio == null;
        }
        // Funcion encolar, introduciendo un nuevo elemento
        public void Encolar(string elemento)
        {
            // Al nuevo nodo, se le da el valor de un nodo nuevo (vacio)
            Nodo nuevo = new Nodo(elemento);

            // Si el inicio es igual a nulo, se añade hasta arriba, y fin sera el
            // mismo valor que el inicio
            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                // Si no, el fin.sig sera movido hacia adelante y se añade el nodo nuevo
                fin.sig = nuevo;
                fin = nuevo;
            }
        }

        // Funcion desencolar, para sacar un elemento de la lista
        public string Desencolar()
        {
            if (estaVacio())
            {
                return null;
            }
            // datoRem se refiere al dato eliminado / removido
            Nodo eliminar = inicio;
            // El nodo a eliminar sera el nodo inicial, y el datoRem se convierte en el valor de dicho nodo
            string datoRem = eliminar.Valor;
            inicio = inicio.sig;

            if (inicio == null)
            {
                fin = null;
            }
            // Se elimina todo, incluido las referencias usadas para conseguir el dato a eliminar
            eliminar.Valor = null;
            eliminar.sig = null;
            eliminar = null;

            return datoRem;
        }
        // Función peek, quien permite ver el primer dato de la lista
        // Esta función no era necesaria, pero la quise añadir como parte de esta ya que no
        // pude exponerla durante su tiempo (exposición de cola 3sB)
        public string Peek()
        {
            //Si el inicio es igual a nulo, se devuelve nulo (para poder hacer un isVacia() luego)
            if (estaVacio())
            {
                return null;
            }
            // Se da el primer dato
            return inicio.Valor;
        }
        //Función vaciar, para vaciar la cola
        public void Vaciar()
        {
            if (estaVacio())
            {
                MessageBox.Show("La cola ya está vacía");
                return;
            }

            // Mientras haya nodos, dequeue a cada uno
            while (!estaVacio())
            {
                Desencolar();
            }

            MessageBox.Show("La cola ha sido vaciada");
        }

        // Esta funcion permite obtener los elementos de la cola como strings
        public string Mostrar()
        {
            // El elemento res (resultado) se marca como vacío mediante ""
            string res = "";
            // Al nodo actual se le da el valor del inicio
            Nodo actual = inicio;
            //Mientras actual sea diferente a null, el resultado será introducir nueva línea hasta llenar
            while (actual != null)
            {
                res += actual.Valor.ToString() + Environment.NewLine;
                actual = actual.sig;
            }
            return res.Trim();
        }

        // Esta función también es un extra, permitiendo ver el total de lineas que hay dentro de la cola
        public int ActualizarTotal()
        {
            int totalElementos = 0;
            Nodo actual = inicio;
            while (actual != null)
            {
                totalElementos++;
                actual = actual.sig;
            }
            return totalElementos;
        }
    }
}
