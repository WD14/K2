using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace K2
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter1;
        private DataTable originalDataTable;

        public Form1(string role)
        {
            InitializeComponent();

            // Підключення до бази даних
            string connectionString = "Server=localhost;Port=3306;Database=trade;Uid=root;Pwd=root_pas4308;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                LoadData("товари", dataGridViewPriceList);
                LoadData("замовлення", dataGridViewOrders);
                LoadData("поставки", dataGridViewSupplies);
                LoadData("кадри", dataGridViewEmployees);
                LoadData("списання", dataGridViewWriteOffs);
                LoadData("клієнти", dataGridViewClients);
                LoadData("знижки", dataGridViewDiscount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при відображенні даних: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadData(string tableName, DataGridView dataGridView, int clientID = 0)
        {
            string query = "SELECT * FROM " + tableName;

            if (clientID != 0)
            {
                query += " WHERE ID = " + clientID;
            }

            adapter1 = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter1);

            originalDataTable = new DataTable();
            adapter1.Fill(originalDataTable);
            dataGridView.DataSource = originalDataTable;

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
        }
        private void UpdateData()
        {
            adapter1.Update(originalDataTable); 
            UpdateUnitOfMeasure();
            LoadData("товари", dataGridViewPriceList);
            LoadData("знижки", dataGridViewDiscount);
            LoadData("списання", dataGridViewWriteOffs);
        }

        private void RefreshDataGridView()
        {
            dataGridViewPriceList.DataSource = originalDataTable;
        }

        private void UpdateUnitOfMeasure()
        {
            DataColumn unitOfMeasureColumn = originalDataTable.Columns["Одиниця_виміру"];
            if (unitOfMeasureColumn != null)
            {
                foreach (DataGridViewRow row in dataGridViewPriceList.Rows)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    string unitOfMeasure = GetUnitOfMeasure(id);

                    row.Cells[unitOfMeasureColumn.ColumnName].Value = unitOfMeasure;
                }
            }
        }


        private string GetUnitOfMeasure(int productID)
        {
            if (productID <= 10)
                return "кг";
            else
                return "шт";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData(); 

            MessageBox.Show("Дані оновлено у базі даних.");
        }

        private void dataGridViewPriceList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow updatedRow = dataGridViewPriceList.Rows[e.RowIndex];

            int id = Convert.ToInt32(updatedRow.Cells["Id"].Value);
            string productName = updatedRow.Cells["Назва"].Value.ToString();
            int price = Convert.ToInt32(updatedRow.Cells["Ціна"].Value);

            DataRow[] rowsToUpdate = originalDataTable.Select("ID = " + id);
            if (rowsToUpdate.Length > 0)
            {
                rowsToUpdate[0]["Назва"] = productName;
                rowsToUpdate[0]["Ціна"] = price;
            }
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            int newID;
            bool isNumeric = int.TryParse(txtProductID.Text, out newID);

            if (!isNumeric)
            {
                MessageBox.Show("ID має бути числовим значенням.");
                return;
            }

            if (IsIDExists(newID))
            {
                MessageBox.Show("Введений ID вже існує.");
                return;
            }

            DataRow newRow = originalDataTable.NewRow();
            newRow["ID"] = newID;
            newRow["ID_Категорії"] = GetCategoryID(newID); // Отримати ID категорії
            newRow["Назва"] = txtProductName.Text;
            newRow["Кількість"] = decimal.Parse(txtQuantity.Text);
            newRow["Ціна"] = decimal.Parse(txtPrice.Text);
            newRow["Дата_Виробництва"] = dateTimePickerProductionDate.Text;
            newRow["Термін_Придатності"] = dateTimePickerExpirationDate.Text;
            originalDataTable.Rows.Add(newRow);

            RefreshDataGridView();
            UpdateData();
        }

        private int GetCategoryID(int productID)
        {
            if (productID <= 10)
                return 1;
            else
                return 2;
        }

        private bool IsIDExists(int id)
        {
            foreach (DataRow row in originalDataTable.Rows)
            {
                int existingID = Convert.ToInt32(row["ID"]);
                if (existingID == id)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtSupplyProductID.Text);
            int quantity = int.Parse(txtSupplyQuantity.Text);
            var date = System.DateTime.Parse(dateTimePickerSupplyDate.Text);

            string query = "INSERT INTO поставки (ID_Товару, Кількість, Дата) VALUES (@ProductId, @Quantity, @Date)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Date", date);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Дані додано до таблиці 'поставки'.");

                    LoadData("поставки", dataGridViewSupplies);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка при додаванні даних до таблиці 'поставки': " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void btnDeleteSupply_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupplies.SelectedRows.Count > 0)
            {
                int selectedRowID = Convert.ToInt32(dataGridViewSupplies.SelectedRows[0].Cells["ID"].Value);

                string query = "DELETE FROM поставки WHERE ID = @RowID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RowID", selectedRowID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Рядок успішно видалено з таблиці 'поставки'.");

                        LoadData("поставки", dataGridViewSupplies);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Сталася помилка при видаленні рядка з таблиці 'поставки': " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рядок для видалення.");
            }
        }
        private void WriteOffProduct(int productID, int quantity, string reason)
        {
            // Отримати сьогоднішню дату
            var currentDate = System.DateTime.Today;

            string updateQuantityQuery = $"UPDATE `товари` SET `Кількість` = `Кількість` - {quantity} WHERE `ID` = {productID};";

            ExecuteNonQuery(updateQuantityQuery);

            // Записати списання товару у таблицю "списання"
            string writeOffQuery = $"INSERT INTO `списання` (`ID_Товару`, `Кількість`, `Причина`, `Дата_Списання`) " +
                $"VALUES ({productID}, {quantity}, '{reason}', '{currentDate.ToString("yyyy-MM-dd")}');";

            ExecuteNonQuery(writeOffQuery);
            LoadData("товари", dataGridViewPriceList);

            MessageBox.Show($"{quantity} одиниць товару було списано з причиною: {reason}");
        }

        private void ExecuteNonQuery(string query)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(txtProductID.Text);
            int quantity = int.Parse(txtQuantity.Text);
            string reason = txtReason.Text;

            WriteOffProduct(productID, quantity, reason);
        }
        private void DeleteWriteOff(int writeOffID)
        {
            string deleteWriteOffQuery = $"DELETE FROM `списання` WHERE `ID` = {writeOffID};";

            ExecuteNonQuery(deleteWriteOffQuery);

            LoadData("списання", dataGridViewWriteOffs);

            MessageBox.Show("Рядок списання був успішно видалений.");
        }

        private void btnDeleteWriteOff_Click(object sender, EventArgs e)
        {
            if (dataGridViewWriteOffs.SelectedRows.Count > 0)
            {
                int writeOffID = int.Parse(dataGridViewWriteOffs.SelectedRows[0].Cells["ID"].Value.ToString());

                DeleteWriteOff(writeOffID);
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рядок списання для видалення.");
            }
        }
        private void textBoxClientID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxClientID.Text))
            {
                LoadData("клієнти", dataGridViewClients);
            }
            else if (int.TryParse(textBoxClientID.Text, out int clientID))
            {
                LoadData("клієнти", dataGridViewClients, clientID);

                // Автоматичне виділення рядка з вказаним ID клієнта
                if (dataGridViewClients.Rows.Count > 0)
                {
                    dataGridViewClients.Rows[0].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("ID клієнта має бути числовим значенням.");
                textBoxClientID.Text = ""; 
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Перевірка, чи вибрано рядок для видалення
            if (dataGridViewPriceList.SelectedRows.Count > 0)
            {
                int selectedRowID = Convert.ToInt32(dataGridViewPriceList.SelectedRows[0].Cells["ID"].Value);

                string query = "DELETE FROM товари WHERE ID = @RowID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RowID", selectedRowID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Рядок успішно видалено з прайс-листа.");

                        LoadData("товари", dataGridViewPriceList);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Сталася помилка при видаленні рядка з прайс-листа: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рядок для видалення.");
            }
        }
        private void AddOrder(int clientID, DateTime date, int productID, int employeeID, int quantity)
{
    string query = "INSERT INTO замовлення (ID_Клієнта, Дата, ID_Товару, ID_Співробітника, Кількість) VALUES (@clientID, @date, @productID, @employeeID, @quantity)";

    try
    {
        using (MySqlCommand command = new MySqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@clientID", clientID);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@productID", productID);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@quantity", quantity);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    catch (MySqlException ex)
    {
        // Ігнорувати повідомлення про помилку "Кількість у замовленні перевищує доступну кількість товару"
        if (ex.Message.Contains("Кількість у замовленні перевищує доступну кількість товару"))
        {
            return;
        }
        MessageBox.Show("Error occurred: " + ex.Message);
    }
}

        /*private void UpdateOrderPrice(int orderID)
        {
            string query = "UPDATE замовлення SET Ціна = (SELECT Ціна FROM товари WHERE ID = замовлення.ID_Товару) * замовлення.Кількість WHERE ID = @orderID";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@orderID", orderID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }*/

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CID.Text, out int clientID))
            {
                MessageBox.Show("Invalid Client ID. Please enter a valid integer value.");
                return;
            }

            if (!DateTime.TryParse(DT.Text, out DateTime date))
            {
                MessageBox.Show("Invalid Date. Please enter a valid date value.");
                return;
            }

            if (!int.TryParse(PID.Text, out int productID))
            {
                MessageBox.Show("Invalid Product ID. Please enter a valid integer value.");
                return;
            }

            if (!int.TryParse(EID.Text, out int employeeID))
            {
                MessageBox.Show("Invalid Employee ID. Please enter a valid integer value.");
                return;
            }

            if (!int.TryParse(Q.Text, out int quantity))
            {
                MessageBox.Show("Invalid Quantity. Please enter a valid integer value.");
                return;
            }

            try
            {
                string query = "INSERT INTO замовлення (ID_Клієнта, Дата, ID_Товару, ID_Співробітника, Кількість) VALUES (@clientID, @date, @productID, @employeeID, @quantity)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@clientID", clientID);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@productID", productID);
                    command.Parameters.AddWithValue("@employeeID", employeeID);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData("замовлення", dataGridViewOrders);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error occurred while adding the order: " + ex.Message);
            }
        }

        private void RemoveOrder(int orderID)
        {
            string query = "DELETE FROM замовлення WHERE ID = @orderID";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@orderID", orderID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxOrderID.Text, out int orderID))
            {
                MessageBox.Show("Invalid Order ID. Please enter a valid integer value.");
                return;
            }

            try
            {
                RemoveOrder(orderID);

                // Оновити дані в DataGridView
                LoadData("замовлення", dataGridViewOrders);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error occurred while removing the order: " + ex.Message);
            }
        }
        private void AddClient(string name, string contact)
        {
            string query = "INSERT INTO клієнти (Ім_я, Контактні_дані) VALUES (@name, @contact)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@contact", contact);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void RemoveClient(int clientID)
        {
            string query = "DELETE FROM клієнти WHERE ID = @clientID";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@clientID", clientID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Додати клієнта
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string contact = textBoxContact.Text;

            AddClient(name, contact);

            LoadData("клієнти", dataGridViewClients);
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                int clientID = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["ID"].Value);

                RemoveClient(clientID);
                LoadData("клієнти", dataGridViewClients);
            }
        }
        private void AddDiscount(int clientID, decimal value, DateTime startDate, DateTime endDate)
        {
            string query = "INSERT INTO знижки (ID_Клієнта, Величина, Початок, Кінець) VALUES (@clientID, @value, @startDate, @endDate)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@clientID", clientID);
                command.Parameters.AddWithValue("@value", value);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void UpdateDiscount(int clientID, decimal value, DateTime startDate, DateTime endDate)
        {
            string query = "UPDATE знижки SET Величина = @value, Початок = @startDate, Кінець = @endDate WHERE ID_Клієнта = @clientID";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@value", value);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                command.Parameters.AddWithValue("@clientID", clientID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtClientID.Text, out int clientID))
            {
                MessageBox.Show("Invalid Client ID. Please enter a valid integer value.");
                return;
            }

            if (!decimal.TryParse(txtValue.Text, out decimal value))
            {
                MessageBox.Show("Invalid Value. Please enter a valid decimal value.");
                return;
            }

            if (!DateTime.TryParse(dtStartDate.Text, out DateTime startDate))
            {
                MessageBox.Show("Invalid Start Date. Please enter a valid date value.");
                return;
            }

            if (!DateTime.TryParse(dtEndDate.Text, out DateTime endDate))
            {
                MessageBox.Show("Invalid End Date. Please enter a valid date value.");
                return;
            }

            AddDiscount(clientID, value, startDate, endDate);

            // Оновити дані в DataGridView
            LoadData("знижки", dataGridViewDiscount);
        }
        private void DeleteDiscount(int discountID)
        {
            string query = "DELETE FROM знижки WHERE ID = @discountID";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@discountID", discountID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDiscountID.Text, out int discountID))
            {
                MessageBox.Show("Invalid Discount ID. Please enter a valid integer value.");
                return;
            }

            DeleteDiscount(discountID);

            // Оновити дані в DataGridView
            LoadData("знижки", dataGridViewDiscount);
        }
        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtClientID.Text, out int clientID))
            {
                MessageBox.Show("Invalid Client ID. Please enter a valid integer value.");
                return;
            }

            if (!decimal.TryParse(txtValue.Text, out decimal value))
            {
                MessageBox.Show("Invalid Value. Please enter a valid decimal value.");
                return;
            }

            DateTime startDate;
            DateTime endDate;

            if (!DateTime.TryParse(dtStartDate.Text, out startDate))
            {
                MessageBox.Show("Invalid Start Date. Please enter a valid date value.");
                return;
            }

            if (!DateTime.TryParse(dtEndDate.Text, out endDate))
            {
                MessageBox.Show("Invalid End Date. Please enter a valid date value.");
                return;
            }

            UpdateDiscount(clientID, value, startDate, endDate);

            // Оновити дані в DataGridView
            LoadData("знижки", dataGridViewDiscount);
        }
    }
}
