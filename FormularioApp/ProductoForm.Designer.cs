namespace FormularioApp
{
    partial class ProductoForm
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
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtMarca = new TextBox();
            label2 = new Label();
            txtNombreProducto = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            txtCantidadDisponible = new TextBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            btnEditar = new FontAwesome.Sharp.IconButton();
            txtPrecioProdcut = new TextBox();
            label5 = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            dgvProducto = new DataGridView();
            panel6 = new Panel();
            cmbTipo = new ComboBox();
            cmbCategoria = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtFechaCaducidad = new TextBox();
            label9 = new Label();
            txtDescripcion = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 82);
            panel1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Silver;
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(56, 24);
            label8.Name = "label8";
            label8.Size = new Size(276, 28);
            label8.TabIndex = 0;
            label8.Text = "Registrar un Producto:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 572);
            panel2.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.8076057F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.1923943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 306F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Controls.Add(panel7, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.9758072F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.0241928F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 178F));
            tableLayoutPanel1.Size = new Size(1207, 572);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(343, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(554, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateGray;
            panel3.Controls.Add(txtMarca);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtNombreProducto);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 262);
            panel3.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(18, 171);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(270, 27);
            txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Location = new Point(18, 126);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Marca:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(18, 72);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(270, 27);
            txtNombreProducto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(txtCantidadDisponible);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(txtPrecioProdcut);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(btnAgregar);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 271);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 298);
            panel4.TabIndex = 2;
            // 
            // txtCantidadDisponible
            // 
            txtCantidadDisponible.Location = new Point(131, 95);
            txtCantidadDisponible.Name = "txtCantidadDisponible";
            txtCantidadDisponible.Size = new Size(118, 27);
            txtCantidadDisponible.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(239, 167);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 86);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Lavender;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 95);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 5;
            label6.Text = "Cantidad:";
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(131, 167);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(77, 86);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtPrecioProdcut
            // 
            txtPrecioProdcut.Location = new Point(131, 25);
            txtPrecioProdcut.Name = "txtPrecioProdcut";
            txtPrecioProdcut.Size = new Size(118, 27);
            txtPrecioProdcut.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 28);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 3;
            label5.Text = "Precio:";
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(24, 167);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(74, 86);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvProducto);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(343, 271);
            panel5.Name = "panel5";
            panel5.Size = new Size(554, 298);
            panel5.TabIndex = 3;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Dock = DockStyle.Fill;
            dgvProducto.Location = new Point(0, 0);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(554, 298);
            dgvProducto.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SlateGray;
            panel6.Controls.Add(cmbTipo);
            panel6.Controls.Add(cmbCategoria);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(903, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(301, 262);
            panel6.TabIndex = 4;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(36, 71);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 8;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(36, 170);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Location = new Point(36, 126);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Location = new Point(36, 34);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Tipo:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkCyan;
            panel7.Controls.Add(iconButton1);
            panel7.Controls.Add(txtFechaCaducidad);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(txtDescripcion);
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(903, 271);
            panel7.Name = "panel7";
            panel7.Size = new Size(301, 298);
            panel7.TabIndex = 5;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.DiceD20;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(109, 193);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(114, 83);
            iconButton1.TabIndex = 33;
            iconButton1.Text = "Registrar";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtFechaCaducidad
            // 
            txtFechaCaducidad.Location = new Point(36, 139);
            txtFechaCaducidad.Name = "txtFechaCaducidad";
            txtFechaCaducidad.Size = new Size(187, 27);
            txtFechaCaducidad.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Lavender;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(36, 99);
            label9.Name = "label9";
            label9.Size = new Size(168, 23);
            label9.TabIndex = 6;
            label9.Text = "Fecha de Caducidad:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(9, 55);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(289, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Lavender;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 14);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 4;
            label7.Text = "Descripcion:";
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 654);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductoForm";
            Text = "ProductoForm";
            Load += ProductoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox txtMarca;
        private Label label2;
        private TextBox txtNombreProducto;
        private Label label3;
        private TextBox txtCantidadDisponible;
        private Label label6;
        private TextBox txtPrecioProdcut;
        private Label label5;
        private ComboBox cmbTipo;
        private ComboBox cmbCategoria;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label7;
        private TextBox txtFechaCaducidad;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dgvProducto;
    }
}