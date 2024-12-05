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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnEditarCliente = new FontAwesome.Sharp.IconButton();
            btnBorrarCliente = new FontAwesome.Sharp.IconButton();
            btnGuardarCliente = new FontAwesome.Sharp.IconButton();
            txtEmail = new TextBox();
            txtNumtelefono = new TextBox();
            txtNombreCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvClientes = new DataGridView();
            panel3 = new Panel();
            label5 = new Label();
            comboFiltro = new ComboBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            txtFlitroCliente = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.2787952F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.72121F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1020, 554);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnEditarCliente);
            panel1.Controls.Add(btnBorrarCliente);
            panel1.Controls.Add(btnGuardarCliente);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNumtelefono);
            panel1.Controls.Add(txtNombreCliente);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 548);
            panel1.TabIndex = 0;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.DarkSlateGray;
            btnEditarCliente.FlatAppearance.BorderSize = 2;
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            btnEditarCliente.IconColor = Color.Black;
            btnEditarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarCliente.Location = new Point(106, 469);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(62, 48);
            btnEditarCliente.TabIndex = 10;
            btnEditarCliente.UseVisualStyleBackColor = false;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.BackColor = Color.DarkSlateGray;
            btnBorrarCliente.FlatAppearance.BorderSize = 2;
            btnBorrarCliente.FlatStyle = FlatStyle.Flat;
            btnBorrarCliente.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrarCliente.IconColor = Color.Black;
            btnBorrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarCliente.Location = new Point(192, 469);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(62, 48);
            btnBorrarCliente.TabIndex = 9;
            btnBorrarCliente.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.DarkSlateGray;
            btnGuardarCliente.FlatAppearance.BorderSize = 2;
            btnGuardarCliente.FlatStyle = FlatStyle.Flat;
            btnGuardarCliente.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btnGuardarCliente.IconColor = Color.Black;
            btnGuardarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarCliente.Location = new Point(19, 469);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(62, 48);
            btnGuardarCliente.TabIndex = 8;
            btnGuardarCliente.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(19, 406);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 30);
            txtEmail.TabIndex = 7;
            // 
            // txtNumtelefono
            // 
            txtNumtelefono.Font = new Font("Segoe UI", 10.2F);
            txtNumtelefono.Location = new Point(19, 297);
            txtNumtelefono.Name = "txtNumtelefono";
            txtNumtelefono.Size = new Size(194, 30);
            txtNumtelefono.TabIndex = 6;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Segoe UI", 10.2F);
            txtNombreCliente.Location = new Point(19, 186);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(194, 30);
            txtNombreCliente.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkOliveGreen;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 353);
            label4.Name = "label4";
            label4.Size = new Size(140, 38);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.BackColor = Color.DarkOliveGreen;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 244);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 3;
            label3.Text = "Numero:";
            // 
            // label2
            // 
            label2.BackColor = Color.DarkOliveGreen;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 136);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.DarkSlateGray;
            iconPictureBox1.ForeColor = Color.Honeydew;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconPictureBox1.IconColor = Color.Honeydew;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 61;
            iconPictureBox1.Location = new Point(19, 33);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(66, 61);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 46);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 0;
            label1.Text = "Detalle Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvClientes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(301, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 548);
            panel2.TabIndex = 1;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(20, 160);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(687, 366);
            dgvClientes.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtFlitroCliente);
            panel3.Controls.Add(iconButton4);
            panel3.Controls.Add(iconButton3);
            panel3.Controls.Add(comboFiltro);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(716, 131);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSlateGray;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(20, 23);
            label5.Name = "label5";
            label5.Size = new Size(687, 61);
            label5.TabIndex = 0;
            label5.Text = "Lista De Usuarios:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboFiltro
            // 
            comboFiltro.FormattingEnabled = true;
            comboFiltro.Location = new Point(192, 41);
            comboFiltro.Name = "comboFiltro";
            comboFiltro.Size = new Size(151, 28);
            comboFiltro.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.DarkSlateGray;
            iconButton3.FlatAppearance.BorderSize = 2;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconButton3.IconColor = Color.OliveDrab;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(583, 33);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(45, 39);
            iconButton3.TabIndex = 9;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.DarkSlateGray;
            iconButton4.FlatAppearance.BorderSize = 2;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton4.IconColor = Color.OliveDrab;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(647, 33);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(40, 39);
            iconButton4.TabIndex = 10;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // txtFlitroCliente
            // 
            txtFlitroCliente.Location = new Point(387, 41);
            txtFlitroCliente.Name = "txtFlitroCliente";
            txtFlitroCliente.Size = new Size(161, 27);
            txtFlitroCliente.TabIndex = 11;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 554);
            Controls.Add(tableLayoutPanel1);
            Name = "ClienteForm";
            Text = "ClienteForm";
            Load += ClienteForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvClientes;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnGuardarCliente;
        private TextBox txtEmail;
        private TextBox txtNumtelefono;
        private TextBox txtNombreCliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnEditarCliente;
        private FontAwesome.Sharp.IconButton btnBorrarCliente;
        private Panel panel3;
        private ComboBox comboFiltro;
        private Label label5;
        private TextBox txtFlitroCliente;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}