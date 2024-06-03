using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Practica
{
    public partial class Registro : Form
    {
        string connectionString = "Server=localhost;Port=3307;Database=practica;Uid=root;Pwd=;";
        string consulta = "SELECT * FROM registros";
        public Registro()
        {
            InitializeComponent();
            dgvDatos.Columns.Add("@Num_C", "Numero Control");
            dgvDatos.Columns.Add("@Nombres", "NOMBRE");
            dgvDatos.Columns.Add("@Apellido_P", "APELLIDO_P");
            dgvDatos.Columns.Add("@Apellido_M", "APELLIDO_M");
            dgvDatos.Columns.Add("@Id_Semestre", "SEMESTRE");
            dgvDatos.Columns.Add("@Id_Carrera", "CARRERA");
            dgvDatos.Columns.Add("@Id_Grupo", "GRUPO");
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDatos.Rows.Clear(); // Limpieza de datos repetidos al conectar
                MySqlConnection databaseConnection = new MySqlConnection(connectionString); // Es el que realiza la conexión entre la base de datos
                MySqlCommand commandatabase = new MySqlCommand(consulta, databaseConnection);
                commandatabase.CommandTimeout = 60;

                // Deshabilitar la selección automática de celdas
                dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                databaseConnection.Open();
                MySqlDataReader reader = commandatabase.ExecuteReader();

                while (reader.Read())
                {
                    dgvDatos.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));
                }

                // Cambiar el enfoque de la celda después de cargar los datos
                dgvDatos.CurrentCell = null; // Esto desenfoca la celda actualmente seleccionada, si la hay

                databaseConnection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + error.ToString());
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string idNumeroControl = textBox1.Text.Trim(); // Obtener el ID número de control del TextBox

                // Cadena de conexión
                string connectionString = "Server=localhost;Port=3307;Database=practica;Uid=root;Pwd=;";

                // Consulta SQL con parámetros para eliminar el registro con el ID número de control especificado
                string deleteQuery = "DELETE FROM registros WHERE NUM_C = @NUM_C";

                // Establecer la conexión
                using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand commandDatabase = new MySqlCommand(deleteQuery, databaseConnection))
                    {
                        // Establecer el parámetro con el ID número de control
                        commandDatabase.Parameters.AddWithValue("@NUM_C", idNumeroControl);

                        commandDatabase.CommandTimeout = 60;

                        try
                        {
                            databaseConnection.Open();
                            int rowsAffected = commandDatabase.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Se eliminó el registro correctamente.");

                                // Limpia el DataGridView
                                dgvDatos.Rows.Clear();

                                // Vuelve a cargar los datos en la tabla
                                CargarDatosEnTabla();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún registro con el ID número de control especificado.");
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error al intentar eliminar el registro: " + error.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a la base de datos: " + ex.Message);
            }
        }

        // Método para cargar los datos en la tabla
        private void CargarDatosEnTabla()
        {
            try
            {
                // Cadena de conexión
                string connectionString = "Server=localhost;Port=3307;Database=practica;Uid=root;Pwd=;";

                // Consulta SQL para seleccionar todos los registros
                string selectQuery = "SELECT * FROM registros";

                // Establecer la conexión
                using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand commandDatabase = new MySqlCommand(selectQuery, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        // Abrir la conexión
                        databaseConnection.Open();

                        // Ejecutar la consulta y leer los resultados
                        using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                        {
                            // Limpiar la tabla antes de agregar nuevos datos
                            dgvDatos.Rows.Clear();

                            // Leer los datos y agregarlos a la tabla
                            while (reader.Read())
                            {
                                dgvDatos.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en la tabla: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string idNumeroControl = textBox1.Text.Trim(); // Obtener el ID número de control del TextBox

                // Deshacer el resaltado de la fila anteriormente seleccionada
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }

                // Recorrer todas las filas del DataGridView para buscar el nuevo ID número de control
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Verificar si el valor de la celda coincide con el ID buscado
                        if (cell.Value != null && cell.Value.ToString() == idNumeroControl)
                        {
                            // Resaltar la fila en azul si se encuentra el ID buscado
                            row.DefaultCellStyle.BackColor = Color.Blue;
                            return; // Termina la búsqueda después de encontrar la primera coincidencia
                        }
                    }
                }

                // Si no se encuentra ningún registro con el ID número de control especificado, muestra un mensaje
                MessageBox.Show("No se encontró ningún registro con el ID número de control especificado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el registro: " + ex.Message);
            }
        }
    }
}

