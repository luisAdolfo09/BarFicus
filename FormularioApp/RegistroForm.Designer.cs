namespace FormularioApp
{
    partial class RegistroForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnRegistrar = new Button();
            txtRegistroContraseña = new TextBox();
            txtRegistroUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            btnAtras = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAtras);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtRegistroContraseña);
            panel1.Controls.Add(txtRegistroUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(124, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 596);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(568, 99);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightSeaGreen;
            btnRegistrar.Font = new Font("Courier New", 12F, FontStyle.Bold);
            btnRegistrar.Location = new Point(446, 425);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(367, 81);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtRegistroContraseña
            // 
            txtRegistroContraseña.Location = new Point(446, 339);
            txtRegistroContraseña.Margin = new Padding(3, 4, 3, 4);
            txtRegistroContraseña.MaxLength = 10;
            txtRegistroContraseña.Name = "txtRegistroContraseña";
            txtRegistroContraseña.PasswordChar = '*';
            txtRegistroContraseña.Size = new Size(366, 27);
            txtRegistroContraseña.TabIndex = 5;
            txtRegistroContraseña.TextChanged += txtRegistroContraseña_TextChanged;
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Location = new Point(446, 231);
            txtRegistroUsuario.Margin = new Padding(3, 4, 3, 4);
            txtRegistroUsuario.MaxLength = 12;
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.Size = new Size(366, 27);
            txtRegistroUsuario.TabIndex = 4;
            txtRegistroUsuario.TextChanged += txtRegistroUsuario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label3.Location = new Point(435, 311);
            label3.Name = "label3";
            label3.Size = new Size(274, 23);
            label3.TabIndex = 3;
            label3.Text = "Ingrese Una Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label2.Location = new Point(431, 203);
            label2.Name = "label2";
            label2.Size = new Size(346, 23);
            label2.TabIndex = 2;
            label2.Text = "Ingrese Un Nombre De Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 14.25F, FontStyle.Bold);
            label1.Location = new Point(510, 41);
            label1.Name = "label1";
            label1.Size = new Size(278, 27);
            label1.TabIndex = 1;
            label1.Text = "Registro de Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 553);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.LightSeaGreen;
            btnAtras.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.Location = new Point(701, 525);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(122, 45);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 709);
            Controls.Add(panel1);
            Name = "RegistroForm";
            Text = "RegistroForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnRegistrar;
        private TextBox txtRegistroContraseña;
        private TextBox txtRegistroUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private Button btnAtras;
    }
}