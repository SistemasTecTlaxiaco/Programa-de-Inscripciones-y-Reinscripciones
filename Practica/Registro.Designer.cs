
namespace Practica
{
    partial class Registro
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
            dgvDatos = new DataGridView();
            btnEliminar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnConectar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.GridColor = Color.White;
            dgvDatos.Location = new Point(2, 46);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(714, 424);
            dgvDatos.TabIndex = 2;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.FromArgb(0, 0, 64);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(132, 476);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(233, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnConectar
            // 
            btnConectar.Anchor = AnchorStyles.None;
            btnConectar.BackColor = Color.FromArgb(0, 0, 64);
            btnConectar.ForeColor = Color.White;
            btnConectar.Location = new Point(461, 476);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(124, 34);
            btnConectar.TabIndex = 7;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.FromArgb(0, 0, 64);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(522, -2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 27);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 522);
            Controls.Add(btnBuscar);
            Controls.Add(btnConectar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(dgvDatos);
            Name = "Registro";
            Text = "Form2";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnEliminar;
        private Label label1;
        private TextBox textBox1;
        private Button btnConectar;
        private Button btnBuscar;
    }
}