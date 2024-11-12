using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            // Le añadí un mensaje de error al intentar insertar un numero con 
            // decimal, ya que crasheaba el programa cuando se intentaba insertar uno
            if (int.TryParse(txtDato.Text, out int dato))
            {
                miArbol.InsertaNodo(dato, ref miRaiz);

                //Leer arbol completo y mostrarlo en caja de texto
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
                int altura = miArbol.alturaNiveles(miRaiz);
                txtAltura.Text = altura.ToString();
            }
            else
            {
                MessageBox.Show("Inserte un número entero");
            }

            txtDato.Text = "";
            ActualizarNumNodos();
            ActualizarNumHojas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            lblRecorridoNiveles.Text = "";
            ActualizarNumNodos();
            ActualizarNumHojas();
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;

            //Recorrido por niveles
            //Se obtiene el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if(miRaiz == null)
            {
                lblRecorridoNiveles.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoNiveles.Text = "";
            miArbol.recorridoNiveles();
            lblRecorridoNiveles.Text = miArbol.strRecorrido;

        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();
            bool[] numGen = new bool[101]; // Permite marcar los valores generados, hasta el 100
            // Nota: al igual que se usará despues, el 101 no hace que llegue hasta el 101, sino que
            // es hasta el 100

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato;
                while(true)
                {
                    Dato = rnd.Next(1, 101); // Se genera un numero entre 1 y 100
                    // Se utiliza 101 ya que la propia función limita a un número antes
                    if (!numGen[Dato])
                    {
                        numGen[Dato] = true;
                        break;
                    }
                }

                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtAltura.Text = miArbol.alturaNiveles(miRaiz).ToString(); // Se actualiza la altura
            ActualizarNumNodos();
            ActualizarNumHojas();
            txtDato.Text = "";
        }
        private void ActualizarNumNodos()
        {
            txtNumNodos.Text = miArbol.ObtenerCantidadNodos().ToString();
        }
        private void ActualizarNumHojas()
        {
            txtHojas.Text = miArbol.ObtenerCantidadHojas().ToString();
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se obtiene el nodo raiz
            miRaiz = miArbol.RegresaRaiz();

            // Se verifica primero que el valor insertado sea un número entero
            if (int.TryParse(txtBuscar.Text, out int datoBuscado))
            {
                // found es un objeto que utilice para referise al dato a buscar
                // Le puse found en lugar de elementoBuscado para acortar
                bool found = miArbol.Busqueda(datoBuscado, miRaiz);

                // Se muestra el resultado en un MessageBox
                if (found)
                {
                    MessageBox.Show($"El valor {datoBuscado} si se encuentra en el árbol");
                }
                else
                {
                    MessageBox.Show($"El valor {datoBuscado} NO se encuentra en el árbol.");
                }
            }
            else
            {
                MessageBox.Show("Inserte  un elemento válido");
            }
        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            miArbol.podaArbol();
            txtArbol.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            lblRecorridoNiveles.Text = "";
            ActualizarNumNodos();
            ActualizarNumHojas();
        }

        private void btnEliminarScsr_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            // Verificar que el valor ingresado sea un número entero
            if (int.TryParse(txtEliminar.Text, out int datoEliminar))
            {
                miArbol.eliminarSucesor(datoEliminar, ref miRaiz);

                // Leer el árbol completo y mostrarlo en el cuadro de texto
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                // Actualizar la altura, número de nodos y hojas
                txtAltura.Text = miArbol.alturaNiveles(miRaiz).ToString();
                ActualizarNumNodos();
                ActualizarNumHojas();
            }
            else
            {
                MessageBox.Show("Inserte un elemento válido");
            }

            txtEliminar.Text = "";
        }

        private void btnEliminarPrdcsr_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            // Verificar que el valor ingresado sea un número entero
            if (int.TryParse(txtEliminar.Text, out int datoEliminar))
            {
                miArbol.eliminarPredecesor(datoEliminar, ref miRaiz);

                // Leer el árbol completo y mostrarlo en el cuadro de texto
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                // Actualizar la altura, número de nodos y hojas
                txtAltura.Text = miArbol.alturaNiveles(miRaiz).ToString();
                ActualizarNumNodos();
                ActualizarNumHojas();
            }
            else
            {
                MessageBox.Show("Inserte un elemento válido");
            }

            txtEliminar.Text = "";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Verificar si el árbol es lleno
            bool esArbolLleno = miArbol.esLleno(miRaiz);

            // Verificar si el árbol es completo
            bool esArbolCompleto = miArbol.esCompleto(miRaiz);

            if (esArbolLleno && esArbolCompleto)
            {
                MessageBox.Show("El árbol es completo y lleno.");
            }
            else if (esArbolLleno)
            {
                MessageBox.Show("El árbol es lleno pero no completo.");
            }
            else if (esArbolCompleto)
            {
                MessageBox.Show("El árbol es completo pero no lleno.");
            }
            else
            {
                MessageBox.Show("El árbol no es completo ni lleno.");
            }
        }
    }
}
