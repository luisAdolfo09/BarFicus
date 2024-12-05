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
            btnProveedores = new Button();
            btnempleados = new Button();
            btnRegist = new Button();
            panelLogo = new Panel();
            panelChildForm = new Panel();
            panelIniLateral.SuspendLayout();
            panelInventario.SuspendLayout();
            panelNegocio.SuspendLayout();
            panelSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelIniLateral
            // 
            panelIniLateral.AutoScroll = true;
            panelIniLateral.BackColor = Color.FromArgb(11, 7, 17);
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
            panelIniLateral.Size = new Size(253, 553);
            panelIniLateral.TabIndex = 0;
            // 
            // panelInventario
            // 
            panelInventario.BackColor = Color.FromArgb(35, 32, 39);
            panelInventario.Controls.Add(Ingredientes);
            panelInventario.Controls.Add(btnPlatillos);
            panelInventario.Controls.Add(btnProductos);
            panelInventario.Dock = DockStyle.Top;
            panelInventario.Location = new Point(0, 476);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(232, 133);
            panelInventario.TabIndex = 6;
            // 
            // Ingredientes
            // 
            Ingredientes.Dock = DockStyle.Top;
            Ingredientes.FlatAppearance.BorderSize = 0;
            Ingredientes.FlatStyle = FlatStyle.Flat;
            Ingredientes.ForeColor = Color.LightGray;
            Ingredientes.Location = new Point(0, 80);
            Ingredientes.Name = "Ingredientes";
            Ingredientes.Padding = new Padding(35, 0, 0, 0);
            Ingredientes.Size = new Size(232, 40);
            Ingredientes.TabIndex = 2;
            Ingredientes.Text = "Ingredientes";
            Ingredientes.TextAlign = ContentAlignment.MiddleLeft;
            Ingredientes.UseVisualStyleBackColor = true;
            Ingredientes.Click += Ingredientes_Click;
            // 
            // btnPlatillos
            // 
            btnPlatillos.Dock = DockStyle.Top;
            btnPlatillos.FlatAppearance.BorderSize = 0;
            btnPlatillos.FlatStyle = FlatStyle.Flat;
            btnPlatillos.ForeColor = Color.LightGray;
            btnPlatillos.Location = new Point(0, 40);
            btnPlatillos.Name = "btnPlatillos";
            btnPlatillos.Padding = new Padding(35, 0, 0, 0);
            btnPlatillos.Size = new Size(232, 40);
            btnPlatillos.TabIndex = 1;
            btnPlatillos.Text = "Platillos";
            btnPlatillos.TextAlign = ContentAlignment.MiddleLeft;
            btnPlatillos.UseVisualStyleBackColor = true;
            btnPlatillos.Click += btnPlatillos_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.LightGray;
            btnProductos.Location = new Point(0, 0);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(35, 0, 0, 0);
            btnProductos.Size = new Size(232, 40);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // Inventario
            // 
            Inventario.Dock = DockStyle.Top;
            Inventario.FlatAppearance.BorderSize = 0;
            Inventario.FlatStyle = FlatStyle.Flat;
            Inventario.ForeColor = Color.Gainsboro;
            Inventario.Location = new Point(0, 431);
            Inventario.Name = "Inventario";
            Inventario.Padding = new Padding(10, 0, 0, 0);
            Inventario.Size = new Size(232, 45);
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
            panelNegocio.Location = new Point(0, 346);
            panelNegocio.Name = "panelNegocio";
            panelNegocio.Size = new Size(232, 85);
            panelNegocio.TabIndex = 3;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.LightGray;
            btnVentas.Location = new Point(0, 40);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(35, 0, 0, 0);
            btnVentas.Size = new Size(232, 40);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCompra
            // 
            btnCompra.Dock = DockStyle.Top;
            btnCompra.FlatAppearance.BorderSize = 0;
            btnCompra.FlatStyle = FlatStyle.Flat;
            btnCompra.ForeColor = Color.LightGray;
            btnCompra.Location = new Point(0, 0);
            btnCompra.Name = "btnCompra";
            btnCompra.Padding = new Padding(35, 0, 0, 0);
            btnCompra.Size = new Size(232, 40);
            btnCompra.TabIndex = 0;
            btnCompra.Text = "Compra";
            btnCompra.TextAlign = ContentAlignment.MiddleLeft;
            btnCompra.UseVisualStyleBackColor = true;
            btnCompra.Click += btnCompra_Click;
            // 
            // btnNegocios
            // 
            btnNegocios.Dock = DockStyle.Top;
            btnNegocios.FlatAppearance.BorderSize = 0;
            btnNegocios.FlatStyle = FlatStyle.Flat;
            btnNegocios.ForeColor = Color.Gainsboro;
            btnNegocios.Location = new Point(0, 301);
            btnNegocios.Name = "btnNegocios";
            btnNegocios.Padding = new Padding(10, 0, 0, 0);
            btnNegocios.Size = new Size(232, 45);
            btnNegocios.TabIndex = 2;
            btnNegocios.Text = "Negocios";
            btnNegocios.TextAlign = ContentAlignment.MiddleLeft;
            btnNegocios.UseVisualStyleBackColor = true;
            btnNegocios.Click += btnNegocios_Click;
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenu.Controls.Add(btnProveedores);
            panelSubMenu.Controls.Add(btnempleados);
            panelSubMenu.Dock = DockStyle.Top;
            panelSubMenu.Location = new Point(0, 168);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(232, 133);
            panelSubMenu.TabIndex = 1;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.ForeColor = Color.LightGray;
            btnProveedores.Location = new Point(0, 40);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(35, 0, 0, 0);
            btnProveedores.Size = new Size(232, 40);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnempleados
            // 
            btnempleados.Dock = DockStyle.Top;
            btnempleados.FlatAppearance.BorderSize = 0;
            btnempleados.FlatStyle = FlatStyle.Flat;
            btnempleados.ForeColor = Color.LightGray;
            btnempleados.Location = new Point(0, 0);
            btnempleados.Name = "btnempleados";
            btnempleados.Padding = new Padding(35, 0, 0, 0);
            btnempleados.Size = new Size(232, 40);
            btnempleados.TabIndex = 0;
            btnempleados.Text = "Empleados";
            btnempleados.TextAlign = ContentAlignment.MiddleLeft;
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
            btnRegist.Size = new Size(232, 45);
            btnRegist.TabIndex = 0;
            btnRegist.Text = "Registro";
            btnRegist.TextAlign = ContentAlignment.MiddleLeft;
            btnRegist.UseVisualStyleBackColor = true;
            btnRegist.Click += btnRegist_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(232, 123);
            panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(23, 21, 32);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(253, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(679, 553);
            panelChildForm.TabIndex = 1;
            // 
            // IniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(panelChildForm);
            Controls.Add(panelIniLateral);
            MinimumSize = new Size(950, 600);
            Name = "IniForm";
            Text = "IniForm";
            panelIniLateral.ResumeLayout(false);
            panelInventario.ResumeLayout(false);
            panelNegocio.ResumeLayout(false);
            panelSubMenu.ResumeLayout(false);
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
    }
}