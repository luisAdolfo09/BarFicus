namespace FormularioApp
{
    partial class EmpleadosForm
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
            label1 = new Label();
            btnCrear = new Button();
            txtPrimerNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTelefono = new TextBox();
            txtPuesto = new TextBox();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            txtCedulaIndentidad = new TextBox();
            txtAntiguedad = new TextBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 44);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "PrimerNombre";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(115, 336);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(12, 91);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(125, 27);
            txtPrimerNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 44);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "PrimerApellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 44);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 4;
            label3.Text = "SegundoApellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 44);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 5;
            label4.Text = "Puesto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 178);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 6;
            label5.Text = "Antiguedad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 178);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 7;
            label6.Text = "CedulaIdentidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(641, 166);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 8;
            label7.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(616, 216);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(616, 91);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(125, 27);
            txtPuesto.TabIndex = 10;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(400, 91);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(125, 27);
            txtSegundoApellido.TabIndex = 11;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(197, 91);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(125, 27);
            txtPrimerApellido.TabIndex = 12;
            // 
            // txtCedulaIndentidad
            // 
            txtCedulaIndentidad.Location = new Point(347, 216);
            txtCedulaIndentidad.Name = "txtCedulaIndentidad";
            txtCedulaIndentidad.Size = new Size(125, 27);
            txtCedulaIndentidad.TabIndex = 13;
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Location = new Point(71, 216);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.Size = new Size(125, 27);
            txtAntiguedad.TabIndex = 14;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(312, 336);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(503, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(12, 392);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(940, 188);
            dgvEmpleados.TabIndex = 18;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 605);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(txtAntiguedad);
            Controls.Add(txtCedulaIndentidad);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtPuesto);
            Controls.Add(txtTelefono);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrimerNombre);
            Controls.Add(btnCrear);
            Controls.Add(label1);
            Name = "EmpleadosForm";
            Text = "EmpleadosForm";
            Load += EmpleadosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCrear;
        private TextBox txtPrimerNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTelefono;
        private TextBox txtPuesto;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtCedulaIndentidad;
        private TextBox txtAntiguedad;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvEmpleados;
    }
}