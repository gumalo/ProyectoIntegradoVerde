namespace ProyectoEquipoVerde
{
    partial class FCritica
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
            this.txtCritica = new System.Windows.Forms.RichTextBox();
            this.trbPuntuacion = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotaNum = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbTag = new System.Windows.Forms.PictureBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.trbTag = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCritica = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbPuntuacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTag)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCritica
            // 
            this.txtCritica.Location = new System.Drawing.Point(391, 94);
            this.txtCritica.Name = "txtCritica";
            this.txtCritica.Size = new System.Drawing.Size(203, 145);
            this.txtCritica.TabIndex = 0;
            this.txtCritica.Text = "";
            // 
            // trbPuntuacion
            // 
            this.trbPuntuacion.Location = new System.Drawing.Point(23, 150);
            this.trbPuntuacion.Name = "trbPuntuacion";
            this.trbPuntuacion.Size = new System.Drawing.Size(104, 45);
            this.trbPuntuacion.TabIndex = 1;
            this.trbPuntuacion.Scroll += new System.EventHandler(this.TrbPuntuacion_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblNotaNum);
            this.panel1.Controls.Add(this.trbPuntuacion);
            this.panel1.Location = new System.Drawing.Point(29, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 205);
            this.panel1.TabIndex = 2;
            // 
            // lblNotaNum
            // 
            this.lblNotaNum.AutoSize = true;
            this.lblNotaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaNum.Location = new System.Drawing.Point(37, 60);
            this.lblNotaNum.Name = "lblNotaNum";
            this.lblNotaNum.Size = new System.Drawing.Size(68, 73);
            this.lblNotaNum.TabIndex = 4;
            this.lblNotaNum.Text = "0";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.BackColor = System.Drawing.Color.Gray;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(44, 53);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(120, 25);
            this.lblNota.TabIndex = 3;
            this.lblNota.Text = "Puntuación";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pcbTag);
            this.panel2.Controls.Add(this.lblTag);
            this.panel2.Controls.Add(this.trbTag);
            this.panel2.Location = new System.Drawing.Point(213, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 205);
            this.panel2.TabIndex = 5;
            // 
            // pcbTag
            // 
            this.pcbTag.Image = global::ProyectoEquipoVerde.Properties.Resources.brainwash;
            this.pcbTag.InitialImage = null;
            this.pcbTag.Location = new System.Drawing.Point(42, 60);
            this.pcbTag.Name = "pcbTag";
            this.pcbTag.Size = new System.Drawing.Size(73, 73);
            this.pcbTag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTag.TabIndex = 4;
            this.pcbTag.TabStop = false;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(54, 19);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(49, 25);
            this.lblTag.TabIndex = 3;
            this.lblTag.Text = "Tag";
            // 
            // trbTag
            // 
            this.trbTag.Location = new System.Drawing.Point(23, 150);
            this.trbTag.Maximum = 5;
            this.trbTag.Minimum = 1;
            this.trbTag.Name = "trbTag";
            this.trbTag.Size = new System.Drawing.Size(104, 45);
            this.trbTag.TabIndex = 1;
            this.trbTag.Value = 1;
            this.trbTag.Scroll += new System.EventHandler(this.TrbTag_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.lblCritica);
            this.panel3.Location = new System.Drawing.Point(391, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 61);
            this.panel3.TabIndex = 6;
            // 
            // lblCritica
            // 
            this.lblCritica.AutoSize = true;
            this.lblCritica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCritica.Location = new System.Drawing.Point(9, 17);
            this.lblCritica.Name = "lblCritica";
            this.lblCritica.Size = new System.Drawing.Size(174, 25);
            this.lblCritica.TabIndex = 5;
            this.lblCritica.Text = "Crítica (opcional)";
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSize = true;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(494, 251);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 34);
            this.btnEnviar.TabIndex = 27;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(429, 251);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 34);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "MODIFICAR CRÍTICA";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // FCritica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(617, 297);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCritica);
            this.Name = "FCritica";
            this.Text = "FCritica";
            this.Load += new System.EventHandler(this.FCritica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbPuntuacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTag)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCritica;
        private System.Windows.Forms.TrackBar trbPuntuacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotaNum;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TrackBar trbTag;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCritica;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnModificar;
    }
}