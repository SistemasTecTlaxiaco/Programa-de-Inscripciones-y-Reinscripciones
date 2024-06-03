
namespace Practica
{
    partial class pantalla
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtApellido_P = new TextBox();
            TxtNumC = new TextBox();
            Fond = new Panel();
            ComboBoxGrupo = new ComboBox();
            ComboBoxCarrera = new ComboBox();
            ComboBoxSemestre = new ComboBox();
            txtNombre = new TextBox();
            label8 = new Label();
            txtApellido_M = new TextBox();
            panel2 = new Panel();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Fond.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 60);
            label1.Name = "label1";
            label1.Size = new Size(648, 36);
            label1.TabIndex = 0;
            label1.Text = "Ingresa tus datos para continuar con tu proceso de reinscripción\r\n al Instituto Tecnologico de Tlaxiaco";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(323, 170);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre (s) :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 64);
            label3.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 170);
            label3.Name = "label3";
            label3.Size = new Size(159, 16);
            label3.TabIndex = 2;
            label3.Text = "Numero de Control :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 64);
            label4.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(508, 170);
            label4.Name = "label4";
            label4.Size = new Size(151, 16);
            label4.TabIndex = 3;
            label4.Text = "Apellido Paterno :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 64);
            label5.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(323, 355);
            label5.Name = "label5";
            label5.Size = new Size(87, 16);
            label5.TabIndex = 4;
            label5.Text = "Semestre :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 64);
            label6.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(550, 355);
            label6.Name = "label6";
            label6.Size = new Size(79, 16);
            label6.TabIndex = 5;
            label6.Text = "Carrera :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 0, 64);
            label7.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(128, 459);
            label7.Name = "label7";
            label7.Size = new Size(63, 16);
            label7.TabIndex = 6;
            label7.Text = "Grupo :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtApellido_P
            // 
            txtApellido_P.Location = new Point(508, 212);
            txtApellido_P.Name = "txtApellido_P";
            txtApellido_P.Size = new Size(185, 23);
            txtApellido_P.TabIndex = 7;
            txtApellido_P.TextChanged += txtApellido_P_TextChanged;
            // 
            // TxtNumC
            // 
            TxtNumC.Location = new Point(79, 212);
            TxtNumC.Name = "TxtNumC";
            TxtNumC.Size = new Size(159, 23);
            TxtNumC.TabIndex = 9;
            TxtNumC.TextChanged += TxtNumC_TextChanged;
            // 
            // Fond
            // 
            Fond.BackColor = Color.Navy;
            Fond.BackgroundImage = (Image)resources.GetObject("Fond.BackgroundImage");
            Fond.Controls.Add(ComboBoxGrupo);
            Fond.Controls.Add(ComboBoxCarrera);
            Fond.Controls.Add(ComboBoxSemestre);
            Fond.Controls.Add(txtNombre);
            Fond.Controls.Add(label8);
            Fond.Controls.Add(txtApellido_M);
            Fond.Controls.Add(panel2);
            Fond.Controls.Add(button2);
            Fond.Controls.Add(button1);
            Fond.Controls.Add(label3);
            Fond.Controls.Add(label4);
            Fond.Controls.Add(label2);
            Fond.Controls.Add(label7);
            Fond.Controls.Add(txtApellido_P);
            Fond.Controls.Add(label5);
            Fond.Controls.Add(label6);
            Fond.Controls.Add(TxtNumC);
            Fond.Controls.Add(label1);
            Fond.Dock = DockStyle.Fill;
            Fond.Location = new Point(0, 0);
            Fond.Name = "Fond";
            Fond.Size = new Size(734, 561);
            Fond.TabIndex = 13;
            Fond.Paint += Fondo_Paint;
            // 
            // ComboBoxGrupo
            // 
            ComboBoxGrupo.FormattingEnabled = true;
            ComboBoxGrupo.Location = new Point(79, 498);
            ComboBoxGrupo.Name = "ComboBoxGrupo";
            ComboBoxGrupo.Size = new Size(121, 23);
            ComboBoxGrupo.TabIndex = 26;
            ComboBoxGrupo.SelectedIndexChanged += ComboBoxGrupo_SelectedIndexChanged;
            // 
            // ComboBoxCarrera
            // 
            ComboBoxCarrera.FormattingEnabled = true;
            ComboBoxCarrera.Location = new Point(518, 392);
            ComboBoxCarrera.Name = "ComboBoxCarrera";
            ComboBoxCarrera.Size = new Size(154, 23);
            ComboBoxCarrera.TabIndex = 25;
            ComboBoxCarrera.SelectedIndexChanged += ComboBoxCarrera_SelectedIndexChanged;
            // 
            // ComboBoxSemestre
            // 
            ComboBoxSemestre.FormattingEnabled = true;
            ComboBoxSemestre.Location = new Point(289, 392);
            ComboBoxSemestre.Name = "ComboBoxSemestre";
            ComboBoxSemestre.Size = new Size(171, 23);
            ComboBoxSemestre.TabIndex = 24;
            ComboBoxSemestre.SelectedIndexChanged += ComboBoxSemestre_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(275, 212);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 23);
            txtNombre.TabIndex = 23;
            txtNombre.TextChanged += TxtNombre_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 0, 64);
            label8.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(79, 355);
            label8.Name = "label8";
            label8.Size = new Size(151, 16);
            label8.TabIndex = 19;
            label8.Text = "Apellido Materno :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtApellido_M
            // 
            txtApellido_M.Location = new Point(62, 392);
            txtApellido_M.Name = "txtApellido_M";
            txtApellido_M.Size = new Size(185, 23);
            txtApellido_M.TabIndex = 18;
            txtApellido_M.TextChanged += txtApellido_M_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(progressBar1);
            panel2.Location = new Point(0, 538);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 23);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-19, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(747, 23);
            progressBar1.TabIndex = 16;
            progressBar1.Click += progressBar1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(25, 12);
            button2.Name = "button2";
            button2.Size = new Size(44, 27);
            button2.TabIndex = 14;
            button2.Text = "X";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(563, 498);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 13;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // pantalla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 561);
            Controls.Add(Fond);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pantalla";
            Text = "Reins";
            Fond.ResumeLayout(false);
            Fond.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void txtApellido_P_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
            
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtApellido_P;
        private TextBox TxtNumC;
        private Panel Fond;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private ProgressBar progressBar1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Label label8;
        private TextBox txtApellido_M;
        private TextBox txtNombre;
        private ComboBox ComboBoxGrupo;
        private ComboBox ComboBoxCarrera;
        private ComboBox ComboBoxSemestre;
    }
}