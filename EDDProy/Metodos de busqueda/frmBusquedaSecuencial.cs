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
    public partial class frmBusquedaSecuencial : Form
    {
        private List<int> listaNumeros = new List<int>();
        private List<int> listaOriginal = new List<int>();
        public frmBusquedaSecuencial()
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

                while (listaNumeros.Count < cantidad)
                {
                    int numero = random.Next(1, 101);
                    if (!listaNumeros.Contains(numero))
                    {
                        listaNumeros.Add(numero);
                        listaOriginal.Add(numero);
                        listaTexto += numero.ToString() + Environment.NewLine;
                    }
                }

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
                Listas listaEnlazada = new Listas();
                foreach (var num in listaOriginal)
                {
                    listaEnlazada.InsertBase(num.ToString());
                }

                string resultado = BusquedaSecuencial.FuncionSecuencial(listaEnlazada, valorBuscar.ToString());
                stopwatch.Stop();
                MessageBox.Show(resultado);
                txtTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para buscar");
            }
        }
    }
}
