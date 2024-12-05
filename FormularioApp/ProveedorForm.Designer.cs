namespace FormularioApp
{
    partial class ProveedorForm
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
            txtFlitroProvee = new TextBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnEditarProvee = new FontAwesome.Sharp.IconButton();
            btnBorrarProvee = new FontAwesome.Sharp.IconButton();
            btnGuardarProvee = new FontAwesome.Sharp.IconButton();
            txtCorreoProvee = new TextBox();
            txtContactoProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            comboFiltroProvee = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            dgvClientes = new DataGridView();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            NombreProveedor = new DataGridViewTextBoxColumn();
            ContactoProvee = new DataGridViewTextBoxColumn();
            TelefonoProvee = new DataGridViewTextBoxColumn();
            DireccionProvee = new DataGridViewTextBoxColumn();
            CorreoProvee = new DataGridViewTextBoxColumn();
            label6 = new Label();
            txtDireccionProvee = new TextBox();
            label7 = new Label();
            txtTelefonoProvee = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtFlitroProvee
            // 
            txtFlitroProvee.Location = new Point(496, 71);
            txtFlitroProvee.Name = "txtFlitroProvee";
            txtFlitroProvee.Size = new Size(171, 27);
            txtFlitroProvee.TabIndex = 11;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton3.BackColor = Color.DarkSlateGray;
            iconButton3.FlatAppearance.BorderSize = 2;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconButton3.IconColor = Color.OliveDrab;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(719, 60);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(45, 39);
            iconButton3.TabIndex = 9;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // btnEditarProvee
            // 
            btnEditarProvee.BackColor = Color.DarkSlateGray;
            btnEditarProvee.FlatAppearance.BorderSize = 2;
            btnEditarProvee.FlatStyle = FlatStyle.Flat;
            btnEditarProvee.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            btnEditarProvee.IconColor = Color.Black;
            btnEditarProvee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarProvee.Location = new Point(131, 645);
            btnEditarProvee.Name = "btnEditarProvee";
            btnEditarProvee.Size = new Size(62, 48);
            btnEditarProvee.TabIndex = 10;
            btnEditarProvee.UseVisualStyleBackColor = false;
            // 
            // btnBorrarProvee
            // 
            btnBorrarProvee.BackColor = Color.DarkSlateGray;
            btnBorrarProvee.FlatAppearance.BorderSize = 2;
            btnBorrarProvee.FlatStyle = FlatStyle.Flat;
            btnBorrarProvee.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrarProvee.IconColor = Color.Black;
            btnBorrarProvee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarProvee.Location = new Point(230, 645);
            btnBorrarProvee.Name = "btnBorrarProvee";
            btnBorrarProvee.Size = new Size(62, 48);
            btnBorrarProvee.TabIndex = 9;
            btnBorrarProvee.UseVisualStyleBackColor = false;
            // 
            // btnGuardarProvee
            // 
            btnGuardarProvee.BackColor = Color.DarkSlateGray;
            btnGuardarProvee.FlatAppearance.BorderSize = 2;
            btnGuardarProvee.FlatStyle = FlatStyle.Flat;
            btnGuardarProvee.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btnGuardarProvee.IconColor = Color.Black;
            btnGuardarProvee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarProvee.Location = new Point(33, 645);
            btnGuardarProvee.Name = "btnGuardarProvee";
            btnGuardarProvee.Size = new Size(62, 48);
            btnGuardarProvee.TabIndex = 8;
            btnGuardarProvee.UseVisualStyleBackColor = false;
            // 
            // txtCorreoProvee
            // 
            txtCorreoProvee.Font = new Font("Segoe UI", 10.2F);
            txtCorreoProvee.Location = new Point(19, 587);
            txtCorreoProvee.Name = "txtCorreoProvee";
            txtCorreoProvee.Size = new Size(289, 30);
            txtCorreoProvee.TabIndex = 7;
            // 
            // txtContactoProveedor
            // 
            txtContactoProveedor.Font = new Font("Segoe UI", 10.2F);
            txtContactoProveedor.Location = new Point(19, 267);
            txtContactoProveedor.Name = "txtContactoProveedor";
            txtContactoProveedor.Size = new Size(194, 30);
            txtContactoProveedor.TabIndex = 6;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Font = new Font("Segoe UI", 10.2F);
            txtNombreProveedor.Location = new Point(19, 167);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(194, 30);
            txtNombreProveedor.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkOliveGreen;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 535);
            label4.Name = "label4";
            label4.Size = new Size(140, 38);
            label4.TabIndex = 4;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.BackColor = Color.DarkOliveGreen;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 219);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 3;
            label3.Text = "Contacto:";
            // 
            // comboFiltroProvee
            // 
            comboFiltroProvee.FormattingEnabled = true;
            comboFiltroProvee.Location = new Point(283, 71);
            comboFiltroProvee.Name = "comboFiltroProvee";
            comboFiltroProvee.Size = new Size(176, 28);
            comboFiltroProvee.TabIndex = 1;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSlateGray;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(828, 167);
            label5.TabIndex = 0;
            label5.Text = "Lista De Proveedores:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtFlitroProvee);
            panel3.Controls.Add(iconButton4);
            panel3.Controls.Add(iconButton3);
            panel3.Controls.Add(comboFiltroProvee);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(828, 164);
            panel3.TabIndex = 1;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton4.BackColor = Color.DarkSlateGray;
            iconButton4.FlatAppearance.BorderSize = 2;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton4.IconColor = Color.OliveDrab;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(779, 60);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(40, 39);
            iconButton4.TabIndex = 10;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { NombreProveedor, ContactoProvee, TelefonoProvee, DireccionProvee, CorreoProvee });
            dgvClientes.Location = new Point(0, 170);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(822, 537);
            dgvClientes.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkOliveGreen;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 116);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.DarkSlateGray;
            iconPictureBox1.ForeColor = Color.Honeydew;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            iconPictureBox1.IconColor = Color.Honeydew;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 60;
            iconPictureBox1.Location = new Point(19, 33);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(62, 60);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 41);
            label1.Name = "label1";
            label1.Size = new Size(202, 43);
            label1.TabIndex = 0;
            label1.Text = "Detalles Proveedor:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6462879F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.353714F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1168, 722);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(txtTelefonoProvee);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDireccionProvee);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnEditarProvee);
            panel1.Controls.Add(btnBorrarProvee);
            panel1.Controls.Add(btnGuardarProvee);
            panel1.Controls.Add(txtCorreoProvee);
            panel1.Controls.Add(txtContactoProveedor);
            panel1.Controls.Add(txtNombreProveedor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 716);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvClientes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(337, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 716);
            panel2.TabIndex = 1;
            // 
            // NombreProveedor
            // 
            NombreProveedor.HeaderText = "Nombre";
            NombreProveedor.MinimumWidth = 6;
            NombreProveedor.Name = "NombreProveedor";
            NombreProveedor.Width = 150;
            // 
            // ContactoProvee
            // 
            ContactoProvee.HeaderText = "Contacto";
            ContactoProvee.MinimumWidth = 6;
            ContactoProvee.Name = "ContactoProvee";
            ContactoProvee.Width = 125;
            // 
            // TelefonoProvee
            // 
            TelefonoProvee.HeaderText = "Telefono";
            TelefonoProvee.MinimumWidth = 6;
            TelefonoProvee.Name = "TelefonoProvee";
            TelefonoProvee.Width = 125;
            // 
            // DireccionProvee
            // 
            DireccionProvee.HeaderText = "Direccion";
            DireccionProvee.MinimumWidth = 6;
            DireccionProvee.Name = "DireccionProvee";
            DireccionProvee.Width = 180;
            // 
            // CorreoProvee
            // 
            CorreoProvee.HeaderText = "Correo";
            CorreoProvee.MinimumWidth = 6;
            CorreoProvee.Name = "CorreoProvee";
            CorreoProvee.Width = 180;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOliveGreen;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 422);
            label6.Name = "label6";
            label6.Size = new Size(140, 38);
            label6.TabIndex = 11;
            label6.Text = "Direccion:";
            // 
            // txtDireccionProvee
            // 
            txtDireccionProvee.Font = new Font("Segoe UI", 10.2F);
            txtDireccionProvee.Location = new Point(19, 480);
            txtDireccionProvee.Name = "txtDireccionProvee";
            txtDireccionProvee.Size = new Size(289, 30);
            txtDireccionProvee.TabIndex = 12;
            // 
            // label7
            // 
            label7.BackColor = Color.DarkOliveGreen;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 312);
            label7.Name = "label7";
            label7.Size = new Size(140, 38);
            label7.TabIndex = 13;
            label7.Text = "Telefono:";
            // 
            // txtTelefonoProvee
            // 
            txtTelefonoProvee.Font = new Font("Segoe UI", 10.2F);
            txtTelefonoProvee.Location = new Point(19, 369);
            txtTelefonoProvee.Name = "txtTelefonoProvee";
            txtTelefonoProvee.Size = new Size(194, 30);
            txtTelefonoProvee.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(327, 33);
            label8.Name = "label8";
            label8.Size = new Size(103, 21);
            label8.TabIndex = 12;
            label8.Text = "Buscar por:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(535, 33);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 13;
            label9.Text = "Campo:";
            // 
            // ProveedorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 722);
            Controls.Add(tableLayoutPanel1);
            Name = "ProveedorForm";
            Text = "ProveedorForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFlitroProvee;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnEditarProvee;
        private FontAwesome.Sharp.IconButton btnBorrarProvee;
        private FontAwesome.Sharp.IconButton btnGuardarProvee;
        private TextBox txtCorreoProvee;
        private TextBox txtContactoProveedor;
        private TextBox txtNombreProveedor;
        private Label label4;
        private Label label3;
        private ComboBox comboFiltroProvee;
        private Label label5;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private DataGridView dgvClientes;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn NombreProveedor;
        private DataGridViewTextBoxColumn ContactoProvee;
        private DataGridViewTextBoxColumn TelefonoProvee;
        private DataGridViewTextBoxColumn DireccionProvee;
        private DataGridViewTextBoxColumn CorreoProvee;
        private TextBox txtTelefonoProvee;
        private Label label7;
        private TextBox txtDireccionProvee;
        private Label label6;
        private Label label9;
        private Label label8;
    }
}