namespace UTTT.Ejemplo.Eventos
{
    partial class frmPaqueteriaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaqueteriaPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscarClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbSeparador = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.lblNombrePrincipal = new System.Windows.Forms.TextBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblDetalleDatosCliente = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpSeparador = new System.Windows.Forms.GroupBox();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.picModuloGasto = new System.Windows.Forms.PictureBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.dgbVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaFinMuestra = new System.Windows.Forms.Label();
            this.lblFechaInicioMuestra = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblEstadoMuestra = new System.Windows.Forms.Label();
            this.lblClaveMuestra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModuloGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(12, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paqueteria UTTT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(413, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(834, 89);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(915, 89);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarClave
            // 
            this.txtBuscarClave.Location = new System.Drawing.Point(179, 92);
            this.txtBuscarClave.Name = "txtBuscarClave";
            this.txtBuscarClave.Size = new System.Drawing.Size(228, 20);
            this.txtBuscarClave.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clave:";
            // 
            // grbSeparador
            // 
            this.grbSeparador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSeparador.Location = new System.Drawing.Point(12, 71);
            this.grbSeparador.Name = "grbSeparador";
            this.grbSeparador.Size = new System.Drawing.Size(978, 10);
            this.grbSeparador.TabIndex = 312;
            this.grbSeparador.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(494, 92);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 313;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(9, 133);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 14);
            this.lblResultado.TabIndex = 314;
            this.lblResultado.Text = "[Resultados]";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalle.Controls.Add(this.lblClaveMuestra);
            this.pnlDetalle.Controls.Add(this.lblEstadoMuestra);
            this.pnlDetalle.Controls.Add(this.lblProducto);
            this.pnlDetalle.Controls.Add(this.lblFechaInicioMuestra);
            this.pnlDetalle.Controls.Add(this.lblFechaFinMuestra);
            this.pnlDetalle.Controls.Add(this.label3);
            this.pnlDetalle.Controls.Add(this.lblNombrePrincipal);
            this.pnlDetalle.Controls.Add(this.lblFechaFin);
            this.pnlDetalle.Controls.Add(this.lblFechaIngreso);
            this.pnlDetalle.Controls.Add(this.lblClave);
            this.pnlDetalle.Controls.Add(this.lblDetalleDatosCliente);
            this.pnlDetalle.Controls.Add(this.lblEstado);
            this.pnlDetalle.Controls.Add(this.grpSeparador);
            this.pnlDetalle.Controls.Add(this.lblTituloDetalle);
            this.pnlDetalle.Controls.Add(this.picModuloGasto);
            this.pnlDetalle.Location = new System.Drawing.Point(501, 150);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(489, 348);
            this.pnlDetalle.TabIndex = 316;
            // 
            // lblNombrePrincipal
            // 
            this.lblNombrePrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombrePrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombrePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblNombrePrincipal.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombrePrincipal.Location = new System.Drawing.Point(56, 23);
            this.lblNombrePrincipal.Multiline = true;
            this.lblNombrePrincipal.Name = "lblNombrePrincipal";
            this.lblNombrePrincipal.Size = new System.Drawing.Size(411, 28);
            this.lblNombrePrincipal.TabIndex = 263;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(16, 134);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 260;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(16, 112);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(68, 13);
            this.lblFechaIngreso.TabIndex = 258;
            this.lblFechaIngreso.Text = "Fecha Inicio:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(16, 90);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 246;
            this.lblClave.Text = "Clave:";
            // 
            // lblDetalleDatosCliente
            // 
            this.lblDetalleDatosCliente.AutoSize = true;
            this.lblDetalleDatosCliente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleDatosCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDetalleDatosCliente.Location = new System.Drawing.Point(10, 65);
            this.lblDetalleDatosCliente.Name = "lblDetalleDatosCliente";
            this.lblDetalleDatosCliente.Size = new System.Drawing.Size(111, 14);
            this.lblDetalleDatosCliente.TabIndex = 243;
            this.lblDetalleDatosCliente.Text = "[Datos Paquete]";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 180);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 235;
            this.lblEstado.Text = "Estado:";
            // 
            // grpSeparador
            // 
            this.grpSeparador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSeparador.Location = new System.Drawing.Point(11, 49);
            this.grpSeparador.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grpSeparador.Name = "grpSeparador";
            this.grpSeparador.Size = new System.Drawing.Size(468, 10);
            this.grpSeparador.TabIndex = 233;
            this.grpSeparador.TabStop = false;
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalle.ForeColor = System.Drawing.Color.Black;
            this.lblTituloDetalle.Location = new System.Drawing.Point(53, 6);
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(147, 13);
            this.lblTituloDetalle.TabIndex = 232;
            this.lblTituloDetalle.Text = "Información del Paquete";
            // 
            // picModuloGasto
            // 
            this.picModuloGasto.Image = ((System.Drawing.Image)(resources.GetObject("picModuloGasto.Image")));
            this.picModuloGasto.Location = new System.Drawing.Point(11, 6);
            this.picModuloGasto.Name = "picModuloGasto";
            this.picModuloGasto.Size = new System.Drawing.Size(36, 35);
            this.picModuloGasto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picModuloGasto.TabIndex = 231;
            this.picModuloGasto.TabStop = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToResizeColumns = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbVer});
            this.dgvResultado.Location = new System.Drawing.Point(12, 150);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(483, 348);
            this.dgvResultado.TabIndex = 317;
            // 
            // dgbVer
            // 
            this.dgbVer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "->";
            this.dgbVer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgbVer.HeaderText = "Ver";
            this.dgbVer.Name = "dgbVer";
            this.dgbVer.ReadOnly = true;
            this.dgbVer.Width = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 264;
            this.label3.Text = "Producto:";
            // 
            // lblFechaFinMuestra
            // 
            this.lblFechaFinMuestra.AutoSize = true;
            this.lblFechaFinMuestra.Location = new System.Drawing.Point(123, 134);
            this.lblFechaFinMuestra.Name = "lblFechaFinMuestra";
            this.lblFechaFinMuestra.Size = new System.Drawing.Size(0, 13);
            this.lblFechaFinMuestra.TabIndex = 265;
            // 
            // lblFechaInicioMuestra
            // 
            this.lblFechaInicioMuestra.AutoSize = true;
            this.lblFechaInicioMuestra.Location = new System.Drawing.Point(123, 112);
            this.lblFechaInicioMuestra.Name = "lblFechaInicioMuestra";
            this.lblFechaInicioMuestra.Size = new System.Drawing.Size(0, 13);
            this.lblFechaInicioMuestra.TabIndex = 266;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(123, 157);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(0, 13);
            this.lblProducto.TabIndex = 267;
            // 
            // lblEstadoMuestra
            // 
            this.lblEstadoMuestra.AutoSize = true;
            this.lblEstadoMuestra.Location = new System.Drawing.Point(123, 180);
            this.lblEstadoMuestra.Name = "lblEstadoMuestra";
            this.lblEstadoMuestra.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoMuestra.TabIndex = 268;
            // 
            // lblClaveMuestra
            // 
            this.lblClaveMuestra.AutoSize = true;
            this.lblClaveMuestra.Location = new System.Drawing.Point(123, 90);
            this.lblClaveMuestra.Name = "lblClaveMuestra";
            this.lblClaveMuestra.Size = new System.Drawing.Size(0, 13);
            this.lblClaveMuestra.TabIndex = 269;
            // 
            // frmPaqueteriaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 510);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbSeparador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarClave);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaqueteriaPrincipal";
            this.ShowIcon = false;
            this.Text = "Paqueteria UTTT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModuloGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscarClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbSeparador;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Label lblClaveMuestra;
        private System.Windows.Forms.Label lblEstadoMuestra;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFechaInicioMuestra;
        private System.Windows.Forms.Label lblFechaFinMuestra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblNombrePrincipal;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblDetalleDatosCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpSeparador;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.PictureBox picModuloGasto;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewButtonColumn dgbVer;
    }
}

