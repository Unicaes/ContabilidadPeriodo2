namespace ProyectoContabilidad.View
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnMayorizacion = new System.Windows.Forms.Button();
            this.btnLibroDiario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAcerca);
            this.splitContainer1.Panel1.Controls.Add(this.btnBalance);
            this.splitContainer1.Panel1.Controls.Add(this.btnMayorizacion);
            this.splitContainer1.Panel1.Controls.Add(this.btnLibroDiario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1174, 654);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAcerca
            // 
            this.btnAcerca.Location = new System.Drawing.Point(12, 595);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(276, 47);
            this.btnAcerca.TabIndex = 3;
            this.btnAcerca.Text = "Acerca de";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(12, 118);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(276, 47);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "Balance de comprobacion";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnMayorizacion
            // 
            this.btnMayorizacion.Location = new System.Drawing.Point(12, 65);
            this.btnMayorizacion.Name = "btnMayorizacion";
            this.btnMayorizacion.Size = new System.Drawing.Size(276, 47);
            this.btnMayorizacion.TabIndex = 1;
            this.btnMayorizacion.Text = "Mayorizacion";
            this.btnMayorizacion.UseVisualStyleBackColor = true;
            this.btnMayorizacion.Click += new System.EventHandler(this.btnMayorizacion_Click);
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.Location = new System.Drawing.Point(12, 12);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Size = new System.Drawing.Size(276, 47);
            this.btnLibroDiario.TabIndex = 0;
            this.btnLibroDiario.Text = "Libro Diario";
            this.btnLibroDiario.UseVisualStyleBackColor = true;
            this.btnLibroDiario.Click += new System.EventHandler(this.btnLibroDiario_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 648);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 654);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainFor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLibroDiario;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnMayorizacion;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Panel panel1;
    }
}