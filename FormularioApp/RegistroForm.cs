using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class RegistroForm : Form
    {
        // Lista para almacenar los usuarios registrados temporalmente en memoria
        private List<string> listaUsuarios = new List<string>();

        public RegistroForm()
        {
            InitializeComponent();
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false; // El botón de registro está deshabilitado inicialmente
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtRegistroUsuario.Text;
            string contraseña = txtRegistroContraseña.Text;

            // Verificar si el nombre de usuario ya existe en la lista en memoria
            if (NombreUsuarioExistente(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario ya está en uso. Elija otro nombre de usuario.");
            }
            else
            {
                // Si no existe, guardar el nuevo registro en la lista
                string registroCSV = $"{nombreUsuario},{contraseña}";
                listaUsuarios.Add(registroCSV); // Guardar el usuario en la lista

                // Limpiar los campos de texto
                txtRegistroUsuario.Clear();
                txtRegistroContraseña.Clear();

                // Confirmación de registro exitoso
                MessageBox.Show("Cuenta creada exitosamente.");
            }
        }

        private bool NombreUsuarioExistente(string nombreUsuario)
        {
            // Verificar si el nombre de usuario ya está registrado en la lista
            return listaUsuarios.Any(u => u.Split(',')[0] == nombreUsuario);
        }

        private void txtRegistroUsuario_TextChanged(object sender, EventArgs e)
        {
            HabilitarRegistro();
        }

        private void txtRegistroContraseña_TextChanged(object sender, EventArgs e)
        {
            HabilitarRegistro();
        }

        private void HabilitarRegistro()
        {
            // Habilitar el botón solo si ambos campos están llenos
            if (!string.IsNullOrWhiteSpace(txtRegistroUsuario.Text) && !string.IsNullOrWhiteSpace(txtRegistroContraseña.Text))
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtRegistroUsuario_Validating(object sender, CancelEventArgs e)
        {
            // Validar que el nombre de usuario tenga al menos 3 caracteres
            if (txtRegistroUsuario.Text.Length < 3)
            {
                errorProvider1.SetError(txtRegistroUsuario, "Debe contener al menos 3 letras.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtRegistroUsuario, "");
            }
        }

        private void txtRegistroContraseña_Validating(object sender, CancelEventArgs e)
        {
            // Validar que la contraseña tenga al menos 8 caracteres
            if (txtRegistroContraseña.Text.Length < 8)
            {
                errorProvider1.SetError(txtRegistroContraseña, "Debe contener al menos 8 caracteres.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtRegistroContraseña, "");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }// Cierre de btnAtras evento Click
    }
}
