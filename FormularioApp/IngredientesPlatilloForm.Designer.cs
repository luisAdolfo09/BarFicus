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
            pictureBox1 = new PictureBox();
            //panel1 = new Panel();
            //label1 = new Label();
            //label2 = new Label();
            txtIngredientesPlatillo = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            txtCantidadNecesario = new TextBox();
            dgvIngredientesPlatillo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientesPlatillo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SLIDE_JUST_EAT_6533_copia;
            pictureBox1.Location = new Point(175, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 82);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(185, 31);
            label1.Name = "label1";
            label1.Size = new Size(251, 28);
            label1.TabIndex = 0;
            label1.Text = "Registrar un Platillo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(29, 329);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre del platillo:";
            // 
            // txtIngredientesPlatillo
            // 
            txtIngredientesPlatillo.Location = new Point(185, 326);
            txtIngredientesPlatillo.Name = "txtIngredientesPlatillo";
            txtIngredientesPlatillo.Size = new Size(191, 27);
            txtIngredientesPlatillo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Location = new Point(413, 329);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "Ingrediente:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(523, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonFace;
            label4.Location = new Point(29, 377);
            label4.Name = "label4";
            label4.Size = new Size(119, 24);
            label4.TabIndex = 6;
            label4.Text = "Cantidad:";
            // 
            // txtCantidadNecesario
            // 
            txtCantidadNecesario.Location = new Point(185, 374);
            txtCantidadNecesario.Name = "txtCantidadNecesario";
            txtCantidadNecesario.Size = new Size(125, 27);
            txtCantidadNecesario.TabIndex = 7;
            // 
            // dgvIngredientesPlatillo
            // 
            dgvIngredientesPlatillo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientesPlatillo.Location = new Point(29, 433);
            dgvIngredientesPlatillo.Name = "dgvIngredientesPlatillo";
            dgvIngredientesPlatillo.RowHeadersWidth = 51;
            dgvIngredientesPlatillo.Size = new Size(596, 274);
            dgvIngredientesPlatillo.TabIndex = 8;
            // 
            // IngredientesPlatilloForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(738, 739);
            Controls.Add(dgvIngredientesPlatillo);
            Controls.Add(txtCantidadNecesario);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(txtIngredientesPlatillo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "IngredientesPlatilloForm";
            Text = "IngredientesPlatilloForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientesPlatillo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtIngredientesPlatillo;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox txtCantidadNecesario;
        private DataGridView dgvIngredientesPlatillo;
    }
}