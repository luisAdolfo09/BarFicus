namespace FormularioApp
{
    partial class ClienteForm
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEmail = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 175);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(332, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(572, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(139, 355);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(363, 355);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(619, 355);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(94, 29);
            btnEmail.TabIndex = 5;
            btnEmail.Text = "Eliminar";
            btnEmail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 125);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 125);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Telefono";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(603, 125);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(198, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(394, 113);
            dataGridView1.TabIndex = 9;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEmail);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "ClienteForm";
            Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
    }
}