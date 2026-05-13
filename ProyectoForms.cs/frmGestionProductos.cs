using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoForms.cs
{
    public partial class frmGestionProductos : Form
    {
        //DECLARACION DE VARIABLES GLOBALES
        int varIdProducto;
        string varNombreProducto;
        string varDescripcion;
        int varStock;
        int varPrecio;
        string varCategoria;

        DataTable tablaProductos;

        public frmGestionProductos()
        {
            InitializeComponent();
        }

        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            // Variables locales
            varIdProducto = 0;
            varNombreProducto = "";
            varCategoria = "";
            varStock = 0;
            varPrecio = 0;
            varDescripcion = "";

          
            tablaProductos = new DataTable();
            tablaProductos.Columns.Add("ID", typeof(int));
            tablaProductos.Columns.Add("Nombre", typeof(string));
            tablaProductos.Columns.Add("Código", typeof(string));
            tablaProductos.Columns.Add("Stock", typeof(int));
            tablaProductos.Columns.Add("Precio", typeof(int));
            tablaProductos.Columns.Add("Categoría", typeof(string));
            tablaProductos.Columns.Add("Descripción", typeof(string));

            dgvProductos.DataSource = tablaProductos;

            CargarCategorias();
        }

        private void CargarCategorias()
        {
            List<string> categorias = new List<string>
            {
                "Alimentos",
                "Juguetes",
                "Ropa",
                "Collares"
            };

            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(categorias.ToArray());
        }

        private void bttcargar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor completá todos los campos obligatorios (Nombre, Código, Stock y Precio).",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El Stock debe ser un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPrecio.Text, out int precio))
            {
                MessageBox.Show("El Precio debe ser un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            varIdProducto++;
            tablaProductos.Rows.Add(
                varIdProducto,
                txtNombre.Text.Trim(),
                txtCodigo.Text.Trim(),
                stock,
                precio,
                cmbCategoria.SelectedItem?.ToString() ?? "",
                txtDescripcion.Text.Trim()
            );

            // Limpiar campos
            txtNombre.Clear();
            txtCodigo.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("Producto grabado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un producto de la lista para eliminar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = dgvProductos.SelectedRows[0].Cells["Nombre"].Value.ToString();
            DialogResult confirmar = MessageBox.Show(
                $"¿Estás seguro que querés eliminar el producto \"{nombre}\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                int indice = dgvProductos.SelectedRows[0].Index;
                tablaProductos.Rows[indice].Delete();

                txtNombre.Clear();
                txtCodigo.Clear();
                txtStock.Clear();
                txtPrecio.Clear();
                txtDescripcion.Clear();
                cmbCategoria.SelectedIndex = -1;

                MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvProductos.SelectedRows[0];
                txtNombre.Text      = fila.Cells["Nombre"].Value.ToString();
                txtCodigo.Text         = fila.Cells["Código"].Value.ToString();
                txtStock.Text         = fila.Cells["Stock"].Value.ToString();
                txtPrecio.Text         = fila.Cells["Precio"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripción"].Value.ToString();
                cmbCategoria.SelectedItem = fila.Cells["Categoría"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un producto de la lista para modificar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor completá todos los campos obligatorios.",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El Stock debe ser un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPrecio.Text, out int precio))
            {
                MessageBox.Show("El Precio debe ser un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = dgvProductos.SelectedRows[0].Index;
            DataRow fila = tablaProductos.Rows[indice];
            fila["Nombre"]      = txtNombre.Text.Trim();
            fila["Código"]      = txtCodigo.Text.Trim();
            fila["Stock"]       = stock;
            fila["Precio"]      = precio;
            fila["Categoría"]   = cmbCategoria.SelectedItem?.ToString() ?? "";
            fila["Descripción"] = txtDescripcion.Text.Trim();

            // Limpiar campos
            txtNombre.Clear();
            txtCodigo.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("Producto modificado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblG_Click(object sender, EventArgs e)
        {
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboboxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void textboxDescrepcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void picImagenDos_Click(object sender, EventArgs e)
        {
        }

        private void picImagenUno_Click(object sender, EventArgs e)
        {
        }
    }
}
