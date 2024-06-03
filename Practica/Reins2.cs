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
    public partial class Reins2 : Form
    {
        public Reins2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form activarForm = null;
        private void abrirhijoForm(Form hijo, pantalla fondo)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            fondo.Controls.Add(hijo);
            fondo.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ren2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
