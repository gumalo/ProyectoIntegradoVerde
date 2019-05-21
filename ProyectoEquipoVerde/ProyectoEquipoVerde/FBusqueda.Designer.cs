namespace ProyectoEquipoVerde
{
    partial class FBusqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnHeaderBuscarPeli = new System.Windows.Forms.Button();
            this.btnHeaderTwitter = new System.Windows.Forms.Button();
            this.btnHeaderInsta = new System.Windows.Forms.Button();
            this.btnHeaderFB = new System.Windows.Forms.Button();
            this.btnHeaderInicio = new System.Windows.Forms.Button();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPelis = new System.Windows.Forms.Panel();
            this.lblPelis = new System.Windows.Forms.Label();
            this.dgvPelis = new System.Windows.Forms.DataGridView();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.idpeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portada = new System.Windows.Forms.DataGridViewImageColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punt_media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlPelis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelis)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.Location = new System.Drawing.Point(29, 122);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(234, 29);
            this.txtBuscarUsuario.TabIndex = 7;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.btnVerPerfil);
            this.pnlHeader.Controls.Add(this.btnCerrarSesion);
            this.pnlHeader.Controls.Add(this.btnHeaderBuscarPeli);
            this.pnlHeader.Controls.Add(this.btnHeaderTwitter);
            this.pnlHeader.Controls.Add(this.btnHeaderInsta);
            this.pnlHeader.Controls.Add(this.btnHeaderFB);
            this.pnlHeader.Controls.Add(this.btnHeaderInicio);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1344, 92);
            this.pnlHeader.TabIndex = 25;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(1127, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 46);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnVerPerfil.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.Users_Name_icon;
            this.btnVerPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerPerfil.FlatAppearance.BorderSize = 0;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(1197, 16);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(62, 62);
            this.btnVerPerfil.TabIndex = 29;
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.BtnVerPerfil_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_filled_100;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1279, 21);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(53, 53);
            this.btnCerrarSesion.TabIndex = 28;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // btnHeaderBuscarPeli
            // 
            this.btnHeaderBuscarPeli.BackColor = System.Drawing.Color.Transparent;
            this.btnHeaderBuscarPeli.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.media_film_solid_search_512;
            this.btnHeaderBuscarPeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderBuscarPeli.FlatAppearance.BorderSize = 0;
            this.btnHeaderBuscarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderBuscarPeli.Location = new System.Drawing.Point(676, 15);
            this.btnHeaderBuscarPeli.Name = "btnHeaderBuscarPeli";
            this.btnHeaderBuscarPeli.Size = new System.Drawing.Size(77, 65);
            this.btnHeaderBuscarPeli.TabIndex = 26;
            this.btnHeaderBuscarPeli.UseVisualStyleBackColor = false;
            this.btnHeaderBuscarPeli.Click += new System.EventHandler(this.BtnHeaderBuscarPeli_Click);
            // 
            // btnHeaderTwitter
            // 
            this.btnHeaderTwitter.BackColor = System.Drawing.Color.Transparent;
            this.btnHeaderTwitter.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.icons8_twitter_filled_100;
            this.btnHeaderTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderTwitter.FlatAppearance.BorderSize = 0;
            this.btnHeaderTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderTwitter.Location = new System.Drawing.Point(245, 21);
            this.btnHeaderTwitter.Name = "btnHeaderTwitter";
            this.btnHeaderTwitter.Size = new System.Drawing.Size(54, 54);
            this.btnHeaderTwitter.TabIndex = 25;
            this.btnHeaderTwitter.UseVisualStyleBackColor = false;
            this.btnHeaderTwitter.Click += new System.EventHandler(this.BtnHeaderTwitter_Click);
            // 
            // btnHeaderInsta
            // 
            this.btnHeaderInsta.BackColor = System.Drawing.Color.Transparent;
            this.btnHeaderInsta.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.icons8_instagram_filled_100;
            this.btnHeaderInsta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderInsta.FlatAppearance.BorderSize = 0;
            this.btnHeaderInsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderInsta.Location = new System.Drawing.Point(178, 20);
            this.btnHeaderInsta.Name = "btnHeaderInsta";
            this.btnHeaderInsta.Size = new System.Drawing.Size(54, 54);
            this.btnHeaderInsta.TabIndex = 25;
            this.btnHeaderInsta.UseVisualStyleBackColor = false;
            this.btnHeaderInsta.Click += new System.EventHandler(this.BtnHeaderInsta_Click);
            // 
            // btnHeaderFB
            // 
            this.btnHeaderFB.BackColor = System.Drawing.Color.Transparent;
            this.btnHeaderFB.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.icons8_facebook_filled_100;
            this.btnHeaderFB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderFB.FlatAppearance.BorderSize = 0;
            this.btnHeaderFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderFB.Location = new System.Drawing.Point(110, 20);
            this.btnHeaderFB.Name = "btnHeaderFB";
            this.btnHeaderFB.Size = new System.Drawing.Size(54, 54);
            this.btnHeaderFB.TabIndex = 24;
            this.btnHeaderFB.UseVisualStyleBackColor = false;
            this.btnHeaderFB.Click += new System.EventHandler(this.BtnHeaderFB_Click);
            // 
            // btnHeaderInicio
            // 
            this.btnHeaderInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnHeaderInicio.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.LOGO_APP___Extended_V3;
            this.btnHeaderInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderInicio.FlatAppearance.BorderSize = 0;
            this.btnHeaderInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderInicio.Location = new System.Drawing.Point(6, 6);
            this.btnHeaderInicio.Name = "btnHeaderInicio";
            this.btnHeaderInicio.Size = new System.Drawing.Size(77, 79);
            this.btnHeaderInicio.TabIndex = 23;
            this.btnHeaderInicio.UseVisualStyleBackColor = false;
            this.btnHeaderInicio.Click += new System.EventHandler(this.BtnHeaderInicio_Click);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.Gray;
            this.pnlUsuarios.Controls.Add(this.lblUsuarios);
            this.pnlUsuarios.Location = new System.Drawing.Point(29, 177);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(268, 42);
            this.pnlUsuarios.TabIndex = 27;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(3, 9);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(105, 24);
            this.lblUsuarios.TabIndex = 22;
            this.lblUsuarios.Text = "USUARIOS";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nickname,
            this.nombre,
            this.criticas});
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvUsuarios.Location = new System.Drawing.Point(29, 219);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(268, 430);
            this.dgvUsuarios.TabIndex = 26;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPeliculasUser_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // nickname
            // 
            this.nickname.DataPropertyName = "Nick";
            this.nickname.HeaderText = "Nickname";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            this.nickname.Width = 90;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
            // 
            // criticas
            // 
            this.criticas.DataPropertyName = "Criticas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.criticas.DefaultCellStyle = dataGridViewCellStyle3;
            this.criticas.HeaderText = "Críticas";
            this.criticas.Name = "criticas";
            this.criticas.ReadOnly = true;
            this.criticas.Width = 55;
            // 
            // pnlPelis
            // 
            this.pnlPelis.BackColor = System.Drawing.Color.Gray;
            this.pnlPelis.Controls.Add(this.lblPelis);
            this.pnlPelis.Location = new System.Drawing.Point(357, 177);
            this.pnlPelis.Name = "pnlPelis";
            this.pnlPelis.Size = new System.Drawing.Size(600, 42);
            this.pnlPelis.TabIndex = 29;
            // 
            // lblPelis
            // 
            this.lblPelis.AutoSize = true;
            this.lblPelis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelis.Location = new System.Drawing.Point(3, 9);
            this.lblPelis.Name = "lblPelis";
            this.lblPelis.Size = new System.Drawing.Size(110, 24);
            this.lblPelis.TabIndex = 22;
            this.lblPelis.Text = "PELÍCULAS";
            // 
            // dgvPelis
            // 
            this.dgvPelis.AllowUserToAddRows = false;
            this.dgvPelis.AllowUserToDeleteRows = false;
            this.dgvPelis.AllowUserToResizeColumns = false;
            this.dgvPelis.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvPelis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPelis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPelis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeli,
            this.portada,
            this.titulo,
            this.fecha,
            this.director,
            this.punt_media,
            this.tag});
            this.dgvPelis.EnableHeadersVisualStyles = false;
            this.dgvPelis.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvPelis.Location = new System.Drawing.Point(357, 219);
            this.dgvPelis.Name = "dgvPelis";
            this.dgvPelis.ReadOnly = true;
            this.dgvPelis.RowHeadersVisible = false;
            this.dgvPelis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvPelis.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPelis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvPelis.RowTemplate.Height = 90;
            this.dgvPelis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPelis.Size = new System.Drawing.Size(600, 430);
            this.dgvPelis.TabIndex = 28;
            this.dgvPelis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPelis_CellDoubleClick);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.AutoSize = true;
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarUsuario.BackgroundImage = global::ProyectoEquipoVerde.Properties.Resources.search;
            this.btnBuscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(269, 122);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(28, 29);
            this.btnBuscarUsuario.TabIndex = 28;
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.BtnBuscarUsuario_Click);
            // 
            // idpeli
            // 
            this.idpeli.DataPropertyName = "ID";
            this.idpeli.HeaderText = "ID";
            this.idpeli.Name = "idpeli";
            this.idpeli.ReadOnly = true;
            this.idpeli.Visible = false;
            // 
            // portada
            // 
            this.portada.DataPropertyName = "Portada";
            this.portada.HeaderText = "Portada";
            this.portada.Name = "portada";
            this.portada.ReadOnly = true;
            this.portada.Width = 70;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "Titulo";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 160;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle7;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 80;
            // 
            // director
            // 
            this.director.DataPropertyName = "Director";
            this.director.HeaderText = "Director";
            this.director.Name = "director";
            this.director.ReadOnly = true;
            // 
            // punt_media
            // 
            this.punt_media.DataPropertyName = "Puntuacion";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punt_media.DefaultCellStyle = dataGridViewCellStyle8;
            this.punt_media.HeaderText = "Punt. Media";
            this.punt_media.Name = "punt_media";
            this.punt_media.ReadOnly = true;
            this.punt_media.Width = 89;
            // 
            // tag
            // 
            this.tag.DataPropertyName = "tag";
            this.tag.HeaderText = "Tag";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 70;
            // 
            // FBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1344, 681);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.pnlPelis);
            this.Controls.Add(this.dgvPelis);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Name = "FBusqueda";
            this.Text = "FBusqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlPelis.ResumeLayout(false);
            this.pnlPelis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnHeaderBuscarPeli;
        private System.Windows.Forms.Button btnHeaderTwitter;
        private System.Windows.Forms.Button btnHeaderInsta;
        private System.Windows.Forms.Button btnHeaderFB;
        private System.Windows.Forms.Button btnHeaderInicio;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlPelis;
        private System.Windows.Forms.Label lblPelis;
        private System.Windows.Forms.DataGridView dgvPelis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticas;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeli;
        private System.Windows.Forms.DataGridViewImageColumn portada;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn director;
        private System.Windows.Forms.DataGridViewTextBoxColumn punt_media;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
    }
}