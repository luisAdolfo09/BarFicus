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
            label9 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            txtTotal = new TextBox();
            label8 = new Label();
            btnPDFVenta = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            textBox1 = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            panel2 = new Panel();
            btnBuscarID = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtPrecioUnit = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvDetalleVenta = new DataGridView();
            txtTipoPago = new TextBox();
            label10 = new Label();
            txtCantidad = new TextBox();
            NoVenta = new DataGridViewTextBoxColumn();
            ProductoDetalle = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            CantidadDetalleCompra = new DataGridViewTextBoxColumn();
            TipoPago = new DataGridViewTextBoxColumn();
            SubTotalCompra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GrayText;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(89, 26);
            label9.Name = "label9";
            label9.Size = new Size(201, 27);
            label9.TabIndex = 17;
            label9.Text = "Detalle de Venta";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(956, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(165, 525);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 25;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.HighlightText;
            label8.Location = new Point(39, 525);
            label8.Name = "label8";
            label8.Size = new Size(107, 31);
            label8.TabIndex = 23;
            label8.Text = "Monto Total: ";
            // 
            // btnPDFVenta
            // 
            btnPDFVenta.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnPDFVenta.IconColor = Color.Black;
            btnPDFVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPDFVenta.Location = new Point(1005, 472);
            btnPDFVenta.Name = "btnPDFVenta";
            btnPDFVenta.Size = new Size(139, 68);
            btnPDFVenta.TabIndex = 24;
            btnPDFVenta.Text = "Descargar";
            btnPDFVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDFVenta.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(239, 36);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 46);
            iconButton1.TabIndex = 14;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.HighlightText;
            label7.Location = new Point(819, 26);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 13;
            label7.Text = "Empleado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(785, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 27);
            textBox1.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.HighlightText;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 49;
            iconPictureBox1.Location = new Point(26, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(49, 49);
            iconPictureBox1.TabIndex = 17;
            iconPictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HighlightText;
            label6.Location = new Point(749, 36);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(1012, 244);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.Yes;
            btnAgregar.Size = new Size(115, 36);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "iconButton1";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Highlight;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1156, 81);
            label5.TabIndex = 0;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtTipoPago);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnBuscarID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPrecioUnit);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(1156, 130);
            panel2.TabIndex = 21;
            // 
            // btnBuscarID
            // 
            btnBuscarID.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnBuscarID.IconColor = Color.Black;
            btnBuscarID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarID.Location = new Point(194, 36);
            btnBuscarID.Name = "btnBuscarID";
            btnBuscarID.Size = new Size(39, 46);
            btnBuscarID.TabIndex = 8;
            btnBuscarID.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.Location = new Point(321, 26);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "Tipo de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HighlightText;
            label4.Location = new Point(476, 26);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 6;
            label4.Text = "Precio Unitario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Location = new Point(1005, 26);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // txtPrecioUnit
            // 
            txtPrecioUnit.Location = new Point(467, 65);
            txtPrecioUnit.Name = "txtPrecioUnit";
            txtPrecioUnit.Size = new Size(125, 27);
            txtPrecioUnit.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "No. Venta";
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 81);
            panel1.TabIndex = 20;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1012, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 29);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1012, 323);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 29);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { NoVenta, ProductoDetalle, PrecioUnitario, CantidadDetalleCompra, TipoPago, SubTotalCompra });
            dgvDetalleVenta.Location = new Point(37, 240);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(962, 258);
            dgvDetalleVenta.TabIndex = 19;
            // 
            // txtTipoPago
            // 
            txtTipoPago.Location = new Point(307, 63);
            txtTipoPago.Name = "txtTipoPago";
            txtTipoPago.Size = new Size(125, 27);
            txtTipoPago.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.HighlightText;
            label10.Location = new Point(651, 26);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 18;
            label10.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(624, 66);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(135, 27);
            txtCantidad.TabIndex = 19;
            // 
            // NoVenta
            // 
            NoVenta.HeaderText = "No. Venta";
            NoVenta.MinimumWidth = 6;
            NoVenta.Name = "NoVenta";
            NoVenta.Width = 125;
            // 
            // ProductoDetalle
            // 
            ProductoDetalle.HeaderText = "Producto";
            ProductoDetalle.MinimumWidth = 6;
            ProductoDetalle.Name = "ProductoDetalle";
            ProductoDetalle.Width = 155;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.Width = 175;
            // 
            // CantidadDetalleCompra
            // 
            CantidadDetalleCompra.HeaderText = "Cantidad";
            CantidadDetalleCompra.MinimumWidth = 6;
            CantidadDetalleCompra.Name = "CantidadDetalleCompra";
            CantidadDetalleCompra.Width = 170;
            // 
            // TipoPago
            // 
            TipoPago.HeaderText = "Tipo Pago";
            TipoPago.MinimumWidth = 6;
            TipoPago.Name = "TipoPago";
            TipoPago.Width = 125;
            // 
            // SubTotalCompra
            // 
            SubTotalCompra.HeaderText = "Sub Total";
            SubTotalCompra.MinimumWidth = 6;
            SubTotalCompra.Name = "SubTotalCompra";
            SubTotalCompra.Width = 155;
            // 
            // DetalleVentaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1156, 571);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(btnPDFVenta);
            Controls.Add(btnAgregar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvDetalleVenta);
            Name = "DetalleVentaForm";
            Text = "DetalleVentaForm";
            Load += DetalleVentaForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox txtTotal;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnPDFVenta;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label7;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label label5;
        private Panel panel2;
        private TextBox txtTipoPago;
        private FontAwesome.Sharp.IconButton btnBuscarID;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox txtPrecioUnit;
        private Label label1;
        private Panel panel1;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvDetalleVenta;
        private Label label10;
        private TextBox txtCantidad;
        private DataGridViewTextBoxColumn NoVenta;
        private DataGridViewTextBoxColumn ProductoDetalle;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn CantidadDetalleCompra;
        private DataGridViewTextBoxColumn TipoPago;
        private DataGridViewTextBoxColumn SubTotalCompra;
    }
}