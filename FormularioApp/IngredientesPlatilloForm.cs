using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;

namespace FormularioApp
{
    public partial class IngredientesPlatilloForm : Form
    {
        private readonly IngredientePlatilloApiClient _apiClient;  // Cliente API para gestionar ingredientes de platillo
        private int _idPlatillo;  // Id del platillo seleccionado

        public IngredientesPlatilloForm(int idPlatillo)
        {
            InitializeComponent();
            _apiClient = new IngredientePlatilloApiClient();  // Cliente API configurado para ingredientes de platillo
            _idPlatillo = idPlatillo;
        }

        private async void IngredientesPlatilloForm_Load(object sender, EventArgs e)
        {
            await CargarIngredientesPlatillo();
        }

        private async Task CargarIngredientesPlatillo()
        {
            var ingredientesPlatillo = await _apiClient.ObtenerIngredientesPlatillo(_idPlatillo);  // Obtener los ingredientes de este platillo desde la API
            dgvIngredientesPlatillo.DataSource = ingredientesPlatillo;  // Asumimos que el DataGridView se llama dgvIngredientesPlatillo
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que la cantidad necesaria sea un número válido
            if (int.TryParse(txtCantidadNecesario.Text, out int cantidadNecesaria))
            {
                var nuevoIngredientePlatillo = new IngredientePlatillo
                {
                    IdPlatillo = _idPlatillo,
                    IdIngrediente = int.Parse(txtIngredientesPlatillo.Text),  // Asumimos que este es el ID del ingrediente
                    CantidadNecesaria = cantidadNecesaria
                };

                // Llamamos al método para agregar el nuevo ingrediente al platillo
                bool success = await _apiClient.CrearIngredientePlatillo(nuevoIngredientePlatillo);
                if (success)
                {
                    MessageBox.Show("Ingrediente agregado al platillo exitosamente.");
                    await CargarIngredientesPlatillo();  // Recargamos la lista de ingredientes asociados al platillo
                }
                else
                {
                    MessageBox.Show("Error al agregar el ingrediente al platillo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay un ingrediente asociado al platillo seleccionado en el DataGridView
            if (dgvIngredientesPlatillo.SelectedRows.Count > 0)
            {
                var ingredientePlatilloSeleccionado = dgvIngredientesPlatillo.SelectedRows[0].DataBoundItem as IngredientePlatillo;
                if (ingredientePlatilloSeleccionado != null)
                {
                    // Actualizamos la cantidad necesaria del ingrediente seleccionado
                    ingredientePlatilloSeleccionado.CantidadNecesaria = int.Parse(txtCantidadNecesario.Text);

                    // Llamamos al método para editar el ingrediente asociado al platillo
                    bool success = await _apiClient.EditarIngredientePlatillo(ingredientePlatilloSeleccionado);
                    if (success)
                    {
                        MessageBox.Show("Ingrediente del platillo editado exitosamente.");
                        await CargarIngredientesPlatillo();  // Recargamos la lista de ingredientes asociados al platillo
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el ingrediente del platillo.");
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay un ingrediente asociado al platillo seleccionado en el DataGridView
            if (dgvIngredientesPlatillo.SelectedRows.Count > 0)
            {
                var ingredientePlatilloSeleccionado = dgvIngredientesPlatillo.SelectedRows[0].DataBoundItem as IngredientePlatillo;
                if (ingredientePlatilloSeleccionado != null)
                {
                    // Llamamos al método para eliminar el ingrediente asociado al platillo
                    bool success = await _apiClient.EliminarIngredientePlatillo(ingredientePlatilloSeleccionado.IdPlatillo, ingredientePlatilloSeleccionado.IdIngrediente);
                    if (success)
                    {
                        MessageBox.Show("Ingrediente del platillo eliminado exitosamente.");
                        await CargarIngredientesPlatillo();  // Recargamos la lista de ingredientes asociados al platillo
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el ingrediente del platillo.");
                    }
                }
            }
        }

        // Método para seleccionar un ingrediente en el DataGridView y cargar sus detalles en los TextBox
        private void dgvIngredientesPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ingredientePlatilloSeleccionado = dgvIngredientesPlatillo.Rows[e.RowIndex].DataBoundItem as IngredientePlatillo;
                if (ingredientePlatilloSeleccionado != null)
                {
                    // Cargamos los datos del ingrediente asociado al platillo seleccionado en los TextBox
                    txtIngredientesPlatillo.Text = ingredientePlatilloSeleccionado.IdIngrediente.ToString();
                    txtCantidadNecesario.Text = ingredientePlatilloSeleccionado.CantidadNecesaria.ToString();
                }
            }
        }
    }
}
