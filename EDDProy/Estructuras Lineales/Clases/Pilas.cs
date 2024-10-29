using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;
using System.Windows.Forms;

namespace EDDemo
{
    class Pila
    {
        public Nodo top;

        public Pila()
        {
            top = null;
        }
        public bool isEmpty()
        {
            return top == null;
        }
        // Función para añadir un elemento a la pila (Push)
        public void Push(string elemento)
        {
            Nodo nuevo = new Nodo(elemento);
            nuevo.sig = top;
            top = nuevo;
        }

        // Función para eliminar el elemento del tope de la pila (Pop)
        public string Pop()
        {
            if (isEmpty())
            {
                return null;  // Si está vacía, retorna null
            }

            string valor = top.Valor;
            Nodo eliminar = top;
            top = top.sig;  // El top pasa al siguiente nodo

            // Se limpia el nodo eliminado
            eliminar.Valor = null;
            eliminar.sig = null;

            return valor;  // Retorna el valor eliminado
        }
        // Esta funcion permite vaciar la lista
        public void Vaciar()
        {
            if (isEmpty())
            {
                MessageBox.Show("La pila ya está vacía");
                return;
            }

            // Recorrer la pila haciendo pop y mostrando los elementos
            while (!isEmpty())
            {
                Pop();
            }
            MessageBox.Show("La pila ha sido vaciada");
        }
        // Función para mostrar los elementos de la pila como un string
        public string Mostrar()
        {
            string res = "";
            Nodo actual = top;
            while (actual != null)
            {
                res += actual.Valor.ToString() + Environment.NewLine;
                actual = actual.sig;
            }
            return res.Trim();
        }

        // Contador de elementos totales en la pila
        public int ActualizarTotal()
        {
            int totalElementos = 0;
            Nodo actual = top;
            while (actual != null)
            {
                totalElementos++;
                actual = actual.sig;
            }
            return totalElementos;
        }
    }
}
