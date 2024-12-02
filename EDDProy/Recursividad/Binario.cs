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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recursividad
{
    public partial class Binario : Form
    {
        private int numOperaciones = 0;
        public Binario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el número de elementos y el valor a buscar
                int[] arreglo = textBox1.Text.Split(',').Select(int.Parse).ToArray();
                int valorBuscado = int.Parse(textBox2.Text);

                if (arreglo.Length == 0)
                {
                    MessageBox.Show("El arreglo está vacío.");
                    textBox4.Text = "";
                    textBox5.Text = "";
                    return;
                }

                // Ordenar el arreglo (la búsqueda binaria requiere que el arreglo esté ordenado)
                Array.Sort(arreglo);

                // Iniciar el cronómetro de tiempo
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Inicializar el contador de operaciones
                numOperaciones = 0;

                // Realizar la búsqueda binaria
                int resultado = BusquedaBinaria(arreglo, valorBuscado);

                stopwatch.Stop();

                // Mostrar los resultados
                if (resultado == -1)
                {
                    textBox3.Text = $"Valor no encontrado.";
                }
                else
                {
                    textBox3.Text = $"Valor encontrado en el índice {resultado}.";
                }
                textBox4.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                textBox5.Text = $"{numOperaciones}";
            }
            catch (FormatException)
            {
                // Mensajes de error en caso de formato inválido
                MessageBox.Show("Ingresa valores válidos.");
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
        private int BusquedaBinaria(int[] arreglo, int valorBuscado)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                numOperaciones++; // Contar operaciones en cada iteración
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arreglo[medio] == valorBuscado)
                {
                    return medio;
                }
                if (arreglo[medio] < valorBuscado)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }
            return -1;
        }
    }
}
