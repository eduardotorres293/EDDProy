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
        public bool estaVacio()
        {
            return top == null;
        }
        // Función para añadir un elemento a la pila (Push)
        public void Push(string elemento)
        {
            // Se crea un nodo nuevo, con un parametro elemento
            Nodo nuevo = new Nodo(elemento);
            // La referencia del nodo siguiente será el nuevo tope
            nuevo.sig = top;
            // Aqui el tope se vuelve el nodo nuevo
            top = nuevo;
        }

        // Función para eliminar el elemento del tope de la pila (Pop)
        public string Pop()
        {
            if (estaVacio())
            {
                return null;  // Si está vacía, retorna null
            }

            Nodo Aux = top;

            // La pila de la cima es actualizada
            top = top.sig;

            // Se saca el dato del nodo eliminado
            string Dato = Aux.Valor;

            // Se libera explícitamente el nodo
            Aux = null;  // Establecer Aux a null para borrar el dato

            // Se regresa dato del nodo eliminado
            return Dato;  // Retorna el valor eliminado
        }
        // Esta funcion permite vaciar la lista
        public void Vaciar()
        {
            if (estaVacio())
            {
                MessageBox.Show("La pila ya está vacía");
                return;
            }

            // Recorrer la pila haciendo pop y mostrando los elementos
            while (!estaVacio())
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
