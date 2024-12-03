namespace EDDemo.Metodos_de_ordenamiento
{
    partial class frmIntercalacion
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
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.txtArchivo1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnGenerar2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.txtIntercalado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIntercalar = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodos de ordenamiento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 77);
            this.panel2.TabIndex = 18;
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(113, 117);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad1.TabIndex = 19;
            // 
            // txtArchivo1
            // 
            this.txtArchivo1.Location = new System.Drawing.Point(113, 173);
            this.txtArchivo1.Name = "txtArchivo1";
            this.txtArchivo1.Size = new System.Drawing.Size(360, 20);
            this.txtArchivo1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(109, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Archivo 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(109, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad a generar";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(178, 116);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(101, 20);
            this.btnGenerar.TabIndex = 23;
            this.btnGenerar.Text = "Generar archivo";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnGenerar2
            // 
            this.btnGenerar2.Location = new System.Drawing.Point(178, 278);
            this.btnGenerar2.Name = "btnGenerar2";
            this.btnGenerar2.Size = new System.Drawing.Size(101, 20);
            this.btnGenerar2.TabIndex = 28;
            this.btnGenerar2.Text = "Generar archivo";
            this.btnGenerar2.UseVisualStyleBackColor = true;
            this.btnGenerar2.Click += new System.EventHandler(this.btnGenerar2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(109, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cantidad a generar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(109, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Archivo 2";
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Location = new System.Drawing.Point(113, 335);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.Size = new System.Drawing.Size(360, 20);
            this.txtArchivo2.TabIndex = 25;
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Location = new System.Drawing.Point(113, 279);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad2.TabIndex = 24;
            // 
            // txtIntercalado
            // 
            this.txtIntercalado.Location = new System.Drawing.Point(607, 216);
            this.txtIntercalado.Name = "txtIntercalado";
            this.txtIntercalado.Size = new System.Drawing.Size(360, 20);
            this.txtIntercalado.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(603, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Archivo intercalado";
            // 
            // btnIntercalar
            // 
            this.btnIntercalar.Location = new System.Drawing.Point(780, 193);
            this.btnIntercalar.Name = "btnIntercalar";
            this.btnIntercalar.Size = new System.Drawing.Size(101, 20);
            this.btnIntercalar.TabIndex = 31;
            this.btnIntercalar.Text = "Intercalar";
            this.btnIntercalar.UseVisualStyleBackColor = true;
            this.btnIntercalar.Click += new System.EventHandler(this.btnIntercalar_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(607, 279);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 32;
            // 
            // frmIntercalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.btnIntercalar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIntercalado);
            this.Controls.Add(this.btnGenerar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtArchivo2);
            this.Controls.Add(this.txtCantidad2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArchivo1);
            this.Controls.Add(this.txtCantidad1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmIntercalacion";
            this.Text = "frmIntercalacion";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.TextBox txtArchivo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnGenerar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.TextBox txtIntercalado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIntercalar;
        private System.Windows.Forms.TextBox txtTiempo;
    }
}