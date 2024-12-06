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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            btnGuardarProvee = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            dataGridView2 = new DataGridView();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            PrimerNombre = new DataGridViewTextBoxColumn();
            PrimerApellido = new DataGridViewTextBoxColumn();
            SegundoApellido = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Puesto = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(568, 257);
            dataGridView1.TabIndex = 2;
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
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(iconButton2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1149, 295);
            panel4.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1028, 258);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
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
            // panel5
            // 
            panel5.Controls.Add(btnRegistrar);
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(btnEditar);
            panel5.Controls.Add(dataGridView2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1149, 305);
            panel5.TabIndex = 10;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.ControlLightLight;
            iconButton2.FlatAppearance.BorderSize = 2;
            iconButton2.ForeColor = SystemColors.ButtonHighlight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(1069, 118);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(62, 48);
            iconButton2.TabIndex = 9;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { PrimerNombre, PrimerApellido, SegundoApellido, Cedula, Puesto, Telefono });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Location = new Point(6, 16);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(910, 283);
            dataGridView2.TabIndex = 2;
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
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(14, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 32);
            textBox1.TabIndex = 5;
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
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(14, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 32);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(269, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 32);
            textBox3.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(269, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 31);
            comboBox1.TabIndex = 11;
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
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(526, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 32);
            textBox4.TabIndex = 13;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(526, 175);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 28);
            dateTimePicker1.TabIndex = 15;
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
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(780, 82);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 32);
            textBox5.TabIndex = 17;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataGridView dataGridView2;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn PrimerNombre;
        private DataGridViewTextBoxColumn PrimerApellido;
        private DataGridViewTextBoxColumn SegundoApellido;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Puesto;
        private DataGridViewTextBoxColumn Telefono;
    }
}