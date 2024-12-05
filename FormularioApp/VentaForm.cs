using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;

namespace FormularioApp
{
    public partial class VentaForm : Form
    {
        private readonly VentasApiClient _apiClient;  // Cliente API para gestionar ventas

        public VentaForm()
        {
            InitializeComponent();
            _apiClient = new VentasApiClient();  // Asumiendo que tienes este cliente configurado
        }

        private async void VentaForm_Load(object sender, EventArgs e)
        {
            await CargarVentas();
        }

        private async Task CargarVentas()
        {
            var ventas = await _apiClient.ObtenerVentas();  // Método para obtener las ventas
            dgvVenta.DataSource = ventas;  // Asumimos que el DataGridView se llama dgvVenta
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos los datos de entrada
            if (decimal.TryParse(txtTotal.Text, out decimal total) &&
                DateTime.TryParse(txtFecha.Text, out DateTime fecha))
            {
                var nuevaVenta = new Venta
                {
                    Fecha = fecha,
                    IdCliente = string.IsNullOrEmpty(txtCliente.Text) ? (int?)null : int.Parse(txtCliente.Text),
                    Total = total,
                    Descripcion = txtDescripcion.Text
                };

                // Llamamos al método para agregar la nueva venta
                bool success = await _apiClient.CrearVenta(nuevaVenta);
                if (success)
                {
                    MessageBox.Show("Venta agregada exitosamente.");
                    await CargarVentas();  // Recargamos la lista de ventas
                }
                else
                {
                    MessageBox.Show("Error al agregar la venta.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, asegúrese de que los datos sean válidos.");
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una venta seleccionada en el DataGridView
            if (dgvVenta.SelectedRows.Count > 0)
            {
                var ventaSeleccionada = dgvVenta.SelectedRows[0].DataBoundItem as Venta;
                if (ventaSeleccionada != null)
                {
                    // Actualizamos los valores de la venta seleccionada con los valores de los TextBox
                    ventaSeleccionada.Fecha = DateTime.Parse(txtFecha.Text);
                    ventaSeleccionada.IdCliente = string.IsNullOrEmpty(txtCliente.Text) ? (int?)null : int.Parse(txtCliente.Text);
                    ventaSeleccionada.Total = decimal.Parse(txtTotal.Text);
                    ventaSeleccionada.Descripcion = txtDescripcion.Text;

                    // Llamamos al método para editar la venta
                    bool success = await _apiClient.EditarVenta(ventaSeleccionada);
                    if (success)
                    {
                        MessageBox.Show("Venta editada exitosamente.");
                        await CargarVentas();  // Recargamos la lista de ventas
                    }
                    else
                    {
                        MessageBox.Show("Error al editar la venta.");
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una venta seleccionada en el DataGridView
            if (dgvVenta.SelectedRows.Count > 0)
            {
                var ventaSeleccionada = dgvVenta.SelectedRows[0].DataBoundItem as Venta;
                if (ventaSeleccionada != null)
                {
                    // Llamamos al método para eliminar la venta
                    bool success = await _apiClient.EliminarVenta(ventaSeleccionada.IdVenta);
                    if (success)
                    {
                        MessageBox.Show("Venta eliminada exitosamente.");
                        await CargarVentas();  // Recargamos la lista de ventas
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la venta.");
                    }
                }
            }
        }

        // Método para seleccionar una venta en el DataGridView y cargar sus detalles en los TextBox
        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ventaSeleccionada = dgvVenta.Rows[e.RowIndex].DataBoundItem as Venta;
                if (ventaSeleccionada != null)
                {
                    // Cargamos los datos de la venta seleccionada en los TextBox
                    txtFecha.Text = ventaSeleccionada.Fecha.ToString("yyyy-MM-dd");
                    txtCliente.Text = ventaSeleccionada.IdCliente?.ToString() ?? string.Empty;
                    txtTotal.Text = ventaSeleccionada.Total.ToString("0.00");
                    txtDescripcion.Text = ventaSeleccionada.Descripcion;
                }
            }
        }
    }
}
