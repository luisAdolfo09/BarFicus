﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;

namespace FormularioApp
{
    public partial class ProveedorForm : Form
    {
        private readonly ProveedorApiClient _apiClient;  // Cliente API para gestionar proveedores

        public ProveedorForm()
        {
            InitializeComponent();
            _apiClient = new ProveedorApiClient();  // Asegúrate de tener este cliente correctamente configurado
        }

        private async void ProveedorForm_Load(object sender, EventArgs e)
        {
            await CargarProveedores();
        }

        private async Task CargarProveedores()
        {
            var proveedores = await _apiClient.ObtenerProveedores();  // Suponemos que este método obtiene la lista de proveedores
            dgvClientes.DataSource = proveedores;  // Asignamos la lista de proveedores al DataGridView
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // Creamos un nuevo proveedor con los datos de los TextBox
            var nuevoProveedor = new Proveedor
            {
                Nombre = txtNombreProveedor.Text,
                Contacto = txtContactoProveedor.Text,
                Telefono = txtTelefonoProvee.Text,
                Direccion = txtDireccionProvee.Text,
                Correo = txtCorreoProvee.Text
            };

            // Llamamos al método para agregar un nuevo proveedor
            bool success = await _apiClient.CrearProveedor(nuevoProveedor);
            if (success)
            {
                MessageBox.Show("Proveedor agregado exitosamente.");
                await CargarProveedores();  // Recargamos la lista de proveedores
            }
            else
            {
                MessageBox.Show("Error al agregar el proveedor.");
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // Suponemos que seleccionas un proveedor de la lista en el DataGridView
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var proveedorSeleccionado = dgvClientes.SelectedRows[0].DataBoundItem as Proveedor;
                if (proveedorSeleccionado != null)
                {
                    // Actualizamos los datos del proveedor con los valores de los TextBox
                    proveedorSeleccionado.Nombre = txtNombreProveedor.Text;
                    proveedorSeleccionado.Contacto = txtContactoProveedor.Text;
                    proveedorSeleccionado.Telefono = txtTelefonoProvee.Text;
                    proveedorSeleccionado.Direccion = txtDireccionProvee.Text;
                    proveedorSeleccionado.Correo = txtCorreoProvee.Text;

                    // Llamamos al método para editar el proveedor
                    bool success = await _apiClient.EditarProveedor(proveedorSeleccionado);
                    if (success)
                    {
                        MessageBox.Show("Proveedor editado exitosamente.");
                        await CargarProveedores();  // Recargamos la lista de proveedores
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el proveedor.");
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Comprobamos si hay algún proveedor seleccionado en el DataGridView
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var proveedorSeleccionado = dgvClientes.SelectedRows[0].DataBoundItem as Proveedor;
                if (proveedorSeleccionado != null)
                {
                    // Llamamos al método para eliminar el proveedor
                    bool success = await _apiClient.EliminarProveedor(proveedorSeleccionado.IdProveedor);
                    if (success)
                    {
                        MessageBox.Show("Proveedor eliminado exitosamente.");
                        await CargarProveedores();  // Recargamos la lista de proveedores
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el proveedor.");
                    }
                }
            }
        }

        // Método para seleccionar un proveedor en el DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Asumimos que seleccionamos un proveedor en el DataGridView
                var proveedorSeleccionado = dgvClientes.Rows[e.RowIndex].DataBoundItem as Proveedor;
                if (proveedorSeleccionado != null)
                {
                    // Cargamos los datos del proveedor seleccionado en los TextBox
                    txtNombreProveedor.Text = proveedorSeleccionado.Nombre;
                    txtContactoProveedor.Text = proveedorSeleccionado.Contacto;
                    txtTelefonoProvee.Text = proveedorSeleccionado.Telefono;
                    txtDireccionProvee.Text = proveedorSeleccionado.Direccion;
                    txtCorreoProvee.Text = proveedorSeleccionado.Correo;
                }
            }
        }

        private void ProveedorForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
