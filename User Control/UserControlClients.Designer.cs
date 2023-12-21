namespace HotelApp2.User_Control
{
    partial class UserControlClients
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
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxAdress1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhone1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPage1);
            this.tabControlClient.Location = new System.Drawing.Point(61, 42);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(969, 337);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.checkBox1);
            this.tabPageAddClient.Controls.Add(this.textBoxAdress);
            this.tabPageAddClient.Controls.Add(this.label5);
            this.tabPageAddClient.Controls.Add(this.textBoxPhoneNumb);
            this.tabPageAddClient.Controls.Add(this.label4);
            this.tabPageAddClient.Controls.Add(this.buttonAdd);
            this.tabPageAddClient.Controls.Add(this.textBoxLastName);
            this.tabPageAddClient.Controls.Add(this.label3);
            this.tabPageAddClient.Controls.Add(this.textBoxFirstName);
            this.tabPageAddClient.Controls.Add(this.label2);
            this.tabPageAddClient.Controls.Add(this.label1);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(961, 303);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Добавить клиента";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            this.tabPageAddClient.Leave += new System.EventHandler(this.tabPageAddClient_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(483, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(392, 46);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Клиент подписал согласие на обработку \r\nперсональных данных";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdress.Location = new System.Drawing.Point(483, 163);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(278, 28);
            this.textBoxAdress.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(479, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Паспорт";
            // 
            // textBoxPhoneNumb
            // 
            this.textBoxPhoneNumb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNumb.Location = new System.Drawing.Point(87, 155);
            this.textBoxPhoneNumb.Name = "textBoxPhoneNumb";
            this.textBoxPhoneNumb.Size = new System.Drawing.Size(278, 28);
            this.textBoxPhoneNumb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер телефона";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(87, 216);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(197, 52);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName.Location = new System.Drawing.Point(483, 91);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(278, 28);
            this.textBoxLastName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(479, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фамилия";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(87, 91);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(278, 28);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавить клиента:";
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.Controls.Add(this.dataGridViewClient);
            this.tabPageSearchClient.Controls.Add(this.textBoxSearchPhone);
            this.tabPageSearchClient.Controls.Add(this.label6);
            this.tabPageSearchClient.Controls.Add(this.label7);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(961, 303);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "Найти клиента";
            this.tabPageSearchClient.UseVisualStyleBackColor = true;
            this.tabPageSearchClient.Enter += new System.EventHandler(this.tabPageSearchClient_Enter);
            this.tabPageSearchClient.Leave += new System.EventHandler(this.tabPageSearchClient_Leave);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Phone,
            this.Passport,
            this.Active});
            this.dataGridViewClient.Location = new System.Drawing.Point(60, 91);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(857, 224);
            this.dataGridViewClient.TabIndex = 9;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            this.dataGridViewClient.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewClient_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Имя";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Surname";
            this.Column3.HeaderText = "Фамилия";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Телефон";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Passport
            // 
            this.Passport.DataPropertyName = "Passport";
            this.Passport.HeaderText = "Паспорт";
            this.Passport.MinimumWidth = 6;
            this.Passport.Name = "Passport";
            this.Passport.ReadOnly = true;
            this.Passport.Visible = false;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Актуально?";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // textBoxSearchPhone
            // 
            this.textBoxSearchPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchPhone.Location = new System.Drawing.Point(163, 57);
            this.textBoxSearchPhone.Name = "textBoxSearchPhone";
            this.textBoxSearchPhone.Size = new System.Drawing.Size(278, 28);
            this.textBoxSearchPhone.TabIndex = 8;
            this.textBoxSearchPhone.TextChanged += new System.EventHandler(this.textBoxSearchPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(159, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Номер телефона";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Найти клиента:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.textBoxAdress1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxPhone1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Controls.Add(this.textBoxLastName1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBoxFirstName1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 303);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Изменить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(297, 216);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 52);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxAdress1
            // 
            this.textBoxAdress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdress1.Location = new System.Drawing.Point(481, 163);
            this.textBoxAdress1.Multiline = true;
            this.textBoxAdress1.Name = "textBoxAdress1";
            this.textBoxAdress1.Size = new System.Drawing.Size(278, 28);
            this.textBoxAdress1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(477, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Паспорт";
            // 
            // textBoxPhone1
            // 
            this.textBoxPhone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhone1.Location = new System.Drawing.Point(85, 155);
            this.textBoxPhone1.Name = "textBoxPhone1";
            this.textBoxPhone1.Size = new System.Drawing.Size(278, 28);
            this.textBoxPhone1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(81, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Номер телефона";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(85, 216);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(197, 52);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName1.Location = new System.Drawing.Point(481, 91);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(278, 28);
            this.textBoxLastName1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(477, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Фамилия";
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName1.Location = new System.Drawing.Point(85, 91);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(278, 28);
            this.textBoxFirstName1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(81, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Имя";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label12.Location = new System.Drawing.Point(4, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Изменить клиента:";
            // 
            // UserControlClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlClients";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.TextBox textBoxPhoneNumb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxSearchPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxAdress1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhone1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}
