using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmColas : Form
    {
        // Se crea un nuevo elemento cola mediante un constructor
        private Cola cola = new Cola();

        // Función caja de texto, utilizada en todos los cinco códigos, por lo que no veo necesario explicar todo de nuevo
        private void CajaDeTexto(TextBox textBox)
        {
            int cantidadLineas = textBox.Lines.Length;
            int alturaPorLinea = textBox.Font.Height;
            int padding = 5;
            textBox.Height = (cantidadLineas * alturaPorLinea) + padding;
        }

        private void recorrer()
        {
            txtCola.Text = cola.Mostrar();
            CajaDeTexto(txtCola);
            txtTotal.Text = cola.ActualizarTotal().ToString();
        }
        public frmColas()
        {
            InitializeComponent();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Se le da a valor el texto a introducir
            string valor = txtValor.Text;

            if (!string.IsNullOrWhiteSpace(valor))
            {
                cola.Encolar(valor); // Encolar cualquier tipo de dato
                recorrer();
                txtValor.Clear(); // Limpiar el textbox2 para un nuevo valor
                // Se cambia el tamaño mediante cajadetexto()
                CajaDeTexto(txtCola);
            }
            else
            {
                MessageBox.Show("Ingrese un elemento válido");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            // Se le da al valor removido el elemento que se quita mediante
            // desencolar()
            string removed = cola.Desencolar();
            // Si el elemento eliminado no es nulo, se hace lo siguiente
            if (removed != null)
            {
                // La caja de texto muestra la nueva cola actualizada
                recorrer();
                // Se modifica el tamaño de la caja de texto al tamaño de los datos
                CajaDeTexto(txtCola);
            }
            else
            {
                MessageBox.Show("La cola está vacía");
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            // A elemento peek se le asigna el valor de la funcion peek utilizada en la cola
            string elementoPeek = cola.Peek();
            // Se vacia la caja de texto en la que se introduce el dato
            txtPeek.Clear();
            // Se verifica que elemento peek no este vacio
            if (elementoPeek != null)
            {
                txtPeek.Text = elementoPeek.ToString();
            }
            else
            {
                MessageBox.Show("La cola está vacía");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            while (!cola.estaVacio())
            {
                cola.Desencolar();
            }
            recorrer();
            MessageBox.Show("La cola ha sido vaciada");
        }
    }
}
