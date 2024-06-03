namespace Practica
{
    partial class Portada
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
            button1 = new Button();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtAPP = new TextBox();
            txtAPM = new TextBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtNumeroInspirante = new TextBox();
            ComboCarrera = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            port = new Panel();
            port.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(26, 25);
            button1.Name = "button1";
            button1.Size = new Size(45, 23);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(226, 31);
            label7.Name = "label7";
            label7.Size = new Size(294, 17);
            label7.TabIndex = 8;
            label7.Text = "Rellena las siguientes casillas para poder registrarte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 148);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido Materno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 148);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 148);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido Paterno:";
            // 
            // txtAPP
            // 
            txtAPP.Location = new Point(275, 183);
            txtAPP.Multiline = true;
            txtAPP.Name = "txtAPP";
            txtAPP.Size = new Size(159, 23);
            txtAPP.TabIndex = 1;
            // 
            // txtAPM
            // 
            txtAPM.Location = new Point(486, 183);
            txtAPM.Multiline = true;
            txtAPM.Name = "txtAPM";
            txtAPM.Size = new Size(159, 23);
            txtAPM.TabIndex = 5;
            txtAPM.TextChanged += txtAPM_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(73, 183);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(73, 374);
            txtEdad.Multiline = true;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(159, 21);
            txtEdad.TabIndex = 7;
            // 
            // txtNumeroInspirante
            // 
            txtNumeroInspirante.Location = new Point(275, 372);
            txtNumeroInspirante.Multiline = true;
            txtNumeroInspirante.Name = "txtNumeroInspirante";
            txtNumeroInspirante.Size = new Size(159, 23);
            txtNumeroInspirante.TabIndex = 8;
            // 
            // ComboCarrera
            // 
            ComboCarrera.FormattingEnabled = true;
            ComboCarrera.Items.AddRange(new object[] { "Ingenieria en Sistemas Computacionales", "Ingenirria en Gestion Empresarial", "Ingenieria Industrial", "Ingenieria Civil", "Licenciatura en Administración", "Arquitectura" });
            ComboCarrera.Location = new Point(486, 372);
            ComboCarrera.Name = "ComboCarrera";
            ComboCarrera.Size = new Size(159, 23);
            ComboCarrera.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 343);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Edad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 343);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 10;
            label5.Text = "Numero de Inspirante:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 343);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 11;
            label6.Text = "Carrera";
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(588, 452);
            button2.Name = "button2";
            button2.Size = new Size(120, 27);
            button2.TabIndex = 12;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // port
            // 
            port.Controls.Add(button1);
            port.Controls.Add(label7);
            port.Controls.Add(txtEdad);
            port.Controls.Add(label2);
            port.Controls.Add(txtAPM);
            port.Controls.Add(label3);
            port.Controls.Add(button2);
            port.Controls.Add(txtAPP);
            port.Controls.Add(label1);
            port.Controls.Add(label4);
            port.Controls.Add(txtNumeroInspirante);
            port.Controls.Add(txtNombre);
            port.Controls.Add(label6);
            port.Controls.Add(label5);
            port.Controls.Add(ComboCarrera);
            port.Dock = DockStyle.Fill;
            port.Location = new Point(0, 0);
            port.Name = "port";
            port.Size = new Size(734, 561);
            port.TabIndex = 13;
            // 
            // Portada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(734, 561);
            Controls.Add(port);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Portada";
            Text = "Portada";
            port.ResumeLayout(false);
            port.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox txtAPP;
        private TextBox txtAPM;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtNumeroInspirante;
        private ComboBox ComboCarrera;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label label7;
        private Panel port;
    }
}