using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class LoginForm : Form
    {
        private List<(string usuario, string contraseña)> credencialesValidas = new List<(string usuario, string contraseña)>
        {
            ("usuario1", "contraseña1"),
            ("usuario2", "contraseña2"),
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnIniciarSesion.Enabled = false;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Eliminamos la validación de las credenciales
            // string nUsuario = txtUsuario.Text.Trim();
            // string contraseña = txtContraseña.Text.Trim();

            // Aquí no validamos las credenciales, simplemente abrimos el formulario
            EmpleadosForm frmEmplds = new EmpleadosForm();
            frmEmplds.Show();
            this.Hide();

            // Limpiar los campos después de iniciar sesión
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        // Método CredencialesExistentes ya no es necesario
        // private bool CredencialesExistentes(string nUsuario, string contraseña)
        // {
        //     Console.WriteLine($"Intentando iniciar sesión con Usuario: {nUsuario}, Contraseña: {contraseña}");
        //     return credencialesValidas.Any(credencial =>
        //         credencial.usuario.Equals(nUsuario, StringComparison.OrdinalIgnoreCase) &&
        //         credencial.contraseña.Equals(contraseña));
        // }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonIniciarSesion();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonIniciarSesion();
        }

        private void HabilitarBotonIniciarSesion()
        {
            btnIniciarSesion.Enabled = !string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text);
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Length < 3)
            {
                errorProvider1.SetError(txtUsuario, "Debe contener al menos 3 caracteres.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "");
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraseña.Text.Length < 8)
            {
                errorProvider1.SetError(txtContraseña, "Debe contener al menos 8 caracteres.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtContraseña, "");
            }
        }

        private void lblRegistrarse_LinkClicked(object sender, EventArgs e)
        {
            RegistroForm registroUsuario = new RegistroForm();
            registroUsuario.Show();
        }
    }
}
