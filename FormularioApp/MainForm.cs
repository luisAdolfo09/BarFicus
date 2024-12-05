using System;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Método genérico para abrir formularios con o sin parámetros
        private void OpenForm<T>(params object[] parameters) where T : Form
        {
            try
            {
                Form form = (T)Activator.CreateInstance(typeof(T), parameters);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Abrir formulario de Empleados
        private void btnEmpleadoForm_Click(object sender, EventArgs e)
        {
            OpenForm<EmpleadosForm>();
        }

        // Abrir formulario de Proveedores
        private void btnProveedorForm_Click(object sender, EventArgs e)
        {
            OpenForm<ProveedorForm>();
        }

        // Abrir formulario de Productos
        private void btnProductoForm_Click(object sender, EventArgs e)
        {
            OpenForm<ProductoForm>();
        }

        // Abrir formulario de Ventas
        private void btnVentaForm_Click(object sender, EventArgs e)
        {
            OpenForm<VentaForm>();
        }

        // Abrir formulario de Ingredientes
        private void btnIngredienteForm_Click(object sender, EventArgs e)
        {
            OpenForm<IngredientesForm>();
        }

        // Abrir el formulario de Ingredientes Platillo con idPlatillo
        private void btnIngredientesPlatilloForm_Click(object sender, EventArgs e)
        {
            int idPlatillo = 1; // Reemplaza con el valor real que necesites
            OpenForm<IngredientesPlatilloForm>(idPlatillo);
        }

        // Abrir formulario de Detalles de Compra con idCompra
        private void btnDetalleCompraForm_Click(object sender, EventArgs e)
        {
            int idCompra = 1; // Reemplaza con el valor real que necesites
            OpenForm<DetalleCompraForm>(idCompra);
        }

        // Abrir el formulario de Compra
        private void btnCompra_Click(object sender, EventArgs e)
        {
            OpenForm<CompraForm>();
        }

        // Abrir formulario de Detalles de Venta con idVenta
        private void btnDetalleVentaForm_Click(object sender, EventArgs e)
        {
            int idVenta = 1; // Reemplaza con el valor real que necesites
            OpenForm<DetalleVentaForm>(idVenta);
        }

        // Abrir el formulario de Clientes
        private void btnCliente_Click(object sender, EventArgs e)
        {
            OpenForm<ClienteForm>();
        }
    }
}