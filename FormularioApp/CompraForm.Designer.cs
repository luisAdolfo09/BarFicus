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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtDescripcion = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            textBox3 = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.305027F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.694973F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 88);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.88F));
            tableLayoutPanel1.Size = new Size(1154, 625);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 87);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSlateGray;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1154, 85);
            label5.TabIndex = 14;
            label5.Text = "Registrar Compras:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 201);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion De Compra:";
            // 
            // label7
            // 
            label7.BackColor = Color.DarkOliveGreen;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(96, 42);
            label7.Name = "label7";
            label7.Size = new Size(70, 39);
            label7.TabIndex = 10;
            label7.Text = "Fecha:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(487, 93);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(205, 27);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(713, 412);
            dataGridView1.TabIndex = 21;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOliveGreen;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 42);
            label1.Name = "label1";
            label1.Size = new Size(109, 39);
            label1.TabIndex = 12;
            label1.Text = "Proveedor";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(300, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkOliveGreen;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(526, 42);
            label2.Name = "label2";
            label2.Size = new Size(125, 39);
            label2.TabIndex = 14;
            label2.Text = "Descripcion:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(22, 66);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 28);
            comboBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkOliveGreen;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 16);
            label3.Name = "label3";
            label3.Size = new Size(125, 37);
            label3.TabIndex = 16;
            label3.Text = "Producto:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(722, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 201);
            panel2.TabIndex = 24;
            // 
            // label4
            // 
            label4.BackColor = Color.Teal;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(429, 201);
            label4.TabIndex = 24;
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(722, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(429, 412);
            panel3.TabIndex = 25;
            // 
            // label6
            // 
            label6.BackColor = Color.Teal;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(429, 412);
            label6.TabIndex = 25;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.BackColor = Color.DarkOliveGreen;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(236, 16);
            label8.Name = "label8";
            label8.Size = new Size(157, 37);
            label8.TabIndex = 25;
            label8.Text = "Precio Compra:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 26;
            // 
            // label9
            // 
            label9.BackColor = Color.DarkOliveGreen;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(236, 108);
            label9.Name = "label9";
            label9.Size = new Size(157, 37);
            label9.TabIndex = 27;
            label9.Text = "Precio de Venta:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 27);
            textBox2.TabIndex = 28;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(50, 108);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(112, 78);
            iconButton1.TabIndex = 29;
            iconButton1.Text = "Agregar";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.BackColor = Color.DarkOliveGreen;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(132, 36);
            label10.Name = "label10";
            label10.Size = new Size(165, 37);
            label10.TabIndex = 26;
            label10.Text = "Total a pagar:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 27);
            textBox3.TabIndex = 27;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(163, 166);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(112, 78);
            iconButton2.TabIndex = 30;
            iconButton2.Text = "Registrar";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // CompraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 713);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "CompraForm";
            Text = "CompraForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label5;
        private GroupBox groupBox1;
        private Label label1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox txtDescripcion;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Panel panel2;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox1;
        private Label label8;
        private Panel panel3;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox3;
        private Label label10;
    }
}