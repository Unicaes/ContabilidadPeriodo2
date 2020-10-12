namespace ProyectoContabilidad.View
{
    partial class Balance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuma1 = new System.Windows.Forms.Label();
            this.lblSuma2 = new System.Windows.Forms.Label();
            this.lblSuma3 = new System.Windows.Forms.Label();
            this.lblSuma4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUMAS IGUALES";
            // 
            // lblSuma1
            // 
            this.lblSuma1.AutoSize = true;
            this.lblSuma1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma1.Location = new System.Drawing.Point(581, 488);
            this.lblSuma1.Name = "lblSuma1";
            this.lblSuma1.Size = new System.Drawing.Size(63, 22);
            this.lblSuma1.TabIndex = 2;
            this.lblSuma1.Text = "Suma1";
            // 
            // lblSuma2
            // 
            this.lblSuma2.AutoSize = true;
            this.lblSuma2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma2.Location = new System.Drawing.Point(650, 488);
            this.lblSuma2.Name = "lblSuma2";
            this.lblSuma2.Size = new System.Drawing.Size(63, 22);
            this.lblSuma2.TabIndex = 3;
            this.lblSuma2.Text = "Suma2";
            // 
            // lblSuma3
            // 
            this.lblSuma3.AutoSize = true;
            this.lblSuma3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma3.Location = new System.Drawing.Point(719, 488);
            this.lblSuma3.Name = "lblSuma3";
            this.lblSuma3.Size = new System.Drawing.Size(63, 22);
            this.lblSuma3.TabIndex = 4;
            this.lblSuma3.Text = "Suma3";
            // 
            // lblSuma4
            // 
            this.lblSuma4.AutoSize = true;
            this.lblSuma4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma4.Location = new System.Drawing.Point(788, 490);
            this.lblSuma4.Name = "lblSuma4";
            this.lblSuma4.Size = new System.Drawing.Size(63, 22);
            this.lblSuma4.TabIndex = 5;
            this.lblSuma4.Text = "Suma4";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 648);
            this.Controls.Add(this.lblSuma4);
            this.Controls.Add(this.lblSuma3);
            this.Controls.Add(this.lblSuma2);
            this.Controls.Add(this.lblSuma1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuma1;
        private System.Windows.Forms.Label lblSuma2;
        private System.Windows.Forms.Label lblSuma3;
        private System.Windows.Forms.Label lblSuma4;
    }
}