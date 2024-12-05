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
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            var nuevoEmpleado = ObtenerEmpleadoDeFormulario();
            if (nuevoEmpleado == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            await RealizarAccionEmpleado(() => _apiClient.CrearEmpleado(nuevoEmpleado), "Empleado creado exitosamente.");
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var empleadoSeleccionado = dgvEmpleados.SelectedRows[0].DataBoundItem as Empleados;
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado para editar.");
                return;
            }

            ActualizarEmpleadoDeFormulario(empleadoSeleccionado);
            await RealizarAccionEmpleado(() => _apiClient.EditarEmpleado(empleadoSeleccionado), "Empleado editado exitosamente.");
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var empleadoSeleccionado = dgvEmpleados.SelectedRows[0].DataBoundItem as Empleados;
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado para eliminar.");
                return;
            }

            await RealizarAccionEmpleado(() => _apiClient.EliminarEmpleado(empleadoSeleccionado.IdEmpleado), "Empleado eliminado exitosamente.");
        }

        private Empleados ObtenerEmpleadoDeFormulario()
        {
            if (string.IsNullOrEmpty(txtPrimerNombre.Text) ||
                string.IsNullOrEmpty(txtPrimerApellido.Text) ||
                string.IsNullOrEmpty(txtPuesto.Text) ||
                !int.TryParse(txtAntiguedad.Text, out var antiguedad) ||
                !int.TryParse(txtTelefono.Text, out var telefono))
            {
                return null;
            }

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

        private void ActualizarEmpleadoDeFormulario(Empleados empleado)
        {
            empleado.PrimerNombre = txtPrimerNombre.Text;
            empleado.PrimerApellido = txtPrimerApellido.Text;
            empleado.SegundoApellido = txtSegundoApellido.Text;
            empleado.Puesto = txtPuesto.Text;
            empleado.Antiguedad = int.Parse(txtAntiguedad.Text);
            empleado.CedulaIdentidad = txtCedulaIndentidad.Text;
            empleado.Telefono = int.Parse(txtTelefono.Text);
        }

        private async Task RealizarAccionEmpleado(Func<Task<bool>> accion, string mensajeExito)
        {
            try
            {
                bool success = await accion();
                if (success)
                {
                    MessageBox.Show(mensajeExito);
                    await CargarEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al realizar la acción.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
