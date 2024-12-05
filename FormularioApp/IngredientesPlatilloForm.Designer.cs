namespace FormularioApp
{
    partial class IngredientesPlatilloForm
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
            txtCantidadNecesario = new TextBox();
            txtIngredientesPlatillo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvIngredientesPlatillo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientesPlatillo).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(178, 500);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(397, 500);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(628, 500);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCantidadNecesario
            // 
            txtCantidadNecesario.Location = new Point(558, 255);
            txtCantidadNecesario.Name = "txtCantidadNecesario";
            txtCantidadNecesario.Size = new Size(125, 27);
            txtCantidadNecesario.TabIndex = 3;
            // 
            // txtIngredientesPlatillo
            // 
            txtIngredientesPlatillo.Location = new Point(201, 255);
            txtIngredientesPlatillo.Name = "txtIngredientesPlatillo";
            txtIngredientesPlatillo.Size = new Size(125, 27);
            txtIngredientesPlatillo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 179);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingredientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 179);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 6;
            label2.Text = "CantidadNecesaria";
            // 
            // dgvIngredientesPlatillo
            // 
            dgvIngredientesPlatillo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientesPlatillo.Location = new Point(156, 304);
            dgvIngredientesPlatillo.Name = "dgvIngredientesPlatillo";
            dgvIngredientesPlatillo.RowHeadersWidth = 51;
            dgvIngredientesPlatillo.Size = new Size(585, 158);
            dgvIngredientesPlatillo.TabIndex = 7;
            // 
            // IngredientesPlatilloForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 608);
            Controls.Add(dgvIngredientesPlatillo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIngredientesPlatillo);
            Controls.Add(txtCantidadNecesario);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "IngredientesPlatilloForm";
            Text = "IngredientesPlatilloForm";
            ((System.ComponentModel.ISupportInitialize)dgvIngredientesPlatillo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtCantidadNecesario;
        private TextBox txtIngredientesPlatillo;
        private Label label1;
        private Label label2;
        private DataGridView dgvIngredientesPlatillo;
    }
}