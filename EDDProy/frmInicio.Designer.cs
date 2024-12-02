
namespace EDDemo
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasCircularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasCircularesSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasCircularesDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialDeUnNúmeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoDeUnExponenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumarElementosDeArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuenciaDeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torreDeHanoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recursividadToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem,
            this.listasCircularesToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasSimplesToolStripMenuItem,
            this.listasDoblesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.listasToolStripMenuItem.Text = "Listas";
            this.listasToolStripMenuItem.Click += new System.EventHandler(this.listasToolStripMenuItem_Click);
            // 
            // listasSimplesToolStripMenuItem
            // 
            this.listasSimplesToolStripMenuItem.Name = "listasSimplesToolStripMenuItem";
            this.listasSimplesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listasSimplesToolStripMenuItem.Text = "Listas simples";
            this.listasSimplesToolStripMenuItem.Click += new System.EventHandler(this.listasSimplesToolStripMenuItem_Click);
            // 
            // listasDoblesToolStripMenuItem
            // 
            this.listasDoblesToolStripMenuItem.Name = "listasDoblesToolStripMenuItem";
            this.listasDoblesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listasDoblesToolStripMenuItem.Text = "Listas dobles";
            this.listasDoblesToolStripMenuItem.Click += new System.EventHandler(this.listasDoblesToolStripMenuItem_Click);
            // 
            // listasCircularesToolStripMenuItem
            // 
            this.listasCircularesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasCircularesSimplesToolStripMenuItem,
            this.listasCircularesDoblesToolStripMenuItem});
            this.listasCircularesToolStripMenuItem.Name = "listasCircularesToolStripMenuItem";
            this.listasCircularesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.listasCircularesToolStripMenuItem.Text = "Listas circulares";
            // 
            // listasCircularesSimplesToolStripMenuItem
            // 
            this.listasCircularesSimplesToolStripMenuItem.Name = "listasCircularesSimplesToolStripMenuItem";
            this.listasCircularesSimplesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.listasCircularesSimplesToolStripMenuItem.Text = "Listas circulares simples";
            this.listasCircularesSimplesToolStripMenuItem.Click += new System.EventHandler(this.listasCircularesSimplesToolStripMenuItem_Click);
            // 
            // listasCircularesDoblesToolStripMenuItem
            // 
            this.listasCircularesDoblesToolStripMenuItem.Name = "listasCircularesDoblesToolStripMenuItem";
            this.listasCircularesDoblesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.listasCircularesDoblesToolStripMenuItem.Text = "Listas circulares dobles";
            this.listasCircularesDoblesToolStripMenuItem.Click += new System.EventHandler(this.listasCircularesDoblesToolStripMenuItem_Click);
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no lineales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // recursividadToolStripMenuItem
            // 
            this.recursividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factorialDeUnNúmeroToolStripMenuItem,
            this.cálculoDeUnExponenteToolStripMenuItem,
            this.sumarElementosDeArregloToolStripMenuItem,
            this.secuenciaDeFibonacciToolStripMenuItem,
            this.búsquedaBinariaToolStripMenuItem,
            this.torreDeHanoiToolStripMenuItem});
            this.recursividadToolStripMenuItem.Name = "recursividadToolStripMenuItem";
            this.recursividadToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.recursividadToolStripMenuItem.Text = "Recursividad";
            // 
            // factorialDeUnNúmeroToolStripMenuItem
            // 
            this.factorialDeUnNúmeroToolStripMenuItem.Name = "factorialDeUnNúmeroToolStripMenuItem";
            this.factorialDeUnNúmeroToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.factorialDeUnNúmeroToolStripMenuItem.Text = "Factorial de un número";
            this.factorialDeUnNúmeroToolStripMenuItem.Click += new System.EventHandler(this.factorialDeUnNúmeroToolStripMenuItem_Click);
            // 
            // cálculoDeUnExponenteToolStripMenuItem
            // 
            this.cálculoDeUnExponenteToolStripMenuItem.Name = "cálculoDeUnExponenteToolStripMenuItem";
            this.cálculoDeUnExponenteToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cálculoDeUnExponenteToolStripMenuItem.Text = "Cálculo de un exponente";
            this.cálculoDeUnExponenteToolStripMenuItem.Click += new System.EventHandler(this.cálculoDeUnExponenteToolStripMenuItem_Click);
            // 
            // sumarElementosDeArregloToolStripMenuItem
            // 
            this.sumarElementosDeArregloToolStripMenuItem.Name = "sumarElementosDeArregloToolStripMenuItem";
            this.sumarElementosDeArregloToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sumarElementosDeArregloToolStripMenuItem.Text = "Sumar elementos de arreglo";
            this.sumarElementosDeArregloToolStripMenuItem.Click += new System.EventHandler(this.sumarElementosDeArregloToolStripMenuItem_Click);
            // 
            // secuenciaDeFibonacciToolStripMenuItem
            // 
            this.secuenciaDeFibonacciToolStripMenuItem.Name = "secuenciaDeFibonacciToolStripMenuItem";
            this.secuenciaDeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.secuenciaDeFibonacciToolStripMenuItem.Text = "Secuencia de Fibonacci";
            this.secuenciaDeFibonacciToolStripMenuItem.Click += new System.EventHandler(this.secuenciaDeFibonacciToolStripMenuItem_Click);
            // 
            // búsquedaBinariaToolStripMenuItem
            // 
            this.búsquedaBinariaToolStripMenuItem.Name = "búsquedaBinariaToolStripMenuItem";
            this.búsquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.búsquedaBinariaToolStripMenuItem.Text = "Búsqueda binaria";
            this.búsquedaBinariaToolStripMenuItem.Click += new System.EventHandler(this.búsquedaBinariaToolStripMenuItem_Click);
            // 
            // torreDeHanoiToolStripMenuItem
            // 
            this.torreDeHanoiToolStripMenuItem.Name = "torreDeHanoiToolStripMenuItem";
            this.torreDeHanoiToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.torreDeHanoiToolStripMenuItem.Text = "Torre de Hanoi";
            this.torreDeHanoiToolStripMenuItem.Click += new System.EventHandler(this.torreDeHanoiToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasDoblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasCircularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasCircularesSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasCircularesDoblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialDeUnNúmeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculoDeUnExponenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumarElementosDeArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuenciaDeFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torreDeHanoiToolStripMenuItem;
    }
}

