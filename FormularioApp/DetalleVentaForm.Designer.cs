namespace FormularioApp
{
    partial class DetalleVentaForm
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
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            txtVentadt = new TextBox();
            txtProductoid = new TextBox();
            txtCantidaddt = new TextBox();
            txtPrecioUnit = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvDetalleVenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(170, 409);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(364, 409);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(551, 409);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 169);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Producto";
            // 
            // txtVentadt
            // 
            txtVentadt.Location = new Point(26, 212);
            txtVentadt.Name = "txtVentadt";
            txtVentadt.Size = new Size(125, 27);
            txtVentadt.TabIndex = 4;
            // 
            // txtProductoid
            // 
            txtProductoid.Location = new Point(225, 212);
            txtProductoid.Name = "txtProductoid";
            txtProductoid.Size = new Size(125, 27);
            txtProductoid.TabIndex = 5;
            // 
            // txtCantidaddt
            // 
            txtCantidaddt.Location = new Point(426, 212);
            txtCantidaddt.Name = "txtCantidaddt";
            txtCantidaddt.Size = new Size(125, 27);
            txtCantidaddt.TabIndex = 6;
            // 
            // txtPrecioUnit
            // 
            txtPrecioUnit.Location = new Point(617, 212);
            txtPrecioUnit.Name = "txtPrecioUnit";
            txtPrecioUnit.Size = new Size(125, 27);
            txtPrecioUnit.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 169);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 169);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 9;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(629, 169);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 10;
            label4.Text = "PrecioUnitario";
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(120, 257);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(553, 117);
            dgvDetalleVenta.TabIndex = 11;
            dgvDetalleVenta.CellContentClick += dgvDetalleVenta_CellContentClick;
            // 
            // DetalleVentaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 473);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrecioUnit);
            Controls.Add(txtCantidaddt);
            Controls.Add(txtProductoid);
            Controls.Add(txtVentadt);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "DetalleVentaForm";
            Text = "DetalleVentaForm";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private TextBox txtVentadt;
        private TextBox txtProductoid;
        private TextBox txtCantidaddt;
        private TextBox txtPrecioUnit;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvDetalleVenta;
    }
}