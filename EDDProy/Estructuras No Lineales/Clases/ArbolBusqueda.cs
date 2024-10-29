using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public bool Busqueda(int Dato, NodoBinario nodo)
        {
            if (nodo == null)
            {
                return false; // Se devuelve falso si el valor no es encontrado
            }
            if (Dato == nodo.Dato)
            {
                return true; // Se devuelve verdadero
            }
            else if (Dato < nodo.Dato)
            {
                return Busqueda(Dato, nodo.Izq); // Se busca en el subarbol izquierdo
            }
            else
            {
                return Busqueda(Dato, nodo.Der); // Se busca en el subarbol derecho
            }
        }

        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
            else
                MessageBox.Show($"El elemento {Dato} ya está en el árbol.");
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();

            if (nodo.Izq != null)
            {
                b.AppendFormat("\"{0}\" -> \"{1}\" [label=\"L\"];" + Environment.NewLine, nodo.Dato, nodo.Izq.Dato); // Muestra "L" refiriendose a Left en inglés (izquierda)
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("\"{0}\" -> \"{1}\" [label=\"R\"];" + Environment.NewLine, nodo.Dato, nodo.Der.Dato); // Muestra "R" refiriendose a Right en inglés (derecha)
                b.Append(ToDot(nodo.Der));
            }

            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

    }
}
