namespace ProyectoEquipoVerde
{
    partial class FPerfilUsuario
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
            this.lblCriticaReciente = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.DataPeliculasV = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ptcUsuario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.picboxBuscar = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxUsuario = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataPeliculasV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCriticaReciente
            // 
            this.lblCriticaReciente.AutoSize = true;
            this.lblCriticaReciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticaReciente.Location = new System.Drawing.Point(475, 128);
            this.lblCriticaReciente.Name = "lblCriticaReciente";
            this.lblCriticaReciente.Size = new System.Drawing.Size(187, 24);
            this.lblCriticaReciente.TabIndex = 9;
            this.lblCriticaReciente.Text = "CRÍTICA RECIENTE:";
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(668, 123);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 34);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(266, 110);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(97, 20);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "INFO USER";
            this.lblInfo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // DataPeliculasV
            // 
            this.DataPeliculasV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DataPeliculasV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPeliculasV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Puntuacion});
            this.DataPeliculasV.Location = new System.Drawing.Point(507, 163);
            this.DataPeliculasV.Name = "DataPeliculasV";
            this.DataPeliculasV.Size = new System.Drawing.Size(249, 282);
            this.DataPeliculasV.TabIndex = 13;
            this.DataPeliculasV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPeliculasV_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(306, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 31);
            this.textBox1.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(216, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNick.Location = new System.Drawing.Point(216, 204);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(103, 24);
            this.lblNick.TabIndex = 17;
            this.lblNick.Text = "NickName:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.textBox2.Location = new System.Drawing.Point(325, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(101, 36);
            this.textBox2.TabIndex = 16;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(216, 252);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(111, 24);
            this.lblContra.TabIndex = 19;
            this.lblContra.Text = "Contraseña:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.textBox3.Location = new System.Drawing.Point(333, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(93, 36);
            this.textBox3.TabIndex = 18;
            // 
            // ptcUsuario
            // 
            this.ptcUsuario.Location = new System.Drawing.Point(11, 128);
            this.ptcUsuario.Name = "ptcUsuario";
            this.ptcUsuario.Size = new System.Drawing.Size(199, 181);
            this.ptcUsuario.TabIndex = 0;
            this.ptcUsuario.TabStop = false;
            this.ptcUsuario.Click += new System.EventHandler(this.ptcUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.picBoxClose);
            this.panel1.Controls.Add(this.picboxBuscar);
            this.panel1.Controls.Add(this.picBoxLogo);
            this.panel1.Controls.Add(this.picBoxUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 92);
            this.panel1.TabIndex = 20;
            // 
            // picBoxClose
            // 
            this.picBoxClose.Image = global::ProyectoEquipoVerde.Properties.Resources.iconfinder_cross_35931;
            this.picBoxClose.Location = new System.Drawing.Point(762, 12);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(35, 33);
            this.picBoxClose.TabIndex = 6;
            this.picBoxClose.TabStop = false;
            // 
            // picboxBuscar
            // 
            this.picboxBuscar.BackColor = System.Drawing.Color.Gray;
            this.picboxBuscar.Image = global::ProyectoEquipoVerde.Properties.Resources.buscar;
            this.picboxBuscar.Location = new System.Drawing.Point(372, 12);
            this.picboxBuscar.Name = "picboxBuscar";
            this.picboxBuscar.Size = new System.Drawing.Size(66, 66);
            this.picboxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxBuscar.TabIndex = 2;
            this.picboxBuscar.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.ErrorImage = null;
            this.picBoxLogo.Image = global::ProyectoEquipoVerde.Properties.Resources.LOGO_APP___Extended_V3;
            this.picBoxLogo.InitialImage = null;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(66, 66);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxUsuario
            // 
            this.picBoxUsuario.ErrorImage = null;
            this.picBoxUsuario.Image = global::ProyectoEquipoVerde.Properties.Resources.usuario;
            this.picBoxUsuario.InitialImage = null;
            this.picBoxUsuario.Location = new System.Drawing.Point(690, 12);
            this.picBoxUsuario.Name = "picBoxUsuario";
            this.picBoxUsuario.Size = new System.Drawing.Size(66, 66);
            this.picBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsuario.TabIndex = 0;
            this.picBoxUsuario.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Puntuacion
            // 
            this.Puntuacion.HeaderText = "Puntuacion";
            this.Puntuacion.Name = "Puntuacion";
            // 
            // FPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(821, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataPeliculasV);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblCriticaReciente);
            this.Controls.Add(this.ptcUsuario);
            this.Name = "FPerfilUsuario";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.DataPeliculasV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcUsuario;
        private System.Windows.Forms.Label lblCriticaReciente;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView DataPeliculasV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.PictureBox picboxBuscar;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuacion;
    }
}