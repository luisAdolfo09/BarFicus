using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;

namespace FormularioApp
{
    public partial class DetalleCompraForm : Form
    {
        private readonly DetallesCompraApiClient _apiClient;  // Cliente API para gestionar detalles de la compra
        private int _idCompra;  // ID de la compra seleccionada

        public DetalleCompraForm(int idCompra)
        {
            InitializeComponent();
            _apiClient = new DetallesCompraApiClient();  // Cliente API configurado para detalles de compra
            _idCompra = idCompra;  // Asignamos el ID de la compra
        }

        private async void DetalleCompraForm_Load(object sender, EventArgs e)
        {
            await CargarDetallesCompra();
        }

        // Método para cargar los detalles de la compra en el DataGridView
        private async Task CargarDetallesCompra()
        {
            var detallesCompra = await _apiClient.ObtenerDetallesCompra(_idCompra);  // Obtener detalles de la compra desde la API
            dgvDetalleCompra.DataSource = detallesCompra;  // Asumimos que el DataGridView se llama dgvDetalleCompra
        }

        private async void btnAgregardt_Click(object sender, EventArgs e)
        {
            // Validamos que los campos de cantidad y precio sean números válidos
            if (int.TryParse(txtCantidaddt.Text, out int cantidad) && decimal.TryParse(txtPrecioUnitdt.Text, out decimal precioUnitario))
            {
                var nuevoDetalleCompra = new DetalleCompra
                {
                    IdCompra = _idCompra,
                   /* IdProducto = int.Parse(txtProductodt.Text),*/  // Asumimos que el ID del producto se ingresa en este TextBox
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario
                };

                // Llamamos al método para agregar un nuevo detalle de compra
                bool success = await _apiClient.CrearDetalleCompra(nuevoDetalleCompra);
                if (success)
                {
                    MessageBox.Show("Detalle de compra agregado exitosamente.");
                    await CargarDetallesCompra();  // Recargamos los detalles de la compra
                }
                else
                {
                    MessageBox.Show("Error al agregar el detalle de la compra.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese cantidades y precios válidos.");
            }
        }

        private async void btnEditardt_Click(object sender, EventArgs e)
        {
            // Verificamos si se ha seleccionado un detalle de la compra en el DataGridView
            if (dgvDetalleCompra.SelectedRows.Count > 0)
            {
                var detalleCompraSeleccionado = dgvDetalleCompra.SelectedRows[0].DataBoundItem as DetalleCompra;
                if (detalleCompraSeleccionado != null)
                {
                    // Actualizamos los campos del detalle de compra seleccionado con los nuevos valores
                    detalleCompraSeleccionado.Cantidad = int.Parse(txtCantidaddt.Text);
                    detalleCompraSeleccionado.PrecioUnitario = decimal.Parse(txtPrecioUnitdt.Text);

                    // Llamamos al método para editar el detalle de la compra
                    bool success = await _apiClient.EditarDetalleCompra(detalleCompraSeleccionado);
                    if (success)
                    {
                        MessageBox.Show("Detalle de compra editado exitosamente.");
                        await CargarDetallesCompra();  // Recargamos los detalles de la compra
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el detalle de la compra.");
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si se ha seleccionado un detalle de la compra en el DataGridView
            if (dgvDetalleCompra.SelectedRows.Count > 0)
            {
                var detalleCompraSeleccionado = dgvDetalleCompra.SelectedRows[0].DataBoundItem as DetalleCompra;
                if (detalleCompraSeleccionado != null)
                {
                    // Llamamos al método para eliminar el detalle de la compra
                    bool success = await _apiClient.EliminarDetalleCompra(detalleCompraSeleccionado.IdDetalleCompra);
                    if (success)
                    {
                        MessageBox.Show("Detalle de compra eliminado exitosamente.");
                        await CargarDetallesCompra();  // Recargamos los detalles de la compra
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el detalle de la compra.");
                    }
                }
            }
        }

        // Método para seleccionar un detalle de la compra en el DataGridView y cargar sus datos en los TextBox
        private void dgvDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detalleCompraSeleccionado = dgvDetalleCompra.Rows[e.RowIndex].DataBoundItem as DetalleCompra;
                if (detalleCompraSeleccionado != null)
                {
                    // Cargamos los datos del detalle de compra seleccionado en los TextBox
                    //txtNombreProducto.Text = detalleCompraSeleccionado.IdProducto.ToString();
                    txtCantidaddt.Text = detalleCompraSeleccionado.Cantidad.ToString();
                    txtPrecioUnitdt.Text = detalleCompraSeleccionado.PrecioUnitario.ToString("F2");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
