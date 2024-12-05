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
            txtNombreProducto = new TextBox();
            txtTipo = new TextBox();
            txtMarca = new TextBox();
            txtPrecioProdcut = new TextBox();
            txtFechaCaducidad = new TextBox();
            txtDescripcion = new TextBox();
            txtCantidadDisponible = new TextBox();
            dgvProducto = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(56, 189);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 27);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(273, 189);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(125, 27);
            txtTipo.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(482, 189);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 2;
            // 
            // txtPrecioProdcut
            // 
            txtPrecioProdcut.Location = new Point(684, 189);
            txtPrecioProdcut.Name = "txtPrecioProdcut";
            txtPrecioProdcut.Size = new Size(125, 27);
            txtPrecioProdcut.TabIndex = 3;
            // 
            // txtFechaCaducidad
            // 
            txtFechaCaducidad.Location = new Point(579, 318);
            txtFechaCaducidad.Name = "txtFechaCaducidad";
            txtFechaCaducidad.Size = new Size(125, 27);
            txtFechaCaducidad.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(352, 318);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // txtCantidadDisponible
            // 
            txtCantidadDisponible.Location = new Point(148, 318);
            txtCantidadDisponible.Name = "txtCantidadDisponible";
            txtCantidadDisponible.Size = new Size(125, 27);
            txtCantidadDisponible.TabIndex = 6;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(203, 388);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(513, 123);
            dgvProducto.TabIndex = 7;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(142, 527);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(438, 527);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(759, 527);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 137);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 137);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 12;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(523, 137);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 13;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(720, 137);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 14;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 266);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 15;
            label5.Text = "CantidadDisponible";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 266);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 16;
            label6.Text = "Descripcion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(586, 266);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 17;
            label7.Text = "FechaCaducidad";
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 599);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProducto);
            Controls.Add(txtCantidadDisponible);
            Controls.Add(txtDescripcion);
            Controls.Add(txtFechaCaducidad);
            Controls.Add(txtPrecioProdcut);
            Controls.Add(txtMarca);
            Controls.Add(txtTipo);
            Controls.Add(txtNombreProducto);
            Name = "ProductoForm";
            Text = "ProductoForm";
            Load += ProductoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtTipo;
        private TextBox txtMarca;
        private TextBox txtPrecioProdcut;
        private TextBox txtFechaCaducidad;
        private TextBox txtDescripcion;
        private TextBox txtCantidadDisponible;
        private DataGridView dgvProducto;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}