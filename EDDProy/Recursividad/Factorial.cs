using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recursividad
{
    public partial class Factorial : Form
    {
        private int numOperaciones;
        public Factorial()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          try
            {
                // Esta línea convierte el dato de entrada a un número entero
                int number = Convert.ToInt32(textBox1.Text);

                if (number < 0)
                {
                    MessageBox.Show("El número no puede ser negativo.");
                    textBox3.Text = ""; //esta parte limpia el tiempo y las operaciones
                    textBox4.Text = "";
                }
                else
                {
                    // Stopwatch funciona como el contador de tiempo, iniciando un nuevo proceso en el primer código
                    // Luego comienza y cuenta el tiempo hasta que el CalcularFactorial esté completo
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    numOperaciones = 0;
                    long result = CalcularFactorial(number);
                    stopwatch.Stop();

                    // Cajas de texto para mostrar la cantidad de operaciones y milísegundos
                    textBox2.Text = result.ToString();
                    textBox3.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                    textBox4.Text = $"{numOperaciones}";
                }
            }
            catch (FormatException)
            {
                // Excepciones dadas por el código en caso de que no se cumpla algo
                MessageBox.Show("Ingresa un número válido.");
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        // Método recursivo para calcular el factorial
        private long CalcularFactorial(int n)
        {
            // Aumenta la cantidad de operaciones
            numOperaciones++;

            // Cálculo del factorial, utiliza n como referencia para multiplicar n por su número anterior
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalcularFactorial(n - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}