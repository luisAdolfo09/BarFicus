namespace FormularioApp
{
    partial class DetalleCompraForm
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
            btnAgregardt = new Button();
            btnEditardt = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCompradt = new TextBox();
            txtProductodt = new TextBox();
            txtCantidaddt = new TextBox();
            txtPrecioUnitdt = new TextBox();
            dgvDetalleCompra = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).BeginInit();
            SuspendLayout();
            // 
            // btnAgregardt
            // 
            btnAgregardt.Location = new Point(235, 378);
            btnAgregardt.Name = "btnAgregardt";
            btnAgregardt.Size = new Size(94, 29);
            btnAgregardt.TabIndex = 0;
            btnAgregardt.Text = "Agregar";
            btnAgregardt.UseVisualStyleBackColor = true;
            btnAgregardt.Click += btnAgregardt_Click;
            // 
            // btnEditardt
            // 
            btnEditardt.Location = new Point(408, 378);
            btnEditardt.Name = "btnEditardt";
            btnEditardt.Size = new Size(94, 29);
            btnEditardt.TabIndex = 1;
            btnEditardt.Text = "Editar";
            btnEditardt.UseVisualStyleBackColor = true;
            btnEditardt.Click += btnEditardt_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(581, 378);
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
            label1.Location = new Point(84, 98);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 98);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 98);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(622, 98);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 6;
            label4.Text = "PrecioUnitario";
            // 
            // txtCompradt
            // 
            txtCompradt.Location = new Point(37, 168);
            txtCompradt.Name = "txtCompradt";
            txtCompradt.Size = new Size(125, 27);
            txtCompradt.TabIndex = 7;
            // 
            // txtProductodt
            // 
            txtProductodt.Location = new Point(247, 168);
            txtProductodt.Name = "txtProductodt";
            txtProductodt.Size = new Size(125, 27);
            txtProductodt.TabIndex = 8;
            // 
            // txtCantidaddt
            // 
            txtCantidaddt.Location = new Point(408, 168);
            txtCantidaddt.Name = "txtCantidaddt";
            txtCantidaddt.Size = new Size(125, 27);
            txtCantidaddt.TabIndex = 9;
            // 
            // txtPrecioUnitdt
            // 
            txtPrecioUnitdt.Location = new Point(600, 168);
            txtPrecioUnitdt.Name = "txtPrecioUnitdt";
            txtPrecioUnitdt.Size = new Size(125, 27);
            txtPrecioUnitdt.TabIndex = 10;
            // 
            // dgvDetalleCompra
            // 
            dgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompra.Location = new Point(26, 215);
            dgvDetalleCompra.Name = "dgvDetalleCompra";
            dgvDetalleCompra.RowHeadersWidth = 51;
            dgvDetalleCompra.Size = new Size(716, 143);
            dgvDetalleCompra.TabIndex = 11;
            dgvDetalleCompra.CellContentClick += dgvDetalleCompra_CellContentClick;
            // 
            // DetalleCompraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 495);
            Controls.Add(dgvDetalleCompra);
            Controls.Add(txtPrecioUnitdt);
            Controls.Add(txtCantidaddt);
            Controls.Add(txtProductodt);
            Controls.Add(txtCompradt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditardt);
            Controls.Add(btnAgregardt);
            Name = "DetalleCompraForm";
            Text = "DetalleCompraForm";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregardt;
        private Button btnEditardt;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCompradt;
        private TextBox txtProductodt;
        private TextBox txtCantidaddt;
        private TextBox txtPrecioUnitdt;
        private DataGridView dgvDetalleCompra;
    }
}