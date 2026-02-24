using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace K2
{
    public partial class Log : MaterialForm
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private const string WindowsVersionRegistryKey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
        private const string WindowsBuildNumberRegistryValue = "CurrentBuildNumber";

        private string connectionString = "Server=localhost;Port=3306;Database=trade;Uid=root;Pwd=root_pas4308;";

        private bool isAuthorized = false;
        public bool IsAuthorized
        {
            get
            {
                return isAuthorized;
            }
        }

        public Log()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.FormBorderStyle = FormBorderStyle.None;

            // Отримання номера збірки операційної системи Windows
            string currentBuildNumber = GetWindowsBuildNumber();
            int targetBuildNumber = 22000;

            if (int.TryParse(currentBuildNumber, out int buildNumber) && buildNumber > targetBuildNumber)
            {
                // Встановлення закруглених кутів, якщо номер збірки вищий за 22000
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }

            // Вписуйте 5-ий пункт після встановлення MaterialSkin стилю
            materialButton1.Size = new System.Drawing.Size(200, 50); // Задає розмір кнопки
            materialButton1.AutoSize = false; // Вимкнення автоматичного розміщення кнопки
            this.Controls.Add(materialButton1); // Додаємо кнопку до форми

            // Заповнення ComboBox даними з таблиці "посади"
            FillComboBoxWithPositions();
        }

        private void FillComboBoxWithPositions()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT назва FROM посади";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string positionName = reader.GetString("назва");
                        materialComboBox1.Items.Add(positionName);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при отриманні даних з бази даних: " + ex.Message);
                }
                if (materialComboBox1.Items.Count > 0)
                {
                    materialComboBox1.SelectedIndex = 5;
                }
            }
        }

        private string GetWindowsBuildNumber()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(WindowsVersionRegistryKey))
                {
                    if (key != null)
                    {
                        return key.GetValue(WindowsBuildNumberRegistryValue)?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Обробка винятків при доступі до реєстру
                MessageBox.Show("Помилка при отриманні номера збірки операційної системи: " + ex.Message);
            }

            return string.Empty;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string username = materialTextBox21.Text;
            string password = materialTextBox22.Text;
            string selectedRole = materialComboBox1.SelectedItem.ToString();

            // Виконання запиту до бази даних
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT посади.Назва
            FROM користувачі
            JOIN посади ON користувачі.Роль = посади.ID
            WHERE користувачі.Ім_я = @username AND користувачі.Пароль = @password AND посади.Назва = @role";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", selectedRole);
                object result = command.ExecuteScalar();

                if (result != null) // Якщо отримано результат
                {
                    string role = result.ToString();
                    // Збереження інформації про користувача (роль) для подальшого використання в основній формі
                    isAuthorized = true;

                    // Закриття форми входу
                    this.Close();

                    Form1 mainForm = new Form1(role);
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Невірний логін, пароль або роль");
                }
            }
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обробка події вибору елемента в ComboBox
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            materialButton2.FlatStyle = FlatStyle.Flat;
            materialButton2.ForeColor = Color.Black; 
            materialButton2.Font = new Font(materialButton2.Font, FontStyle.Strikeout);
            Guest guestForm = new Guest();
            guestForm.ShowDialog();
        }
    }
}