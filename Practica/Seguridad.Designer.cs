namespace Practica
{
    partial class Seguridad
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
            label1 = new Label();
            User = new TextBox();
            pass = new TextBox();
            ingre = new Button();
            cerrar = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Port = new Panel();
            Port.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 16);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 1;
            label1.Text = "INGRESO";
            label1.Click += label1_Click;
            // 
            // User
            // 
            User.BackColor = Color.White;
            User.BorderStyle = BorderStyle.None;
            User.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User.ForeColor = SystemColors.GrayText;
            User.Location = new Point(57, 160);
            User.Name = "User";
            User.Size = new Size(401, 19);
            User.TabIndex = 2;
            User.Text = "USUARIO";
            User.TextChanged += textBox1_TextChanged;
            User.Enter += User_Enter;
            User.Leave += User_Leave;
            // 
            // pass
            // 
            pass.BackColor = Color.White;
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.ForeColor = SystemColors.GrayText;
            pass.Location = new Point(57, 245);
            pass.Name = "pass";
            pass.Size = new Size(401, 19);
            pass.TabIndex = 3;
            pass.Text = "CONTRASEÑA";
            pass.Enter += pass_Enter;
            pass.Leave += pass_Leave;
            // 
            // ingre
            // 
            ingre.BackColor = Color.FromArgb(0, 0, 64);
            ingre.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            ingre.FlatAppearance.MouseOverBackColor = Color.Gray;
            ingre.FlatStyle = FlatStyle.Flat;
            ingre.ForeColor = SystemColors.ControlLightLight;
            ingre.Location = new Point(115, 365);
            ingre.Name = "ingre";
            ingre.Size = new Size(497, 30);
            ingre.TabIndex = 4;
            ingre.Text = "INGRESAR";
            ingre.UseVisualStyleBackColor = false;
            ingre.Click += ingre_Click;
            // 
            // cerrar
            // 
            cerrar.AutoSize = true;
            cerrar.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cerrar.Location = new Point(683, 16);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(25, 23);
            cerrar.TabIndex = 5;
            cerrar.Text = "X";
            cerrar.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 73);
            label2.Name = "label2";
            label2.Size = new Size(601, 15);
            label2.TabIndex = 6;
            label2.Text = "Esta opción es unicamente para administradores del sistema por lo que si eres un administrador llena los campos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 105);
            label3.Name = "label3";
            label3.Size = new Size(253, 15);
            label3.TabIndex = 7;
            label3.Text = "en caso contrario regresa a la pantalla de inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 182);
            label4.Name = "label4";
            label4.Size = new Size(497, 15);
            label4.TabIndex = 8;
            label4.Text = "__________________________________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 267);
            label5.Name = "label5";
            label5.Size = new Size(497, 15);
            label5.TabIndex = 9;
            label5.Text = "__________________________________________________________________________________________________";
            // 
            // Port
            // 
            Port.Controls.Add(label4);
            Port.Controls.Add(cerrar);
            Port.Controls.Add(label2);
            Port.Controls.Add(label3);
            Port.Controls.Add(label5);
            Port.Controls.Add(pass);
            Port.Controls.Add(label1);
            Port.Controls.Add(User);
            Port.Controls.Add(ingre);
            Port.Dock = DockStyle.Fill;
            Port.Location = new Point(0, 0);
            Port.Name = "Port";
            Port.Size = new Size(734, 430);
            Port.TabIndex = 10;
            // 
            // Seguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 430);
            Controls.Add(Port);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Seguridad";
            Opacity = 0.7D;
            Text = "Seguridad";
            Load += Seguridad_Load;
            Port.ResumeLayout(false);
            Port.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox User;
        private TextBox pass;
        private Button ingre;
        private Label cerrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel Port;
    }
}