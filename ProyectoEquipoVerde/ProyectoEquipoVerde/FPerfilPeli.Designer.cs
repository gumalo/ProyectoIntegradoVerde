namespace ProyectoEquipoVerde
{
    partial class FPerfilPeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPerfilPeli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTit = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblAnyo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.picboxTag = new System.Windows.Forms.PictureBox();
            this.lblValorAnyo = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgvPelis = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.critica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPelis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.picBoxClose);
            this.panel1.Controls.Add(this.picBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 92);
            this.panel1.TabIndex = 6;
            // 
            // picBoxClose
            // 
            this.picBoxClose.Location = new System.Drawing.Point(811, 0);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(20, 16);
            this.picBoxClose.TabIndex = 6;
            this.picBoxClose.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.ErrorImage = null;
            this.picBoxLogo.InitialImage = null;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(66, 66);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(783, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 16);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(55, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.Location = new System.Drawing.Point(231, 115);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(68, 24);
            this.lblTit.TabIndex = 8;
            this.lblTit.Text = "Título:";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDirec.Location = new System.Drawing.Point(231, 167);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(89, 24);
            this.lblDirec.TabIndex = 9;
            this.lblDirec.Text = "Director:";
            // 
            // lblAnyo
            // 
            this.lblAnyo.AutoSize = true;
            this.lblAnyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAnyo.Location = new System.Drawing.Point(231, 221);
            this.lblAnyo.Name = "lblAnyo";
            this.lblAnyo.Size = new System.Drawing.Size(54, 24);
            this.lblAnyo.TabIndex = 10;
            this.lblAnyo.Text = "Año:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(408, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(127, 24);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(541, 115);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 53);
            this.textBox4.TabIndex = 15;
            // 
            // picboxTag
            // 
            this.picboxTag.Location = new System.Drawing.Point(55, 249);
            this.picboxTag.Name = "picboxTag";
            this.picboxTag.Size = new System.Drawing.Size(100, 100);
            this.picboxTag.TabIndex = 16;
            this.picboxTag.TabStop = false;
            // 
            // lblValorAnyo
            // 
            this.lblValorAnyo.AutoSize = true;
            this.lblValorAnyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblValorAnyo.Location = new System.Drawing.Point(326, 221);
            this.lblValorAnyo.Name = "lblValorAnyo";
            this.lblValorAnyo.Size = new System.Drawing.Size(83, 24);
            this.lblValorAnyo.TabIndex = 18;
            this.lblValorAnyo.Text = "AñoPeli";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(717, 304);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(105, 33);
            this.lblRating.TabIndex = 19;
            this.lblRating.Text = "Rating";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDirector.Location = new System.Drawing.Point(326, 167);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(83, 24);
            this.lblDirector.TabIndex = 20;
            this.lblDirector.Text = "Director";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(326, 115);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 24);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Titulo";
            // 
            // dtgvPelis
            // 
            this.dtgvPelis.AllowUserToAddRows = false;
            this.dtgvPelis.AllowUserToDeleteRows = false;
            this.dtgvPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPelis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.valoracion,
            this.critica});
            this.dtgvPelis.Location = new System.Drawing.Point(235, 262);
            this.dtgvPelis.Name = "dtgvPelis";
            this.dtgvPelis.ReadOnly = true;
            this.dtgvPelis.Size = new System.Drawing.Size(476, 116);
            this.dtgvPelis.TabIndex = 22;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // valoracion
            // 
            this.valoracion.HeaderText = "Valoración";
            this.valoracion.Name = "valoracion";
            this.valoracion.ReadOnly = true;
            // 
            // critica
            // 
            this.critica.HeaderText = "Crítica";
            this.critica.Name = "critica";
            this.critica.ReadOnly = true;
            this.critica.Width = 230;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTag.Location = new System.Drawing.Point(81, 354);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(46, 24);
            this.lblTag.TabIndex = 23;
            this.lblTag.Text = "Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "PELÍCULA";
            // 
            // FPerfilPeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.dtgvPelis);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblValorAnyo);
            this.Controls.Add(this.picboxTag);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblAnyo);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FPerfilPeli";
            this.Text = "FPerfilPeli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPelis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label lblAnyo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox picboxTag;
        private System.Windows.Forms.Label lblValorAnyo;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgvPelis;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn critica;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label label1;
    }
}