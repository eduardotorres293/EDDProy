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

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class frmRadix : Form
    {
        public frmRadix()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txtCantidad1.Text, out cantidad) && cantidad > 0)
            {
                Random random = new Random();
                string listaTexto = "";

                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 100);

                    if (i > 0)
                    {
                        listaTexto += ", ";
                    }

                    listaTexto += numero.ToString();
                }

                txtLista.Text = listaTexto;
            }
            else
            {
                MessageBox.Show("Ingresa un número");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Convertimos el texto de txtLista a un arreglo de enteros
            string[] numerosTexto = txtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);
            int[] numeros = new int[numerosTexto.Length];

            // Llenamos el arreglo con los valores de la lista
            for (int i = 0; i < numerosTexto.Length; i++)
            {
                if (int.TryParse(numerosTexto[i], out int numero))
                {
                    numeros[i] = numero;
                }
                else
                {
                    MessageBox.Show("Inserta un elemento válido");
                    return;
                }
            }

            // Usamos un cronómetro para medir el tiempo de ejecución
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Llamamos al algoritmo Radix Sort para ordenar el arreglo
            Radix.FuncionRadix(numeros);

            stopwatch.Stop();

            // Mostramos el arreglo ordenado en txtOrdenado
            txtOrdenado.Text = string.Join(", ", numeros);

            // Mostramos el tiempo de ejecución en el TextBox txtTiempo
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }
}
