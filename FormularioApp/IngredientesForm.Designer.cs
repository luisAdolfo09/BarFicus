namespace FormularioApp
{
    partial class IngredientesForm
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
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFechaCaducidad = new TextBox();
            txtDescripcionIngredientes = new TextBox();
            txtNombreIngrediente = new TextBox();
            txtCostoUnitario = new TextBox();
            txtCantidadDisponible = new TextBox();
            txtProducto = new TextBox();
            dgvIngredientes = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(199, 317);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 94);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 94);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "CostoUnitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(706, 94);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 3;
            label3.Text = "CantidadDisponible";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 211);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 211);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 5;
            label5.Text = "FechaCaducidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(726, 211);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 6;
            label6.Text = "Producto";
            // 
            // txtFechaCaducidad
            // 
            txtFechaCaducidad.Location = new Point(391, 257);
            txtFechaCaducidad.Name = "txtFechaCaducidad";
            txtFechaCaducidad.Size = new Size(125, 27);
            txtFechaCaducidad.TabIndex = 7;
            // 
            // txtDescripcionIngredientes
            // 
            txtDescripcionIngredientes.Location = new Point(92, 257);
            txtDescripcionIngredientes.Name = "txtDescripcionIngredientes";
            txtDescripcionIngredientes.Size = new Size(125, 27);
            txtDescripcionIngredientes.TabIndex = 8;
            // 
            // txtNombreIngrediente
            // 
            txtNombreIngrediente.Location = new Point(92, 127);
            txtNombreIngrediente.Name = "txtNombreIngrediente";
            txtNombreIngrediente.Size = new Size(125, 27);
            txtNombreIngrediente.TabIndex = 9;
            // 
            // txtCostoUnitario
            // 
            txtCostoUnitario.Location = new Point(391, 127);
            txtCostoUnitario.Name = "txtCostoUnitario";
            txtCostoUnitario.Size = new Size(125, 27);
            txtCostoUnitario.TabIndex = 10;
            // 
            // txtCantidadDisponible
            // 
            txtCantidadDisponible.Location = new Point(706, 127);
            txtCantidadDisponible.Name = "txtCantidadDisponible";
            txtCantidadDisponible.Size = new Size(125, 27);
            txtCantidadDisponible.TabIndex = 11;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(706, 257);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 12;
            // 
            // dgvIngredientes
            // 
            dgvIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientes.Location = new Point(132, 317);
            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.RowHeadersWidth = 51;
            dgvIngredientes.Size = new Size(663, 125);
            dgvIngredientes.TabIndex = 13;
            dgvIngredientes.CellContentClick += dgvIngredientes_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(199, 462);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(436, 462);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(658, 462);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // IngredientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 540);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvIngredientes);
            Controls.Add(txtProducto);
            Controls.Add(txtCantidadDisponible);
            Controls.Add(txtCostoUnitario);
            Controls.Add(txtNombreIngrediente);
            Controls.Add(txtDescripcionIngredientes);
            Controls.Add(txtFechaCaducidad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Name = "IngredientesForm";
            Text = "IngredientesForm";
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFechaCaducidad;
        private TextBox txtDescripcionIngredientes;
        private TextBox txtNombreIngrediente;
        private TextBox txtCostoUnitario;
        private TextBox txtCantidadDisponible;
        private TextBox txtProducto;
        private DataGridView dgvIngredientes;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}