using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;

namespace FormularioApp
{
    public partial class ProductoForm : Form
    {
        private readonly ProductoApiClient _apiClient;  // Cliente API para gestionar productos

        public ProductoForm()
        {
            InitializeComponent();
            _apiClient = new ProductoApiClient();  // Asegúrate de tener este cliente correctamente configurado
        }

        private async void ProductoForm_Load(object sender, EventArgs e)
        {
            await CargarProductos();
        }

        private async Task CargarProductos()
        {
            var productos = await _apiClient.ObtenerProductos();  // Método para obtener la lista de productos
            dgvProducto.DataSource = productos;  // Asumimos que el DataGridView se llama dgvProducto
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos los datos de entrada
            if (decimal.TryParse(txtPrecioProdcut.Text, out decimal precio) &&
                int.TryParse(txtCantidadDisponible.Text, out int cantidad) &&
                DateTime.TryParse(txtFechaCaducidad.Text, out DateTime fechaCaducidad))
            {
                var nuevoProducto = new Producto
                {
                    Nombre = txtNombreProducto.Text,
                    Tipo = txtTipo.Text,
                    Marca = txtMarca.Text,
                    Precio = precio,
                    CantidadDisponible = cantidad,
                    Descripcion = txtDescripcion.Text,
                    FechaCaducidad = fechaCaducidad
                };

                // Llamamos al método para agregar el nuevo producto
                bool success = await _apiClient.CrearProducto(nuevoProducto);
                if (success)
                {
                    MessageBox.Show("Producto agregado exitosamente.");
                    await CargarProductos();  // Recargamos la lista de productos
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, asegúrese de que los datos sean válidos.");
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay un producto seleccionado en el DataGridView
            if (dgvProducto.SelectedRows.Count > 0)
            {
                var productoSeleccionado = dgvProducto.SelectedRows[0].DataBoundItem as Producto;
                if (productoSeleccionado != null)
                {
                    // Actualizamos los valores del producto seleccionado con los valores de los TextBox
                    productoSeleccionado.Nombre = txtNombreProducto.Text;
                    productoSeleccionado.Tipo = txtTipo.Text;
                    productoSeleccionado.Marca = txtMarca.Text;
                    productoSeleccionado.Precio = decimal.Parse(txtPrecioProdcut.Text);
                    productoSeleccionado.CantidadDisponible = int.Parse(txtCantidadDisponible.Text);
                    productoSeleccionado.Descripcion = txtDescripcion.Text;
                    productoSeleccionado.FechaCaducidad = DateTime.Parse(txtFechaCaducidad.Text);

                    // Llamamos al método para editar el producto
                    bool success = await _apiClient.EditarProducto(productoSeleccionado);
                    if (success)
                    {
                        MessageBox.Show("Producto editado exitosamente.");
                        await CargarProductos();  // Recargamos la lista de productos
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el producto.");
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay un producto seleccionado en el DataGridView
            if (dgvProducto.SelectedRows.Count > 0)
            {
                var productoSeleccionado = dgvProducto.SelectedRows[0].DataBoundItem as Producto;
                if (productoSeleccionado != null)
                {
                    // Llamamos al método para eliminar el producto
                    bool success = await _apiClient.EliminarProducto(productoSeleccionado.IdProducto);
                    if (success)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.");
                        await CargarProductos();  // Recargamos la lista de productos
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.");
                    }
                }
            }
        }

        // Método para seleccionar un producto en el DataGridView y cargar sus detalles en los TextBox
        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var productoSeleccionado = dgvProducto.Rows[e.RowIndex].DataBoundItem as Producto;
                if (productoSeleccionado != null)
                {
                    // Cargamos los datos del producto seleccionado en los TextBox
                    txtNombreProducto.Text = productoSeleccionado.Nombre;
                    txtTipo.Text = productoSeleccionado.Tipo;
                    txtMarca.Text = productoSeleccionado.Marca;
                    txtPrecioProdcut.Text = productoSeleccionado.Precio.ToString("0.00");
                    txtCantidadDisponible.Text = productoSeleccionado.CantidadDisponible.ToString();
                    txtDescripcion.Text = productoSeleccionado.Descripcion;
                    txtFechaCaducidad.Text = productoSeleccionado.FechaCaducidad?.ToString("yyyy-MM-dd") ?? string.Empty;
                }
            }
        }
    }
}
