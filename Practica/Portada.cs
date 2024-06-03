using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Practica
{
    public partial class Portada : Form
    {
        string connectionString = "Server=localhost;Port=3307;Database=practica;Uid=root;Pwd=;";
        public Portada()
        {
            InitializeComponent();
            conectar();
        }
        private void conectar()
        {
            // Limpiar los ComboBox antes de cargar nuevos datos
            ComboCarrera.Items.Clear();

            // Consultas SQL para las diferentes tablas
            string consultaCarrera = "SELECT Id_Carrera, Nombre FROM Carrera";


            LlenarComboBox(ComboCarrera, consultaCarrera, "Id_Carrera", "Nombre");

            // Llenar ComboBoxGrupo
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that a valid item is selected
                if (ComboCarrera.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione una carrera.");
                    return;
                }

                // Ensure the selected item is a KeyValuePair
                var selectedCarrera = ComboCarrera.SelectedItem as KeyValuePair<string, string>?;
                if (selectedCarrera == null)
                {
                    MessageBox.Show("Error al obtener la carrera seleccionada.");
                    return;
                }

                // Correct the SQL insert query and parameters
                string insertQuery = "INSERT INTO ingresos (Nombre, APP, APM, Edad, NumAspir, Id_Carrera) " +
                                     "VALUES (@Nombre, @APP, @APM, @Edad, @NumAspir, @Id_Carrera)";

                // Establish the connection
                using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
                {
                    databaseConnection.Open();

                    // Create and configure the insert command
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, databaseConnection))
                    {
                        // Parameters for the insert query
                        insertCommand.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        insertCommand.Parameters.AddWithValue("@APP", txtAPP.Text);
                        insertCommand.Parameters.AddWithValue("@APM", txtAPM.Text);
                        insertCommand.Parameters.AddWithValue("@Edad", txtEdad.Text);
                        insertCommand.Parameters.AddWithValue("@NumAspir", txtNumeroInspirante.Text);
                        insertCommand.Parameters.AddWithValue("@Id_Carrera", selectedCarrera.Value.Key);

                        // Execute the insert query
                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("El registro se ha insertado correctamente.");
                }

                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message + "\nDetalles: " + ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message + "\nDetalles: " + ex.StackTrace);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAPM_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}