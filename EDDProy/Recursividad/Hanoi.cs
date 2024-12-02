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
    public partial class Hanoi : Form
    {
        private int numOperaciones = 0;
        public Hanoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el número de discos de la caja de textos
                int discos = int.Parse(textBox1.Text);

                if (discos < 1)
                {
                    // Mensaje de error, mostrando que el numero debe ser positivo
                    MessageBox.Show("El número de discos debe ser positivo.");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    return;
                }

                // Iniciar el cronómetro de tiempo
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                // Inicializar el contador de operaciones
                numOperaciones = 0;
                StringBuilder resultado = new StringBuilder();
                ResolverTorresDeHanoi(discos, 'A', 'C', 'B', resultado);
                stopwatch.Stop();

                // Resultados
                textBox2.Text = resultado.ToString();
                textBox3.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                textBox4.Text = $"{numOperaciones}";
            }
            catch (FormatException)
            {
                // Mensajes de error en caso de formato inválido
                MessageBox.Show("Ingresa un número válido.");
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
        //Proceso de resolucion de la torres de Hano
        private void ResolverTorresDeHanoi(int n, char origen, char destino, char auxiliar, StringBuilder resultado)
        {
            if (n == 1)
            {
                numOperaciones++;
                // Línea de comienzo
                resultado.AppendLine($"Mover disco 1 de {origen} a {destino}, ");
                return;
            }
            //Movimiento de las torres, variando del numero n
            ResolverTorresDeHanoi(n - 1, origen, auxiliar, destino, resultado);
            numOperaciones++;
            resultado.AppendLine($"Mover disco {n} de {origen} a {destino}, ");
            ResolverTorresDeHanoi(n - 1, auxiliar, destino, origen, resultado);
        }
    }
}
