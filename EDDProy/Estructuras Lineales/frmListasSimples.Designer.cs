namespace EDDemo.Estructuras_Lineales
{
    partial class frmListasSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListasSimples));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.cmbInsertar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.lblInsertar = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.Location = new System.Drawing.Point(469, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "Estructuras no lineales";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 681);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 77);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estructuras lineales";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(303, 226);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(50, 20);
            this.txtTotal.TabIndex = 42;
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.SystemColors.Info;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVaciar.Location = new System.Drawing.Point(459, 395);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(130, 30);
            this.btnVaciar.TabIndex = 41;
            this.btnVaciar.Text = "Vaciar lista";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPosicion.Location = new System.Drawing.Point(673, 222);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(82, 24);
            this.lblPosicion.TabIndex = 40;
            this.lblPosicion.Text = "Posición";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(677, 249);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtPosicion.TabIndex = 39;
            // 
            // cmbInsertar
            // 
            this.cmbInsertar.FormattingEnabled = true;
            this.cmbInsertar.Location = new System.Drawing.Point(805, 249);
            this.cmbInsertar.Name = "cmbInsertar";
            this.cmbInsertar.Size = new System.Drawing.Size(105, 21);
            this.cmbInsertar.TabIndex = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEliminar.Location = new System.Drawing.Point(806, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 30);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(677, 301);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(105, 21);
            this.cmbEliminar.TabIndex = 36;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBuscar.Location = new System.Drawing.Point(677, 343);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 30);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(471, 351);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 34;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBuscar.Location = new System.Drawing.Point(467, 324);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(168, 24);
            this.lblBuscar.TabIndex = 33;
            this.lblBuscar.Text = "Elemento a buscar";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnInsertar.Location = new System.Drawing.Point(934, 241);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 30);
            this.btnInsertar.TabIndex = 32;
            this.btnInsertar.Text = "Añadir";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(471, 301);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 31;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEliminar.Location = new System.Drawing.Point(467, 274);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(168, 24);
            this.lblEliminar.TabIndex = 30;
            this.lblEliminar.Text = "Posición a eliminar";
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(471, 251);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(100, 20);
            this.txtInsertar.TabIndex = 29;
            // 
            // lblInsertar
            // 
            this.lblInsertar.AutoSize = true;
            this.lblInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblInsertar.Location = new System.Drawing.Point(467, 224);
            this.lblInsertar.Name = "lblInsertar";
            this.lblInsertar.Size = new System.Drawing.Size(163, 24);
            this.lblInsertar.TabIndex = 28;
            this.lblInsertar.Text = "Elemento a añadir";
            // 
            // txtLista
            // 
            this.txtLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLista.Location = new System.Drawing.Point(113, 251);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(240, 40);
            this.txtLista.TabIndex = 27;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLista.Location = new System.Drawing.Point(109, 224);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(167, 24);
            this.lblLista.TabIndex = 26;
            this.lblLista.Text = "Lista de elementos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(109, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1105, 72);
            this.label8.TabIndex = 25;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label9.Location = new System.Drawing.Point(106, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 37);
            this.label9.TabIndex = 24;
            this.label9.Text = "Listas simples";
            // 
            // frmListasSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.cmbInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.lblInsertar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "frmListasSimples";
            this.Text = "frmListasSimples";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.ComboBox cmbInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.Label lblInsertar;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}