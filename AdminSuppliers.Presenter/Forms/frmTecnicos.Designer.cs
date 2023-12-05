namespace ProyectoVenta.Formularios.Tecnicos
{
    partial class frmTecnicos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTecnicos));
            btnsalir = new FontAwesome.Sharp.IconButton();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btnborrar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            label12 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dgvTecnicos = new DataGridView();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblresultado = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            cboProveedor = new ComboBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTecnicos).BeginInit();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.Anchor = AnchorStyles.Right;
            btnsalir.BackColor = Color.Crimson;
            btnsalir.Cursor = Cursors.Hand;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.ForeColor = Color.White;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnsalir.IconColor = Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnsalir.IconSize = 24;
            btnsalir.Location = new Point(1103, 0);
            btnsalir.Margin = new Padding(4, 5, 4, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(92, 48);
            btnsalir.TabIndex = 154;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // btneliminar
            // 
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btneliminar.IconColor = Color.Black;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btneliminar.IconSize = 30;
            btneliminar.ImageAlign = ContentAlignment.BottomCenter;
            btneliminar.Location = new Point(28, 712);
            btneliminar.Margin = new Padding(4, 5, 4, 5);
            btneliminar.Name = "btneliminar";
            btneliminar.Padding = new Padding(0, 2, 0, 0);
            btneliminar.Size = new Size(288, 61);
            btneliminar.TabIndex = 153;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnlimpiar.IconSize = 30;
            btnlimpiar.ImageAlign = ContentAlignment.BottomCenter;
            btnlimpiar.Location = new Point(28, 782);
            btnlimpiar.Margin = new Padding(4, 5, 4, 5);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(288, 61);
            btnlimpiar.TabIndex = 152;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnguardar
            // 
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardar.IconColor = Color.Black;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnguardar.IconSize = 30;
            btnguardar.ImageAlign = ContentAlignment.BottomCenter;
            btnguardar.Location = new Point(28, 641);
            btnguardar.Margin = new Padding(4, 5, 4, 5);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(288, 61);
            btnguardar.TabIndex = 150;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnGuardar_Click;
            // 
            // btnborrar
            // 
            btnborrar.Cursor = Cursors.Hand;
            btnborrar.FlatStyle = FlatStyle.Popup;
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 20;
            btnborrar.Location = new Point(1132, 129);
            btnborrar.Margin = new Padding(4, 5, 4, 5);
            btnborrar.Name = "btnborrar";
            btnborrar.Padding = new Padding(0, 2, 0, 0);
            btnborrar.Size = new Size(49, 32);
            btnborrar.TabIndex = 149;
            btnborrar.TextAlign = ContentAlignment.MiddleRight;
            btnborrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(1077, 129);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 5, 0, 0);
            btnbuscar.Size = new Size(49, 32);
            btnbuscar.TabIndex = 148;
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // cbobuscar
            // 
            cbobuscar.Cursor = Cursors.Hand;
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.Font = new Font("Microsoft Sans Serif", 8.45F, FontStyle.Regular, GraphicsUnit.Point);
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Items.AddRange(new object[] { "Apellido", "Nombre", "Telefono" });
            cbobuscar.Location = new Point(688, 129);
            cbobuscar.Margin = new Padding(4, 5, 4, 5);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(192, 25);
            cbobuscar.TabIndex = 146;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(889, 129);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(179, 24);
            txtbuscar.TabIndex = 147;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(588, 134);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 18);
            label12.TabIndex = 145;
            label12.Text = "Buscar por:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(376, 91);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(170, 18);
            label7.TabIndex = 144;
            label7.Text = "LISTA DE TECNICOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(25, 91);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 18);
            label6.TabIndex = 143;
            label6.Text = "DETALLE TECNICOS";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Location = new Point(337, 72);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(13, 780);
            groupBox1.TabIndex = 142;
            groupBox1.TabStop = false;
            // 
            // dgvTecnicos
            // 
            dgvTecnicos.AllowUserToAddRows = false;
            dgvTecnicos.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTecnicos.Location = new Point(376, 174);
            dgvTecnicos.Margin = new Padding(4, 5, 4, 5);
            dgvTecnicos.MultiSelect = false;
            dgvTecnicos.Name = "dgvTecnicos";
            dgvTecnicos.ReadOnly = true;
            dgvTecnicos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvTecnicos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTecnicos.RowTemplate.Height = 24;
            dgvTecnicos.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvTecnicos.Size = new Size(819, 649);
            dgvTecnicos.TabIndex = 141;
            dgvTecnicos.CellContentClick += dgvdata_CellContentClick;
            dgvTecnicos.CellPainting += dgvdata_CellPainting;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 241);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(287, 27);
            txtNombre.TabIndex = 136;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(24, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 135;
            label3.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(28, 174);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(287, 27);
            txtApellido.TabIndex = 134;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(24, 149);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 133;
            label9.Text = "Apellido";
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(1208, 62);
            label2.TabIndex = 132;
            label2.Text = "Tecnicos";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1208, 851);
            label1.TabIndex = 131;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.BackColor = Color.White;
            lblresultado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblresultado.ForeColor = Color.Green;
            lblresultado.Location = new Point(29, 599);
            lblresultado.Margin = new Padding(4, 0, 4, 0);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(93, 17);
            lblresultado.TabIndex = 155;
            lblresultado.Text = "lblresultado";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(28, 311);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(287, 27);
            txtDireccion.TabIndex = 157;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(24, 286);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 156;
            label4.Text = "Direccion";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 455);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 27);
            txtEmail.TabIndex = 184;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(28, 429);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 183;
            label8.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(32, 382);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(287, 27);
            txtTelefono.TabIndex = 182;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(28, 358);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 181;
            label5.Text = "Telefono";
            // 
            // cboProveedor
            // 
            cboProveedor.Cursor = Cursors.Hand;
            cboProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProveedor.Font = new Font("Microsoft Sans Serif", 8.45F, FontStyle.Regular, GraphicsUnit.Point);
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(33, 531);
            cboProveedor.Margin = new Padding(4, 5, 4, 5);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(285, 25);
            cboProveedor.TabIndex = 185;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(33, 502);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 186;
            label10.Text = "Proveedor";
            // 
            // frmTecnicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1208, 851);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(cboProveedor);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(lblresultado);
            Controls.Add(btnsalir);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(btnborrar);
            Controls.Add(btnbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgvTecnicos);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "frmTecnicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Clientes :.";
            WindowState = FormWindowState.Maximized;
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTecnicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTecnicos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label10;
    }
}