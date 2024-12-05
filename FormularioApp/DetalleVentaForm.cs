using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;

namespace FormularioApp
{
    public partial class DetalleVentaForm : Form
    {
        private readonly DetalleVentaApiClient _apiClient;  // Cliente API para gestionar detalles de la venta
        private int _idVenta;  // ID de la venta seleccionada

        public DetalleVentaForm(int idVenta)
        {
            InitializeComponent();
            _apiClient = new DetalleVentaApiClient();  // Cliente API configurado para detalles de venta
            _idVenta = idVenta;  // Asignamos el ID de la venta
        }

        private async void DetalleVentaForm_Load(object sender, EventArgs e)
        {
            await CargarDetallesVenta();
        }

        // Método para cargar los detalles de la venta en el DataGridView
        private async Task CargarDetallesVenta()
        {
            var detallesVenta =  _apiClient.ObtenerDetallesVenta(_idVenta);  // Obtener detalles de la venta desde la API
            dgvDetalleVenta.DataSource = detallesVenta;  // Asumimos que el DataGridView se llama dgvDetalleVenta
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que los campos de cantidad y precio sean números válidos
            if (int.TryParse(txtCantidaddt.Text, out int cantidad) && decimal.TryParse(txtPrecioUnit.Text, out decimal precioUnitario))
            {
                var nuevoDetalleVenta = new DetalleVenta
                {
                    IdVenta = _idVenta,
                    IdProducto = int.Parse(txtProductoid.Text),  // Asumimos que el ID del producto se ingresa en este TextBox
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario,
                    IdEmpleado = 1 // Asumimos que el ID del empleado es fijo o lo obtenemos desde el contexto del usuario
                };

                // Llamamos al método para agregar un nuevo detalle de venta
                bool success = await _apiClient.CrearDetalleVenta(nuevoDetalleVenta);
                if (success)
                {
                    MessageBox.Show("Detalle de venta agregado exitosamente.");
                    await CargarDetallesVenta();  // Recargamos los detalles de la venta
                }
                else
                {
                    MessageBox.Show("Error al agregar el detalle de la venta.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese cantidades y precios válidos.");
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificamos si se ha seleccionado un detalle de la venta en el DataGridView
            if (dgvDetalleVenta.SelectedRows.Count > 0)
            {
                var detalleVentaSeleccionado = dgvDetalleVenta.SelectedRows[0].DataBoundItem as DetalleVenta;
                if (detalleVentaSeleccionado != null)
                {
                    // Actualizamos los campos del detalle de venta seleccionado con los nuevos valores
                    detalleVentaSeleccionado.Cantidad = int.Parse(txtCantidaddt.Text);
                    detalleVentaSeleccionado.PrecioUnitario = decimal.Parse(txtPrecioUnit.Text);

                    // Llamamos al método para editar el detalle de la venta
                    bool success = await _apiClient.EditarDetalleVenta(detalleVentaSeleccionado);
                    if (success)
                    {
                        MessageBox.Show("Detalle de venta editado exitosamente.");
                        await CargarDetallesVenta();  // Recargamos los detalles de la venta
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el detalle de la venta.");
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si se ha seleccionado un detalle de la venta en el DataGridView
            if (dgvDetalleVenta.SelectedRows.Count > 0)
            {
                var detalleVentaSeleccionado = dgvDetalleVenta.SelectedRows[0].DataBoundItem as DetalleVenta;
                if (detalleVentaSeleccionado != null)
                {
                    // Llamamos al método para eliminar el detalle de la venta
                    bool success = await _apiClient.EliminarDetalleVenta(detalleVentaSeleccionado.IdDetalleVenta);
                    if (success)
                    {
                        MessageBox.Show("Detalle de venta eliminado exitosamente.");
                        await CargarDetallesVenta();  // Recargamos los detalles de la venta
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el detalle de la venta.");
                    }
                }
            }
        }

        // Método para seleccionar un detalle de la venta en el DataGridView y cargar sus datos en los TextBox
        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detalleVentaSeleccionado = dgvDetalleVenta.Rows[e.RowIndex].DataBoundItem as DetalleVenta;
                if (detalleVentaSeleccionado != null)
                {
                    // Cargamos los datos del detalle de venta seleccionado en los TextBox
                    txtProductoid.Text = detalleVentaSeleccionado.IdProducto.ToString();
                    txtCantidaddt.Text = detalleVentaSeleccionado.Cantidad.ToString();
                    txtPrecioUnit.Text = detalleVentaSeleccionado.PrecioUnitario.ToString("F2");
                }
            }
        }
    }
}
