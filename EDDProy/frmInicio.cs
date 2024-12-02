using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_No_Lineales;
using Recursividad;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        public void frmInicio_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        public void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        public void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        public void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas mColas = new frmColas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        public void listasSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasSimples mListasSimples = new frmListasSimples();
            mListasSimples.MdiParent = this;
            mListasSimples.Show();
        }

        public void listasDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasDobles mListasDobles = new frmListasDobles();
            mListasDobles.MdiParent = this;
            mListasDobles.Show();
        }

        public void listasCircularesSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasCircularesSimples mListasCircularesSimples = new frmListasCircularesSimples();
            mListasCircularesSimples.MdiParent = this;
            mListasCircularesSimples.Show();
        }

        public void listasCircularesDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasCircularesDobles mListasCircularesDobles = new frmListasCircularesDobles();
            mListasCircularesDobles.MdiParent = this;
            mListasCircularesDobles.Show();
        }

        public void arregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arreglo mArreglo = new Arreglo();
            mArreglo.MdiParent = this;
            mArreglo.Show();
        }

        public void cálculoDeUnExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exponente mExponente = new Exponente();
            mExponente.MdiParent = this;
            mExponente.Show();
        }

        public void sumaDeElementosDeUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arreglo mArreglo = new Arreglo();
            mArreglo.MdiParent = this;
            mArreglo.Show();
        }

        public void secuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci mFibonacci = new Fibonacci();
            mFibonacci.MdiParent = this;
            mFibonacci.Show();
        }

        public void búsquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binario mBinario = new Binario();
            mBinario.MdiParent = this;
            mBinario.Show();
        }

        public void torreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hanoi mHanoi = new Hanoi();
            mHanoi.MdiParent = this;
            mHanoi.Show();
        }
    }
}
