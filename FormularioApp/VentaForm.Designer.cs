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
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDescripcion = new TextBox();
            txtFecha = new TextBox();
            txtCliente = new TextBox();
            txtTotal = new TextBox();
            dgvVenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(214, 425);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(441, 425);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(669, 425);
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
            label1.Location = new Point(77, 101);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 3;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 101);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(522, 101);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 101);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(713, 156);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(48, 156);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 27);
            txtFecha.TabIndex = 8;
             // 
            // txtCliente
            // 
            txtCliente.Location = new Point(268, 156);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(478, 156);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 10;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(162, 234);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(623, 143);
            dgvVenta.TabIndex = 11;
            dgvVenta.CellContentClick += dgvVenta_CellContentClick;
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 515);
            Controls.Add(dgvVenta);
            Controls.Add(txtTotal);
            Controls.Add(txtCliente);
            Controls.Add(txtFecha);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "VentaForm";
            Text = "VentaForm";
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDescripcion;
        private TextBox txtFecha;
        private TextBox txtCliente;
        private TextBox txtTotal;
        private DataGridView dgvVenta;
    }
}