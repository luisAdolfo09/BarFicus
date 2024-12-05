namespace FormularioApp
{
    partial class CompraForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtFecha = new TextBox();
            txtDescripcion = new TextBox();
            txtProveedor = new TextBox();
            txtTotal = new TextBox();
            dgvCompra = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(221, 498);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(445, 498);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(643, 498);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(116, 215);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 27);
            txtFecha.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(722, 215);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 4;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(314, 215);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(125, 27);
            txtProveedor.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(520, 215);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 6;
            // 
            // dgvCompra
            // 
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Location = new Point(34, 283);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.RowHeadersWidth = 51;
            dgvCompra.Size = new Size(891, 188);
            dgvCompra.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 174);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 8;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 174);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 9;
            label2.Text = "Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(556, 174);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(741, 174);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 11;
            label4.Text = "Descripcion";
            // 
            // CompraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 576);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCompra);
            Controls.Add(txtTotal);
            Controls.Add(txtProveedor);
            Controls.Add(txtDescripcion);
            Controls.Add(txtFecha);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CompraForm";
            Text = "CompraForm";
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtFecha;
        private TextBox txtDescripcion;
        private TextBox txtProveedor;
        private TextBox txtTotal;
        private DataGridView dgvCompra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}