namespace ProyectoVenta.Formularios.Usuarios
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            lblresultado = new Label();
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
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            btnseleccionar = new DataGridViewButtonColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            txtusuario = new TextBox();
            label3 = new Label();
            txtnombre = new TextBox();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtclave = new TextBox();
            label4 = new Label();
            txtconfirmarclave = new TextBox();
            label5 = new Label();
            label8 = new Label();
            cborol = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.BackColor = Color.White;
            lblresultado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblresultado.ForeColor = Color.Green;
            lblresultado.Location = new Point(25, 483);
            lblresultado.Margin = new Padding(4, 0, 4, 0);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(93, 17);
            lblresultado.TabIndex = 175;
            lblresultado.Text = "lblresultado";
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.Red;
            btnsalir.Cursor = Cursors.Hand;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.ForeColor = Color.White;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnsalir.IconColor = Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnsalir.IconSize = 24;
            btnsalir.Location = new Point(1109, 11);
            btnsalir.Margin = new Padding(4, 5, 4, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(92, 48);
            btnsalir.TabIndex = 174;
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
            btneliminar.Location = new Point(28, 589);
            btneliminar.Margin = new Padding(4, 5, 4, 5);
            btneliminar.Name = "btneliminar";
            btneliminar.Padding = new Padding(0, 3, 0, 0);
            btneliminar.Size = new Size(288, 62);
            btneliminar.TabIndex = 173;
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
            btnlimpiar.Location = new Point(28, 660);
            btnlimpiar.Margin = new Padding(4, 5, 4, 5);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(288, 62);
            btnlimpiar.TabIndex = 172;
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
            btnguardar.Location = new Point(28, 518);
            btnguardar.Margin = new Padding(4, 5, 4, 5);
            btnguardar.Name = "btnguardar";
            btnguardar.Padding = new Padding(0, 3, 0, 0);
            btnguardar.Size = new Size(288, 62);
            btnguardar.TabIndex = 171;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnborrar
            // 
            btnborrar.Cursor = Cursors.Hand;
            btnborrar.FlatStyle = FlatStyle.Popup;
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 20;
            btnborrar.Location = new Point(1132, 128);
            btnborrar.Margin = new Padding(4, 5, 4, 5);
            btnborrar.Name = "btnborrar";
            btnborrar.Padding = new Padding(0, 3, 0, 0);
            btnborrar.Size = new Size(49, 32);
            btnborrar.TabIndex = 170;
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
            btnbuscar.Location = new Point(1077, 128);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 5, 0, 0);
            btnbuscar.Size = new Size(49, 32);
            btnbuscar.TabIndex = 169;
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
            cbobuscar.Location = new Point(688, 128);
            cbobuscar.Margin = new Padding(4, 5, 4, 5);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(192, 25);
            cbobuscar.TabIndex = 167;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(889, 128);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(179, 24);
            txtbuscar.TabIndex = 168;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(588, 132);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 18);
            label12.TabIndex = 166;
            label12.Text = "Buscar por:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(376, 89);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(170, 18);
            label7.TabIndex = 165;
            label7.Text = "LISTA DE USUARIOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(25, 89);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(159, 18);
            label6.TabIndex = 164;
            label6.Text = "DETALLE USUARIO";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Location = new Point(337, 71);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(13, 651);
            groupBox1.TabIndex = 163;
            groupBox1.TabStop = false;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, btnseleccionar, NombreCompleto, Usuario, IdRol, Rol, Clave });
            dgvdata.Location = new Point(380, 172);
            dgvdata.Margin = new Padding(4, 5, 4, 5);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 24;
            dgvdata.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvdata.Size = new Size(801, 549);
            dgvdata.TabIndex = 162;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.MinimumWidth = 6;
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Resizable = DataGridViewTriState.False;
            btnseleccionar.Width = 35;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Resizable = DataGridViewTriState.False;
            NombreCompleto.SortMode = DataGridViewColumnSortMode.NotSortable;
            NombreCompleto.Width = 180;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Resizable = DataGridViewTriState.False;
            Usuario.SortMode = DataGridViewColumnSortMode.NotSortable;
            Usuario.Width = 200;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.MinimumWidth = 6;
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            IdRol.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 120;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            Clave.Width = 125;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(28, 240);
            txtusuario.Margin = new Padding(4, 5, 4, 5);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(287, 27);
            txtusuario.TabIndex = 161;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(24, 215);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 160;
            label3.Text = "Usuario";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(28, 172);
            txtnombre.Margin = new Padding(4, 5, 4, 5);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(287, 27);
            txtnombre.TabIndex = 159;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(24, 148);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 158;
            label9.Text = "Nombre Completo:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(4, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1203, 682);
            label1.TabIndex = 156;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(1203, 62);
            label2.TabIndex = 157;
            label2.Text = "Usuarios";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(29, 374);
            txtclave.Margin = new Padding(4, 5, 4, 5);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(287, 27);
            txtclave.TabIndex = 177;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(25, 349);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 176;
            label4.Text = "Contraseña";
            // 
            // txtconfirmarclave
            // 
            txtconfirmarclave.Location = new Point(29, 438);
            txtconfirmarclave.Margin = new Padding(4, 5, 4, 5);
            txtconfirmarclave.Name = "txtconfirmarclave";
            txtconfirmarclave.PasswordChar = '*';
            txtconfirmarclave.Size = new Size(287, 27);
            txtconfirmarclave.TabIndex = 179;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(25, 414);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 178;
            label5.Text = "Confirmar Contraseña";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(25, 282);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 180;
            label8.Text = "Rol";
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.FormattingEnabled = true;
            cborol.Location = new Point(29, 306);
            cborol.Margin = new Padding(4, 5, 4, 5);
            cborol.Name = "cborol";
            cborol.Size = new Size(285, 28);
            cborol.TabIndex = 181;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 742);
            ControlBox = false;
            Controls.Add(cborol);
            Controls.Add(label8);
            Controls.Add(txtconfirmarclave);
            Controls.Add(label5);
            Controls.Add(txtclave);
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
            Controls.Add(dgvdata);
            Controls.Add(txtusuario);
            Controls.Add(label3);
            Controls.Add(txtnombre);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1227, 789);
            MinimumSize = new Size(1227, 789);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Usuarios :.";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblresultado;
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
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtconfirmarclave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
    }
}