using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Leave(object sender, EventArgs e)
        {
            if (User.Text == "")
            {
                User.Text = "USUARIO";
                User.ForeColor = Color.Black;
            }
        }

        private void User_Enter(object sender, EventArgs e)
        {
            if (User.Text == "USUARIO")
            {
                User.Text = "";
                User.ForeColor = Color.Black;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "CONTRASEÑA")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = true;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "CONTRASEÑA";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = false;
            }
        }

        private void ingre_Click(object sender, EventArgs e)
        {
            Registro fm2 = new Registro();
            abrirhijoForm(fm2);
        }

        private void Seguridad_Load(object sender, EventArgs e)
        {

        }
        private Form activarForm = null;

        private void abrirhijoForm(Form hijo)
        {
            if (activarForm != null)
                activarForm.Close();

            activarForm = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            Port.Controls.Add(hijo);
            Port.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }
    }
}
