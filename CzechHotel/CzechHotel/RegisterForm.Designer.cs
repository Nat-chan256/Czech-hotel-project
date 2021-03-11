namespace CzechHotel
{
    partial class RegisterForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtbBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.mtbPassportSeries = new System.Windows.Forms.MaskedTextBox();
            this.mtbPassportNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.nudAmountOfResidents = new System.Windows.Forms.NumericUpDown();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.bSaveUser = new System.Windows.Forms.Button();
            this.cbWithChildren = new System.Windows.Forms.CheckBox();
            this.nudRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtbBirthDate
            // 
            this.dtbBirthDate.Location = new System.Drawing.Point(7, 231);
            this.dtbBirthDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtbBirthDate.MaxDate = new System.DateTime(2003, 3, 5, 0, 0, 0, 0);
            this.dtbBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtbBirthDate.Name = "dtbBirthDate";
            this.dtbBirthDate.Size = new System.Drawing.Size(151, 20);
            this.dtbBirthDate.TabIndex = 3;
            this.dtbBirthDate.Value = new System.DateTime(2003, 3, 5, 0, 0, 0, 0);
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.Color.Silver;
            this.tbName.Location = new System.Drawing.Point(7, 68);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(90, 20);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Имя";
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbSurname
            // 
            this.tbSurname.ForeColor = System.Drawing.Color.Silver;
            this.tbSurname.Location = new System.Drawing.Point(7, 91);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(90, 20);
            this.tbSurname.TabIndex = 5;
            this.tbSurname.Text = "Фамилия";
            this.tbSurname.Enter += new System.EventHandler(this.tbSurname_Enter);
            this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress);
            this.tbSurname.Leave += new System.EventHandler(this.tbSurname_Leave);
            // 
            // tbGender
            // 
            this.tbGender.ForeColor = System.Drawing.Color.Silver;
            this.tbGender.Location = new System.Drawing.Point(7, 114);
            this.tbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(90, 20);
            this.tbGender.TabIndex = 6;
            this.tbGender.Text = "Гендер";
            this.tbGender.Enter += new System.EventHandler(this.tbGender_Enter);
            this.tbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGender_KeyPress);
            this.tbGender.Leave += new System.EventHandler(this.tbGender_Leave);
            // 
            // mtbPassportSeries
            // 
            this.mtbPassportSeries.ForeColor = System.Drawing.Color.Silver;
            this.mtbPassportSeries.Location = new System.Drawing.Point(7, 136);
            this.mtbPassportSeries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbPassportSeries.Name = "mtbPassportSeries";
            this.mtbPassportSeries.Size = new System.Drawing.Size(90, 20);
            this.mtbPassportSeries.TabIndex = 7;
            this.mtbPassportSeries.Text = "Серия паспорта";
            this.mtbPassportSeries.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
            this.mtbPassportSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
            this.mtbPassportSeries.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
            // 
            // mtbPassportNumber
            // 
            this.mtbPassportNumber.ForeColor = System.Drawing.Color.Silver;
            this.mtbPassportNumber.Location = new System.Drawing.Point(7, 159);
            this.mtbPassportNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbPassportNumber.Name = "mtbPassportNumber";
            this.mtbPassportNumber.Size = new System.Drawing.Size(90, 20);
            this.mtbPassportNumber.TabIndex = 8;
            this.mtbPassportNumber.Text = "Номер паспорта";
            this.mtbPassportNumber.Enter += new System.EventHandler(this.mtbPassportNumber_Enter);
            this.mtbPassportNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportNumber_KeyPress);
            this.mtbPassportNumber.Leave += new System.EventHandler(this.mtbPassportNumber_Leave);
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.ForeColor = System.Drawing.Color.Silver;
            this.mtbPhoneNumber.Location = new System.Drawing.Point(7, 182);
            this.mtbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(90, 20);
            this.mtbPhoneNumber.TabIndex = 9;
            this.mtbPhoneNumber.Tag = "";
            this.mtbPhoneNumber.Text = "Номер телефона";
            this.mtbPhoneNumber.Enter += new System.EventHandler(this.mtbPhoneNumber_Enter);
            this.mtbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPhoneNumber_KeyPress);
            this.mtbPhoneNumber.Leave += new System.EventHandler(this.mtbPhoneNumber_Leave);
            // 
            // nudAmountOfResidents
            // 
            this.nudAmountOfResidents.Location = new System.Drawing.Point(304, 89);
            this.nudAmountOfResidents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAmountOfResidents.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAmountOfResidents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountOfResidents.Name = "nudAmountOfResidents";
            this.nudAmountOfResidents.Size = new System.Drawing.Size(90, 20);
            this.nudAmountOfResidents.TabIndex = 12;
            this.nudAmountOfResidents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Location = new System.Drawing.Point(244, 110);
            this.dtpArrivalDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpArrivalDate.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(151, 20);
            this.dtpArrivalDate.TabIndex = 13;
            this.dtpArrivalDate.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dtpArrivalDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Location = new System.Drawing.Point(244, 132);
            this.dtpDepartureDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDepartureDate.MinDate = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(151, 20);
            this.dtpDepartureDate.TabIndex = 14;
            this.dtpDepartureDate.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpDepartureDate_ValueChanged);
            // 
            // bSaveUser
            // 
            this.bSaveUser.Location = new System.Drawing.Point(392, 237);
            this.bSaveUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSaveUser.Name = "bSaveUser";
            this.bSaveUser.Size = new System.Drawing.Size(79, 24);
            this.bSaveUser.TabIndex = 15;
            this.bSaveUser.Text = "Сохранить";
            this.bSaveUser.UseVisualStyleBackColor = true;
            this.bSaveUser.Click += new System.EventHandler(this.bSaveUser_Click);
            // 
            // cbWithChildren
            // 
            this.cbWithChildren.AutoSize = true;
            this.cbWithChildren.Location = new System.Drawing.Point(404, 88);
            this.cbWithChildren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbWithChildren.Name = "cbWithChildren";
            this.cbWithChildren.Size = new System.Drawing.Size(73, 17);
            this.cbWithChildren.TabIndex = 16;
            this.cbWithChildren.Text = "С детьми";
            this.cbWithChildren.UseVisualStyleBackColor = true;
            // 
            // nudRoomNumber
            // 
            this.nudRoomNumber.Location = new System.Drawing.Point(304, 67);
            this.nudRoomNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudRoomNumber.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudRoomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoomNumber.Name = "nudRoomNumber";
            this.nudRoomNumber.Size = new System.Drawing.Size(90, 20);
            this.nudRoomNumber.TabIndex = 17;
            this.nudRoomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Личные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "О заселении";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Номер комнаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Количество заселяющихся";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Дата заселения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Дата выселения";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 467);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtbBirthDate);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbSurname);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbGender);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.mtbPassportSeries);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.mtbPassportNumber);
            this.tabPage1.Controls.Add(this.mtbPhoneNumber);
            this.tabPage1.Controls.Add(this.nudRoomNumber);
            this.tabPage1.Controls.Add(this.nudAmountOfResidents);
            this.tabPage1.Controls.Add(this.cbWithChildren);
            this.tabPage1.Controls.Add(this.dtpArrivalDate);
            this.tabPage1.Controls.Add(this.bSaveUser);
            this.tabPage1.Controls.Add(this.dtpDepartureDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(649, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 2);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Занесение нового постояльца в базу данных.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.maskedTextBox2);
            this.tabPage2.Controls.Add(this.maskedTextBox3);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dateTimePicker3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(649, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактировать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 2);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Изменение существующей записи.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Личные данные";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Дата выселения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 232);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2003, 3, 5, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new System.DateTime(2003, 3, 5, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Дата заселения";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(7, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "Имя";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 216);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Дата рождения";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(7, 93);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.Text = "Фамилия";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Количество заселяющихся";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(7, 115);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "Гендер";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Номер комнаты";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBox1.Location = new System.Drawing.Point(7, 138);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBox1.TabIndex = 29;
            this.maskedTextBox1.Text = "Серия паспорта";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(151, 41);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "О заселении";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBox2.Location = new System.Drawing.Point(7, 161);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBox2.TabIndex = 30;
            this.maskedTextBox2.Text = "Номер паспорта";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBox3.Location = new System.Drawing.Point(7, 184);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBox3.TabIndex = 31;
            this.maskedTextBox3.Tag = "";
            this.maskedTextBox3.Text = "Номер телефона";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(304, 68);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 37;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(304, 91);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown2.TabIndex = 32;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(404, 89);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "С детьми";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(244, 111);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 35;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(244, 134);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker3.MinDate = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker3.TabIndex = 34;
            this.dateTimePicker3.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(649, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Об отеле";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 467);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Форма регистрации";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.DateTimePicker dtbBirthDate;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.TextBox tbGender;
		private System.Windows.Forms.MaskedTextBox mtbPassportSeries;
		private System.Windows.Forms.MaskedTextBox mtbPassportNumber;
		private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
		private System.Windows.Forms.NumericUpDown nudAmountOfResidents;
		private System.Windows.Forms.DateTimePicker dtpArrivalDate;
		private System.Windows.Forms.DateTimePicker dtpDepartureDate;
		private System.Windows.Forms.Button bSaveUser;
		private System.Windows.Forms.CheckBox cbWithChildren;
		private System.Windows.Forms.NumericUpDown nudRoomNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}

