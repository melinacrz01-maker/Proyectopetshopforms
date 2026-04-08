namespace ProyectoForms.cs
{
    partial class Form1
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
            this.lblG = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.lblStockk = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.textBX1 = new System.Windows.Forms.TextBox();
            this.combitobox = new System.Windows.Forms.ComboBox();
            this.texpaquete = new System.Windows.Forms.TextBox();
            this.txtCd = new System.Windows.Forms.TextBox();
            this.textBoxYourname = new System.Windows.Forms.TextBox();
            this.textBDS = new System.Windows.Forms.TextBox();
            this.bttcargar = new System.Windows.Forms.Button();
            this.pictureBoxDOS = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttmodifique = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.Gold;
            this.lblG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.ForeColor = System.Drawing.Color.Black;
            this.lblG.Location = new System.Drawing.Point(86, 9);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(191, 24);
            this.lblG.TabIndex = 1;
            this.lblG.Text = "Gestion de Productos";
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
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(25, 83);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(61, 16);
            this.lblcode.TabIndex = 3;
            this.lblcode.Text = "Codigo:";
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
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(25, 174);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 16);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Categoria:";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(12, 216);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(94, 16);
            this.lbldescription.TabIndex = 7;
            this.lbldescription.Text = "Descripción:";
            // 
            // textBX1
            // 
            this.textBX1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBX1.Location = new System.Drawing.Point(112, 142);
            this.textBX1.Name = "textBX1";
            this.textBX1.Size = new System.Drawing.Size(141, 20);
            this.textBX1.TabIndex = 8;
            // 
            // combitobox
            // 
            this.combitobox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.combitobox.FormattingEnabled = true;
            this.combitobox.Location = new System.Drawing.Point(112, 174);
            this.combitobox.Name = "combitobox";
            this.combitobox.Size = new System.Drawing.Size(141, 21);
            this.combitobox.TabIndex = 9;
            // 
            // texpaquete
            // 
            this.texpaquete.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.texpaquete.Location = new System.Drawing.Point(112, 113);
            this.texpaquete.Name = "texpaquete";
            this.texpaquete.Size = new System.Drawing.Size(141, 20);
            this.texpaquete.TabIndex = 10;
            // 
            // txtCd
            // 
            this.txtCd.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtCd.Location = new System.Drawing.Point(112, 82);
            this.txtCd.Name = "txtCd";
            this.txtCd.Size = new System.Drawing.Size(141, 20);
            this.txtCd.TabIndex = 11;
            // 
            // textBoxYourname
            // 
            this.textBoxYourname.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxYourname.Location = new System.Drawing.Point(112, 53);
            this.textBoxYourname.Name = "textBoxYourname";
            this.textBoxYourname.Size = new System.Drawing.Size(141, 20);
            this.textBoxYourname.TabIndex = 12;
            // 
            // textBDS
            // 
            this.textBDS.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBDS.Location = new System.Drawing.Point(112, 215);
            this.textBDS.Multiline = true;
            this.textBDS.Name = "textBDS";
            this.textBDS.Size = new System.Drawing.Size(141, 81);
            this.textBDS.TabIndex = 13;
            // 
            // bttcargar
            // 
            this.bttcargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttcargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttcargar.Location = new System.Drawing.Point(28, 443);
            this.bttcargar.Name = "bttcargar";
            this.bttcargar.Size = new System.Drawing.Size(113, 34);
            this.bttcargar.TabIndex = 14;
            this.bttcargar.Text = "Cargar";
            this.bttcargar.UseVisualStyleBackColor = false;
            this.bttcargar.Click += new System.EventHandler(this.bttcargar_Click);
            // 
            // pictureBoxDOS
            // 
            this.pictureBoxDOS.Image = global::ProyectoForms.cs.Properties.Resources.yellow_fancy_dog_puppy_avatar_badge_poster_logo_templates_print_illustration_in_flat_cartoon_style_vector__1_;
            this.pictureBoxDOS.Location = new System.Drawing.Point(192, 331);
            this.pictureBoxDOS.Name = "pictureBoxDOS";
            this.pictureBoxDOS.Size = new System.Drawing.Size(122, 118);
            this.pictureBoxDOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDOS.TabIndex = 15;
            this.pictureBoxDOS.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoForms.cs.Properties.Resources.yellow_fancy_dog_puppy_avatar_badge_poster_logo_templates_print_illustration_in_flat_cartoon_style_vector;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttmodifique
            // 
            this.buttmodifique.BackColor = System.Drawing.Color.Red;
            this.buttmodifique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttmodifique.Location = new System.Drawing.Point(192, 443);
            this.buttmodifique.Name = "buttmodifique";
            this.buttmodifique.Size = new System.Drawing.Size(122, 34);
            this.buttmodifique.TabIndex = 16;
            this.buttmodifique.Text = "Modificar";
            this.buttmodifique.UseVisualStyleBackColor = false;
            this.buttmodifique.Click += new System.EventHandler(this.buttmodifique_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(340, 510);
            this.Controls.Add(this.buttmodifique);
            this.Controls.Add(this.pictureBoxDOS);
            this.Controls.Add(this.bttcargar);
            this.Controls.Add(this.textBDS);
            this.Controls.Add(this.textBoxYourname);
            this.Controls.Add(this.txtCd);
            this.Controls.Add(this.texpaquete);
            this.Controls.Add(this.combitobox);
            this.Controls.Add(this.textBX1);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblStockk);
            this.Controls.Add(this.lblcode);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label lblStockk;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox textBX1;
        private System.Windows.Forms.ComboBox combitobox;
        private System.Windows.Forms.TextBox texpaquete;
        private System.Windows.Forms.TextBox txtCd;
        private System.Windows.Forms.TextBox textBoxYourname;
        private System.Windows.Forms.TextBox textBDS;
        private System.Windows.Forms.Button bttcargar;
        private System.Windows.Forms.PictureBox pictureBoxDOS;
        private System.Windows.Forms.Button buttmodifique;
    }
}

