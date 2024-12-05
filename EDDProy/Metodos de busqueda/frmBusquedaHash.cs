using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Metodos_de_busqueda.Clases;

namespace EDDemo.Metodos_de_busqueda
{
    public partial class frmBusquedaHash : Form
    {
        private BusquedaHash.HashTable tablaHash;
        public frmBusquedaHash()
        {
            InitializeComponent();
            tablaHash = new BusquedaHash.HashTable();
        }

        private void btnHashing_Click(object sender, EventArgs e)
        {
            // Se obtiene el input
            string input = txtHashing.Text;

            // Se genera un hash mediante la funcion hash polinomial
            int claveHash = BusquedaHash.HashTable.FuncionHashPolinomial(input, 100);  // Usamos el tamaño de tabla 100

            // Se inserta el valor en la tabla hash
            tablaHash.Insertar(input);

            txtLista.AppendText($"Clave: {claveHash}\r\nElemento: {input}\r\n\r\n");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Se verifica si el valor de la búsqueda (clave) es numérico
            if (int.TryParse(txtBuscar.Text, out int claveBuscada))
            {
                // Se busca el valor asociado a la clave en la tabla hash
                string resultado = tablaHash.Buscar(claveBuscada);

                // Se muestra el resultado de la búsqueda en txtEncontrado
                if (resultado != null)
                {
                    txtEncontrado.Text = $"Elemento: {resultado}";
                }
                else
                {
                    txtEncontrado.Text = $"Elemento: {claveBuscada} no encontrado";
                }
                stopwatch.Stop();

                txtTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            else
            {
                MessageBox.Show("Ingresa un número a buscar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablaHash.LimpiarTabla();
            txtLista.Clear(); 
            txtEncontrado.Clear();
            txtTiempo.Clear();
        }
    }
}
