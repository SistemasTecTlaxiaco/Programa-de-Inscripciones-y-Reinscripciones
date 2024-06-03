using System.Runtime.InteropServices;
namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            personalizar();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

        private void personalizar()
        {

            Subtramite.Visible = false;
            SubP.Visible = false;
        }

        private void ocultar()
        {
            if (Subtramite.Visible == true)
                Subtramite.Visible = false;
            if (SubP.Visible == true)
                SubP.Visible = false;
        }
        private void mostrar(Panel menu)
        {
            if (menu.Visible == false)
            {
                ocultar();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }
        private void T_Click(object sender, EventArgs e)
        {
            mostrar(Subtramite);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            abrirhijoForm(new Portada());

            ocultar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirhijoForm(new pantalla());



            ocultar();
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
            portada.Controls.Add(hijo);
            portada.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void P_Click(object sender, EventArgs e)
        {
            mostrar(SubP);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirhijoForm(new pagosfichas());


            ocultar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirhijoForm(new pagosR());


            ocultar();
        }

        private void C_Click(object sender, EventArgs e)
        {
            abrirhijoForm(new Correo());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ocultar();
        }

        private void A_Click(object sender, EventArgs e)
        {
            abrirhijoForm(new ayuda());



            ocultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void portada_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirhijoForm(new Seguridad());



            ocultar();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void portada_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
