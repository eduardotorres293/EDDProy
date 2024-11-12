namespace EDDemo.Estructuras_Lineales
{
    partial class frmColas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.lblPeek = new System.Windows.Forms.Label();
            this.txtPeek = new System.Windows.Forms.TextBox();
            this.lblCola = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.Location = new System.Drawing.Point(107, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estructuras lineales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 77);
            this.panel2.TabIndex = 23;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(304, 229);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(50, 20);
            this.txtTotal.TabIndex = 48;
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.SystemColors.Info;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVaciar.Location = new System.Drawing.Point(655, 426);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(130, 30);
            this.btnVaciar.TabIndex = 47;
            this.btnVaciar.Text = "Vaciar cola";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // lblPeek
            // 
            this.lblPeek.AutoSize = true;
            this.lblPeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPeek.Location = new System.Drawing.Point(503, 332);
            this.lblPeek.Name = "lblPeek";
            this.lblPeek.Size = new System.Drawing.Size(53, 24);
            this.lblPeek.TabIndex = 46;
            this.lblPeek.Text = "Peek";
            // 
            // txtPeek
            // 
            this.txtPeek.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPeek.Location = new System.Drawing.Point(507, 359);
            this.txtPeek.Name = "txtPeek";
            this.txtPeek.ReadOnly = true;
            this.txtPeek.Size = new System.Drawing.Size(100, 20);
            this.txtPeek.TabIndex = 45;
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCola.Location = new System.Drawing.Point(110, 229);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(168, 24);
            this.lblCola.TabIndex = 44;
            this.lblCola.Text = "Cola de elementos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(110, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1117, 72);
            this.label3.TabIndex = 43;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnPeek
            // 
            this.btnPeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPeek.Location = new System.Drawing.Point(668, 351);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(105, 30);
            this.btnPeek.TabIndex = 42;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDequeue.Location = new System.Drawing.Point(668, 304);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(105, 30);
            this.btnDequeue.TabIndex = 41;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnQueue.Location = new System.Drawing.Point(668, 256);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(105, 30);
            this.btnQueue.TabIndex = 40;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblValor.Location = new System.Drawing.Point(503, 229);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 24);
            this.lblValor.TabIndex = 39;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(507, 256);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 38;
            // 
            // txtCola
            // 
            this.txtCola.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCola.Location = new System.Drawing.Point(114, 256);
            this.txtCola.Multiline = true;
            this.txtCola.Name = "txtCola";
            this.txtCola.ReadOnly = true;
            this.txtCola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCola.Size = new System.Drawing.Size(240, 40);
            this.txtCola.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.Location = new System.Drawing.Point(106, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 37);
            this.label6.TabIndex = 36;
            this.label6.Text = "Colas";
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.lblPeek);
            this.Controls.Add(this.txtPeek);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmColas";
            this.Text = "frmColas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label lblPeek;
        private System.Windows.Forms.TextBox txtPeek;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Label label6;
    }
}