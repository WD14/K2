namespace K2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerExpirationDate = new System.Windows.Forms.TextBox();
            this.dateTimePickerProductionDate = new System.Windows.Forms.TextBox();
            this.CategoryID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dataGridViewPriceList = new System.Windows.Forms.DataGridView();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnWriteOff = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.TextBox();
            this.EID = new System.Windows.Forms.TextBox();
            this.PID = new System.Windows.Forms.TextBox();
            this.DT = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.TextBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteSupply = new System.Windows.Forms.Button();
            this.btnAddSupply = new System.Windows.Forms.Button();
            this.dateTimePickerSupplyDate = new System.Windows.Forms.TextBox();
            this.txtSupplyQuantity = new System.Windows.Forms.TextBox();
            this.txtSupplyProductID = new System.Windows.Forms.TextBox();
            this.dataGridViewSupplies = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnDeleteWriteOff = new System.Windows.Forms.Button();
            this.dataGridViewWriteOffs = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtDiscountID = new System.Windows.Forms.TextBox();
            this.btnDeleteDiscount = new System.Windows.Forms.Button();
            this.btnUpdateDiscount = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.TextBox();
            this.dtStartDate = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.dataGridViewDiscount = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriceList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOffs)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.tabPage4);
            this.TabControl1.Controls.Add(this.tabPage5);
            this.TabControl1.Controls.Add(this.tabPage6);
            this.TabControl1.Controls.Add(this.tabPage7);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1360, 701);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddColumn);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dateTimePickerExpirationDate);
            this.tabPage1.Controls.Add(this.dateTimePickerProductionDate);
            this.tabPage1.Controls.Add(this.CategoryID);
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtProductName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtQuantity);
            this.tabPage1.Controls.Add(this.dataGridViewPriceList);
            this.tabPage1.Controls.Add(this.txtReason);
            this.tabPage1.Controls.Add(this.txtProductID);
            this.tabPage1.Controls.Add(this.btnWriteOff);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1352, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Прайс-лист";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.BackColor = System.Drawing.Color.Silver;
            this.btnAddColumn.Location = new System.Drawing.Point(684, 536);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(228, 136);
            this.btnAddColumn.TabIndex = 5;
            this.btnAddColumn.Text = "Додати";
            this.btnAddColumn.UseVisualStyleBackColor = false;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(1037, 574);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(309, 95);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Видалити рядок";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 598);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Термін придатності";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Дата виробництва";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 569);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Вартість";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID-категорії";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Назва товару";
            // 
            // dateTimePickerExpirationDate
            // 
            this.dateTimePickerExpirationDate.Location = new System.Drawing.Point(487, 595);
            this.dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            this.dateTimePickerExpirationDate.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerExpirationDate.TabIndex = 13;
            // 
            // dateTimePickerProductionDate
            // 
            this.dateTimePickerProductionDate.Location = new System.Drawing.Point(487, 544);
            this.dateTimePickerProductionDate.Name = "dateTimePickerProductionDate";
            this.dateTimePickerProductionDate.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerProductionDate.TabIndex = 12;
            // 
            // CategoryID
            // 
            this.CategoryID.Location = new System.Drawing.Point(101, 595);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(253, 20);
            this.CategoryID.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(101, 569);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(253, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(101, 543);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(253, 20);
            this.txtProductName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1034, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кількість";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Причина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID-товару";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(1093, 499);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(253, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // dataGridViewPriceList
            // 
            this.dataGridViewPriceList.AllowUserToOrderColumns = true;
            this.dataGridViewPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriceList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPriceList.Name = "dataGridViewPriceList";
            this.dataGridViewPriceList.Size = new System.Drawing.Size(1346, 490);
            this.dataGridViewPriceList.TabIndex = 4;
            this.dataGridViewPriceList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPriceList_CellEndEdit);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(775, 499);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(253, 20);
            this.txtReason.TabIndex = 3;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(460, 499);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(253, 20);
            this.txtProductID.TabIndex = 2;
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.Location = new System.Drawing.Point(1037, 533);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(309, 35);
            this.btnWriteOff.TabIndex = 1;
            this.btnWriteOff.Text = "Списати товар";
            this.btnWriteOff.UseVisualStyleBackColor = true;
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.textBoxOrderID);
            this.tabPage2.Controls.Add(this.btnRemoveOrder);
            this.tabPage2.Controls.Add(this.btnAddOrder);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.Q);
            this.tabPage2.Controls.Add(this.EID);
            this.tabPage2.Controls.Add(this.PID);
            this.tabPage2.Controls.Add(this.DT);
            this.tabPage2.Controls.Add(this.CID);
            this.tabPage2.Controls.Add(this.dataGridViewOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1352, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Замовлення";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(506, 502);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "ID_Замовлення";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(483, 521);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(130, 20);
            this.textBoxOrderID.TabIndex = 13;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveOrder.Location = new System.Drawing.Point(230, 565);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(203, 60);
            this.btnRemoveOrder.TabIndex = 12;
            this.btnRemoveOrder.Text = "Видалити замовлення";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddOrder.Location = new System.Drawing.Point(230, 499);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(203, 60);
            this.btnAddOrder.TabIndex = 11;
            this.btnAddOrder.Text = "Додати замовлення";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 608);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Кількість";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 582);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Співробітник";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 556);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "ID_Товару";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Дата";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 502);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "ID_Клієнта";
            // 
            // Q
            // 
            this.Q.Location = new System.Drawing.Point(72, 605);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(152, 20);
            this.Q.TabIndex = 5;
            // 
            // EID
            // 
            this.EID.Location = new System.Drawing.Point(73, 579);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(151, 20);
            this.EID.TabIndex = 4;
            // 
            // PID
            // 
            this.PID.Location = new System.Drawing.Point(73, 553);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(151, 20);
            this.PID.TabIndex = 3;
            // 
            // DT
            // 
            this.DT.Location = new System.Drawing.Point(72, 525);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(152, 20);
            this.DT.TabIndex = 2;
            // 
            // CID
            // 
            this.CID.Location = new System.Drawing.Point(73, 499);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(151, 20);
            this.CID.TabIndex = 1;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(1346, 490);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnDeleteSupply);
            this.tabPage3.Controls.Add(this.btnAddSupply);
            this.tabPage3.Controls.Add(this.dateTimePickerSupplyDate);
            this.tabPage3.Controls.Add(this.txtSupplyQuantity);
            this.tabPage3.Controls.Add(this.txtSupplyProductID);
            this.tabPage3.Controls.Add(this.dataGridViewSupplies);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1352, 675);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поставки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID_товару";
            // 
            // btnDeleteSupply
            // 
            this.btnDeleteSupply.Location = new System.Drawing.Point(327, 590);
            this.btnDeleteSupply.Name = "btnDeleteSupply";
            this.btnDeleteSupply.Size = new System.Drawing.Size(212, 72);
            this.btnDeleteSupply.TabIndex = 5;
            this.btnDeleteSupply.Text = "Видалити поставку";
            this.btnDeleteSupply.UseVisualStyleBackColor = true;
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Location = new System.Drawing.Point(327, 499);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(212, 72);
            this.btnAddSupply.TabIndex = 4;
            this.btnAddSupply.Text = "Додати поставку";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // dateTimePickerSupplyDate
            // 
            this.dateTimePickerSupplyDate.Location = new System.Drawing.Point(109, 590);
            this.dateTimePickerSupplyDate.Name = "dateTimePickerSupplyDate";
            this.dateTimePickerSupplyDate.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerSupplyDate.TabIndex = 3;
            // 
            // txtSupplyQuantity
            // 
            this.txtSupplyQuantity.Location = new System.Drawing.Point(109, 551);
            this.txtSupplyQuantity.Name = "txtSupplyQuantity";
            this.txtSupplyQuantity.Size = new System.Drawing.Size(212, 20);
            this.txtSupplyQuantity.TabIndex = 2;
            // 
            // txtSupplyProductID
            // 
            this.txtSupplyProductID.Location = new System.Drawing.Point(109, 515);
            this.txtSupplyProductID.Name = "txtSupplyProductID";
            this.txtSupplyProductID.Size = new System.Drawing.Size(212, 20);
            this.txtSupplyProductID.TabIndex = 1;
            // 
            // dataGridViewSupplies
            // 
            this.dataGridViewSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplies.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSupplies.Name = "dataGridViewSupplies";
            this.dataGridViewSupplies.Size = new System.Drawing.Size(1346, 490);
            this.dataGridViewSupplies.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewEmployees);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1352, 675);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Кадри";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1346, 490);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnDeleteWriteOff);
            this.tabPage5.Controls.Add(this.dataGridViewWriteOffs);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1352, 675);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Списання";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnDeleteWriteOff
            // 
            this.btnDeleteWriteOff.Location = new System.Drawing.Point(1103, 525);
            this.btnDeleteWriteOff.Name = "btnDeleteWriteOff";
            this.btnDeleteWriteOff.Size = new System.Drawing.Size(246, 123);
            this.btnDeleteWriteOff.TabIndex = 1;
            this.btnDeleteWriteOff.Text = "Видалити рядок";
            this.btnDeleteWriteOff.UseVisualStyleBackColor = true;
            this.btnDeleteWriteOff.Click += new System.EventHandler(this.btnDeleteWriteOff_Click);
            // 
            // dataGridViewWriteOffs
            // 
            this.dataGridViewWriteOffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriteOffs.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWriteOffs.Name = "dataGridViewWriteOffs";
            this.dataGridViewWriteOffs.Size = new System.Drawing.Size(1346, 490);
            this.dataGridViewWriteOffs.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.btnAddClient);
            this.tabPage6.Controls.Add(this.textBoxContact);
            this.tabPage6.Controls.Add(this.textBoxName);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.textBoxClientID);
            this.tabPage6.Controls.Add(this.dataGridViewClients);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1352, 675);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Клієнти";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(73, 580);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Контактні дані";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(126, 518);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Ім\'я";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Видалити клієнта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(331, 499);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(167, 66);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Додати клієнта";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(158, 577);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(163, 20);
            this.textBoxContact.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(158, 515);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Пошук";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(53, 4);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(268, 20);
            this.textBoxClientID.TabIndex = 2;
            this.textBoxClientID.TextChanged += new System.EventHandler(this.textBoxClientID_TextChanged);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(1346, 463);
            this.dataGridViewClients.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtDiscountID);
            this.tabPage7.Controls.Add(this.btnDeleteDiscount);
            this.tabPage7.Controls.Add(this.btnUpdateDiscount);
            this.tabPage7.Controls.Add(this.btnAddDiscount);
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Controls.Add(this.label23);
            this.tabPage7.Controls.Add(this.label22);
            this.tabPage7.Controls.Add(this.label21);
            this.tabPage7.Controls.Add(this.dtEndDate);
            this.tabPage7.Controls.Add(this.dtStartDate);
            this.tabPage7.Controls.Add(this.txtValue);
            this.tabPage7.Controls.Add(this.txtClientID);
            this.tabPage7.Controls.Add(this.dataGridViewDiscount);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1352, 675);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Знижки";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtDiscountID
            // 
            this.txtDiscountID.Location = new System.Drawing.Point(1202, 600);
            this.txtDiscountID.Name = "txtDiscountID";
            this.txtDiscountID.Size = new System.Drawing.Size(144, 20);
            this.txtDiscountID.TabIndex = 15;
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteDiscount.Location = new System.Drawing.Point(1202, 626);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(144, 43);
            this.btnDeleteDiscount.TabIndex = 14;
            this.btnDeleteDiscount.Text = "Видалити знижку";
            this.btnDeleteDiscount.UseVisualStyleBackColor = false;
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.Location = new System.Drawing.Point(314, 554);
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(144, 43);
            this.btnUpdateDiscount.TabIndex = 13;
            this.btnUpdateDiscount.Text = "Оновити";
            this.btnUpdateDiscount.UseVisualStyleBackColor = true;
            this.btnUpdateDiscount.Click += new System.EventHandler(this.btnUpdateDiscount_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(314, 502);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(144, 43);
            this.btnAddDiscount.TabIndex = 12;
            this.btnAddDiscount.Text = "Додати знижку";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 580);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Кінець";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 554);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Початок";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 528);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Величина";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 502);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "ID_Клієнта";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(88, 577);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(187, 20);
            this.dtEndDate.TabIndex = 6;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(88, 551);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(187, 20);
            this.dtStartDate.TabIndex = 5;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(88, 525);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(187, 20);
            this.txtValue.TabIndex = 4;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(88, 499);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(187, 20);
            this.txtClientID.TabIndex = 3;
            // 
            // dataGridViewDiscount
            // 
            this.dataGridViewDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscount.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDiscount.Name = "dataGridViewDiscount";
            this.dataGridViewDiscount.Size = new System.Drawing.Size(1346, 490);
            this.dataGridViewDiscount.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 719);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 130);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.TabControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriceList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOffs)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewSupplies;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewWriteOffs;
        private System.Windows.Forms.Button btnWriteOff;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewPriceList;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateTimePickerExpirationDate;
        private System.Windows.Forms.TextBox dateTimePickerProductionDate;
        private System.Windows.Forms.TextBox CategoryID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridViewDiscount;
        private System.Windows.Forms.TextBox dateTimePickerSupplyDate;
        private System.Windows.Forms.TextBox txtSupplyQuantity;
        private System.Windows.Forms.TextBox txtSupplyProductID;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.Button btnDeleteSupply;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteWriteOff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox Q;
        private System.Windows.Forms.TextBox EID;
        private System.Windows.Forms.TextBox PID;
        private System.Windows.Forms.TextBox DT;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox dtEndDate;
        private System.Windows.Forms.TextBox dtStartDate;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnUpdateDiscount;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtDiscountID;
        private System.Windows.Forms.Button btnDeleteDiscount;
    }
}

