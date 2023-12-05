namespace AdminSupplier.Presenter
{
    partial class FormReports
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            button1 = new Button();
            panel5 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 86);
            panel1.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1032, 19);
            button4.Name = "button4";
            button4.Size = new Size(87, 39);
            button4.TabIndex = 25;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1147, 20);
            button5.Name = "button5";
            button5.Size = new Size(87, 39);
            button5.TabIndex = 24;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 20);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 23;
            label4.Text = "Reportes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 15);
            label5.Name = "label5";
            label5.Size = new Size(313, 38);
            label5.TabIndex = 4;
            label5.Text = "Reporte de Incidencias";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1266, 592);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1266, 539);
            panel3.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label3);
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 233);
            panel6.Name = "panel6";
            panel6.Size = new Size(1266, 321);
            panel6.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 23);
            label3.Name = "label3";
            label3.Size = new Size(301, 38);
            label3.TabIndex = 23;
            label3.Text = "Reporte de Productos";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(53, 106);
            button1.Name = "button1";
            button1.Size = new Size(290, 119);
            button1.TabIndex = 13;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(button2);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1266, 233);
            panel5.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(53, 90);
            button2.Name = "button2";
            button2.Size = new Size(290, 105);
            button2.TabIndex = 22;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 678);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReports";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}