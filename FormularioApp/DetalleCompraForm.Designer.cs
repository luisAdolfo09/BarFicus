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
            btnEditardt = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCantidaddt = new TextBox();
            txtPrecioUnitdt = new TextBox();
            dgvDetalleCompra = new DataGridView();
            ProductoDetalle = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            CantidadDetalle = new DataGridViewTextBoxColumn();
            SubTotalDetalle = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label9 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            btnBuscarID = new FontAwesome.Sharp.IconButton();
            btnAgregardt = new FontAwesome.Sharp.IconButton();
            btnPDF = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            txtMontoTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditardt
            // 
            btnEditardt.Location = new Point(846, 317);
            btnEditardt.Name = "btnEditardt";
            btnEditardt.Size = new Size(94, 29);
            btnEditardt.TabIndex = 1;
            btnEditardt.Text = "Editar";
            btnEditardt.UseVisualStyleBackColor = true;
            btnEditardt.Click += btnEditardt_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(846, 404);
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
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(39, 52);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 3;
            label1.Text = "No. Detalle";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Location = new Point(344, 36);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.Location = new Point(503, 36);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HighlightText;
            label4.Location = new Point(642, 36);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 6;
            label4.Text = "Precio Unitario";
            // 
            // txtCantidaddt
            // 
            txtCantidaddt.Location = new Point(481, 73);
            txtCantidaddt.Name = "txtCantidaddt";
            txtCantidaddt.Size = new Size(125, 27);
            txtCantidaddt.TabIndex = 9;
            // 
            // txtPrecioUnitdt
            // 
            txtPrecioUnitdt.Location = new Point(637, 73);
            txtPrecioUnitdt.Name = "txtPrecioUnitdt";
            txtPrecioUnitdt.Size = new Size(125, 27);
            txtPrecioUnitdt.TabIndex = 10;
            // 
            // dgvDetalleCompra
            // 
            dgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompra.Columns.AddRange(new DataGridViewColumn[] { ProductoDetalle, PrecioCompra, CantidadDetalle, SubTotalDetalle });
            dgvDetalleCompra.Location = new Point(37, 241);
            dgvDetalleCompra.Name = "dgvDetalleCompra";
            dgvDetalleCompra.RowHeadersWidth = 51;
            dgvDetalleCompra.Size = new Size(768, 243);
            dgvDetalleCompra.TabIndex = 11;
            dgvDetalleCompra.CellContentClick += dgvDetalleCompra_CellContentClick;
            // 
            // ProductoDetalle
            // 
            ProductoDetalle.HeaderText = "Producto";
            ProductoDetalle.MinimumWidth = 6;
            ProductoDetalle.Name = "ProductoDetalle";
            ProductoDetalle.Width = 155;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio de Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 175;
            // 
            // CantidadDetalle
            // 
            CantidadDetalle.HeaderText = "Cantidad";
            CantidadDetalle.MinimumWidth = 6;
            CantidadDetalle.Name = "CantidadDetalle";
            CantidadDetalle.Width = 170;
            // 
            // SubTotalDetalle
            // 
            SubTotalDetalle.HeaderText = "Sub Total";
            SubTotalDetalle.MinimumWidth = 6;
            SubTotalDetalle.Name = "SubTotalDetalle";
            SubTotalDetalle.Width = 155;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 81);
            panel1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(99, 26);
            label9.Name = "label9";
            label9.Size = new Size(226, 27);
            label9.TabIndex = 17;
            label9.Text = "Detalle de Compra";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.HighlightText;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 49;
            iconPictureBox1.Location = new Point(24, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(59, 49);
            iconPictureBox1.TabIndex = 17;
            iconPictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Highlight;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(974, 81);
            label5.TabIndex = 0;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
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
            panel2.Controls.Add(txtPrecioUnitdt);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtCantidaddt);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 130);
            panel2.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(318, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(239, 63);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 46);
            iconButton1.TabIndex = 14;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.HighlightText;
            label7.Location = new Point(822, 36);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 13;
            label7.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(795, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 27);
            textBox1.TabIndex = 12;
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
            // btnBuscarID
            // 
            btnBuscarID.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnBuscarID.IconColor = Color.Black;
            btnBuscarID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarID.Location = new Point(194, 65);
            btnBuscarID.Name = "btnBuscarID";
            btnBuscarID.Size = new Size(39, 46);
            btnBuscarID.TabIndex = 8;
            btnBuscarID.UseVisualStyleBackColor = true;
            // 
            // btnAgregardt
            // 
            btnAgregardt.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregardt.IconColor = Color.Black;
            btnAgregardt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregardt.Location = new Point(846, 228);
            btnAgregardt.Name = "btnAgregardt";
            btnAgregardt.RightToLeft = RightToLeft.Yes;
            btnAgregardt.Size = new Size(94, 36);
            btnAgregardt.TabIndex = 14;
            btnAgregardt.Text = "Guadar";
            btnAgregardt.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            btnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnPDF.IconColor = Color.Black;
            btnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPDF.Location = new Point(822, 463);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(139, 68);
            btnPDF.TabIndex = 15;
            btnPDF.Text = "Descargar";
            btnPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDF.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.HighlightText;
            label8.Location = new Point(39, 511);
            label8.Name = "label8";
            label8.Size = new Size(107, 31);
            label8.TabIndex = 15;
            label8.Text = "Monto Total: ";
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(165, 511);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(125, 27);
            txtMontoTotal.TabIndex = 16;
            // 
            // DetalleCompraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(974, 567);
            Controls.Add(txtMontoTotal);
            Controls.Add(label8);
            Controls.Add(btnPDF);
            Controls.Add(btnAgregardt);
            Controls.Add(dgvDetalleCompra);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditardt);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleCompraForm";
            Text = "DetalleCompraForm";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditardt;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCantidaddt;
        private TextBox txtPrecioUnitdt;
        private DataGridView dgvDetalleCompra;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnAgregardt;
        private FontAwesome.Sharp.IconButton btnBuscarID;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnPDF;
        private Label label8;
        private TextBox txtMontoTotal;
        private DataGridViewTextBoxColumn ProductoDetalle;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn CantidadDetalle;
        private DataGridViewTextBoxColumn SubTotalDetalle;
        private Label label9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}