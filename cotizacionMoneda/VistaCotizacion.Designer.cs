namespace cotizacionMoneda
{
    partial class VistaCotizacion
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
            this.components = new System.ComponentModel.Container();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.rbtnCompra = new System.Windows.Forms.RadioButton();
            this.rbtnVenta = new System.Windows.Forms.RadioButton();
            this.lbxMonedas = new System.Windows.Forms.ListBox();
            this.monedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblConversion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monedaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(188, 168);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el monto en pesos:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(188, 24);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // rbtnCompra
            // 
            this.rbtnCompra.AutoSize = true;
            this.rbtnCompra.Location = new System.Drawing.Point(51, 64);
            this.rbtnCompra.Name = "rbtnCompra";
            this.rbtnCompra.Size = new System.Drawing.Size(85, 17);
            this.rbtnCompra.TabIndex = 3;
            this.rbtnCompra.TabStop = true;
            this.rbtnCompra.Text = "radioButton1";
            this.rbtnCompra.UseVisualStyleBackColor = true;
            // 
            // rbtnVenta
            // 
            this.rbtnVenta.AutoSize = true;
            this.rbtnVenta.Location = new System.Drawing.Point(188, 64);
            this.rbtnVenta.Name = "rbtnVenta";
            this.rbtnVenta.Size = new System.Drawing.Size(85, 17);
            this.rbtnVenta.TabIndex = 4;
            this.rbtnVenta.TabStop = true;
            this.rbtnVenta.Text = "radioButton2";
            this.rbtnVenta.UseVisualStyleBackColor = true;
            // 
            // lbxMonedas
            // 
            this.lbxMonedas.DataSource = this.monedaBindingSource;
            this.lbxMonedas.DisplayMember = "Tipo";
            this.lbxMonedas.FormattingEnabled = true;
            this.lbxMonedas.Location = new System.Drawing.Point(51, 96);
            this.lbxMonedas.Name = "lbxMonedas";
            this.lbxMonedas.Size = new System.Drawing.Size(120, 95);
            this.lbxMonedas.TabIndex = 5;
            this.lbxMonedas.ValueMember = "Simbolo";
            // 
            // monedaBindingSource
            // 
            this.monedaBindingSource.DataSource = typeof(cotizacionMoneda.Moneda);
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Location = new System.Drawing.Point(48, 211);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(10, 13);
            this.lblConversion.TabIndex = 6;
            this.lblConversion.Text = "-";
            // 
            // VistaCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 284);
            this.Controls.Add(this.lblConversion);
            this.Controls.Add(this.lbxMonedas);
            this.Controls.Add(this.rbtnVenta);
            this.Controls.Add(this.rbtnCompra);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "VistaCotizacion";
            this.Text = "Cotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.monedaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.RadioButton rbtnCompra;
        private System.Windows.Forms.RadioButton rbtnVenta;
        private System.Windows.Forms.ListBox lbxMonedas;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.BindingSource monedaBindingSource;
    }
}

