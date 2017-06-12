namespace ordenes_de_trabajo
{
    partial class frmModificarOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarOrden));
            this.lblNumeroOt = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaOrden = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblsec = new System.Windows.Forms.Label();
            this.lblFechalimite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroOt
            // 
            this.lblNumeroOt.AutoSize = true;
            this.lblNumeroOt.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOt.Location = new System.Drawing.Point(336, 9);
            this.lblNumeroOt.Name = "lblNumeroOt";
            this.lblNumeroOt.Size = new System.Drawing.Size(130, 29);
            this.lblNumeroOt.TabIndex = 37;
            this.lblNumeroOt.Text = "Orden N° 33";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(341, 68);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(203, 21);
            this.cmbEstado.TabIndex = 1;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Book Antiqua", 11F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(24, 340);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(173, 26);
            this.dtpInicio.TabIndex = 34;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Book Antiqua", 11F);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(302, 340);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(173, 26);
            this.dtpFin.TabIndex = 33;
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.AutoSize = true;
            this.lblFechaOrden.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaOrden.Location = new System.Drawing.Point(21, 7);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Size = new System.Drawing.Size(142, 29);
            this.lblFechaOrden.TabIndex = 32;
            this.lblFechaOrden.Text = "23 MAR 2017";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsuario.Location = new System.Drawing.Point(23, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(124, 19);
            this.lblUsuario.TabIndex = 31;
            this.lblUsuario.Text = "Matias Fernandez";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(394, 550);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 33);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitar.BackgroundImage")));
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(510, 465);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(34, 35);
            this.btnQuitar.TabIndex = 30;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(510, 418);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(34, 35);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gvGrilla
            // 
            this.gvGrilla.AllowUserToAddRows = false;
            this.gvGrilla.AllowUserToDeleteRows = false;
            this.gvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvGrilla.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.gvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Tipo});
            this.gvGrilla.Location = new System.Drawing.Point(28, 390);
            this.gvGrilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvGrilla.Name = "gvGrilla";
            this.gvGrilla.ReadOnly = true;
            this.gvGrilla.RowTemplate.Height = 24;
            this.gvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGrilla.Size = new System.Drawing.Size(479, 157);
            this.gvGrilla.TabIndex = 27;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdUsuario";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Location = new System.Drawing.Point(23, 250);
            this.txtJustificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.ReadOnly = true;
            this.txtJustificacion.Size = new System.Drawing.Size(521, 66);
            this.txtJustificacion.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sector";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 100);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(522, 64);
            this.txtDescripcion.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Personal Asignado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Fin";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(22, 318);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(94, 20);
            this.lblSector.TabIndex = 21;
            this.lblSector.Text = "Fecha Inicio";
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.AutoSize = true;
            this.lblJustificacion.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustificacion.Location = new System.Drawing.Point(22, 228);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.Size = new System.Drawing.Size(209, 20);
            this.lblJustificacion.TabIndex = 20;
            this.lblJustificacion.Text = "Justificación de fecha límite ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(337, 46);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 20);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(331, 174);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 20);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha límite ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(22, 78);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 20);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripción";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(27, 550);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 33);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar orden";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.BackColor = System.Drawing.Color.Transparent;
            this.lblsec.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.Location = new System.Drawing.Point(24, 194);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(137, 23);
            this.lblsec.TabIndex = 40;
            this.lblsec.Text = "Nombre Sector";
            // 
            // lblFechalimite
            // 
            this.lblFechalimite.AutoSize = true;
            this.lblFechalimite.BackColor = System.Drawing.Color.Transparent;
            this.lblFechalimite.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechalimite.Location = new System.Drawing.Point(331, 194);
            this.lblFechalimite.Name = "lblFechalimite";
            this.lblFechalimite.Size = new System.Drawing.Size(94, 23);
            this.lblFechalimite.TabIndex = 41;
            this.lblFechalimite.Text = "10/06/17";
            // 
            // frmModificarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 591);
            this.Controls.Add(this.lblFechalimite);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblNumeroOt);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lblFechaOrden);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gvGrilla);
            this.Controls.Add(this.txtJustificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblJustificacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar orden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmModificarOrden_FormClosing);
            this.Load += new System.EventHandler(this.frmModificarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumeroOt;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblFechaOrden;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView gvGrilla;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lblFechalimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}