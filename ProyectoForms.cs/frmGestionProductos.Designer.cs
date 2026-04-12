namespace ProyectoForms.cs
{
    partial class frmGestionProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionProductos));
            this.lblG = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.lblStockk = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.comboboxcategoria = new System.Windows.Forms.ComboBox();
            this.texpaquete = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textboxDescrepcion = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.buttmodifique = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.imagentres = new System.Windows.Forms.PictureBox();
            this.Imagendos = new System.Windows.Forms.PictureBox();
            this.ImagenUno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagentres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagendos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenUno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.Gold;
            this.lblG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.ForeColor = System.Drawing.Color.Black;
            this.lblG.Location = new System.Drawing.Point(63, 9);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(265, 24);
            this.lblG.TabIndex = 1;
            this.lblG.Text = "Gestión de Productos Petshop";
            this.lblG.Click += new System.EventHandler(this.lblG_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(25, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 16);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nombre:";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(25, 83);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(61, 16);
            this.lblcode.TabIndex = 3;
            this.lblcode.Text = "Código:";
            this.lblcode.Click += new System.EventHandler(this.lblcode_Click);
            // 
            // lblStockk
            // 
            this.lblStockk.AutoSize = true;
            this.lblStockk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockk.Location = new System.Drawing.Point(25, 114);
            this.lblStockk.Name = "lblStockk";
            this.lblStockk.Size = new System.Drawing.Size(50, 16);
            this.lblStockk.TabIndex = 4;
            this.lblStockk.Text = "Stock:";
            this.lblStockk.Click += new System.EventHandler(this.lblStockk_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(25, 142);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(56, 16);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Precio:";
            this.lblMoney.Click += new System.EventHandler(this.lblMoney_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(25, 174);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 16);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Categoría:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(25, 216);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(94, 16);
            this.lbldescription.TabIndex = 7;
            this.lbldescription.Text = "Descripción:";
            this.lbldescription.Click += new System.EventHandler(this.lbldescription_Click);
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textPrecio.Location = new System.Drawing.Point(125, 141);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(60, 20);
            this.textPrecio.TabIndex = 3;
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // comboboxcategoria
            // 
            this.comboboxcategoria.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.comboboxcategoria.FormattingEnabled = true;
            this.comboboxcategoria.Items.AddRange(new object[] {
            "Alimentos",
            "Juguetes",
            "Ropa",
            "Collares "});
            this.comboboxcategoria.Location = new System.Drawing.Point(125, 173);
            this.comboboxcategoria.Name = "comboboxcategoria";
            this.comboboxcategoria.Size = new System.Drawing.Size(141, 21);
            this.comboboxcategoria.TabIndex = 4;
            this.comboboxcategoria.SelectedIndexChanged += new System.EventHandler(this.comboboxcategoria_SelectedIndexChanged);
            // 
            // texpaquete
            // 
            this.texpaquete.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.texpaquete.Location = new System.Drawing.Point(125, 112);
            this.texpaquete.Name = "texpaquete";
            this.texpaquete.Size = new System.Drawing.Size(60, 20);
            this.texpaquete.TabIndex = 2;
            this.texpaquete.TextChanged += new System.EventHandler(this.texpaquete_TextChanged);
            // 
            // textCodigo
            // 
            this.textCodigo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textCodigo.Location = new System.Drawing.Point(125, 81);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(141, 20);
            this.textCodigo.TabIndex = 1;
            this.textCodigo.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxNombre.Location = new System.Drawing.Point(125, 52);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(141, 20);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textboxDescrepcion
            // 
            this.textboxDescrepcion.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textboxDescrepcion.Location = new System.Drawing.Point(125, 215);
            this.textboxDescrepcion.Multiline = true;
            this.textboxDescrepcion.Name = "textboxDescrepcion";
            this.textboxDescrepcion.Size = new System.Drawing.Size(141, 81);
            this.textboxDescrepcion.TabIndex = 5;
            this.textboxDescrepcion.TextChanged += new System.EventHandler(this.textboxDescrepcion_TextChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGrabar.Location = new System.Drawing.Point(20, 415);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(95, 34);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.bttcargar_Click);
            // 
            // buttmodifique
            // 
            this.buttmodifique.BackColor = System.Drawing.Color.Red;
            this.buttmodifique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttmodifique.Location = new System.Drawing.Point(129, 415);
            this.buttmodifique.Name = "buttmodifique";
            this.buttmodifique.Size = new System.Drawing.Size(94, 34);
            this.buttmodifique.TabIndex = 7;
            this.buttmodifique.Text = "Modificar";
            this.buttmodifique.UseVisualStyleBackColor = false;
            this.buttmodifique.Click += new System.EventHandler(this.buttmodifique_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Blue;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(241, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 34);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(10, 490);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(320, 160);
            this.dgvProductos.TabIndex = 20;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // imagentres
            // 
            this.imagentres.BackColor = System.Drawing.Color.NavajoWhite;
            this.imagentres.Image = global::ProyectoForms.cs.Properties.Resources._56373640_hueso_de_perro_de_juguete_tema_de_ilustración_de_arte_vectorial;
            this.imagentres.Location = new System.Drawing.Point(241, 319);
            this.imagentres.Name = "imagentres";
            this.imagentres.Size = new System.Drawing.Size(87, 96);
            this.imagentres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagentres.TabIndex = 21;
            this.imagentres.TabStop = false;
            // 
            // Imagendos
            // 
            this.Imagendos.Image = global::ProyectoForms.cs.Properties.Resources.yellow_fancy_dog_puppy_avatar_badge_poster_logo_templates_print_illustration_in_flat_cartoon_style_vector__1_;
            this.Imagendos.Location = new System.Drawing.Point(129, 319);
            this.Imagendos.Name = "Imagendos";
            this.Imagendos.Size = new System.Drawing.Size(90, 96);
            this.Imagendos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagendos.TabIndex = 15;
            this.Imagendos.TabStop = false;
            this.Imagendos.Click += new System.EventHandler(this.Imagendos_Click);
            // 
            // ImagenUno
            // 
            this.ImagenUno.BackgroundImage = global::ProyectoForms.cs.Properties.Resources.yellow_fancy_dog_puppy_avatar_badge_poster_logo_templates_print_illustration_in_flat_cartoon_style_vector;
            this.ImagenUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagenUno.ErrorImage = null;
            this.ImagenUno.Location = new System.Drawing.Point(18, 319);
            this.ImagenUno.Name = "ImagenUno";
            this.ImagenUno.Size = new System.Drawing.Size(97, 96);
            this.ImagenUno.TabIndex = 0;
            this.ImagenUno.TabStop = false;
            this.ImagenUno.Click += new System.EventHandler(this.ImagenUno_Click);
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(340, 665);
            this.Controls.Add(this.imagentres);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.buttmodifique);
            this.Controls.Add(this.Imagendos);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.textboxDescrepcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.texpaquete);
            this.Controls.Add(this.comboboxcategoria);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblStockk);
            this.Controls.Add(this.lblcode);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.ImagenUno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de productos - PETSHOP";
            this.Load += new System.EventHandler(this.frmGestionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagentres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagendos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenUno;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label lblStockk;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.ComboBox comboboxcategoria;
        private System.Windows.Forms.TextBox texpaquete;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textboxDescrepcion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.PictureBox Imagendos;
        private System.Windows.Forms.Button buttmodifique;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.PictureBox imagentres;
    }
}

