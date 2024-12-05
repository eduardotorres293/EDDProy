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
using EDDemo.Metodos_de_busqueda.Clases;

namespace EDDemo.Metodos_de_busqueda
{
    public partial class frmBusquedaBinaria : Form
    {
        private List<int> listaNumeros = new List<int>();
        private List<int> listaOriginal = new List<int>();
        public frmBusquedaBinaria()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txtCantidad1.Text, out cantidad) && cantidad > 0)
            {
                Random random = new Random();
                listaNumeros.Clear();
                listaOriginal.Clear();
                string listaTexto = "";

                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 101);
                    listaNumeros.Add(numero);
                    listaOriginal.Add(numero);
                    listaTexto += numero.ToString() + Environment.NewLine;
                }

                listaNumeros = listaNumeros.Distinct().ToList();
                listaNumeros.Sort();

                txtLista.Text = listaTexto;
            }
            else
            {
                MessageBox.Show("Ingresa un número válido");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valorBuscar;
            if (int.TryParse(txtBuscar.Text, out valorBuscar))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int resultado = BusquedaBinaria.FuncionBinaria(listaNumeros.ToArray(), valorBuscar);
                stopwatch.Stop();
                txtTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                if (resultado != -1)
                {
                    int posicionOriginal = listaOriginal.IndexOf(valorBuscar) + 1;

                    MessageBox.Show($"Elemento {valorBuscar} encontrado en las posiciones: {posicionOriginal}");
                }
                else
                {
                    MessageBox.Show("Número no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para buscar");
            }
        }
    }
}
