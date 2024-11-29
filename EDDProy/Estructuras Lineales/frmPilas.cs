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
//using EDDemo.Clases;

namespace EDDemo
{

    public partial class frmPilas : Form
    {
        public Pila pila = new Pila();
        public frmPilas()
        {
            InitializeComponent();
        }
        // Esta función solo es estética, ya que permite cambiar el tamaño de la caja de texto ajustandose al tamaño de
        // los nuevos elementos
        public void CajaDeTexto(TextBox textBox)
        {
            int cantidadLineas = textBox.Lines.Length;
            int alturaLineas = textBox.Font.Height; // Altura de cada línea según el tamaño de la fuente
            int espacio = 5; // Un espacio adicional para que no quede tan justo
            textBox.Height = (cantidadLineas * alturaLineas) + espacio;
        }
        // Esta funcion refresca la pila, permitiendo que se actualicen los cambios
        public void recorrer()
        {
            txtPila.Text = pila.Mostrar();
            CajaDeTexto(txtPila);
            // Esta línea permite actualizar el conteo total de elementos
            txtCounter.Text = pila.ActualizarTotal().ToString();
        }

        public void btnPush_Click(object sender, EventArgs e)
        {
            string valor = txtValor.Text;

            if (!string.IsNullOrWhiteSpace(valor))
            {
                pila.Push(valor);  // Añadir el elemento a la pila
                recorrer(); // Se refresca la pila
                txtValor.Clear();  // La caja de texto donde se introdujo el dato se vacía
            }
            else
            {
                MessageBox.Show("Ingrese un elemento válido");
            }
        }

        public void btnPop_Click(object sender, EventArgs e)
        {
            string eliminado = pila.Pop();  // Se elimina el elemento del tope

            if (eliminado != null)
            {
                recorrer();
            }
            else
            {
                MessageBox.Show("La pila está vacía");
            }
        }

        public void btnVaciar_Click(object sender, EventArgs e)
        {
            while (!pila.estaVacio())
            {
                pila.Pop();
            }
            recorrer();
            MessageBox.Show("La pila ha sido vaciada");
        }
    }
}
