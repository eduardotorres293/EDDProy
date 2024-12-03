using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class frmIntercalacion : Form
    {
        // Lista para almacenar los números generados en ambos archivos
        private HashSet<int> numerosArchivo1 = new HashSet<int>();
        private HashSet<int> numerosArchivo2 = new HashSet<int>();
        private void GenerarNumerosAleatorios(int cantidad, int archivo)
        {
            // Determinar el conjunto de números a generar, dependiendo del archivo
            HashSet<int> numerosGenerados = archivo == 1 ? numerosArchivo1 : numerosArchivo2;

            Random random = new Random();
            while (numerosGenerados.Count < cantidad)
            {
                // Generar un número aleatorio entre 1 y 100 (puedes ajustar el rango si es necesario)
                int numeroAleatorio = random.Next(1, 1001); // Número aleatorio entre 1 y 100

                // Asegurarse de que el número no se repita en ninguno de los dos archivos
                if (!numerosArchivo1.Contains(numeroAleatorio) && !numerosArchivo2.Contains(numeroAleatorio))
                {
                    numerosGenerados.Add(numeroAleatorio);
                }
            }
        }
        public frmIntercalacion()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de generar nuevos números
            txtArchivo1.Clear();

            // Leer la cantidad de números a generar desde el txtCantidad1
            if (int.TryParse(txtCantidad1.Text, out int cantidadArchivo1))
            {
                // Validar que la cantidad sea mayor que cero
                if (cantidadArchivo1 > 0)
                {
                    // Limpiar los números previos generados
                    numerosArchivo1.Clear();

                    // Generar números aleatorios para el primer archivo
                    GenerarNumerosAleatorios(cantidadArchivo1, 1);

                    // Mostrar los números generados en el TextBox correspondiente
                    txtArchivo1.Text = string.Join(", ", numerosArchivo1.OrderBy(n => n));
                }
                else
                {
                    MessageBox.Show("Introduce una cantidad");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un elemento válido");
            }
        }

        private void btnGenerar2_Click(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de generar nuevos números
            txtArchivo2.Clear();

            // Leer la cantidad de números a generar desde el txtCantidad2
            if (int.TryParse(txtCantidad2.Text, out int cantidadArchivo2))
            {
                // Validar que la cantidad sea mayor que cero
                if (cantidadArchivo2 > 0)
                {
                    // Limpiar los números previos generados
                    numerosArchivo2.Clear();

                    // Generar números aleatorios para el segundo archivo
                    GenerarNumerosAleatorios(cantidadArchivo2, 2);

                    // Mostrar los números generados en el TextBox correspondiente
                    txtArchivo2.Text = string.Join(", ", numerosArchivo2.OrderBy(n => n));
                }
                else
                {
                    MessageBox.Show("Introduce una cantidad");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un elemento válido");
            }
        }
        private Listas CrearListaDesdeTextBox(string texto)
        {
            Listas lista = new Listas();
            string[] numeros = texto.Split(',').Select(s => s.Trim()).ToArray();
            foreach (var numero in numeros)
            {
                if (int.TryParse(numero, out int num))
                {
                    lista.InsertBase(num.ToString()); // Insertar el número en la lista
                }
            }
            return lista;
        }
        private void btnIntercalar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Stopwatch para medir el tiempo de ejecución
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // Iniciar el cronómetro
            // Crear listas a partir de los valores de los TextBox
            Listas lista1 = CrearListaDesdeTextBox(txtArchivo1.Text);
            Listas lista2 = CrearListaDesdeTextBox(txtArchivo2.Text);

            // Crear instancia de la clase Intercalacion
            Intercalacion intercalacion = new Intercalacion();
            Listas listaIntercalada = intercalacion.FuncionIntercalacion(lista1, lista2);
            // Detener el cronómetro
            stopwatch.Stop();

            // Mostrar el tiempo de ejecución en el TextBox txtTiempo
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";

            // Mostrar los números intercalados en el TextBox correspondiente
            Nodo nodo = listaIntercalada.inicio;
            List<int> intercalados = new List<int>();
            while (nodo != null)
            {
                intercalados.Add(int.Parse(nodo.Valor)); // Obtener el valor de la lista intercalada
                nodo = nodo.sig;
            }

            // Mostrar la lista intercalada en el TextBox
            txtIntercalado.Text = string.Join(", ", intercalados.OrderBy(n => n));
        }
    }
}
