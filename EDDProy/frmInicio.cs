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
    }
}
