namespace FormularioApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlLateral = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            errorProvider1 = new ErrorProvider(components);
            lblRegistrarse = new LinkLabel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackgroundImage = (Image)resources.GetObject("pnlLateral.BackgroundImage");
            pnlLateral.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLateral.Location = new Point(0, 2);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(800, 695);
            pnlLateral.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(800, -23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(601, 439);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(860, 461);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(845, 516);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(1055, 458);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(264, 27);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(1055, 509);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(264, 27);
            txtContraseña.TabIndex = 5;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.LightSeaGreen;
            btnIniciarSesion.Location = new Point(908, 571);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(412, 43);
            btnIniciarSesion.TabIndex = 6;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.AutoSize = true;
            lblRegistrarse.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrarse.Location = new Point(1184, 644);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(131, 21);
            lblRegistrarse.TabIndex = 7;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = "REGISTRARSE";
            lblRegistrarse.LinkClicked += lblRegistrarse_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(982, 645);
            label3.Name = "label3";
            label3.Size = new Size(196, 20);
            label3.TabIndex = 8;
            label3.Text = "No tienes cuenta?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1402, 697);
            Controls.Add(label3);
            Controls.Add(lblRegistrarse);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pnlLateral);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLateral;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIniciarSesion;
        private ErrorProvider errorProvider1;
        private Label label3;
        private LinkLabel lblRegistrarse;
    }
}