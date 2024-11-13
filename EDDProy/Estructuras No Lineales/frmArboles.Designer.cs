
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnPodar = new System.Windows.Forms.Button();
            this.lblRecorridoNiveles = new System.Windows.Forms.Label();
            this.lblNiveles = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblNumNodos = new System.Windows.Forms.Label();
            this.txtNumNodos = new System.Windows.Forms.TextBox();
            this.lblHojas = new System.Windows.Forms.Label();
            this.txtHojas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarScsr = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarPrdcsr = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(214, 128);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(276, 128);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(113, 292);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ReadOnly = true;
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(1123, 389);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpiar.Location = new System.Drawing.Point(1144, 90);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 24);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Vaciar árbol";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrafica.Location = new System.Drawing.Point(1144, 118);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(109, 24);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Gráficar árbol";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRecorrer.Location = new System.Drawing.Point(296, 202);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(81, 32);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDatos.Location = new System.Drawing.Point(104, 132);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(109, 17);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Valor a insertar:";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCrearArbol.Location = new System.Drawing.Point(898, 117);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 29);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(834, 120);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPostOrden.Location = new System.Drawing.Point(386, 222);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(80, 17);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(491, 222);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(138, 17);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "Recorrido postorden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInOrden.Location = new System.Drawing.Point(403, 197);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(63, 17);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreOrden.Location = new System.Drawing.Point(394, 175);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(74, 17);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(490, 197);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(122, 17);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "Recorrido inorden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.BackColor = System.Drawing.SystemColors.Control;
            this.lblRecorridoPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(491, 175);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(132, 17);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "Recorrido preorden";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 77);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estructuras no lineales";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 681);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(698, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Generación aleatoria de árboles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(699, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cantidad de nodos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(104, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Generación por nodos de árboles";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnBuscar.Location = new System.Drawing.Point(1006, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 24);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1069, 93);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(50, 20);
            this.txtBuscar.TabIndex = 21;
            // 
            // btnPodar
            // 
            this.btnPodar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPodar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPodar.Location = new System.Drawing.Point(1144, 146);
            this.btnPodar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(109, 24);
            this.btnPodar.TabIndex = 22;
            this.btnPodar.Text = "Podar árbol";
            this.btnPodar.UseVisualStyleBackColor = true;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // lblRecorridoNiveles
            // 
            this.lblRecorridoNiveles.AutoSize = true;
            this.lblRecorridoNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecorridoNiveles.Location = new System.Drawing.Point(491, 247);
            this.lblRecorridoNiveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoNiveles.Name = "lblRecorridoNiveles";
            this.lblRecorridoNiveles.Size = new System.Drawing.Size(143, 17);
            this.lblRecorridoNiveles.TabIndex = 24;
            this.lblRecorridoNiveles.Text = "Recorrido por niveles";
            // 
            // lblNiveles
            // 
            this.lblNiveles.AutoSize = true;
            this.lblNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNiveles.Location = new System.Drawing.Point(386, 247);
            this.lblNiveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(82, 17);
            this.lblNiveles.TabIndex = 23;
            this.lblNiveles.Text = "Por niveles:";
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAltura.Location = new System.Drawing.Point(203, 181);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.ReadOnly = true;
            this.txtAltura.Size = new System.Drawing.Size(50, 20);
            this.txtAltura.TabIndex = 25;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAltura.Location = new System.Drawing.Point(113, 184);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 17);
            this.lblAltura.TabIndex = 26;
            this.lblAltura.Text = "Altura:";
            // 
            // lblNumNodos
            // 
            this.lblNumNodos.AutoSize = true;
            this.lblNumNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumNodos.Location = new System.Drawing.Point(113, 210);
            this.lblNumNodos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumNodos.Name = "lblNumNodos";
            this.lblNumNodos.Size = new System.Drawing.Size(90, 17);
            this.lblNumNodos.TabIndex = 28;
            this.lblNumNodos.Text = "Num. Nodos:";
            // 
            // txtNumNodos
            // 
            this.txtNumNodos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNumNodos.Location = new System.Drawing.Point(203, 210);
            this.txtNumNodos.Name = "txtNumNodos";
            this.txtNumNodos.ReadOnly = true;
            this.txtNumNodos.Size = new System.Drawing.Size(50, 20);
            this.txtNumNodos.TabIndex = 27;
            // 
            // lblHojas
            // 
            this.lblHojas.AutoSize = true;
            this.lblHojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHojas.Location = new System.Drawing.Point(113, 239);
            this.lblHojas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHojas.Name = "lblHojas";
            this.lblHojas.Size = new System.Drawing.Size(85, 17);
            this.lblHojas.TabIndex = 30;
            this.lblHojas.Text = "Num. Hojas:";
            // 
            // txtHojas
            // 
            this.txtHojas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHojas.Location = new System.Drawing.Point(203, 239);
            this.txtHojas.Name = "txtHojas";
            this.txtHojas.ReadOnly = true;
            this.txtHojas.Size = new System.Drawing.Size(50, 20);
            this.txtHojas.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(383, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Valor a eliminar:";
            // 
            // btnEliminarScsr
            // 
            this.btnEliminarScsr.Location = new System.Drawing.Point(550, 115);
            this.btnEliminarScsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarScsr.Name = "btnEliminarScsr";
            this.btnEliminarScsr.Size = new System.Drawing.Size(116, 24);
            this.btnEliminarScsr.TabIndex = 32;
            this.btnEliminarScsr.Text = "Eliminar sucesor";
            this.btnEliminarScsr.UseVisualStyleBackColor = true;
            this.btnEliminarScsr.Click += new System.EventHandler(this.btnEliminarScsr_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(493, 128);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.txtEliminar.Multiline = true;
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(52, 26);
            this.txtEliminar.TabIndex = 31;
            // 
            // btnEliminarPrdcsr
            // 
            this.btnEliminarPrdcsr.Location = new System.Drawing.Point(550, 143);
            this.btnEliminarPrdcsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPrdcsr.Name = "btnEliminarPrdcsr";
            this.btnEliminarPrdcsr.Size = new System.Drawing.Size(116, 24);
            this.btnEliminarPrdcsr.TabIndex = 34;
            this.btnEliminarPrdcsr.Text = "Eliminar predecesor";
            this.btnEliminarPrdcsr.UseVisualStyleBackColor = true;
            this.btnEliminarPrdcsr.Click += new System.EventHandler(this.btnEliminarPrdcsr_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerificar.Location = new System.Drawing.Point(113, 264);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(116, 24);
            this.btnVerificar.TabIndex = 35;
            this.btnVerificar.Text = "Verificar árbol";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnEliminarPrdcsr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarScsr);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.lblHojas);
            this.Controls.Add(this.txtHojas);
            this.Controls.Add(this.lblNumNodos);
            this.Controls.Add(this.txtNumNodos);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblRecorridoNiveles);
            this.Controls.Add(this.lblNiveles);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Label lblRecorridoNiveles;
        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblNumNodos;
        private System.Windows.Forms.TextBox txtNumNodos;
        private System.Windows.Forms.Label lblHojas;
        private System.Windows.Forms.TextBox txtHojas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarScsr;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminarPrdcsr;
        private System.Windows.Forms.Button btnVerificar;
    }
}