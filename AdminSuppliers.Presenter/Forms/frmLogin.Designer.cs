namespace ProyectoVenta.Formularios
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label3 = new Label();
            label2 = new Label();
            btnSalir = new Button();
            btningresar = new Button();
            txtclave = new TextBox();
            txtusuario = new TextBox();
            label1 = new Label();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 511);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 47;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 425);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 48;
            label2.Text = "Usuario";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(240, 606);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 49);
            btnSalir.TabIndex = 53;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.Black;
            btningresar.Cursor = Cursors.Hand;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btningresar.ForeColor = Color.White;
            btningresar.Location = new Point(56, 606);
            btningresar.Margin = new Padding(4, 5, 4, 5);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(143, 49);
            btningresar.TabIndex = 52;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // txtclave
            // 
            txtclave.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtclave.Location = new Point(56, 541);
            txtclave.Margin = new Padding(4, 5, 4, 5);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(325, 26);
            txtclave.TabIndex = 51;
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.Location = new Point(56, 455);
            txtusuario.Margin = new Padding(4, 5, 4, 5);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(325, 26);
            txtusuario.TabIndex = 50;
            txtusuario.Text = "Admin";
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(436, 345);
            label1.TabIndex = 49;
            // 
            // btnProveedores
            // 
            btnProveedores.Anchor = AnchorStyles.None;
            btnProveedores.BackColor = SystemColors.Control;
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.FlatAppearance.BorderColor = Color.Teal;
            btnProveedores.FlatAppearance.BorderSize = 2;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.Black;
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            btnProveedores.IconColor = Color.Black;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.IconSize = 100;
            btnProveedores.ImageAlign = ContentAlignment.BottomCenter;
            btnProveedores.Location = new Point(115, 85);
            btnProveedores.Margin = new Padding(4, 5, 4, 5);
            btnProveedores.MaximumSize = new Size(191, 147);
            btnProveedores.MinimumSize = new Size(191, 147);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(191, 147);
            btnProveedores.TabIndex = 54;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 775);
            ControlBox = false;
            Controls.Add(btnProveedores);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btningresar);
            Controls.Add(txtclave);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(454, 822);
            MinimumSize = new Size(454, 822);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Login :.";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnProveedores;
    }
}