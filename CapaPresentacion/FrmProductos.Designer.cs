namespace CapaPresentacion
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Opciones = new System.Windows.Forms.DataGridViewImageColumn();
            this.AgregarOpcion = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCargarProductoActivo = new System.Windows.Forms.CheckBox();
            this.cbxCargaProductoInactivo = new System.Windows.Forms.CheckBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblListadoProducto = new System.Windows.Forms.Label();
            this.dgvOpciones = new System.Windows.Forms.DataGridView();
            this.EditarActual = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListadoOpciones = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.Opciones,
            this.AgregarOpcion});
            this.dgvProductos.Location = new System.Drawing.Point(12, 204);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(758, 331);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Opciones
            // 
            this.Opciones.HeaderText = "Opciones";
            this.Opciones.Image = ((System.Drawing.Image)(resources.GetObject("Opciones.Image")));
            this.Opciones.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Opciones.Name = "Opciones";
            this.Opciones.ReadOnly = true;
            // 
            // AgregarOpcion
            // 
            this.AgregarOpcion.HeaderText = "AgregarOpcion";
            this.AgregarOpcion.Image = ((System.Drawing.Image)(resources.GetObject("AgregarOpcion.Image")));
            this.AgregarOpcion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AgregarOpcion.Name = "AgregarOpcion";
            this.AgregarOpcion.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCargarProductoActivo);
            this.groupBox1.Controls.Add(this.cbxCargaProductoInactivo);
            this.groupBox1.Controls.Add(this.Titulo);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // cbxCargarProductoActivo
            // 
            this.cbxCargarProductoActivo.AutoSize = true;
            this.cbxCargarProductoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCargarProductoActivo.Location = new System.Drawing.Point(98, 100);
            this.cbxCargarProductoActivo.Name = "cbxCargarProductoActivo";
            this.cbxCargarProductoActivo.Size = new System.Drawing.Size(248, 21);
            this.cbxCargarProductoActivo.TabIndex = 3;
            this.cbxCargarProductoActivo.Text = "Cargar Solo Productos Activos";
            this.cbxCargarProductoActivo.UseVisualStyleBackColor = true;
            this.cbxCargarProductoActivo.CheckedChanged += new System.EventHandler(this.cbxCargarProductoActivo_CheckedChanged);
            // 
            // cbxCargaProductoInactivo
            // 
            this.cbxCargaProductoInactivo.AutoSize = true;
            this.cbxCargaProductoInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCargaProductoInactivo.Location = new System.Drawing.Point(98, 73);
            this.cbxCargaProductoInactivo.Name = "cbxCargaProductoInactivo";
            this.cbxCargaProductoInactivo.Size = new System.Drawing.Size(260, 21);
            this.cbxCargaProductoInactivo.TabIndex = 2;
            this.cbxCargaProductoInactivo.Text = "Cargar Solo Productos Inactivos";
            this.cbxCargaProductoInactivo.UseVisualStyleBackColor = true;
            this.cbxCargaProductoInactivo.CheckedChanged += new System.EventHandler(this.cbxCargaProductoInactivo_CheckedChanged);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(6, 41);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(74, 24);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Buscar";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.AccessibleDescription = "";
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(98, 41);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(470, 26);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.WordWrap = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            this.txtBusqueda.Leave += new System.EventHandler(this.txtBusqueda_Leave);
            // 
            // lblListadoProducto
            // 
            this.lblListadoProducto.AutoSize = true;
            this.lblListadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoProducto.Location = new System.Drawing.Point(17, 172);
            this.lblListadoProducto.Name = "lblListadoProducto";
            this.lblListadoProducto.Size = new System.Drawing.Size(203, 26);
            this.lblListadoProducto.TabIndex = 2;
            this.lblListadoProducto.Text = "Listado Productos";
            // 
            // dgvOpciones
            // 
            this.dgvOpciones.AllowUserToAddRows = false;
            this.dgvOpciones.AllowUserToDeleteRows = false;
            this.dgvOpciones.AllowUserToOrderColumns = true;
            this.dgvOpciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarActual});
            this.dgvOpciones.Location = new System.Drawing.Point(787, 204);
            this.dgvOpciones.Name = "dgvOpciones";
            this.dgvOpciones.ReadOnly = true;
            this.dgvOpciones.RowHeadersVisible = false;
            this.dgvOpciones.Size = new System.Drawing.Size(360, 331);
            this.dgvOpciones.TabIndex = 4;
            this.dgvOpciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpciones_CellContentClick);
            // 
            // EditarActual
            // 
            this.EditarActual.HeaderText = "Editar";
            this.EditarActual.Image = ((System.Drawing.Image)(resources.GetObject("EditarActual.Image")));
            this.EditarActual.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarActual.Name = "EditarActual";
            this.EditarActual.ReadOnly = true;
            this.EditarActual.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditarActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditarActual.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(782, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opciones Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListadoOpciones);
            this.groupBox2.Controls.Add(this.btnAgregarProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(787, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 134);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenimiento Producto, Opciones";
            // 
            // btnListadoOpciones
            // 
            this.btnListadoOpciones.Image = global::CapaPresentacion.Properties.Resources.opcion_de_lista;
            this.btnListadoOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoOpciones.Location = new System.Drawing.Point(84, 77);
            this.btnListadoOpciones.Name = "btnListadoOpciones";
            this.btnListadoOpciones.Size = new System.Drawing.Size(198, 42);
            this.btnListadoOpciones.TabIndex = 4;
            this.btnListadoOpciones.Text = "Opciones";
            this.btnListadoOpciones.UseVisualStyleBackColor = true;
            this.btnListadoOpciones.Click += new System.EventHandler(this.btnListadoOpciones_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(84, 29);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(198, 42);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Opciones";
            this.dataGridViewImageColumn3.Image = global::CapaPresentacion.Properties.Resources.opcion_de_lista;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOpciones);
            this.Controls.Add(this.lblListadoProducto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblListadoProducto;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.CheckBox cbxCargaProductoInactivo;
        private System.Windows.Forms.DataGridView dgvOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListadoOpciones;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn EditarActual;
        private System.Windows.Forms.CheckBox cbxCargarProductoActivo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Opciones;
        private System.Windows.Forms.DataGridViewImageColumn AgregarOpcion;
    }
}

