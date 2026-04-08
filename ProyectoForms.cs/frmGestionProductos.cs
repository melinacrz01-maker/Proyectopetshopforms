using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public frmGestionProductos()
        {
            InitializeComponent();
        }

        private void bttcargar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttmodifique_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            //INICIALIZAR LAS VARIABLES
            varIdProducto = 0;
            varNombreProducto = "";
            varCategoria = "";
            varStock = 0;
            varPrecio = 0;
            varDescripcion = "";

            textBoxYourname.Text = "melina";
            txtCd.Text = "1314";
            texpaquete.Text = "queda un paquete disponiple";
            textBX1.Text = "$13123";
            combitobox.Items.Add("Alimento");
            combitobox.Items.Add("Juguetes");
            combitobox.Items.Add("Ropa");
            textBDS.Text = "Que el pedido este ready";

        }
    }
}
