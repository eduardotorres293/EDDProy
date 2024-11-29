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
    public partial class frmListasCircularesSimples : Form
    {
        // Instancia de la lista circular
        public ListaCircular lista = new ListaCircular();
        public frmListasCircularesSimples()
        {
            InitializeComponent();
            LoadComboBox();
        }
        // Refresca la lista visual en el formulario
        public void recorrer()
        {
            txtLista.Text = lista.Mostrar();
            CajaDeTexto(txtLista);
            txtTotal.Text = lista.Total().ToString();
        }

        // Ajusta el tamaño del TextBox basado en el contenido
        public void CajaDeTexto(TextBox textBox)
        {
            int cantidadLineas = textBox.Lines.Length;
            int alturaLineas = textBox.Font.Height;
            int espacio = 5;
            textBox.Height = (cantidadLineas * alturaLineas) + espacio;
        }
        // Carga las opciones del ComboBox
        public void LoadComboBox()
        {
            cmbEliminar.Items.Clear();
            cmbEliminar.Items.Add("Eliminar tope");
            cmbEliminar.Items.Add("Eliminar base");
            cmbEliminar.Items.Add("Eliminar en posición");

            cmbEliminar.SelectedIndex = 0;

            cmbInsertar.Items.Clear();
            cmbInsertar.Items.Add("Insertar tope");
            cmbInsertar.Items.Add("Insertar base");
            cmbInsertar.Items.Add("Insertar en posición");

            cmbInsertar.SelectedIndex = 0;
        }
        public void btnInsertar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = txtInsertar.Text;
            string opcionInsertar = cmbInsertar.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nuevoElemento))
            {
                MessageBox.Show("Introduce un elemento válido");
                return;
            }

            if (string.IsNullOrEmpty(opcionInsertar))
            {
                MessageBox.Show("Selecciona dónde insertar");
                return;
            }

            // Inserta según la opción seleccionada
            if (opcionInsertar == "Insertar base")
            {
                lista.InsertBase(nuevoElemento);
            }
            else if (opcionInsertar == "Insertar tope")
            {
                lista.InsertTop(nuevoElemento);
            }
            else if (opcionInsertar == "Insertar en posición")
            {
                if (int.TryParse(txtPosicion.Text, out int posicion))
                {
                    lista.InsertCenter(nuevoElemento, posicion);
                    txtPosicion.Clear();
                }
                else
                {
                    MessageBox.Show("Introduce una posición válida");
                }
            }

            recorrer();
            txtInsertar.Clear();
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            string opcionEliminar = cmbEliminar.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(opcionEliminar))
            {
                MessageBox.Show("Selecciona una opción");
                return;
            }

            // Elimina según la opción seleccionada
            if (opcionEliminar == "Eliminar tope")
            {
                lista.DeleteTop();
            }
            else if (opcionEliminar == "Eliminar base")
            {
                lista.DeleteBase();
            }
            else if (opcionEliminar == "Eliminar en posición")
            {
                if (int.TryParse(txtEliminar.Text, out int posicion))
                {
                    lista.DeleteCenter(posicion);
                }
                else
                {
                    MessageBox.Show("Introduce una posición válida");
                }
            }

            recorrer();
            txtEliminar.Clear();
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBuscado = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(valorBuscado))
            {
                MessageBox.Show("Introduce un valor válido para buscar");
                return;
            }

            string resultados = lista.Search(valorBuscado);

            // Muestra las posiciones encontradas o indica que no fue encontrado
            if (resultados.Length > 0)
            {
                MessageBox.Show("Elemento encontrado en: " + resultados);
            }
            else
            {
                MessageBox.Show("El valor no fue encontrado");
            }
        }

        public void btnVaciar_Click(object sender, EventArgs e)
        {
            while (!lista.estaVacio())
            {
                lista.DeleteTop();
            }
            recorrer();
            txtTotal.Clear();
            MessageBox.Show("La lista ha sido vaciada");
        }
    }
}
