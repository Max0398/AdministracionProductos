namespace CapaPresentacion
{
    partial class FrmRegistroOpciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOpcionId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEstadoOpcion = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreOpcion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOpcionId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxEstadoOpcion);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreOpcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 179);
            this.panel1.TabIndex = 0;
            // 
            // txtOpcionId
            // 
            this.txtOpcionId.Location = new System.Drawing.Point(276, 3);
            this.txtOpcionId.Name = "txtOpcionId";
            this.txtOpcionId.Size = new System.Drawing.Size(45, 20);
            this.txtOpcionId.TabIndex = 5;
            this.txtOpcionId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado Opcion";
            // 
            // cbxEstadoOpcion
            // 
            this.cbxEstadoOpcion.FormattingEnabled = true;
            this.cbxEstadoOpcion.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstadoOpcion.Location = new System.Drawing.Point(69, 93);
            this.cbxEstadoOpcion.Name = "cbxEstadoOpcion";
            this.cbxEstadoOpcion.Size = new System.Drawing.Size(138, 21);
            this.cbxEstadoOpcion.TabIndex = 3;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Location = new System.Drawing.Point(99, 131);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(108, 36);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Opcion";
            // 
            // txtNombreOpcion
            // 
            this.txtNombreOpcion.Location = new System.Drawing.Point(69, 50);
            this.txtNombreOpcion.Name = "txtNombreOpcion";
            this.txtNombreOpcion.Size = new System.Drawing.Size(209, 20);
            this.txtNombreOpcion.TabIndex = 0;
            // 
            // FrmRegistroOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 179);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmRegistroOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Opcion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNombreOpcion;
        public System.Windows.Forms.ComboBox cbxEstadoOpcion;
        public System.Windows.Forms.TextBox txtOpcionId;
    }
}