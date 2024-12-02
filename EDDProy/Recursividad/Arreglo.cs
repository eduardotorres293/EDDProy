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
    public partial class Arreglo : Form
    {
        private int numOperaciones;
        public Arreglo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números introducidos en el TextBox y separarlos por comas
                string[] input = textBox1.Text.Split(',');
                double[] numeros = Array.ConvertAll(input, s => double.Parse(s.Trim()));

                // Iniciar el cronómetro de tiempo
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Inicializar el contador de operaciones
                numOperaciones = 0;

                // Calcular la suma de los elementos del arreglo
                double suma = SumarArreglo(numeros);

                stopwatch.Stop();

                // Mostrar los resultados
                textBox2.Text = suma.ToString();
                textBox4.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                textBox3.Text = $"{numOperaciones}";
            }
            catch (FormatException)
            {
                // Mensajes de error en caso de formato inválido
                MessageBox.Show("Ingresa valores válidos.");
                textBox4.Text = "";
                textBox3.Text = "";
            }
        }

            private double SumarArreglo(double[] arreglo)
            {
                numOperaciones++;

                // Caso base: Si el arreglo está vacío, la suma es 0
                if (arreglo.Length == 0)
                {
                    return 0;
                }

                // Caso recursivo: Sumar el primer elemento con la suma del resto del arreglo
                return arreglo[0] + SumarArreglo(SubArray(arreglo, 1));
            }

            private double[] SubArray(double[] arreglo, int start)
            {
                // Crear un subarreglo a partir del índice especificado
                double[] result = new double[arreglo.Length - start];
                Array.Copy(arreglo, start, result, 0, result.Length);
                return result;
            }
        }
    }
