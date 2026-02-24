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

namespace K2
{
    public partial class Guest : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=trade;Uid=root;Pwd=root_pas4308;";

        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            // Заборонимо редагування в DataGrid
            dataGridView1.ReadOnly = true;

            // Викличемо метод для заповнення DataGrid з бази даних
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT товари.ID, категорії.Назва as Категорія, товари.Назва, товари.Кількість, товари.Одиниця_виміру, товари.Ціна FROM товари JOIN категорії ON товари.ID_Категорії = категорії.ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    // Приховати стовпці з датами
                    

                    // Встановити джерело даних для DataGrid
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при отриманні даних з бази даних: " + ex.Message);
                }
            }
        }
    }
}