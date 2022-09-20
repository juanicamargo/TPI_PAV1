namespace Proyecto_TPI
{
    partial class frmAltaCliente
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
            this.barriolbl = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNroCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroCasa = new System.Windows.Forms.MaskedTextBox();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.gdrClientes = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrClientes)).BeginInit();
            this.gboDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // barriolbl
            // 
            this.barriolbl.AutoSize = true;
            this.barriolbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barriolbl.Location = new System.Drawing.Point(59, 196);
            this.barriolbl.Name = "barriolbl";
            this.barriolbl.Size = new System.Drawing.Size(56, 20);
            this.barriolbl.TabIndex = 42;
            this.barriolbl.Text = "Barrio:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(40, 238);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 49);
            this.btnLimpiar.TabIndex = 40;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarCliente.Location = new System.Drawing.Point(231, 238);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(75, 49);
            this.btnGuardarCliente.TabIndex = 39;
            this.btnGuardarCliente.Text = "Guardar Cliente";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nro. de casa:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(114, 107);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(191, 23);
            this.txtCalle.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Calle:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 23);
            this.txtNombre.TabIndex = 30;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(44, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(113, 42);
            this.txtNroCliente.Mask = "99999999";
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(193, 23);
            this.txtNroCliente.TabIndex = 45;
            this.txtNroCliente.ValidatingType = typeof(int);
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroDoc.Location = new System.Drawing.Point(25, 42);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(90, 20);
            this.lblNroDoc.TabIndex = 44;
            this.lblNroDoc.Text = "Nro cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Localidad:";
            // 
            // txtNroCasa
            // 
            this.txtNroCasa.Location = new System.Drawing.Point(113, 138);
            this.txtNroCasa.Mask = "99999999";
            this.txtNroCasa.Name = "txtNroCasa";
            this.txtNroCasa.Size = new System.Drawing.Size(193, 23);
            this.txtNroCasa.TabIndex = 48;
            this.txtNroCasa.ValidatingType = typeof(int);
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(113, 167);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(193, 23);
            this.cboLocalidad.TabIndex = 49;
            this.cboLocalidad.SelectedIndexChanged += new System.EventHandler(this.cboLocalidad_SelectedIndexChanged);
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(113, 196);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(192, 23);
            this.cboBarrio.TabIndex = 50;
            // 
            // gdrClientes
            // 
            this.gdrClientes.AllowUserToAddRows = false;
            this.gdrClientes.AllowUserToDeleteRows = false;
            this.gdrClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.calle,
            this.nro_calle,
            this.Localidad,
            this.Barrio});
            this.gdrClientes.Location = new System.Drawing.Point(368, 21);
            this.gdrClientes.Name = "gdrClientes";
            this.gdrClientes.ReadOnly = true;
            this.gdrClientes.RowTemplate.Height = 25;
            this.gdrClientes.Size = new System.Drawing.Size(625, 300);
            this.gdrClientes.TabIndex = 51;
            this.gdrClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrClientes_CellClick);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "nro_cliente";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_cliente";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // nro_calle
            // 
            this.nro_calle.DataPropertyName = "nro_calle";
            this.nro_calle.HeaderText = "Nro. casa";
            this.nro_calle.Name = "nro_calle";
            this.nro_calle.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "id_localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Barrio
            // 
            this.Barrio.DataPropertyName = "id_barrio";
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // gboDatosCliente
            // 
            this.gboDatosCliente.Controls.Add(this.btnActualizar);
            this.gboDatosCliente.Controls.Add(this.txtNombre);
            this.gboDatosCliente.Controls.Add(this.lblNombre);
            this.gboDatosCliente.Controls.Add(this.cboBarrio);
            this.gboDatosCliente.Controls.Add(this.label3);
            this.gboDatosCliente.Controls.Add(this.cboLocalidad);
            this.gboDatosCliente.Controls.Add(this.txtCalle);
            this.gboDatosCliente.Controls.Add(this.txtNroCasa);
            this.gboDatosCliente.Controls.Add(this.label2);
            this.gboDatosCliente.Controls.Add(this.label1);
            this.gboDatosCliente.Controls.Add(this.btnGuardarCliente);
            this.gboDatosCliente.Controls.Add(this.txtNroCliente);
            this.gboDatosCliente.Controls.Add(this.btnLimpiar);
            this.gboDatosCliente.Controls.Add(this.lblNroDoc);
            this.gboDatosCliente.Controls.Add(this.barriolbl);
            this.gboDatosCliente.Location = new System.Drawing.Point(12, 12);
            this.gboDatosCliente.Name = "gboDatosCliente";
            this.gboDatosCliente.Size = new System.Drawing.Size(334, 309);
            this.gboDatosCliente.TabIndex = 52;
            this.gboDatosCliente.TabStop = false;
            this.gboDatosCliente.Text = "Datos del Cliente";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Location = new System.Drawing.Point(132, 238);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 49);
            this.btnActualizar.TabIndex = 51;
            this.btnActualizar.Text = "Actualizar Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 422);
            this.Controls.Add(this.gboDatosCliente);
            this.Controls.Add(this.gdrClientes);
            this.Name = "frmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo cliente";
            this.Load += new System.EventHandler(this.frmAltaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrClientes)).EndInit();
            this.gboDatosCliente.ResumeLayout(false);
            this.gboDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label barriolbl;
        private Button btnLimpiar;
        private Button btnGuardarCliente;
        private Label label2;
        private TextBox txtCalle;
        private Label label3;
        private TextBox txtNombre;
        private Label lblNombre;
        private MaskedTextBox txtNroCliente;
        private Label lblNroDoc;
        private Label label1;
        private MaskedTextBox txtNroCasa;
        private ComboBox cboLocalidad;
        private ComboBox cboBarrio;
        private DataGridView gdrClientes;
        private GroupBox gboDatosCliente;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn calle;
        private DataGridViewTextBoxColumn nro_calle;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn Barrio;
        private Button btnActualizar;
    }
}