namespace Practica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button4 = new Button();
            button1 = new Button();
            A = new Button();
            C = new Button();
            SubP = new Panel();
            button5 = new Button();
            button6 = new Button();
            P = new Button();
            Subtramite = new Panel();
            button3 = new Button();
            button2 = new Button();
            T = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            portada = new PictureBox();
            panel1.SuspendLayout();
            SubP.SuspendLayout();
            Subtramite.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)portada).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(A);
            panel1.Controls.Add(C);
            panel1.Controls.Add(SubP);
            panel1.Controls.Add(P);
            panel1.Controls.Add(Subtramite);
            panel1.Controls.Add(T);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 561);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button4.Location = new Point(0, 400);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(200, 30);
            button4.TabIndex = 10;
            button4.Text = "REGISTROS";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(0, 531);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(200, 30);
            button1.TabIndex = 9;
            button1.Text = "SALIDA";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // A
            // 
            A.Dock = DockStyle.Top;
            A.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            A.Location = new Point(0, 370);
            A.Name = "A";
            A.Padding = new Padding(10, 0, 0, 0);
            A.Size = new Size(200, 30);
            A.TabIndex = 8;
            A.Text = "AYUDA";
            A.TextAlign = ContentAlignment.MiddleLeft;
            A.UseVisualStyleBackColor = true;
            A.Click += A_Click;
            // 
            // C
            // 
            C.Dock = DockStyle.Top;
            C.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            C.Location = new Point(0, 340);
            C.Name = "C";
            C.Padding = new Padding(10, 0, 0, 0);
            C.Size = new Size(200, 30);
            C.TabIndex = 6;
            C.Text = "CORREO";
            C.TextAlign = ContentAlignment.MiddleLeft;
            C.UseVisualStyleBackColor = true;
            C.Click += C_Click;
            // 
            // SubP
            // 
            SubP.Controls.Add(button5);
            SubP.Controls.Add(button6);
            SubP.Dock = DockStyle.Top;
            SubP.Location = new Point(0, 277);
            SubP.Name = "SubP";
            SubP.Size = new Size(200, 63);
            SubP.TabIndex = 5;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(0, 30);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(200, 30);
            button5.TabIndex = 1;
            button5.Text = "Reincripción";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Padding = new Padding(35, 0, 0, 0);
            button6.Size = new Size(200, 30);
            button6.TabIndex = 0;
            button6.Text = "Incripción";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // P
            // 
            P.Dock = DockStyle.Top;
            P.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            P.Location = new Point(0, 247);
            P.Name = "P";
            P.Padding = new Padding(10, 0, 0, 0);
            P.Size = new Size(200, 30);
            P.TabIndex = 4;
            P.Text = "PAGOS";
            P.TextAlign = ContentAlignment.MiddleLeft;
            P.UseVisualStyleBackColor = true;
            P.Click += P_Click;
            // 
            // Subtramite
            // 
            Subtramite.Controls.Add(button3);
            Subtramite.Controls.Add(button2);
            Subtramite.Dock = DockStyle.Top;
            Subtramite.Location = new Point(0, 184);
            Subtramite.Name = "Subtramite";
            Subtramite.Size = new Size(200, 63);
            Subtramite.TabIndex = 3;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(0, 30);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(200, 30);
            button3.TabIndex = 1;
            button3.Text = "Reincripción";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(200, 30);
            button2.TabIndex = 0;
            button2.Text = "Incripción";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // T
            // 
            T.Dock = DockStyle.Top;
            T.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            T.Location = new Point(0, 154);
            T.Name = "T";
            T.Padding = new Padding(10, 0, 0, 0);
            T.Size = new Size(200, 30);
            T.TabIndex = 2;
            T.Text = "TRAMITE";
            T.TextAlign = ContentAlignment.MiddleLeft;
            T.UseVisualStyleBackColor = true;
            T.Click += T_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 154);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(portada);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 561);
            panel2.TabIndex = 1;
            // 
            // portada
            // 
            portada.Dock = DockStyle.Fill;
            portada.Image = (Image)resources.GetObject("portada.Image");
            portada.Location = new Point(0, 0);
            portada.Name = "portada";
            portada.Size = new Size(734, 561);
            portada.TabIndex = 0;
            portada.TabStop = false;
            portada.Click += portada_Click;
            portada.MouseDown += portada_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            SubP.ResumeLayout(false);
            Subtramite.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)portada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button P;
        private Panel Subtramite;
        private Button button3;
        private Button button2;
        private Button T;
        private Panel panel3;
        private Panel panel2;
        private PictureBox portada;
        private Button A;
        private Button C;
        private Panel SubP;
        private Button button5;
        private Button button6;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button4;
    }
}
