using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;

namespace FormularioApp
{
    public partial class EmpleadosForm : Form
    {
        private readonly EmpleadosApiClient _apiClient;

        public EmpleadosForm()
        {
            InitializeComponent();
            _apiClient = new EmpleadosApiClient();
        }

        private async void EmpleadosForm_Load(object sender, EventArgs e)
        {
            await CargarEmpleados();
        }

        // Método para cargar los empleados en el DataGridView
        private async Task CargarEmpleados()
        {
            try
            {
                var empleados = await _apiClient.ObtenerEmpleados();
                dgvEmpleados.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}");
                Console.WriteLine(ex.ToString()); // Para depurar más detalles en la consola
            }
        }

        // Método para crear un nuevo empleado
        private async void btnCrear_Click(object sender, EventArgs e)
        {
            var nuevoEmpleado = ObtenerEmpleadoDeFormulario();
            if (nuevoEmpleado == null)
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            await RealizarAccionEmpleado(() => _apiClient.CrearEmpleado(nuevoEmpleado), "Empleado creado exitosamente.");
        }

        // Método para editar un empleado existente
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            var empleadoSeleccionado = dgvEmpleados.SelectedRows[0].DataBoundItem as Empleados;
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener los datos del empleado.");
                return;
            }

            // Actualizar el formulario con los datos del empleado seleccionado
            ActualizarEmpleadoDeFormulario(empleadoSeleccionado);

            // Realizar la acción de editar
            await RealizarAccionEmpleado(() => _apiClient.EditarEmpleado(empleadoSeleccionado), "Empleado editado exitosamente.");
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            var empleadoSeleccionado = dgvEmpleados.SelectedRows[0].DataBoundItem as Empleados;
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener los datos del empleado.");
                return;
            }

            var confirmDelete = MessageBox.Show("¿Estás seguro de que quieres eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                // Llamamos al método de eliminación en la API
                var exito = await _apiClient.EliminarEmpleado(empleadoSeleccionado.IdEmpleado);

                if (exito)
                {
                    MessageBox.Show("Empleado eliminado exitosamente.");
                    await CargarEmpleados();  // Recargar la lista de empleados
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el empleado. Intenta de nuevo.");
                }
            }
        }



        // Método para obtener los datos del formulario y convertirlos a un objeto Empleados
        private Empleados ObtenerEmpleadoDeFormulario()
        {
            // Validar campos requeridos
            if (string.IsNullOrEmpty(txtPrimerNombre.Text) ||
                string.IsNullOrEmpty(txtPrimerApellido.Text) ||
                string.IsNullOrEmpty(txtSegundoApellido.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                string.IsNullOrEmpty(txtAntiguedad.Text) ||
                string.IsNullOrEmpty(txtPuesto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return null;
            }

            // Validar antigüedad como un número válido
            if (!int.TryParse(txtAntiguedad.Text, out var antiguedad) || antiguedad <= 0)
            {
                MessageBox.Show("La antigüedad debe ser un número válido y mayor que 0.");
                return null;
            }

            // Validar teléfono como un número válido
            if (!int.TryParse(txtTelefono.Text, out var telefono) || telefono <= 0)
            {
                MessageBox.Show("El teléfono debe ser un número válido y mayor que 0.");
                return null;
            }

            // Si todos los campos son válidos, devolver el nuevo empleado
            return new Empleados
            {
                PrimerNombre = txtPrimerNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                Puesto = txtPuesto.Text,
                Antiguedad = antiguedad,
                CedulaIdentidad = txtCedulaIndentidad.Text,
                Telefono = telefono
            };
        }

        // Método para actualizar los datos del empleado seleccionado en el formulario
        private void ActualizarEmpleadoDeFormulario(Empleados empleado)
        {
            // Actualizar los campos del formulario con los datos del empleado
            txtPrimerNombre.Text = empleado.PrimerNombre;
            txtPrimerApellido.Text = empleado.PrimerApellido;
            txtSegundoApellido.Text = empleado.SegundoApellido;
            txtPuesto.Text = empleado.Puesto;
            txtAntiguedad.Text = empleado.Antiguedad.ToString();
            txtCedulaIndentidad.Text = empleado.CedulaIdentidad;
            txtTelefono.Text = empleado.Telefono.ToString();
        }

        // Método para realizar las acciones de Crear, Editar, Eliminar de un empleado
        private async Task RealizarAccionEmpleado(Func<Task<bool>> accion, string mensajeExito)
        {
            try
            {
                bool success = await accion();
                if (success)
                {
                    MessageBox.Show(mensajeExito);
                    await CargarEmpleados(); // Recargar la lista de empleados después de la acción
                }
                else
                {
                    MessageBox.Show("Error al realizar la acción.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
                Console.WriteLine(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
