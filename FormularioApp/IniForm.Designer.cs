namespace FormularioApp
{
    partial class IniForm
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
            panelIniLateral = new Panel();
            panelDetalles = new Panel();
            btnDetalleVenta = new FontAwesome.Sharp.IconButton();
            btnDetalleCompra = new FontAwesome.Sharp.IconButton();
            btnDetalles = new Button();
            panelInventario = new Panel();
            Ingredientes = new Button();
            btnPlatillos = new Button();
            btnProductos = new Button();
            Inventario = new Button();
            panelNegocio = new Panel();
            btnVentas = new Button();
            btnCompra = new Button();
            btnNegocios = new Button();
            panelSubMenu = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnProducto = new FontAwesome.Sharp.IconButton();
            btnProveedores = new Button();
            btnempleados = new Button();
            btnRegist = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelChildForm = new Panel();
            panelIniLateral.SuspendLayout();
            panelDetalles.SuspendLayout();
            panelInventario.SuspendLayout();
            panelNegocio.SuspendLayout();
            panelSubMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelIniLateral
            // 
            panelIniLateral.AutoScroll = true;
            panelIniLateral.BackColor = Color.FromArgb(11, 7, 17);
            panelIniLateral.Controls.Add(panelDetalles);
            panelIniLateral.Controls.Add(btnDetalles);
            panelIniLateral.Controls.Add(panelInventario);
            panelIniLateral.Controls.Add(Inventario);
            panelIniLateral.Controls.Add(panelNegocio);
            panelIniLateral.Controls.Add(btnNegocios);
            panelIniLateral.Controls.Add(panelSubMenu);
            panelIniLateral.Controls.Add(btnRegist);
            panelIniLateral.Controls.Add(panelLogo);
            panelIniLateral.Dock = DockStyle.Left;
            panelIniLateral.Location = new Point(0, 0);
            panelIniLateral.Name = "panelIniLateral";
            panelIniLateral.Size = new Size(265, 919);
            panelIniLateral.TabIndex = 0;
            // 
            // panelDetalles
            // 
            panelDetalles.Controls.Add(btnDetalleVenta);
            panelDetalles.Controls.Add(btnDetalleCompra);
            panelDetalles.Dock = DockStyle.Top;
            panelDetalles.Location = new Point(0, 788);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(265, 99);
            panelDetalles.TabIndex = 8;
            // 
            // btnDetalleVenta
            // 
            btnDetalleVenta.BackColor = Color.FromArgb(35, 32, 39);
            btnDetalleVenta.Dock = DockStyle.Top;
            btnDetalleVenta.FlatStyle = FlatStyle.Flat;
            btnDetalleVenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetalleVenta.ForeColor = Color.White;
            btnDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDetalleVenta.IconColor = Color.Black;
            btnDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDetalleVenta.Location = new Point(0, 47);
            btnDetalleVenta.Name = "btnDetalleVenta";
            btnDetalleVenta.Size = new Size(265, 50);
            btnDetalleVenta.TabIndex = 1;
            btnDetalleVenta.Text = "Detalle Venta";
            btnDetalleVenta.UseVisualStyleBackColor = false;
            btnDetalleVenta.Click += iconButton3_Click;
            // 
            // btnDetalleCompra
            // 
            btnDetalleCompra.BackColor = Color.FromArgb(35, 32, 39);
            btnDetalleCompra.Dock = DockStyle.Top;
            btnDetalleCompra.FlatStyle = FlatStyle.Flat;
            btnDetalleCompra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetalleCompra.ForeColor = Color.White;
            btnDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDetalleCompra.IconColor = Color.Black;
            btnDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDetalleCompra.Location = new Point(0, 0);
            btnDetalleCompra.Name = "btnDetalleCompra";
            btnDetalleCompra.Size = new Size(265, 47);
            btnDetalleCompra.TabIndex = 0;
            btnDetalleCompra.Text = "Detalle Compra";
            btnDetalleCompra.UseVisualStyleBackColor = false;
            btnDetalleCompra.Click += iconButton2_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Dock = DockStyle.Top;
            btnDetalles.FlatAppearance.BorderSize = 0;
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.Gainsboro;
            btnDetalles.Location = new Point(0, 732);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Padding = new Padding(10, 0, 0, 0);
            btnDetalles.Size = new Size(265, 56);
            btnDetalles.TabIndex = 7;
            btnDetalles.Text = "Detalles";
            btnDetalles.TextAlign = ContentAlignment.MiddleLeft;
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // panelInventario
            // 
            panelInventario.BackColor = Color.FromArgb(35, 32, 39);
            panelInventario.Controls.Add(Ingredientes);
            panelInventario.Controls.Add(btnPlatillos);
            panelInventario.Controls.Add(btnProductos);
            panelInventario.Dock = DockStyle.Top;
            panelInventario.Location = new Point(0, 581);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(265, 151);
            panelInventario.TabIndex = 6;
            // 
            // Ingredientes
            // 
            Ingredientes.Dock = DockStyle.Top;
            Ingredientes.FlatStyle = FlatStyle.Flat;
            Ingredientes.ForeColor = Color.LightGray;
            Ingredientes.Location = new Point(0, 103);
            Ingredientes.Name = "Ingredientes";
            Ingredientes.Padding = new Padding(35, 0, 0, 0);
            Ingredientes.Size = new Size(265, 48);
            Ingredientes.TabIndex = 2;
            Ingredientes.Text = "Ingredientes";
            Ingredientes.UseVisualStyleBackColor = true;
            Ingredientes.Click += Ingredientes_Click;
            // 
            // btnPlatillos
            // 
            btnPlatillos.Dock = DockStyle.Top;
            btnPlatillos.FlatStyle = FlatStyle.Flat;
            btnPlatillos.ForeColor = Color.LightGray;
            btnPlatillos.Location = new Point(0, 53);
            btnPlatillos.Name = "btnPlatillos";
            btnPlatillos.Padding = new Padding(35, 0, 0, 0);
            btnPlatillos.Size = new Size(265, 50);
            btnPlatillos.TabIndex = 1;
            btnPlatillos.Text = "Platillos";
            btnPlatillos.UseVisualStyleBackColor = true;
            btnPlatillos.Click += btnPlatillos_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.LightGray;
            btnProductos.Location = new Point(0, 0);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(35, 0, 0, 0);
            btnProductos.Size = new Size(265, 53);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // Inventario
            // 
            Inventario.Dock = DockStyle.Top;
            Inventario.FlatAppearance.BorderSize = 0;
            Inventario.FlatStyle = FlatStyle.Flat;
            Inventario.ForeColor = Color.Gainsboro;
            Inventario.Location = new Point(0, 523);
            Inventario.Name = "Inventario";
            Inventario.Padding = new Padding(10, 0, 0, 0);
            Inventario.Size = new Size(265, 58);
            Inventario.TabIndex = 5;
            Inventario.Text = "Inventario";
            Inventario.TextAlign = ContentAlignment.MiddleLeft;
            Inventario.UseVisualStyleBackColor = true;
            Inventario.Click += Inventario_Click;
            // 
            // panelNegocio
            // 
            panelNegocio.BackColor = Color.FromArgb(35, 32, 39);
            panelNegocio.Controls.Add(btnVentas);
            panelNegocio.Controls.Add(btnCompra);
            panelNegocio.Dock = DockStyle.Top;
            panelNegocio.Location = new Point(0, 426);
            panelNegocio.Name = "panelNegocio";
            panelNegocio.Size = new Size(265, 97);
            panelNegocio.TabIndex = 3;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.LightGray;
            btnVentas.Location = new Point(0, 53);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(35, 0, 0, 0);
            btnVentas.Size = new Size(265, 44);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCompra
            // 
            btnCompra.Dock = DockStyle.Top;
            btnCompra.FlatStyle = FlatStyle.Flat;
            btnCompra.ForeColor = Color.LightGray;
            btnCompra.Location = new Point(0, 0);
            btnCompra.Name = "btnCompra";
            btnCompra.Padding = new Padding(35, 0, 0, 0);
            btnCompra.Size = new Size(265, 53);
            btnCompra.TabIndex = 0;
            btnCompra.Text = "Compra";
            btnCompra.UseVisualStyleBackColor = true;
            btnCompra.Click += btnCompra_Click;
            // 
            // btnNegocios
            // 
            btnNegocios.Dock = DockStyle.Top;
            btnNegocios.FlatAppearance.BorderSize = 0;
            btnNegocios.FlatStyle = FlatStyle.Flat;
            btnNegocios.ForeColor = Color.Gainsboro;
            btnNegocios.Location = new Point(0, 361);
            btnNegocios.Name = "btnNegocios";
            btnNegocios.Padding = new Padding(10, 0, 0, 0);
            btnNegocios.Size = new Size(265, 65);
            btnNegocios.TabIndex = 2;
            btnNegocios.Text = "Negocios";
            btnNegocios.TextAlign = ContentAlignment.MiddleLeft;
            btnNegocios.UseVisualStyleBackColor = true;
            btnNegocios.Click += btnNegocios_Click;
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenu.Controls.Add(iconButton1);
            panelSubMenu.Controls.Add(btnProducto);
            panelSubMenu.Controls.Add(btnProveedores);
            panelSubMenu.Controls.Add(btnempleados);
            panelSubMenu.Dock = DockStyle.Top;
            panelSubMenu.Location = new Point(0, 178);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(265, 183);
            panelSubMenu.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(35, 32, 39);
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 132);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(265, 45);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Cliente";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.FromArgb(35, 32, 39);
            btnProducto.Dock = DockStyle.Top;
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.ForeColor = Color.White;
            btnProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProducto.IconColor = Color.Black;
            btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProducto.Location = new Point(0, 86);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(265, 46);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "Nuevo Producto";
            btnProducto.TextAlign = ContentAlignment.MiddleRight;
            btnProducto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.ForeColor = Color.LightGray;
            btnProveedores.Location = new Point(0, 46);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(35, 0, 0, 0);
            btnProveedores.Size = new Size(265, 40);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnempleados
            // 
            btnempleados.Dock = DockStyle.Top;
            btnempleados.FlatStyle = FlatStyle.Flat;
            btnempleados.ForeColor = Color.LightGray;
            btnempleados.Location = new Point(0, 0);
            btnempleados.Name = "btnempleados";
            btnempleados.Padding = new Padding(35, 0, 0, 0);
            btnempleados.Size = new Size(265, 46);
            btnempleados.TabIndex = 0;
            btnempleados.Text = "Empleados";
            btnempleados.UseVisualStyleBackColor = true;
            btnempleados.Click += btnempleados_Click;
            // 
            // btnRegist
            // 
            btnRegist.Dock = DockStyle.Top;
            btnRegist.FlatAppearance.BorderSize = 0;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.ForeColor = Color.Gainsboro;
            btnRegist.Location = new Point(0, 123);
            btnRegist.Name = "btnRegist";
            btnRegist.Padding = new Padding(10, 0, 0, 0);
            btnRegist.Size = new Size(265, 55);
            btnRegist.TabIndex = 0;
            btnRegist.Text = "Registro";
            btnRegist.TextAlign = ContentAlignment.MiddleLeft;
            btnRegist.UseVisualStyleBackColor = true;
            btnRegist.Click += btnRegist_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(265, 123);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.barficus_adjusted_horizontal_more;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(23, 21, 32);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(265, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(667, 919);
            panelChildForm.TabIndex = 1;
            // 
            // IniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 919);
            Controls.Add(panelChildForm);
            Controls.Add(panelIniLateral);
            MinimumSize = new Size(950, 600);
            Name = "IniForm";
            Text = "IniForm";
            Load += IniForm_Load;
            panelIniLateral.ResumeLayout(false);
            panelDetalles.ResumeLayout(false);
            panelInventario.ResumeLayout(false);
            panelNegocio.ResumeLayout(false);
            panelSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIniLateral;
        private Button btnRegist;
        private Panel panelLogo;
        private Panel panelSubMenu;
        private Button button6;
        private Button button5;
        private Button btnProveedores;
        private Button button3;
        private Button btnempleados;
        private Panel panelInventario;
        private Button Ingredientes;
        private Button btnPlatillos;
        private Button btnProductos;
        private Button Inventario;
        private Panel panelNegocio;
        private Button btnVentas;
        private Button btnCompra;
        private Button btnNegocios;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnProducto;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button btnDetalles;
        private Panel panelDetalles;
        private FontAwesome.Sharp.IconButton btnDetalleVenta;
        private FontAwesome.Sharp.IconButton btnDetalleCompra;
    }
}