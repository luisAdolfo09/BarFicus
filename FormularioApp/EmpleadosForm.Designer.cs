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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            dgvEmpleados = new DataGridView();
            PrimerNombre = new DataGridViewTextBoxColumn();
            PrimerApellido = new DataGridViewTextBoxColumn();
            SegundoApellido = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Puesto = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            btnGuardarProvee = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtTelefono = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtCedulaIndentidad = new TextBox();
            label6 = new Label();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPrimerNombre = new TextBox();
            label2 = new Label();
            btnCrear = new FontAwesome.Sharp.IconButton();
            txtAntiguedad = new TextBox();
            txtPuesto = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5619831F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.43802F));
            tableLayoutPanel1.Size = new Size(1161, 706);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 82);
            panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.InactiveCaption;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            iconButton1.IconColor = Color.SeaGreen;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(23, 9);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(331, 51);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Registro de Empleados";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkGreen;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1155, 82);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1155, 612);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2512474F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.7487526F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1155, 612);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(btnGuardarProvee);
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(1149, 305);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRegistrar);
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(btnEditar);
            panel5.Controls.Add(dgvEmpleados);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1149, 305);
            panel5.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.Location = new Point(965, 193);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 85);
            btnRegistrar.TabIndex = 34;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(993, 108);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(62, 48);
            btnEliminar.TabIndex = 33;
            btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(993, 34);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 48);
            btnEditar.TabIndex = 32;
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { PrimerNombre, PrimerApellido, SegundoApellido, Cedula, Puesto, Telefono });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEmpleados.Location = new Point(6, 16);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(910, 283);
            dgvEmpleados.TabIndex = 2;
            // 
            // PrimerNombre
            // 
            PrimerNombre.HeaderText = "Nombre";
            PrimerNombre.MinimumWidth = 6;
            PrimerNombre.Name = "PrimerNombre";
            PrimerNombre.Width = 150;
            // 
            // PrimerApellido
            // 
            PrimerApellido.HeaderText = "Primer Apellido";
            PrimerApellido.MinimumWidth = 6;
            PrimerApellido.Name = "PrimerApellido";
            PrimerApellido.Width = 150;
            // 
            // SegundoApellido
            // 
            SegundoApellido.HeaderText = "Segundo Apellido";
            SegundoApellido.MinimumWidth = 6;
            SegundoApellido.Name = "SegundoApellido";
            SegundoApellido.Width = 150;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.Width = 150;
            // 
            // Puesto
            // 
            Puesto.HeaderText = "Puesto";
            Puesto.MinimumWidth = 6;
            Puesto.Name = "Puesto";
            Puesto.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // btnGuardarProvee
            // 
            btnGuardarProvee.BackColor = Color.DarkSlateGray;
            btnGuardarProvee.FlatAppearance.BorderSize = 2;
            btnGuardarProvee.FlatStyle = FlatStyle.Flat;
            btnGuardarProvee.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btnGuardarProvee.IconColor = Color.Black;
            btnGuardarProvee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarProvee.Location = new Point(899, 34);
            btnGuardarProvee.Name = "btnGuardarProvee";
            btnGuardarProvee.Size = new Size(62, 48);
            btnGuardarProvee.TabIndex = 9;
            btnGuardarProvee.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(568, 257);
            dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(btnCrear);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1149, 295);
            panel4.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPuesto);
            groupBox1.Controls.Add(txtAntiguedad);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCedulaIndentidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSegundoApellido);
            groupBox1.Controls.Add(txtPrimerApellido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrimerNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1028, 258);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5196_png_1200;
            pictureBox1.Location = new Point(805, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(780, 82);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 32);
            txtTelefono.TabIndex = 17;
            // 
            // label8
            // 
            label8.BackColor = Color.Lavender;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F);
            label8.Location = new Point(805, 32);
            label8.Name = "label8";
            label8.Size = new Size(160, 36);
            label8.TabIndex = 16;
            label8.Text = "Telefono:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Lavender;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(526, 130);
            label7.Name = "label7";
            label7.Size = new Size(160, 36);
            label7.TabIndex = 14;
            label7.Text = "Antigüedad:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCedulaIndentidad
            // 
            txtCedulaIndentidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCedulaIndentidad.Location = new Point(526, 82);
            txtCedulaIndentidad.Name = "txtCedulaIndentidad";
            txtCedulaIndentidad.Size = new Size(214, 32);
            txtCedulaIndentidad.TabIndex = 13;
            // 
            // label6
            // 
            label6.BackColor = Color.Lavender;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(526, 32);
            label6.Name = "label6";
            label6.Size = new Size(160, 36);
            label6.TabIndex = 12;
            label6.Text = "Cedula:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSegundoApellido.Location = new Point(269, 82);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(198, 32);
            txtSegundoApellido.TabIndex = 10;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerApellido.Location = new Point(14, 179);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(198, 32);
            txtPrimerApellido.TabIndex = 9;
            txtPrimerApellido.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.Lavender;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 130);
            label5.Name = "label5";
            label5.Size = new Size(171, 36);
            label5.TabIndex = 8;
            label5.Text = "Primer Apellido:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Lavender;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(269, 32);
            label4.Name = "label4";
            label4.Size = new Size(179, 36);
            label4.TabIndex = 7;
            label4.Text = "Segundo Apellido:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Lavender;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(269, 130);
            label3.Name = "label3";
            label3.Size = new Size(142, 36);
            label3.TabIndex = 6;
            label3.Text = "Puesto:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrimerNombre.Location = new Point(14, 82);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(198, 32);
            txtPrimerNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = Color.Lavender;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 32);
            label2.Name = "label2";
            label2.Size = new Size(171, 36);
            label2.TabIndex = 0;
            label2.Text = "Primer Nombre:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ControlLightLight;
            btnCrear.FlatAppearance.BorderSize = 2;
            btnCrear.ForeColor = SystemColors.ButtonHighlight;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(1069, 118);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(62, 48);
            btnCrear.TabIndex = 9;
            btnCrear.UseVisualStyleBackColor = false;
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAntiguedad.Location = new Point(526, 179);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.Size = new Size(214, 32);
            txtAntiguedad.TabIndex = 19;
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPuesto.Location = new Point(269, 179);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(198, 32);
            txtPuesto.TabIndex = 20;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 706);
            Controls.Add(tableLayoutPanel1);
            Name = "EmpleadosForm";
            Text = "EmpleadosForm";
            Load += EmpleadosForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnGuardarProvee;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton btnCrear;
        private DataGridView dgvEmpleados;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private TextBox txtPrimerApellido;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPrimerNombre;
        private Label label2;
        private Label label7;
        private TextBox txtCedulaIndentidad;
        private Label label6;
        private TextBox txtSegundoApellido;
        private PictureBox pictureBox1;
        private TextBox txtTelefono;
        private Label label8;
        private DataGridViewTextBoxColumn PrimerNombre;
        private DataGridViewTextBoxColumn PrimerApellido;
        private DataGridViewTextBoxColumn SegundoApellido;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Puesto;
        private DataGridViewTextBoxColumn Telefono;
        private TextBox txtAntiguedad;
        private TextBox txtPuesto;
    }
}