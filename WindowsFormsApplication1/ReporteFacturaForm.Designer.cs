namespace WindowsFormsApplication1
{
    partial class ReporteFacturaForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.columnPiezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUpc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.eArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtcuit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eArticuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(489, 290);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPiezas,
            this.columnNumero,
            this.columnUpc,
            this.columnDescripcion,
            this.columnPrecio,
            this.columnImporte});
            this.dgvdetalle.Location = new System.Drawing.Point(23, 146);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.Size = new System.Drawing.Size(643, 112);
            this.dgvdetalle.TabIndex = 1;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(82, 29);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 2;
            this.txtnumero.Text = "A0001-00000456";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Factura";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(36, 290);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtsubtotal.TabIndex = 4;
            this.txtsubtotal.Text = "100";
            // 
            // txtiva
            // 
            this.txtiva.Location = new System.Drawing.Point(142, 290);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(100, 20);
            this.txtiva.TabIndex = 5;
            this.txtiva.Text = "21";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(248, 290);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 6;
            this.txttotal.Text = "121";
            // 
            // columnPiezas
            // 
            this.columnPiezas.HeaderText = "Articulo";
            this.columnPiezas.Name = "columnPiezas";
            // 
            // columnNumero
            // 
            this.columnNumero.HeaderText = "Numero";
            this.columnNumero.Name = "columnNumero";
            // 
            // columnUpc
            // 
            this.columnUpc.HeaderText = "Upc";
            this.columnUpc.Name = "columnUpc";
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.HeaderText = "Descripcion";
            this.columnDescripcion.Name = "columnDescripcion";
            // 
            // columnPrecio
            // 
            this.columnPrecio.HeaderText = "Precio";
            this.columnPrecio.Name = "columnPrecio";
            // 
            // columnImporte
            // 
            this.columnImporte.HeaderText = "Importe";
            this.columnImporte.Name = "columnImporte";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(270, 28);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 7;
            this.txtnombre.Text = "Martin Lopez Jordan";
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(82, 70);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(100, 20);
            this.txtrfc.TabIndex = 8;
            this.txtrfc.Text = "Responsable Inscripto";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(270, 70);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 9;
            this.txtdireccion.Text = "Lopez 964";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(572, 12);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 10;
            // 
            // eArticuloBindingSource
            // 
            this.eArticuloBindingSource.DataSource = typeof(WindowsFormsApplication1.EArticulo);
            // 
            // txtcuit
            // 
            this.txtcuit.Location = new System.Drawing.Point(82, 107);
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(100, 20);
            this.txtcuit.TabIndex = 11;
            this.txtcuit.Text = "20-35644539-3";
            // 
            // ReporteFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 325);
            this.Controls.Add(this.txtcuit);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.btnReporte);
            this.Name = "ReporteFacturaForm";
            this.Text = "Reporte Factura";
            this.Load += new System.EventHandler(this.ReporteFacturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eArticuloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.BindingSource eArticuloBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPiezas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUpc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnImporte;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtcuit;
    }
}

