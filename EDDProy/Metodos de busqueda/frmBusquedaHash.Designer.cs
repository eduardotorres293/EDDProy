namespace EDDemo.Metodos_de_busqueda
{
    partial class frmBusquedaHash
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.btnHashing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHashing = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncontrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodos de busqueda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 77);
            this.panel2.TabIndex = 62;
            // 
            // txtLista
            // 
            this.txtLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLista.Location = new System.Drawing.Point(113, 184);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(257, 460);
            this.txtLista.TabIndex = 63;
            // 
            // btnHashing
            // 
            this.btnHashing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHashing.Location = new System.Drawing.Point(216, 138);
            this.btnHashing.Name = "btnHashing";
            this.btnHashing.Size = new System.Drawing.Size(154, 29);
            this.btnHashing.TabIndex = 64;
            this.btnHashing.Text = "Generar codigo hash";
            this.btnHashing.UseVisualStyleBackColor = true;
            this.btnHashing.Click += new System.EventHandler(this.btnHashing_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(109, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Elemento para hashing";
            // 
            // txtHashing
            // 
            this.txtHashing.Location = new System.Drawing.Point(113, 112);
            this.txtHashing.Name = "txtHashing";
            this.txtHashing.Size = new System.Drawing.Size(254, 20);
            this.txtHashing.TabIndex = 66;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(752, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(154, 29);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar clave hash";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(650, 112);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(96, 20);
            this.txtBuscar.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(646, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Buscar elemento de hashing";
            // 
            // txtEncontrado
            // 
            this.txtEncontrado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEncontrado.Location = new System.Drawing.Point(650, 184);
            this.txtEncontrado.Name = "txtEncontrado";
            this.txtEncontrado.ReadOnly = true;
            this.txtEncontrado.Size = new System.Drawing.Size(256, 20);
            this.txtEncontrado.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(646, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Elemento encontrado";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(277, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "Vaciar lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTiempo.Location = new System.Drawing.Point(650, 300);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(646, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Tiempo";
            // 
            // frmBusquedaHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEncontrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtHashing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHashing);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmBusquedaHash";
            this.Text = "frmBusquedaHash";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button btnHashing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHashing;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncontrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label5;
    }
}