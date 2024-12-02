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
    public partial class Fibonacci : Form
    {
        // Objeto para empezar a contar el numero de operaciones
        private int numOperaciones;
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el número de términos de la secuencia de Fibonacci, sacado del cuadro de texto
                int n = int.Parse(textBox1.Text);

                if (n < 0)
                {
                    // Advertencias si no se cumplen los requisitos
                    MessageBox.Show("El número de términos no puede ser negativo.");
                    textBox4.Text = "";
                    textBox3.Text = "";
                    return;
                }

                // Iniciar el cronómetro de tiempo
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                numOperaciones = 0;
                string resultado = Fibo(n);
                stopwatch.Stop();
                // Mostrar los resultados
                textBox2.Text = resultado;
                textBox4.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                textBox3.Text = $"{numOperaciones}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un valor válido.");
                textBox4.Text = "";
                textBox3.Text = "";
            }
        }
        //Procedimiento para calcular el numero de Fibonacci
        private string Fibo(int n)
        {
            numOperaciones++;

            if (n == 0)
            {
                return "0";
            }
            else if (n == 1)
            {
                return "0, 1";
            }
            else
            {
                int[] fibonacci = new int[n + 1];
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 2; i <= n; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    numOperaciones++;
                }

                return string.Join(", ", fibonacci);
            }
        }
    }
}
