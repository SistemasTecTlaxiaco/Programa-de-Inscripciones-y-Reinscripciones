using MySql.Data.MySqlClient;
using System.Data;


namespace Practica
{
    public partial class pantalla : Form
    {

        string connectionString = "Server=localhost;Port=3307;Database=practica;Uid=root;Pwd=;";


        public pantalla()
        {
            InitializeComponent();
            conectar();


        }

        private void conectar()
        {
            // Limpiar los ComboBox antes de cargar nuevos datos
            ComboBoxSemestre.Items.Clear();
            ComboBoxCarrera.Items.Clear();
            ComboBoxGrupo.Items.Clear();

            // Consultas SQL para las diferentes tablas
            string consultaSemestre = "SELECT Id_Semestre, Nombre FROM Semestre";
            string consultaCarrera = "SELECT Id_Carrera, Nombre FROM Carrera";
            string consultaGrupo = "SELECT Id_Grupo, Nombre FROM Grupo";

            // Llenar ComboBoxSemestre
            LlenarComboBox(ComboBoxSemestre, consultaSemestre, "Id_Semestre", "Nombre");

            // Llenar ComboBoxCarrera
            LlenarComboBox(ComboBoxCarrera, consultaCarrera, "Id_Carrera", "Nombre");

            // Llenar ComboBoxGrupo
            LlenarComboBox(ComboBoxGrupo, consultaGrupo, "Id_Grupo", "Nombre");
        }

        private void LlenarComboBox(ComboBox comboBox, string consulta, string idColumn, string nameColumn)
        {
            MySqlDataReader reader = null;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(consulta, connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(new KeyValuePair<string, string>(reader[idColumn].ToString(), reader[nameColumn].ToString()));
                    }

                    comboBox.DisplayMember = "Value";
                    comboBox.ValueMember = "Key";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (panel2.Visible)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Reins2 fm2 = new Reins2();
                    abrirhijoForm(fm2);
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Consulta SQL con parámetros
                string insertQuery = "INSERT INTO registros (Num_C, Nombres, Apellido_P, Apellido_M, Id_Semestre, Id_Carrera, Id_Grupo) " +
                                     "VALUES (NULL, @Nombres, @Apellido_P, @Apellido_M, @Id_Semestre, @Id_Carrera, @Id_Grupo)";

                // Establecer la conexión
                using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
                {
                    databaseConnection.Open();

                    // Crear y configurar el comando de inserción
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, databaseConnection))
                    {
                        // Parámetros para la consulta de inserción
                        insertCommand.Parameters.AddWithValue("@Nombres", txtNombre.Text);
                        insertCommand.Parameters.AddWithValue("@Apellido_P", txtApellido_P.Text);
                        insertCommand.Parameters.AddWithValue("@Apellido_M", txtApellido_M.Text);
                        insertCommand.Parameters.AddWithValue("@Id_Semestre", ((KeyValuePair<string, string>)ComboBoxSemestre.SelectedItem).Key);
                        insertCommand.Parameters.AddWithValue("@Id_Carrera", ((KeyValuePair<string, string>)ComboBoxCarrera.SelectedItem).Key);
                        insertCommand.Parameters.AddWithValue("@Id_Grupo", ((KeyValuePair<string, string>)ComboBoxGrupo.SelectedItem).Key);


                        // Ejecutar la consulta de inserción
                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("El registro se ha insertado correctamente.");

                    // Iniciar el proceso largo en un hilo aparte
                    Thread hiloProceso = new Thread(ProcesoLargo);
                    hiloProceso.Start();

                    databaseConnection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
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
            Fond.Controls.Add(hijo);
            Fond.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fondo_Paint(object sender, PaintEventArgs e)
        {

        }



        private void progressBar1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Valor del progressBar: " + progressBar1.Value);

            if (progressBar1.Value >= progressBar1.Maximum && panel2.Visible)
            {
                timer1.Stop();
                Reins2 fm2 = new Reins2();
                abrirhijoForm(fm2);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void TxtApellidoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumC_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_M_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
