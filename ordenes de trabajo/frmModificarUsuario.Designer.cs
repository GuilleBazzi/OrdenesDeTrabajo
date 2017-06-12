namespace ordenes_de_trabajo
{
    partial class frmModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarUsuario));
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbTipoDesuario = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnGuard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Sector";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(89, 39);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 32;
            this.lblApellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Email";
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(22, 215);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(313, 21);
            this.cmbSector.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 20);
            this.txtEmail.TabIndex = 29;
            // 
            // cmbTipoDesuario
            // 
            this.cmbTipoDesuario.FormattingEnabled = true;
            this.cmbTipoDesuario.Location = new System.Drawing.Point(22, 162);
            this.cmbTipoDesuario.Name = "cmbTipoDesuario";
            this.cmbTipoDesuario.Size = new System.Drawing.Size(315, 21);
            this.cmbTipoDesuario.TabIndex = 23;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(21, 143);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(110, 18);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "Tipo de usuario";
            // 
            // btnElim
            // 
            this.btnElim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElim.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElim.Location = new System.Drawing.Point(18, 255);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(146, 32);
            this.btnElim.TabIndex = 37;
            this.btnElim.Text = "Eliminar usuario";
            this.btnElim.UseVisualStyleBackColor = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnGuard
            // 
            this.btnGuard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuard.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuard.Location = new System.Drawing.Point(189, 255);
            this.btnGuard.Name = "btnGuard";
            this.btnGuard.Size = new System.Drawing.Size(146, 32);
            this.btnGuard.TabIndex = 38;
            this.btnGuard.Text = "Guardar cambios";
            this.btnGuard.UseVisualStyleBackColor = false;
            this.btnGuard.Click += new System.EventHandler(this.btnGuard_Click);
            // 
            // frmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 316);
            this.Controls.Add(this.btnGuard);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbTipoDesuario);
            this.Controls.Add(this.lblTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.frmModificarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbTipoDesuario;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnGuard;
    }
}