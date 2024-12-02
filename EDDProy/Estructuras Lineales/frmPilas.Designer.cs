
namespace EDDemo
{
    partial class frmPilas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPilas));
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPila = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(303, 252);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.ReadOnly = true;
            this.txtCounter.Size = new System.Drawing.Size(50, 20);
            this.txtCounter.TabIndex = 19;
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.SystemColors.Info;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVaciar.Location = new System.Drawing.Point(648, 387);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(130, 30);
            this.btnVaciar.TabIndex = 18;
            this.btnVaciar.Text = "Vaciar pila";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnPop
            // 
            this.btnPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPop.Location = new System.Drawing.Point(663, 321);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(105, 30);
            this.btnPop.TabIndex = 17;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPush
            // 
            this.btnPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPush.Location = new System.Drawing.Point(663, 269);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(105, 30);
            this.btnPush.TabIndex = 16;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(508, 279);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(504, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Valor";
            // 
            // txtPila
            // 
            this.txtPila.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPila.Location = new System.Drawing.Point(113, 279);
            this.txtPila.Multiline = true;
            this.txtPila.Name = "txtPila";
            this.txtPila.ReadOnly = true;
            this.txtPila.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPila.Size = new System.Drawing.Size(240, 40);
            this.txtPila.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(109, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pila de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(109, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1051, 96);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(106, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pilas";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 77);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 681);
            this.panel1.TabIndex = 20;
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}