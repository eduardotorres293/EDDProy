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
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_ordenamiento;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class frmQuicksort : Form
    {
        public frmQuicksort()
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
                    int numero = random.Next(1, 10000);

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
            string[] numerosTexto = txtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);
            int[] numeros = new int[numerosTexto.Length];

            for (int i = 0; i < numerosTexto.Length; i++)
            {
                if (int.TryParse(numerosTexto[i], out int num))
                {
                    numeros[i] = num;
                }
                else
                {
                    MessageBox.Show("Inserta un elemento válido");
                    return;
                }
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Quicksort.FuncionQuicksort(numeros, 0, numeros.Length - 1);

            stopwatch.Stop();

            txtOrdenado.Text = string.Join(", ", numeros);

            // Aquí se mide en ticks, ya que los milisegundos es una escala grande para esto
            // Siempre marca 0 cuando se usan milisegundos
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }
}
