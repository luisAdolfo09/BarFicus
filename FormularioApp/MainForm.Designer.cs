namespace FormularioApp
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
            btnEmpleadosForm = new Button();
            btnProveedorForm = new Button();
            btnProductoForm = new Button();
            btnVentaForm = new Button();
            btnIngredienteForm = new Button();
            btnDetalleCompraForm = new Button();
            btnDetalleVentaForm = new Button();
            btnIngredientesPlatillo = new Button();
            btnCliente = new Button();
            btnCompraForm = new Button();
            SuspendLayout();
            // 
            // btnEmpleadosForm
            // 
            btnEmpleadosForm.Location = new Point(118, 291);
            btnEmpleadosForm.Name = "btnEmpleadosForm";
            btnEmpleadosForm.Size = new Size(94, 29);
            btnEmpleadosForm.TabIndex = 0;
            btnEmpleadosForm.Text = "Empleados";
            btnEmpleadosForm.UseVisualStyleBackColor = true;
            // 
            // btnProveedorForm
            // 
            btnProveedorForm.Location = new Point(275, 291);
            btnProveedorForm.Name = "btnProveedorForm";
            btnProveedorForm.Size = new Size(94, 29);
            btnProveedorForm.TabIndex = 1;
            btnProveedorForm.Text = "Proveedor";
            btnProveedorForm.UseVisualStyleBackColor = true;
            // 
            // btnProductoForm
            // 
            btnProductoForm.Location = new Point(421, 291);
            btnProductoForm.Name = "btnProductoForm";
            btnProductoForm.Size = new Size(94, 29);
            btnProductoForm.TabIndex = 2;
            btnProductoForm.Text = "Producto";
            btnProductoForm.UseVisualStyleBackColor = true;
            // 
            // btnVentaForm
            // 
            btnVentaForm.Location = new Point(573, 291);
            btnVentaForm.Name = "btnVentaForm";
            btnVentaForm.Size = new Size(94, 29);
            btnVentaForm.TabIndex = 3;
            btnVentaForm.Text = "Venta";
            btnVentaForm.UseVisualStyleBackColor = true;
            // 
            // btnIngredienteForm
            // 
            btnIngredienteForm.Location = new Point(714, 291);
            btnIngredienteForm.Name = "btnIngredienteForm";
            btnIngredienteForm.Size = new Size(111, 29);
            btnIngredienteForm.TabIndex = 4;
            btnIngredienteForm.Text = "Ingredientes";
            btnIngredienteForm.UseVisualStyleBackColor = true;
            // 
            // btnDetalleCompraForm
            // 
            btnDetalleCompraForm.Location = new Point(93, 364);
            btnDetalleCompraForm.Name = "btnDetalleCompraForm";
            btnDetalleCompraForm.Size = new Size(133, 29);
            btnDetalleCompraForm.TabIndex = 5;
            btnDetalleCompraForm.Text = "DetalleCompra";
            btnDetalleCompraForm.UseVisualStyleBackColor = true;
            // 
            // btnDetalleVentaForm
            // 
            btnDetalleVentaForm.Location = new Point(264, 364);
            btnDetalleVentaForm.Name = "btnDetalleVentaForm";
            btnDetalleVentaForm.Size = new Size(116, 29);
            btnDetalleVentaForm.TabIndex = 6;
            btnDetalleVentaForm.Text = "DetalleVenta";
            btnDetalleVentaForm.UseVisualStyleBackColor = true;
            // 
            // btnIngredientesPlatillo
            // 
            btnIngredientesPlatillo.Location = new Point(410, 364);
            btnIngredientesPlatillo.Name = "btnIngredientesPlatillo";
            btnIngredientesPlatillo.Size = new Size(163, 29);
            btnIngredientesPlatillo.TabIndex = 7;
            btnIngredientesPlatillo.Text = "IngredientesPlatillo";
            btnIngredientesPlatillo.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(605, 364);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(94, 29);
            btnCliente.TabIndex = 8;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnCompraForm
            // 
            btnCompraForm.Location = new Point(731, 364);
            btnCompraForm.Name = "btnCompraForm";
            btnCompraForm.Size = new Size(94, 29);
            btnCompraForm.TabIndex = 9;
            btnCompraForm.Text = "Compra";
            btnCompraForm.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 556);
            Controls.Add(btnCompraForm);
            Controls.Add(btnCliente);
            Controls.Add(btnIngredientesPlatillo);
            Controls.Add(btnDetalleVentaForm);
            Controls.Add(btnDetalleCompraForm);
            Controls.Add(btnIngredienteForm);
            Controls.Add(btnVentaForm);
            Controls.Add(btnProductoForm);
            Controls.Add(btnProveedorForm);
            Controls.Add(btnEmpleadosForm);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmpleadosForm;
        private Button btnProveedorForm;
        private Button btnProductoForm;
        private Button btnVentaForm;
        private Button btnIngredienteForm;
        private Button btnDetalleCompraForm;
        private Button btnDetalleVentaForm;
        private Button btnIngredientesPlatillo;
        private Button btnCliente;
        private Button btnCompraForm;
    }
}