namespace EDDemo.Estructuras_Lineales
{
    partial class frmListasCircularesDobles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListasCircularesDobles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.cmbInsertar = new System.Windows.Forms.ComboBox();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 77);
            this.panel2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estructuras lineales";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(303, 221);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(50, 20);
            this.txtTotal.TabIndex = 53;
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.SystemColors.Info;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVaciar.Location = new System.Drawing.Point(465, 403);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(130, 30);
            this.btnVaciar.TabIndex = 52;
            this.btnVaciar.Text = "Vaciar lista";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBuscar.Location = new System.Drawing.Point(673, 341);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 30);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEliminar.Location = new System.Drawing.Point(805, 290);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 30);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnInsertar.Location = new System.Drawing.Point(924, 238);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 30);
            this.btnInsertar.TabIndex = 49;
            this.btnInsertar.Text = "Añadir";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // cmbInsertar
            // 
            this.cmbInsertar.FormattingEnabled = true;
            this.cmbInsertar.Location = new System.Drawing.Point(805, 247);
            this.cmbInsertar.Name = "cmbInsertar";
            this.cmbInsertar.Size = new System.Drawing.Size(100, 21);
            this.cmbInsertar.TabIndex = 48;
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(678, 299);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(100, 21);
            this.cmbEliminar.TabIndex = 47;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(678, 248);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtPosicion.TabIndex = 46;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(483, 351);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(478, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Elementos a buscar";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(482, 300);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(477, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Posición a eliminar";
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(482, 249);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(100, 20);
            this.txtInsertar.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(477, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Elementos a añadir";
            // 
            // txtLista
            // 
            this.txtLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLista.Location = new System.Drawing.Point(113, 248);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(240, 40);
            this.txtLista.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(109, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Lista de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(109, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1122, 72);
            this.label2.TabIndex = 37;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label7.Location = new System.Drawing.Point(106, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 37);
            this.label7.TabIndex = 36;
            this.label7.Text = "Listas circulares dobles";
            // 
            // frmListasCircularesDobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cmbInsertar);
            this.Controls.Add(this.cmbEliminar);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmListasCircularesDobles";
            this.Text = "frmListasCircularesDobles";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ComboBox cmbInsertar;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}