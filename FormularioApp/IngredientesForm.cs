using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;

namespace FormularioApp
{
    public partial class IngredientesForm : Form
    {
        private readonly IngredienteApiClient _apiClient;  // Cliente API para gestionar ingredientes

        public IngredientesForm()
        {
            InitializeComponent();
            _apiClient = new IngredienteApiClient();  // Cliente API configurado para ingredientes
        }

        private async void IngredientesForm_Load(object sender, EventArgs e)
        {
            await CargarIngredientes();
        }

        private async Task CargarIngredientes()
        {
            var ingredientes = await _apiClient.ObtenerIngredientes();  // Obtener los ingredientes de la API
            dgvIngredientes.DataSource = ingredientes;  // Asumimos que el DataGridView se llama dgvIngredientes
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos los datos de entrada
            if (decimal.TryParse(txtCostoUnitario.Text, out decimal costoUnitario) &&
                int.TryParse(txtCantidadDisponible.Text, out int cantidadDisponible))
            {
                var nuevoIngrediente = new Ingrediente
                {
                    Nombre = txtNombreIngrediente.Text,
                    CostoUnitario = costoUnitario,
                    CantidadDisponible = cantidadDisponible,
                    Descripcion = txtDescripcionIngredientes.Text,
                    FechaCaducidad = DateTime.TryParse(txtFechaCaducidad.Text, out DateTime fechaCaducidad) ? fechaCaducidad : (DateTime?)null,
                    IdProducto = string.IsNullOrEmpty(txtProducto.Text) ? (int?)null : int.Parse(txtProducto.Text)
                };

                // Llamamos al método para agregar el nuevo ingrediente
                bool success = await _apiClient.CrearIngrediente(nuevoIngrediente);
                if (success)
                {
                    MessageBox.Show("Ingrediente agregado exitosamente.");
                    await CargarIngredientes();  // Recargamos la lista de ingredientes
                }
                else
                {
                    MessageBox.Show("Error al agregar el ingrediente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, asegúrese de que los datos sean válidos.");
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay un ingrediente seleccionado en el DataGridView
            if (dgvIngredientes.SelectedRows.Count > 0)
            {
                var ingredienteSeleccionado = dgvIngredientes.SelectedRows[0].DataBoundItem as Ingrediente;
                if (ingredienteSeleccionado != null)
                {
                    // Actualizamos los valores del ingrediente seleccionado con los valores de los TextBox
                    ingredienteSeleccionado.Nombre = txtNombreIngrediente.Text;
                    ingredienteSeleccionado.CostoUnitario = decimal.Parse(txtCostoUnitario.Text);
                    ingredienteSeleccionado.CantidadDisponible = int.Parse(txtCantidadDisponible.Text);
                    ingredienteSeleccionado.Descripcion = txtDescripcionIngredientes.Text;
                    ingredienteSeleccionado.FechaCaducidad = DateTime.TryParse(txtFechaCaducidad.Text, out DateTime fechaCaducidad) ? fechaCaducidad : (DateTime?)null;
                    ingredienteSeleccionado.IdProducto = string.IsNullOrEmpty(txtProducto.Text) ? (int?)null : int.Parse(txtProducto.Text);

                    // Llamamos al método para editar el ingrediente
                    bool success = await _apiClient.EditarIngrediente(ingredienteSeleccionado);
                    if (success)
                    {
                        MessageBox.Show("Ingrediente editado exitosamente.");
                        await CargarIngredientes();  // Recargamos la lista de ingredientes
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el ingrediente.");
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay un ingrediente seleccionado en el DataGridView
            if (dgvIngredientes.SelectedRows.Count > 0)
            {
                var ingredienteSeleccionado = dgvIngredientes.SelectedRows[0].DataBoundItem as Ingrediente;
                if (ingredienteSeleccionado != null)
                {
                    // Llamamos al método para eliminar el ingrediente
                    bool success = await _apiClient.EliminarIngrediente(ingredienteSeleccionado.IdIngrediente);
                    if (success)
                    {
                        MessageBox.Show("Ingrediente eliminado exitosamente.");
                        await CargarIngredientes();  // Recargamos la lista de ingredientes
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el ingrediente.");
                    }
                }
            }
        }

        // Método para seleccionar un ingrediente en el DataGridView y cargar sus detalles en los TextBox
        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ingredienteSeleccionado = dgvIngredientes.Rows[e.RowIndex].DataBoundItem as Ingrediente;
                if (ingredienteSeleccionado != null)
                {
                    // Cargamos los datos del ingrediente seleccionado en los TextBox
                    txtNombreIngrediente.Text = ingredienteSeleccionado.Nombre;
                    txtCostoUnitario.Text = ingredienteSeleccionado.CostoUnitario.ToString("0.00");
                    txtCantidadDisponible.Text = ingredienteSeleccionado.CantidadDisponible.ToString();
                    txtDescripcionIngredientes.Text = ingredienteSeleccionado.Descripcion;
                    txtFechaCaducidad.Text = ingredienteSeleccionado.FechaCaducidad?.ToString("yyyy-MM-dd") ?? string.Empty;
                    txtProducto.Text = ingredienteSeleccionado.IdProducto?.ToString() ?? string.Empty;
                }
            }
        }
    }
}
