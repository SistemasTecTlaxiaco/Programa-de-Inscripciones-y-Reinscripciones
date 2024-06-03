
namespace Practica
{
    partial class Correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correo));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDe = new TextBox();
            txtPara = new TextBox();
            txtAsunto = new TextBox();
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            button1.Location = new Point(14, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(51, 31);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 40);
            label1.Name = "label1";
            label1.Size = new Size(178, 18);
            label1.TabIndex = 6;
            label1.Text = "Centro de Correos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 93);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 7;
            label2.Text = "De:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 154);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 8;
            label3.Text = "Para:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 221);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "Asunto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 286);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Mensaje:";
            // 
            // txtDe
            // 
            txtDe.Location = new Point(128, 116);
            txtDe.Name = "txtDe";
            txtDe.Size = new Size(284, 27);
            txtDe.TabIndex = 11;
            // 
            // txtPara
            // 
            txtPara.Location = new Point(128, 177);
            txtPara.Name = "txtPara";
            txtPara.Size = new Size(284, 27);
            txtPara.TabIndex = 12;
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(128, 244);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(451, 27);
            txtAsunto.TabIndex = 13;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(128, 319);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(451, 115);
            txtMensaje.TabIndex = 14;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.ActiveBorder;
            btnEnviar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnEnviar.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnEnviar.ForeColor = SystemColors.ControlText;
            btnEnviar.Location = new Point(514, 451);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(170, 38);
            btnEnviar.TabIndex = 15;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(482, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Correo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(839, 748);
            Controls.Add(pictureBox1);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(txtAsunto);
            Controls.Add(txtPara);
            Controls.Add(txtDe);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Correo";
            Text = "Correo";
            Load += Correo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Correo_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDe;
        private TextBox txtPara;
        private TextBox txtAsunto;
        private TextBox txtMensaje;
        private Button btnEnviar;
        private PictureBox pictureBox1;
    }
}