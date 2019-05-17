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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPerfilUsuario));
            this.ptcUsuario = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCriticaReciente = new System.Windows.Forms.TextBox();
            this.lblCriticaReciente = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // ptcUsuario
            // 
            this.ptcUsuario.Location = new System.Drawing.Point(334, 37);
            this.ptcUsuario.Name = "ptcUsuario";
            this.ptcUsuario.Size = new System.Drawing.Size(124, 121);
            this.ptcUsuario.TabIndex = 0;
            this.ptcUsuario.TabStop = false;
            this.ptcUsuario.Click += new System.EventHandler(this.ptcUsuario_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(342, 180);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(106, 37);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "label1";
            // 
            // txtCriticaReciente
            // 
            this.txtCriticaReciente.BackColor = System.Drawing.Color.White;
            this.txtCriticaReciente.Location = new System.Drawing.Point(198, 340);
            this.txtCriticaReciente.Multiline = true;
            this.txtCriticaReciente.Name = "txtCriticaReciente";
            this.txtCriticaReciente.Size = new System.Drawing.Size(395, 64);
            this.txtCriticaReciente.TabIndex = 10;
            // 
            // lblCriticaReciente
            // 
            this.lblCriticaReciente.AutoSize = true;
            this.lblCriticaReciente.Location = new System.Drawing.Point(339, 313);
            this.lblCriticaReciente.Name = "lblCriticaReciente";
            this.lblCriticaReciente.Size = new System.Drawing.Size(109, 13);
            this.lblCriticaReciente.TabIndex = 9;
            this.lblCriticaReciente.Text = "CRÍTICA RECIENTE:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(363, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 20);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtCriticaReciente);
            this.Controls.Add(this.lblCriticaReciente);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.ptcUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPerfilUsuario";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.ptcUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCriticaReciente;
        private System.Windows.Forms.Label lblCriticaReciente;
        private System.Windows.Forms.Button btnEditar;
    }
}