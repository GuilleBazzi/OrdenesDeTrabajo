namespace ordenes_de_trabajo
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnSectores = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSinAsig = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.btnAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPersonal.FlatAppearance.BorderSize = 3;
            this.btnPersonal.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPersonal.Location = new System.Drawing.Point(44, 239);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(217, 95);
            this.btnPersonal.TabIndex = 5;
            this.btnPersonal.Text = "Administración de usuarios";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnSectores
            // 
            this.btnSectores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSectores.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSectores.FlatAppearance.BorderSize = 3;
            this.btnSectores.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectores.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSectores.Location = new System.Drawing.Point(44, 127);
            this.btnSectores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSectores.Name = "btnSectores";
            this.btnSectores.Size = new System.Drawing.Size(217, 95);
            this.btnSectores.TabIndex = 4;
            this.btnSectores.Text = "Administración de sectores";
            this.btnSectores.UseVisualStyleBackColor = false;
            this.btnSectores.Click += new System.EventHandler(this.btnSectores_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrdenes.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnOrdenes.FlatAppearance.BorderSize = 3;
            this.btnOrdenes.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOrdenes.Location = new System.Drawing.Point(44, 14);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(217, 95);
            this.btnOrdenes.TabIndex = 3;
            this.btnOrdenes.Text = "Ordenes de trabajo";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(322, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ordenes sin asignar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(322, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ordenes en curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(320, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ordenes pendientes";
            // 
            // lblSinAsig
            // 
            this.lblSinAsig.AutoSize = true;
            this.lblSinAsig.Font = new System.Drawing.Font("Book Antiqua", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinAsig.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSinAsig.Location = new System.Drawing.Point(314, 271);
            this.lblSinAsig.Name = "lblSinAsig";
            this.lblSinAsig.Size = new System.Drawing.Size(85, 68);
            this.lblSinAsig.TabIndex = 7;
            this.lblSinAsig.Text = "42";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Book Antiqua", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCurso.Location = new System.Drawing.Point(314, 154);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(85, 68);
            this.lblCurso.TabIndex = 8;
            this.lblCurso.Text = "20";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Book Antiqua", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPendientes.Location = new System.Drawing.Point(314, 41);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(85, 68);
            this.lblPendientes.TabIndex = 9;
            this.lblPendientes.Text = "34";
            // 
            // btnAct
            // 
            this.btnAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAct.BackgroundImage")));
            this.btnAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAct.Location = new System.Drawing.Point(511, 12);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(44, 40);
            this.btnAct.TabIndex = 10;
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 368);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblSinAsig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.btnSectores);
            this.Controls.Add(this.btnOrdenes);
            this.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnSectores;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSinAsig;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Button btnAct;
    }
}