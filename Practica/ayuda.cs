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
    public partial class ayuda : Form
    {
        public ayuda()
        {
            InitializeComponent();
        }
        private void ProcesoLargo()
        {
            for (int i = 0; i < 100; i++)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = i + 1;

                });
                Thread.Sleep(30);
            }
            this.Invoke((MethodInvoker)delegate
            {
                // Si el panel1 está visible, abre el nuevo formulario.
                if (panel1.Visible)
                {
                    Form1 fm2 = new Form1();
                    abrirhijoForm(fm2);
                }

                // Cierra este formulario.
                this.Close();
            });
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
            this.Controls.Add(hijo); // Cambiado de Form1 a this
            hijo.Tag = this; // Se cambia portada.Tag por hijo.Tag para asociar el formulario hijo con el actual.
            hijo.BringToFront();
            hijo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hiloProceso = new Thread(ProcesoLargo);
            hiloProceso.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
