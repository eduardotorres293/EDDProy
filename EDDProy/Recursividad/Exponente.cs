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

namespace Recursividad
{
    public partial class Exponente : Form
    {
        private int numOperaciones = 0;
        public Exponente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Se lee y se transforma el numero introducido, transformandose en un numero double (acepta mas cantidades) y entero respectivamente
                double x = double.Parse(textBox1.Text);
                int n = int.Parse(textBox2.Text);
                if (n < 0)
                {
                    //mensaje de error si se trata de introducir un numero negativo
                    MessageBox.Show("El exponente no puede ser negativo.");
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    // Se invoca y se inicia el cronometro de tiempo
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    //Se marca el numero de operaciones en 0 para comenzar
                    numOperaciones = 0;
                    double resultado = Expo(x, n);
                    stopwatch.Stop();
                    //Se detiene el proceso de tiempo y se dan los resultados de los milisegundos, numero de operaciones y resultado final
                    textBox3.Text = resultado.ToString();
                    textBox4.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                    textBox5.Text = $"{numOperaciones}";
                }
            }
            catch (FormatException)
            {
                // Excepciones (mensajes de errores)
                MessageBox.Show("Ingresa valores válidos.");
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
        // Calculo del exponencial mediante el uso de x y n
        private double Expo(double x, int n)
        {
            numOperaciones++;

            if (n == 0)
            {
                return 1;
            }
            // Aqui si n no es igual a 0, se saca el residuo del exponente entre dos y, si da 0, se realiza la mitad del proceso
            else if (n % 2 == 0)
            {
                double half = Expo(x, n / 2);
                return half * half;
            }
            else
            {
                return x * Expo(x, n - 1);
            }
        }
    }
}
