namespace ordenes_de_trabajo
{
    partial class frmOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenes));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAct = new System.Windows.Forms.Button();
            this.chkInactivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(661, 75);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 31);
            this.btnNuevo.TabIndex = 30;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(11, 79);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(254, 27);
            this.txtFiltro.TabIndex = 29;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filtro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Administracion de ordenes de trabajo";
            // 
            // gvGrilla
            // 
            this.gvGrilla.AllowUserToAddRows = false;
            this.gvGrilla.AllowUserToDeleteRows = false;
            this.gvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvGrilla.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.gvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.FechaCreacion,
            this.FechaLimite,
            this.Estado,
            this.Activo});
            this.gvGrilla.Location = new System.Drawing.Point(11, 111);
            this.gvGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.gvGrilla.Name = "gvGrilla";
            this.gvGrilla.ReadOnly = true;
            this.gvGrilla.RowTemplate.Height = 24;
            this.gvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGrilla.Size = new System.Drawing.Size(745, 304);
            this.gvGrilla.TabIndex = 26;
            this.gvGrilla.Click += new System.EventHandler(this.gvGrilla_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdOrden";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "Fecha creacion";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // FechaLimite
            // 
            this.FechaLimite.DataPropertyName = "FechaLimite";
            this.FechaLimite.HeaderText = "Fecha limite";
            this.FechaLimite.Name = "FechaLimite";
            this.FechaLimite.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activa";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // btnAct
            // 
            this.btnAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAct.BackgroundImage")));
            this.btnAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAct.Location = new System.Drawing.Point(712, 7);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(51, 39);
            this.btnAct.TabIndex = 31;
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // chkInactivos
            // 
            this.chkInactivos.AutoSize = true;
            this.chkInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInactivos.Location = new System.Drawing.Point(543, 82);
            this.chkInactivos.Name = "chkInactivos";
            this.chkInactivos.Size = new System.Drawing.Size(80, 20);
            this.chkInactivos.TabIndex = 32;
            this.chkInactivos.Text = "Inactivos";
            this.chkInactivos.UseVisualStyleBackColor = true;
            this.chkInactivos.CheckedChanged += new System.EventHandler(this.chkInactivos_CheckedChanged);
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 426);
            this.Controls.Add(this.chkInactivos);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvGrilla);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de trabajo";
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvGrilla;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.CheckBox chkInactivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}