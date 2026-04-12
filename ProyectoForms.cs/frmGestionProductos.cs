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
            // Inicializar variables
            varIdProducto = 0;
            varNombreProducto = "";
            varCategoria = "";
            varStock = 0;
            varPrecio = 0;
            varDescripcion = "";

            // Inicializar tabla en memoria
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

            comboboxcategoria.Items.Clear();
            comboboxcategoria.Items.AddRange(categorias.ToArray());
        }

        private void bttcargar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textCodigo.Text) ||
                string.IsNullOrWhiteSpace(texpaquete.Text) ||
                string.IsNullOrWhiteSpace(textPrecio.Text))
            {
                MessageBox.Show("Por favor completá todos los campos obligatorios (Nombre, Código, Stock y Precio).",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(texpaquete.Text, out int stock))
            {
                MessageBox.Show("El Stock debe ser un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textPrecio.Text, out int precio))
            {
                MessageBox.Show("El Precio debe ser un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar fila a la tabla en memoria
            varIdProducto++;
            tablaProductos.Rows.Add(
                varIdProducto,
                textBoxNombre.Text.Trim(),
                textCodigo.Text.Trim(),
                stock,
                precio,
                comboboxcategoria.SelectedItem?.ToString() ?? "",
                textboxDescrepcion.Text.Trim()
            );

            // Limpiar campos
            textBoxNombre.Clear();
            textCodigo.Clear();
            texpaquete.Clear();
            textPrecio.Clear();
            textboxDescrepcion.Clear();
            comboboxcategoria.SelectedIndex = -1;

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

                textBoxNombre.Clear();
                textCodigo.Clear();
                texpaquete.Clear();
                textPrecio.Clear();
                textboxDescrepcion.Clear();
                comboboxcategoria.SelectedIndex = -1;

                MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvProductos.SelectedRows[0];
                textBoxNombre.Text      = fila.Cells["Nombre"].Value.ToString();
                textCodigo.Text         = fila.Cells["Código"].Value.ToString();
                texpaquete.Text         = fila.Cells["Stock"].Value.ToString();
                textPrecio.Text         = fila.Cells["Precio"].Value.ToString();
                textboxDescrepcion.Text = fila.Cells["Descripción"].Value.ToString();
                comboboxcategoria.SelectedItem = fila.Cells["Categoría"].Value.ToString();
            }
        }

        private void buttmodifique_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un producto de la lista para modificar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textCodigo.Text) ||
                string.IsNullOrWhiteSpace(texpaquete.Text) ||
                string.IsNullOrWhiteSpace(textPrecio.Text))
            {
                MessageBox.Show("Por favor completá todos los campos obligatorios.",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(texpaquete.Text, out int stock))
            {
                MessageBox.Show("El Stock debe ser un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textPrecio.Text, out int precio))
            {
                MessageBox.Show("El Precio debe ser un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = dgvProductos.SelectedRows[0].Index;
            DataRow fila = tablaProductos.Rows[indice];
            fila["Nombre"]      = textBoxNombre.Text.Trim();
            fila["Código"]      = textCodigo.Text.Trim();
            fila["Stock"]       = stock;
            fila["Precio"]      = precio;
            fila["Categoría"]   = comboboxcategoria.SelectedItem?.ToString() ?? "";
            fila["Descripción"] = textboxDescrepcion.Text.Trim();

            // Limpiar campos
            textBoxNombre.Clear();
            textCodigo.Clear();
            texpaquete.Clear();
            textPrecio.Clear();
            textboxDescrepcion.Clear();
            comboboxcategoria.SelectedIndex = -1;

            MessageBox.Show("Producto modificado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblG_Click(object sender, EventArgs e)
        {
        }

        private void lblname_Click(object sender, EventArgs e)
        {
        }

        private void lblcode_Click(object sender, EventArgs e)
        {
        }

        private void lblStockk_Click(object sender, EventArgs e)
        {
        }

        private void lblMoney_Click(object sender, EventArgs e)
        {
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
        }

        private void lbldescription_Click(object sender, EventArgs e)
        {
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboboxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void texpaquete_TextChanged(object sender, EventArgs e)
        {
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void textboxDescrepcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void Imagendos_Click(object sender, EventArgs e)
        {
        }

        private void ImagenUno_Click(object sender, EventArgs e)
        {
        }
    }
}
