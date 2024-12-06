namespace FormularioApp
{
    partial class VentaForm
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
            label5 = new Label();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            txtTotal = new TextBox();
            label10 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            txtCantidad = new TextBox();
            panel2 = new Panel();
            label11 = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            cmbProducto = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            cmbEmpleado = new ComboBox();
            label1 = new Label();
            label7 = new Label();
            txtFecha = new DateTimePicker();
            txtDescripcion = new TextBox();
            dgvVenta = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            cmbCliente = new ComboBox();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txtDetalle = new TextBox();
            Producto = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSlateGray;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1186, 85);
            label5.TabIndex = 14;
            label5.Text = "Registrar Ventas:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRegistrar
            // 
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.Location = new Point(333, 226);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 78);
            btnRegistrar.TabIndex = 30;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(22, 304);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(165, 27);
            txtTotal.TabIndex = 27;
            // 
            // label10
            // 
            label10.BackColor = Color.Silver;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 246);
            label10.Name = "label10";
            label10.Size = new Size(165, 37);
            label10.TabIndex = 26;
            label10.Text = "Total a pagar:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.SeaGreen;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(508, 379);
            label6.TabIndex = 25;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDetalle);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnRegistrar);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(675, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 379);
            panel3.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 87);
            panel1.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(314, 68);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(157, 27);
            txtCantidad.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cmbProducto);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(675, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 234);
            panel2.TabIndex = 24;
            // 
            // label11
            // 
            label11.BackColor = Color.Silver;
            label11.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(314, 16);
            label11.Name = "label11";
            label11.Size = new Size(157, 37);
            label11.TabIndex = 30;
            label11.Text = "Cantidad:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(68, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(101, 71);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(22, 67);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(247, 28);
            cmbProducto.TabIndex = 15;
            // 
            // label3
            // 
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 16);
            label3.Name = "label3";
            label3.Size = new Size(125, 37);
            label3.TabIndex = 16;
            label3.Text = "Producto:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.SeaGreen;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(508, 234);
            label4.TabIndex = 24;
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbEmpleado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 234);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion De Ventas:";
            // 
            // label2
            // 
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 128);
            label2.Name = "label2";
            label2.Size = new Size(183, 39);
            label2.TabIndex = 14;
            label2.Text = "Descripcion:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(300, 93);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(279, 30);
            cmbEmpleado.TabIndex = 13;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 42);
            label1.Name = "label1";
            label1.Size = new Size(109, 39);
            label1.TabIndex = 12;
            label1.Text = "Empleado";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Silver;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(113, 42);
            label7.Name = "label7";
            label7.Size = new Size(70, 39);
            label7.TabIndex = 10;
            label7.Text = "Fecha:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.Location = new Point(6, 94);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(273, 26);
            txtFecha.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(21, 190);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(317, 27);
            txtDescripcion.TabIndex = 4;
            // 
            // dgvVenta
            // 
            dgvVenta.BackgroundColor = Color.CadetBlue;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioVenta, Cantidad, Subtotal });
            dgvVenta.Dock = DockStyle.Fill;
            dgvVenta.Location = new Point(3, 243);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(666, 379);
            dgvVenta.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.6610451F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.3389549F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvVenta, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.6F));
            tableLayoutPanel1.Size = new Size(1186, 625);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.BackColor = Color.Silver;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(378, 139);
            label8.Name = "label8";
            label8.Size = new Size(109, 39);
            label8.TabIndex = 14;
            label8.Text = "Cliente";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(300, 187);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(279, 30);
            cmbCliente.TabIndex = 15;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(228, 25);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 71);
            btnEditar.TabIndex = 31;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(370, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 71);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Borrar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.BackColor = Color.Silver;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 129);
            label9.Name = "label9";
            label9.Size = new Size(165, 37);
            label9.TabIndex = 33;
            label9.Text = "No. Detalle:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(21, 188);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(165, 27);
            txtDetalle.TabIndex = 34;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 180;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 130;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Sub Total";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 150;
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 708);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "VentaForm";
            Text = "VentaForm";
            Load += VentaForm_Load_1;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private TextBox txtTotal;
        private Label label10;
        private Label label6;
        private Panel panel3;
        private Panel panel1;
        private TextBox txtCantidad;
        private Panel panel2;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private ComboBox cmbProducto;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cmbEmpleado;
        private Label label1;
        private Label label7;
        private DateTimePicker txtFecha;
        private TextBox txtDescripcion;
        private DataGridView dgvVenta;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbCliente;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnEditar;
        private TextBox txtDetalle;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
    }
}