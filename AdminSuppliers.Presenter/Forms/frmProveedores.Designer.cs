namespace ProyectoVenta.Formularios.Proveedores
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            btnsalir = new FontAwesome.Sharp.IconButton();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguadar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dgvProvedores = new DataGridView();
            txtrazonsocial = new MaskedTextBox();
            label3 = new Label();
            txtcuit = new MaskedTextBox();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmpresa = new MaskedTextBox();
            label4 = new Label();
            txtTelefono = new MaskedTextBox();
            label5 = new Label();
            txtEmail = new MaskedTextBox();
            label8 = new Label();
            btnborrar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProvedores).BeginInit();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.Crimson;
            btnsalir.Cursor = Cursors.Hand;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.ForeColor = Color.White;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnsalir.IconColor = Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnsalir.IconSize = 24;
            btnsalir.Location = new Point(1111, 12);
            btnsalir.Margin = new Padding(4, 5, 4, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(92, 48);
            btnsalir.TabIndex = 173;
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
            btneliminar.Location = new Point(26, 611);
            btneliminar.Margin = new Padding(4, 5, 4, 5);
            btneliminar.Name = "btneliminar";
            btneliminar.Padding = new Padding(0, 2, 0, 0);
            btneliminar.Size = new Size(288, 61);
            btneliminar.TabIndex = 172;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = true;
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
            btnlimpiar.Location = new Point(28, 682);
            btnlimpiar.Margin = new Padding(4, 5, 4, 5);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(288, 61);
            btnlimpiar.TabIndex = 171;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnguadar
            // 
            btnguadar.Cursor = Cursors.Hand;
            btnguadar.FlatStyle = FlatStyle.Flat;
            btnguadar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnguadar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguadar.IconColor = Color.Black;
            btnguadar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnguadar.IconSize = 30;
            btnguadar.ImageAlign = ContentAlignment.BottomCenter;
            btnguadar.Location = new Point(28, 541);
            btnguadar.Margin = new Padding(4, 5, 4, 5);
            btnguadar.Name = "btnguadar";
            btnguadar.Size = new Size(288, 61);
            btnguadar.TabIndex = 170;
            btnguadar.Text = "Guardar";
            btnguadar.TextAlign = ContentAlignment.MiddleRight;
            btnguadar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguadar.UseVisualStyleBackColor = true;
            btnguadar.Click += btnguadar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(377, 91);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(190, 18);
            label7.TabIndex = 164;
            label7.Text = "LISTA DE PROVEEDOR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(27, 91);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(190, 18);
            label6.TabIndex = 163;
            label6.Text = "DETALLE PROVEEDOR";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Location = new Point(339, 72);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(13, 761);
            groupBox1.TabIndex = 162;
            groupBox1.TabStop = false;
            // 
            // dgvProvedores
            // 
            dgvProvedores.AllowUserToAddRows = false;
            dgvProvedores.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProvedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProvedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProvedores.Location = new Point(360, 149);
            dgvProvedores.Margin = new Padding(4, 5, 4, 5);
            dgvProvedores.MultiSelect = false;
            dgvProvedores.Name = "dgvProvedores";
            dgvProvedores.ReadOnly = true;
            dgvProvedores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvProvedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProvedores.RowTemplate.Height = 24;
            dgvProvedores.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvProvedores.Size = new Size(843, 685);
            dgvProvedores.TabIndex = 161;
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Location = new Point(29, 241);
            txtrazonsocial.Margin = new Padding(4, 5, 4, 5);
            txtrazonsocial.Mask = "LLLLLLLLLLLLLLLLLLL";
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.Size = new Size(287, 27);
            txtrazonsocial.TabIndex = 160;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(25, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 159;
            label3.Text = "Razon Social";
            // 
            // txtcuit
            // 
            txtcuit.Location = new Point(29, 174);
            txtcuit.Margin = new Padding(4, 5, 4, 5);
            txtcuit.Mask = "99999";
            txtcuit.Name = "txtcuit";
            txtcuit.Size = new Size(287, 27);
            txtcuit.TabIndex = 158;
            txtcuit.ValidatingType = typeof(int);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(25, 149);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 157;
            label9.Text = "CUIT";
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(1203, 62);
            label2.TabIndex = 156;
            label2.Text = "Proveedores";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1203, 782);
            label1.TabIndex = 155;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(31, 306);
            txtEmpresa.Margin = new Padding(4, 5, 4, 5);
            txtEmpresa.Mask = "LLLLLLLLLLLLLLLLLLLL";
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(287, 27);
            txtEmpresa.TabIndex = 176;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(27, 281);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 175;
            label4.Text = "Empresa";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(31, 371);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Mask = "0000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(287, 27);
            txtTelefono.TabIndex = 178;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(27, 346);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 177;
            label5.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 439);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 27);
            txtEmail.TabIndex = 180;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(27, 414);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 179;
            label8.Text = "Email";
            // 
            // btnborrar
            // 
            btnborrar.Cursor = Cursors.Hand;
            btnborrar.FlatStyle = FlatStyle.Popup;
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 20;
            btnborrar.Location = new Point(1118, 111);
            btnborrar.Margin = new Padding(4, 5, 4, 5);
            btnborrar.Name = "btnborrar";
            btnborrar.Padding = new Padding(0, 2, 0, 0);
            btnborrar.Size = new Size(49, 32);
            btnborrar.TabIndex = 185;
            btnborrar.TextAlign = ContentAlignment.MiddleRight;
            btnborrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click_1;
            // 
            // btnbuscar
            // 
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(1063, 111);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 5, 0, 0);
            btnbuscar.Size = new Size(49, 32);
            btnbuscar.TabIndex = 184;
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // cbobuscar
            // 
            cbobuscar.Cursor = Cursors.Hand;
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.Font = new Font("Microsoft Sans Serif", 8.45F, FontStyle.Regular, GraphicsUnit.Point);
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Items.AddRange(new object[] { "Apellido", "Empresa", "Cuit", "Telefono", "Calificación" });
            cbobuscar.Location = new Point(674, 111);
            cbobuscar.Margin = new Padding(4, 5, 4, 5);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(192, 25);
            cbobuscar.TabIndex = 182;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(875, 111);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(179, 24);
            txtbuscar.TabIndex = 183;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(574, 116);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 18);
            label12.TabIndex = 181;
            label12.Text = "Buscar por:";
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 851);
            ControlBox = false;
            Controls.Add(btnborrar);
            Controls.Add(btnbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(label12);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtEmpresa);
            Controls.Add(label4);
            Controls.Add(btnsalir);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguadar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgvProvedores);
            Controls.Add(txtrazonsocial);
            Controls.Add(label3);
            Controls.Add(txtcuit);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1327, 898);
            MinimumSize = new Size(1227, 585);
            Name = "frmProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Proveedores :.";
            Load += frmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProvedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguadar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProvedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtcuit;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtEmpresa;
        private System.Windows.Forms.MaskedTextBox txtrazonsocial;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private TextBox txtbuscar;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private ComboBox cbobuscar;
        private Label label12;
    }
}