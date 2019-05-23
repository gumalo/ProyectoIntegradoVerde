namespace ProyectoEquipoVerde
{
    partial class FRegistro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegistro));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.lblContrasenya = new System.Windows.Forms.Label();
            this.txtRepContrasenya = new System.Windows.Forms.TextBox();
            this.lblRepetirContrasenya = new System.Windows.Forms.Label();
            this.pcbImagenPerfil = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chbContr = new System.Windows.Forms.CheckBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(12, 87);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(262, 203);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 1;
            this.pcbLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(519, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(143, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(404, 72);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Location = new System.Drawing.Point(519, 105);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(143, 20);
            this.txtContrasenya.TabIndex = 6;
            this.txtContrasenya.UseSystemPasswordChar = true;
            // 
            // lblContrasenya
            // 
            this.lblContrasenya.AutoSize = true;
            this.lblContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenya.Location = new System.Drawing.Point(370, 105);
            this.lblContrasenya.Name = "lblContrasenya";
            this.lblContrasenya.Size = new System.Drawing.Size(107, 20);
            this.lblContrasenya.TabIndex = 5;
            this.lblContrasenya.Text = "Contraseña:";
            // 
            // txtRepContrasenya
            // 
            this.txtRepContrasenya.Location = new System.Drawing.Point(519, 141);
            this.txtRepContrasenya.Name = "txtRepContrasenya";
            this.txtRepContrasenya.Size = new System.Drawing.Size(143, 20);
            this.txtRepContrasenya.TabIndex = 8;
            this.txtRepContrasenya.UseSystemPasswordChar = true;
            // 
            // lblRepetirContrasenya
            // 
            this.lblRepetirContrasenya.AutoSize = true;
            this.lblRepetirContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirContrasenya.Location = new System.Drawing.Point(297, 141);
            this.lblRepetirContrasenya.Name = "lblRepetirContrasenya";
            this.lblRepetirContrasenya.Size = new System.Drawing.Size(171, 20);
            this.lblRepetirContrasenya.TabIndex = 7;
            this.lblRepetirContrasenya.Text = "Repetir Contraseña:";
            // 
            // pcbImagenPerfil
            // 
            this.pcbImagenPerfil.Image = global::ProyectoEquipoVerde.Properties.Resources.Users_Name_icon;
            this.pcbImagenPerfil.Location = new System.Drawing.Point(519, 190);
            this.pcbImagenPerfil.Name = "pcbImagenPerfil";
            this.pcbImagenPerfil.Size = new System.Drawing.Size(143, 144);
            this.pcbImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagenPerfil.TabIndex = 13;
            this.pcbImagenPerfil.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(519, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(404, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // chbContr
            // 
            this.chbContr.AutoSize = true;
            this.chbContr.Location = new System.Drawing.Point(669, 108);
            this.chbContr.Name = "chbContr";
            this.chbContr.Size = new System.Drawing.Size(87, 17);
            this.chbContr.TabIndex = 16;
            this.chbContr.Text = "Hacer visible";
            this.chbContr.UseVisualStyleBackColor = true;
            this.chbContr.CheckedChanged += new System.EventHandler(this.ChbContr_CheckedChanged);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.AutoSize = true;
            this.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(374, 190);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(122, 34);
            this.btnCargarImagen.TabIndex = 28;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click_1);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AutoSize = true;
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(545, 359);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(117, 34);
            this.btnRegistrarse.TabIndex = 29;
            this.btnRegistrarse.Text = "REGÍSTRATE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(456, 359);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(206, 34);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "GUARDAR MODIFICACIÓN";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(756, 422);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.chbContr);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pcbImagenPerfil);
            this.Controls.Add(this.txtRepContrasenya);
            this.Controls.Add(this.lblRepetirContrasenya);
            this.Controls.Add(this.txtContrasenya);
            this.Controls.Add(this.lblContrasenya);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pcbLogo);
            this.Name = "FRegistro";
            this.Text = "FRegistro";
            this.Load += new System.EventHandler(this.FRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.Label lblContrasenya;
        private System.Windows.Forms.TextBox txtRepContrasenya;
        private System.Windows.Forms.Label lblRepetirContrasenya;
        private System.Windows.Forms.PictureBox pcbImagenPerfil;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chbContr;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnModificar;
    }
}