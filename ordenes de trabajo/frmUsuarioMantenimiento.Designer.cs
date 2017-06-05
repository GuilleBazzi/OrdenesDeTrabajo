namespace ordenes_de_trabajo
{
    partial class frmUsuarioMantenimiento
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
            this.gvGrilla = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // gvGrilla
            // 
            this.gvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGrilla.Location = new System.Drawing.Point(21, 44);
            this.gvGrilla.Name = "gvGrilla";
            this.gvGrilla.Size = new System.Drawing.Size(240, 150);
            this.gvGrilla.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(145, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(282, 264);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Eliminar";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // UsuarioMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 336);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gvGrilla);
            this.Name = "UsuarioMantenimiento";
            this.Text = "Usuarios de Mantenimiento";
            this.Load += new System.EventHandler(this.UsuarioMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvGrilla;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn;
    }
}