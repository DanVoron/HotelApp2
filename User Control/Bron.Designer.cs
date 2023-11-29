namespace HotelApp2.User_Control
{
    partial class Bron
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchReservation = new System.Windows.Forms.TabPage();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchClientId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageUpdateReservation = new System.Windows.Forms.TabPage();
            this.textBoxRoomNo1 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.textBoxClientID1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tabPageUpdateReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchReservation);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateReservation);
            this.tabControlReservation.Location = new System.Drawing.Point(61, 42);
            this.tabControlReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(969, 337);
            this.tabControlReservation.TabIndex = 0;
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.Controls.Add(this.textBoxRoomNo);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddReservation.Controls.Add(this.label6);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddReservation.Controls.Add(this.label5);
            this.tabPageAddReservation.Controls.Add(this.comboBoxType);
            this.tabPageAddReservation.Controls.Add(this.textBoxClientID);
            this.tabPageAddReservation.Controls.Add(this.label4);
            this.tabPageAddReservation.Controls.Add(this.buttonAdd);
            this.tabPageAddReservation.Controls.Add(this.label3);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAddReservation.Size = new System.Drawing.Size(961, 303);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Добавить бронь";
            this.tabPageAddReservation.UseVisualStyleBackColor = true;
            this.tabPageAddReservation.Leave += new System.EventHandler(this.tabPageAddReservation_Leave);
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNo.Location = new System.Drawing.Point(484, 89);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(278, 28);
            this.textBoxRoomNo.TabIndex = 32;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut.Location = new System.Drawing.Point(484, 244);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(278, 28);
            this.dateTimePickerOut.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(480, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Выезд";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn.Location = new System.Drawing.Point(484, 161);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(278, 28);
            this.dateTimePickerIn.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(480, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Вьезд";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Одиночная",
            "Двойная",
            "Семейная",
            "Люкс",
            "Делюкс"});
            this.comboBoxType.Location = new System.Drawing.Point(88, 89);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(278, 29);
            this.comboBoxType.TabIndex = 26;
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID.Location = new System.Drawing.Point(88, 156);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(278, 28);
            this.textBoxClientID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(84, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Айди клиента";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(88, 214);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(197, 52);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(480, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Номер комнаты";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Тип комнаты";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Добавить бронь:";
            // 
            // tabPageSearchReservation
            // 
            this.tabPageSearchReservation.Controls.Add(this.dataGridViewReservation);
            this.tabPageSearchReservation.Controls.Add(this.textBoxSearchClientId);
            this.tabPageSearchReservation.Controls.Add(this.label7);
            this.tabPageSearchReservation.Controls.Add(this.label8);
            this.tabPageSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSearchReservation.Name = "tabPageSearchReservation";
            this.tabPageSearchReservation.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSearchReservation.Size = new System.Drawing.Size(961, 303);
            this.tabPageSearchReservation.TabIndex = 1;
            this.tabPageSearchReservation.Text = "Найти бронь";
            this.tabPageSearchReservation.UseVisualStyleBackColor = true;
            this.tabPageSearchReservation.Enter += new System.EventHandler(this.tabPageSearchReservation_Enter);
            this.tabPageSearchReservation.Leave += new System.EventHandler(this.tabPageSearchReservation_Leave);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Active});
            this.dataGridViewReservation.Location = new System.Drawing.Point(64, 92);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersWidth = 51;
            this.dataGridViewReservation.RowTemplate.Height = 24;
            this.dataGridViewReservation.Size = new System.Drawing.Size(857, 208);
            this.dataGridViewReservation.TabIndex = 13;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            this.dataGridViewReservation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewReservation_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Айди Записи";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_Number";
            this.Column3.HeaderText = "Номер комнаты";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Client_ID";
            this.Column4.HeaderText = "Айди клиента";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Type";
            this.Column2.HeaderText = "Тип";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Bron_IN";
            this.Column5.HeaderText = "Вьезд";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Bron_Out";
            this.Column6.HeaderText = "Выезд";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Актуально?";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // textBoxSearchClientId
            // 
            this.textBoxSearchClientId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchClientId.Location = new System.Drawing.Point(167, 58);
            this.textBoxSearchClientId.Name = "textBoxSearchClientId";
            this.textBoxSearchClientId.Size = new System.Drawing.Size(278, 28);
            this.textBoxSearchClientId.TabIndex = 12;
            this.textBoxSearchClientId.TextChanged += new System.EventHandler(this.textBoxSearchClientId_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(163, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Айди клиента";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(7, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Найти бронь:";
            // 
            // tabPageUpdateReservation
            // 
            this.tabPageUpdateReservation.Controls.Add(this.textBoxRoomNo1);
            this.tabPageUpdateReservation.Controls.Add(this.buttonDelete);
            this.tabPageUpdateReservation.Controls.Add(this.dateTimePickerOut1);
            this.tabPageUpdateReservation.Controls.Add(this.label9);
            this.tabPageUpdateReservation.Controls.Add(this.dateTimePickerIn1);
            this.tabPageUpdateReservation.Controls.Add(this.label10);
            this.tabPageUpdateReservation.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateReservation.Controls.Add(this.textBoxClientID1);
            this.tabPageUpdateReservation.Controls.Add(this.label11);
            this.tabPageUpdateReservation.Controls.Add(this.buttonEdit);
            this.tabPageUpdateReservation.Controls.Add(this.label12);
            this.tabPageUpdateReservation.Controls.Add(this.label13);
            this.tabPageUpdateReservation.Controls.Add(this.label14);
            this.tabPageUpdateReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateReservation.Name = "tabPageUpdateReservation";
            this.tabPageUpdateReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateReservation.Size = new System.Drawing.Size(961, 303);
            this.tabPageUpdateReservation.TabIndex = 2;
            this.tabPageUpdateReservation.Text = "Изменить бронь";
            this.tabPageUpdateReservation.UseVisualStyleBackColor = true;
            this.tabPageUpdateReservation.Leave += new System.EventHandler(this.tabPageUpdateReservation_Leave);
            // 
            // textBoxRoomNo1
            // 
            this.textBoxRoomNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNo1.Location = new System.Drawing.Point(483, 89);
            this.textBoxRoomNo1.Name = "textBoxRoomNo1";
            this.textBoxRoomNo1.Size = new System.Drawing.Size(278, 28);
            this.textBoxRoomNo1.TabIndex = 45;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(290, 213);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(135, 52);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut1.Location = new System.Drawing.Point(483, 243);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(278, 28);
            this.dateTimePickerOut1.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(479, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "Выезд";
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn1.Location = new System.Drawing.Point(483, 160);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(278, 28);
            this.dateTimePickerIn1.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(479, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "Вьезд";
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Одиночная",
            "Двойная",
            "Семейная",
            "Люкс",
            "Делюкс"});
            this.comboBoxType1.Location = new System.Drawing.Point(87, 88);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(278, 29);
            this.comboBoxType1.TabIndex = 38;
            // 
            // textBoxClientID1
            // 
            this.textBoxClientID1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID1.Location = new System.Drawing.Point(87, 155);
            this.textBoxClientID1.Name = "textBoxClientID1";
            this.textBoxClientID1.Size = new System.Drawing.Size(278, 28);
            this.textBoxClientID1.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(83, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "Айди клиента";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(87, 213);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(197, 52);
            this.buttonEdit.TabIndex = 35;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(479, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "Номер комнаты";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(83, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Тип комнаты";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label14.Location = new System.Drawing.Point(6, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "Изменить бронь:";
            // 
            // Bron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReservation);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bron";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchReservation.ResumeLayout(false);
            this.tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tabPageUpdateReservation.ResumeLayout(false);
            this.tabPageUpdateReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.TabPage tabPageSearchReservation;
        private System.Windows.Forms.TabPage tabPageUpdateReservation;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.TextBox textBoxSearchClientId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.TextBox textBoxClientID1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.TextBox textBoxRoomNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}
