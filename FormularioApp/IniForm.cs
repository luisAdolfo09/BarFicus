using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class IniForm : Form
    {
        public IniForm()
        {
            InitializeComponent();
            customizeDiseng();
        }
        private void customizeDiseng()
        {
            panelSubMenu.Visible = false;
            panelNegocio.Visible = false;
            panelInventario.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
            if (panelNegocio.Visible == true)
                panelNegocio.Visible = false;
            if (panelInventario.Visible == true)
                panelInventario.Visible = false;
            if (panelDetalles.Visible == true)
                panelDetalles.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnRegist_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu);
        }

        private void btnNegocios_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelNegocio);
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelInventario);
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new EmpleadosForm());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ProveedorForm());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new CompraForm());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new VentaForm());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ProductoForm());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btnPlatillos_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new IngredientesPlatilloForm());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void Ingredientes_Click(object sender, EventArgs e)
        {

        }

        private void IniForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ClienteForm());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ProductoForm());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDetalles);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ());
                hideSubMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }
    }
}
