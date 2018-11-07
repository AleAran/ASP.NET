namespace ClienteServicio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnSumaSinc = new System.Windows.Forms.Button();
            this.btnSumaAsinc = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.btnRestar = new System.Windows.Forms.Button();
            this.lblResta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(75, 57);
            this.lblNumero1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(106, 20);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "NUMERO 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO 2:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(218, 53);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(164, 26);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(218, 126);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(164, 26);
            this.txtNumero2.TabIndex = 3;
            // 
            // btnSumaSinc
            // 
            this.btnSumaSinc.Location = new System.Drawing.Point(2, 209);
            this.btnSumaSinc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSumaSinc.Name = "btnSumaSinc";
            this.btnSumaSinc.Size = new System.Drawing.Size(203, 35);
            this.btnSumaSinc.TabIndex = 4;
            this.btnSumaSinc.Text = "SUMA SINCRONICA";
            this.btnSumaSinc.UseVisualStyleBackColor = true;
            this.btnSumaSinc.Click += new System.EventHandler(this.btnSumaSinc_Click);
            // 
            // btnSumaAsinc
            // 
            this.btnSumaAsinc.Location = new System.Drawing.Point(215, 208);
            this.btnSumaAsinc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSumaAsinc.Name = "btnSumaAsinc";
            this.btnSumaAsinc.Size = new System.Drawing.Size(207, 35);
            this.btnSumaAsinc.TabIndex = 5;
            this.btnSumaAsinc.Text = "SUMA ASINCRONICA";
            this.btnSumaAsinc.UseVisualStyleBackColor = true;
            this.btnSumaAsinc.Click += new System.EventHandler(this.btnSumaAsinc_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(467, 209);
            this.lblSuma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(57, 20);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "label3";
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(80, 309);
            this.btnRestar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(125, 35);
            this.btnRestar.TabIndex = 7;
            this.btnRestar.Text = "RESTAR";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(260, 309);
            this.lblResta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(57, 20);
            this.lblResta.TabIndex = 8;
            this.lblResta.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnSumaAsinc);
            this.Controls.Add(this.btnSumaSinc);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumero1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnSumaSinc;
        private System.Windows.Forms.Button btnSumaAsinc;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Label lblResta;
    }
}

