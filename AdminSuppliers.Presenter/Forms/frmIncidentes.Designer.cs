namespace ProyectoVenta.Formularios.Incidentes
{
    partial class frmIncidentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncidentes));
            cmbTecnico = new ComboBox();
            txtDescripcion = new TextBox();
            label4 = new Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label6 = new Label();
            dgvdata = new DataGridView();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            txtEstado = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            fechaSolucionPicker = new DateTimePicker();
            btnborrar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            label10 = new Label();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbTecnico
            // 
            cmbTecnico.Cursor = Cursors.Hand;
            cmbTecnico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTecnico.Font = new Font("Microsoft Sans Serif", 8.45F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTecnico.FormattingEnabled = true;
            cmbTecnico.Location = new Point(24, 190);
            cmbTecnico.Margin = new Padding(5);
            cmbTecnico.Name = "cmbTecnico";
            cmbTecnico.Size = new Size(285, 25);
            cmbTecnico.TabIndex = 240;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(27, 337);
            txtDescripcion.Margin = new Padding(5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(287, 27);
            txtDescripcion.TabIndex = 236;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(26, 312);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 235;
            label4.Text = "Descripcion";
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
            btnsalir.Location = new Point(1294, 14);
            btnsalir.Margin = new Padding(5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(91, 48);
            btnsalir.TabIndex = 233;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click_1;
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
            btneliminar.Location = new Point(27, 645);
            btneliminar.Margin = new Padding(5);
            btneliminar.Name = "btneliminar";
            btneliminar.Padding = new Padding(0, 3, 0, 0);
            btneliminar.Size = new Size(288, 61);
            btneliminar.TabIndex = 232;
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
            btnlimpiar.Location = new Point(27, 717);
            btnlimpiar.Margin = new Padding(5);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(288, 61);
            btnlimpiar.TabIndex = 231;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click_1;
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
            btnguardar.Location = new Point(27, 575);
            btnguardar.Margin = new Padding(5);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(288, 61);
            btnguardar.TabIndex = 230;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.SandyBrown;
            label7.Location = new Point(360, 116);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(184, 18);
            label7.TabIndex = 224;
            label7.Text = "LISTA DE INCIDENTES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(24, 138);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(184, 18);
            label6.TabIndex = 223;
            label6.Text = "DETALLE INCIDENTES";
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
            dgvdata.Location = new Point(376, 210);
            dgvdata.Margin = new Padding(5);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 24;
            dgvdata.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvdata.Size = new Size(1095, 611);
            dgvdata.TabIndex = 221;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(21, 166);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 218;
            label9.Text = "Tecnico";
            // 
            // label2
            // 
            label2.BackColor = Color.CadetBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(21, 0, 0, 0);
            label2.Size = new Size(1508, 95);
            label2.TabIndex = 217;
            label2.Text = "Incidentes";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1508, 848);
            label1.TabIndex = 216;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Dock = DockStyle.Fill;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(1508, 848);
            label8.TabIndex = 216;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(25, 380);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 241;
            label5.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(25, 405);
            txtEstado.Margin = new Padding(5);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(287, 27);
            txtEstado.TabIndex = 242;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(337, 138);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(13, 642);
            groupBox1.TabIndex = 222;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // fechaSolucionPicker
            // 
            fechaSolucionPicker.Location = new Point(27, 259);
            fechaSolucionPicker.Margin = new Padding(3, 4, 3, 4);
            fechaSolucionPicker.Name = "fechaSolucionPicker";
            fechaSolucionPicker.Size = new Size(285, 27);
            fechaSolucionPicker.TabIndex = 243;
            fechaSolucionPicker.ValueChanged += fechaSolucionPicker_ValueChanged;
            // 
            // btnborrar
            // 
            btnborrar.Cursor = Cursors.Hand;
            btnborrar.FlatStyle = FlatStyle.Popup;
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 20;
            btnborrar.Location = new Point(1436, 157);
            btnborrar.Margin = new Padding(4, 5, 4, 5);
            btnborrar.Name = "btnborrar";
            btnborrar.Padding = new Padding(0, 2, 0, 0);
            btnborrar.Size = new Size(49, 32);
            btnborrar.TabIndex = 248;
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
            btnbuscar.Location = new Point(1370, 157);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 5, 0, 0);
            btnbuscar.Size = new Size(49, 32);
            btnbuscar.TabIndex = 247;
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
            cbobuscar.Items.AddRange(new object[] { "Fecha de Solicitud", "Fecha de Solucion", "Apellido", "Nombre", "Telefono" });
            cbobuscar.Location = new Point(482, 166);
            cbobuscar.Margin = new Padding(4, 5, 4, 5);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(192, 25);
            cbobuscar.TabIndex = 245;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(1129, 165);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(233, 24);
            txtbuscar.TabIndex = 246;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(389, 164);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 18);
            label10.TabIndex = 244;
            label10.Text = "Buscar por:";
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(706, 165);
            dtpInicio.Margin = new Padding(3, 4, 3, 4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(188, 27);
            dtpInicio.TabIndex = 249;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(917, 165);
            dtpFin.Margin = new Padding(3, 4, 3, 4);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(188, 27);
            dtpFin.TabIndex = 250;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(28, 235);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(130, 20);
            label11.TabIndex = 251;
            label11.Text = "Fecha de Solicitud";
            // 
            // frmIncidentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1508, 848);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
            Controls.Add(btnborrar);
            Controls.Add(btnbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(label10);
            Controls.Add(fechaSolucionPicker);
            Controls.Add(txtEstado);
            Controls.Add(label5);
            Controls.Add(cmbTecnico);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(btnsalir);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "frmIncidentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Incidentes :.";
            WindowState = FormWindowState.Maximized;
            Load += frmRegistrarIncidente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbTecnico;
        private TextBox txtDescripcion;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label7;
        private Label label6;
        private DataGridView dgvdata;
        private Label label9;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label5;
        private TextBox txtEstado;
        private GroupBox groupBox1;
        private DateTimePicker fechaSolucionPicker;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private ComboBox cbobuscar;
        private TextBox txtbuscar;
        private Label label10;
        private DataGridView dataGridView1;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Label label11;
    }
}