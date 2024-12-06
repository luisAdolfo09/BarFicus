namespace FormularioApp
{
    partial class CompraForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label2 = new Label();
            cmbProveedorFiltro = new ComboBox();
            label1 = new Label();
            label7 = new Label();
            dtpFechaCompra = new DateTimePicker();
            txtDescripcion = new TextBox();
            dgvCompraProductos = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            txtCantidad = new TextBox();
            label11 = new Label();
            btnAgregarCompra = new FontAwesome.Sharp.IconButton();
            txtPrecioVenta = new TextBox();
            label9 = new Label();
            txtPrecioCompra = new TextBox();
            label8 = new Label();
            cmbProducto = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            txtTotalPagar = new TextBox();
            label10 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompraProductos).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.54593F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.45407F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvCompraProductos, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 88);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.6F));
            tableLayoutPanel1.Size = new Size(1154, 625);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbProveedorFiltro);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpFechaCompra);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 234);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion De Compra:";
            // 
            // label2
            // 
            label2.BackColor = Color.DarkOliveGreen;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 139);
            label2.Name = "label2";
            label2.Size = new Size(183, 39);
            label2.TabIndex = 14;
            label2.Text = "Descripcion:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbProveedorFiltro
            // 
            cmbProveedorFiltro.FormattingEnabled = true;
            cmbProveedorFiltro.Location = new Point(300, 93);
            cmbProveedorFiltro.Name = "cmbProveedorFiltro";
            cmbProveedorFiltro.Size = new Size(279, 30);
            cmbProveedorFiltro.TabIndex = 13;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOliveGreen;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 42);
            label1.Name = "label1";
            label1.Size = new Size(109, 39);
            label1.TabIndex = 12;
            label1.Text = "Proveedor";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.DarkOliveGreen;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(113, 42);
            label7.Name = "label7";
            label7.Size = new Size(70, 39);
            label7.TabIndex = 10;
            label7.Text = "Fecha:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaCompra.Location = new Point(6, 94);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(273, 26);
            dtpFechaCompra.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(300, 146);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(279, 30);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // dgvCompraProductos
            // 
            dgvCompraProductos.BackgroundColor = SystemColors.ActiveBorder;
            dgvCompraProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompraProductos.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, Subtotal });
            dgvCompraProductos.Dock = DockStyle.Fill;
            dgvCompraProductos.Location = new Point(3, 243);
            dgvCompraProductos.Name = "dgvCompraProductos";
            dgvCompraProductos.RowHeadersWidth = 51;
            dgvCompraProductos.Size = new Size(635, 379);
            dgvCompraProductos.TabIndex = 21;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio de Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Sub Total";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnAgregarCompra);
            panel2.Controls.Add(txtPrecioVenta);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtPrecioCompra);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmbProducto);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(644, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 234);
            panel2.TabIndex = 24;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(25, 177);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(157, 27);
            txtCantidad.TabIndex = 31;
            // 
            // label11
            // 
            label11.BackColor = Color.DarkOliveGreen;
            label11.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(25, 125);
            label11.Name = "label11";
            label11.Size = new Size(157, 37);
            label11.TabIndex = 30;
            label11.Text = "Cantidad:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnAgregarCompra.IconColor = Color.Black;
            btnAgregarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarCompra.Location = new Point(385, 63);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(112, 78);
            btnAgregarCompra.TabIndex = 29;
            btnAgregarCompra.Text = "Agregar";
            btnAgregarCompra.TextAlign = ContentAlignment.BottomCenter;
            btnAgregarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarCompra.UseVisualStyleBackColor = true;
            btnAgregarCompra.Click += iconButton1_Click;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(216, 177);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(157, 27);
            txtPrecioVenta.TabIndex = 28;
            // 
            // label9
            // 
            label9.BackColor = Color.DarkOliveGreen;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(216, 125);
            label9.Name = "label9";
            label9.Size = new Size(157, 37);
            label9.TabIndex = 27;
            label9.Text = "Precio de Venta:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(216, 67);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(157, 27);
            txtPrecioCompra.TabIndex = 26;
            // 
            // label8
            // 
            label8.BackColor = Color.DarkOliveGreen;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(216, 16);
            label8.Name = "label8";
            label8.Size = new Size(157, 37);
            label8.TabIndex = 25;
            label8.Text = "Precio Compra:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(22, 67);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(160, 28);
            cmbProducto.TabIndex = 15;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkOliveGreen;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 16);
            label3.Name = "label3";
            label3.Size = new Size(125, 37);
            label3.TabIndex = 16;
            label3.Text = "Producto:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Teal;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(507, 234);
            label4.TabIndex = 24;
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRegistrar);
            panel3.Controls.Add(txtTotalPagar);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(644, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(507, 379);
            panel3.TabIndex = 25;
            // 
            // btnRegistrar
            // 
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.Location = new Point(204, 157);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 78);
            btnRegistrar.TabIndex = 30;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(160, 94);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(195, 27);
            txtTotalPagar.TabIndex = 27;
            // 
            // label10
            // 
            label10.BackColor = Color.DarkOliveGreen;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(173, 40);
            label10.Name = "label10";
            label10.Size = new Size(165, 37);
            label10.TabIndex = 26;
            label10.Text = "Total a pagar:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Teal;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(507, 379);
            label6.TabIndex = 25;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 87);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSlateGray;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1154, 85);
            label5.TabIndex = 14;
            label5.Text = "Registrar Compras:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CompraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 713);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "CompraForm";
            Text = "CompraForm";
            Load += CompraForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompraProductos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label5;
        private GroupBox groupBox1;
        private Label label1;
        private Label label7;
        private DateTimePicker dtpFechaCompra;
        private TextBox txtDescripcion;
        private DataGridView dgvCompraProductos;
        private Label label2;
        private ComboBox cmbProveedorFiltro;
        private Label label3;
        private ComboBox cmbProducto;
        private Panel panel2;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnAgregarCompra;
        private TextBox txtPrecioVenta;
        private Label label9;
        private TextBox txtPrecioCompra;
        private Label label8;
        private Panel panel3;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private TextBox txtTotalPagar;
        private Label label10;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private TextBox txtCantidad;
        private Label label11;
    }
}