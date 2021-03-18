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
			this.tbArrivalDateEditPage = new System.Windows.Forms.TabControl();
			this.tpAddUser = new System.Windows.Forms.TabPage();
			this.label15 = new System.Windows.Forms.Label();
			this.tpEdit = new System.Windows.Forms.TabPage();
			this.cbChooseUser = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpBirthDateEditPage = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.tbNameEditTab = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbSurnameEditTab = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tbGenderEditTab = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.mtbPassportSeriesEditTab = new System.Windows.Forms.MaskedTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.mtbPassportNumberEditTab = new System.Windows.Forms.MaskedTextBox();
			this.mtbPhoneNumberEditTab = new System.Windows.Forms.MaskedTextBox();
			this.nudRoomNumberEditTab = new System.Windows.Forms.NumericUpDown();
			this.nudAmountOfResidentsEditTab = new System.Windows.Forms.NumericUpDown();
			this.cbWithChildrenEditTab = new System.Windows.Forms.CheckBox();
			this.dtpArrivalDateEditTab = new System.Windows.Forms.DateTimePicker();
			this.bSaveChanges = new System.Windows.Forms.Button();
			this.dtpDepartureDateEditTab = new System.Windows.Forms.DateTimePicker();
			this.tpAboutHotel = new System.Windows.Forms.TabPage();
			this.rtbUnoccupiedRooms = new System.Windows.Forms.RichTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.rtbOccupiedRooms = new System.Windows.Forms.RichTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.bSetRoomsNumber = new System.Windows.Forms.Button();
			this.nudRoomsNumber = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).BeginInit();
			this.tbArrivalDateEditPage.SuspendLayout();
			this.tpAddUser.SuspendLayout();
			this.tpEdit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRoomNumberEditTab)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidentsEditTab)).BeginInit();
			this.tpAboutHotel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRoomsNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// dtbBirthDate
			// 
			this.dtbBirthDate.Location = new System.Drawing.Point(9, 284);
			this.dtbBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtbBirthDate.MaxDate = new System.DateTime(2003, 3, 5, 0, 0, 0, 0);
			this.dtbBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtbBirthDate.Name = "dtbBirthDate";
			this.dtbBirthDate.Size = new System.Drawing.Size(200, 22);
			this.dtbBirthDate.TabIndex = 3;
			this.dtbBirthDate.Value = new System.DateTime(2003, 3, 5, 0, 0, 0, 0);
			// 
			// tbName
			// 
			this.tbName.ForeColor = System.Drawing.Color.Silver;
			this.tbName.Location = new System.Drawing.Point(9, 84);
			this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(119, 22);
			this.tbName.TabIndex = 4;
			this.tbName.Tag = "Имя";
			this.tbName.Text = "Имя";
			this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// tbSurname
			// 
			this.tbSurname.ForeColor = System.Drawing.Color.Silver;
			this.tbSurname.Location = new System.Drawing.Point(9, 112);
			this.tbSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(119, 22);
			this.tbSurname.TabIndex = 5;
			this.tbSurname.Tag = "Фамилия";
			this.tbSurname.Text = "Фамилия";
			this.tbSurname.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			this.tbSurname.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// tbGender
			// 
			this.tbGender.ForeColor = System.Drawing.Color.Silver;
			this.tbGender.Location = new System.Drawing.Point(9, 140);
			this.tbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbGender.Name = "tbGender";
			this.tbGender.Size = new System.Drawing.Size(119, 22);
			this.tbGender.TabIndex = 6;
			this.tbGender.Tag = "Гендер";
			this.tbGender.Text = "Гендер";
			this.tbGender.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			this.tbGender.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// mtbPassportSeries
			// 
			this.mtbPassportSeries.ForeColor = System.Drawing.Color.Silver;
			this.mtbPassportSeries.Location = new System.Drawing.Point(9, 167);
			this.mtbPassportSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mtbPassportSeries.Name = "mtbPassportSeries";
			this.mtbPassportSeries.Size = new System.Drawing.Size(119, 22);
			this.mtbPassportSeries.TabIndex = 7;
			this.mtbPassportSeries.Tag = "Серия паспорта";
			this.mtbPassportSeries.Text = "Серия паспорта";
			this.mtbPassportSeries.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
			this.mtbPassportSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
			this.mtbPassportSeries.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
			// 
			// mtbPassportNumber
			// 
			this.mtbPassportNumber.ForeColor = System.Drawing.Color.Silver;
			this.mtbPassportNumber.Location = new System.Drawing.Point(9, 196);
			this.mtbPassportNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mtbPassportNumber.Name = "mtbPassportNumber";
			this.mtbPassportNumber.Size = new System.Drawing.Size(119, 22);
			this.mtbPassportNumber.TabIndex = 8;
			this.mtbPassportNumber.Tag = "Номер паспорта";
			this.mtbPassportNumber.Text = "Номер паспорта";
			this.mtbPassportNumber.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
			this.mtbPassportNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
			this.mtbPassportNumber.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
			// 
			// mtbPhoneNumber
			// 
			this.mtbPhoneNumber.ForeColor = System.Drawing.Color.Silver;
			this.mtbPhoneNumber.Location = new System.Drawing.Point(9, 224);
			this.mtbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mtbPhoneNumber.Name = "mtbPhoneNumber";
			this.mtbPhoneNumber.Size = new System.Drawing.Size(119, 22);
			this.mtbPhoneNumber.TabIndex = 9;
			this.mtbPhoneNumber.Tag = "Номер телефона";
			this.mtbPhoneNumber.Text = "Номер телефона";
			this.mtbPhoneNumber.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
			this.mtbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
			this.mtbPhoneNumber.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
			// 
			// nudAmountOfResidents
			// 
			this.nudAmountOfResidents.Location = new System.Drawing.Point(405, 110);
			this.nudAmountOfResidents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
			this.nudAmountOfResidents.Size = new System.Drawing.Size(120, 22);
			this.nudAmountOfResidents.TabIndex = 12;
			this.nudAmountOfResidents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// dtpArrivalDate
			// 
			this.dtpArrivalDate.Location = new System.Drawing.Point(325, 135);
			this.dtpArrivalDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpArrivalDate.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
			this.dtpArrivalDate.Name = "dtpArrivalDate";
			this.dtpArrivalDate.Size = new System.Drawing.Size(200, 22);
			this.dtpArrivalDate.TabIndex = 13;
			this.dtpArrivalDate.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
			this.dtpArrivalDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
			// 
			// dtpDepartureDate
			// 
			this.dtpDepartureDate.Location = new System.Drawing.Point(325, 162);
			this.dtpDepartureDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDepartureDate.MinDate = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
			this.dtpDepartureDate.Name = "dtpDepartureDate";
			this.dtpDepartureDate.Size = new System.Drawing.Size(200, 22);
			this.dtpDepartureDate.TabIndex = 14;
			this.dtpDepartureDate.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
			this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
			// 
			// bSaveUser
			// 
			this.bSaveUser.Location = new System.Drawing.Point(523, 292);
			this.bSaveUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bSaveUser.Name = "bSaveUser";
			this.bSaveUser.Size = new System.Drawing.Size(105, 30);
			this.bSaveUser.TabIndex = 15;
			this.bSaveUser.Text = "Сохранить";
			this.bSaveUser.UseVisualStyleBackColor = true;
			this.bSaveUser.Click += new System.EventHandler(this.bSaveUser_Click);
			// 
			// cbWithChildren
			// 
			this.cbWithChildren.AutoSize = true;
			this.cbWithChildren.Location = new System.Drawing.Point(539, 108);
			this.cbWithChildren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbWithChildren.Name = "cbWithChildren";
			this.cbWithChildren.Size = new System.Drawing.Size(90, 21);
			this.cbWithChildren.TabIndex = 16;
			this.cbWithChildren.Text = "С детьми";
			this.cbWithChildren.UseVisualStyleBackColor = true;
			this.cbWithChildren.CheckedChanged += new System.EventHandler(this.cbWithChildren_CheckedChanged);
			// 
			// nudRoomNumber
			// 
			this.nudRoomNumber.Location = new System.Drawing.Point(405, 82);
			this.nudRoomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
			this.nudRoomNumber.Size = new System.Drawing.Size(120, 22);
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
			this.label1.Location = new System.Drawing.Point(5, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Личные данные";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(201, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 19;
			this.label2.Text = "О заселении";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(201, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 17);
			this.label3.TabIndex = 20;
			this.label3.Text = "Номер комнаты";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(201, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 17);
			this.label4.TabIndex = 21;
			this.label4.Text = "Количество заселяющихся";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 17);
			this.label5.TabIndex = 22;
			this.label5.Text = "Дата рождения";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(201, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 17);
			this.label6.TabIndex = 23;
			this.label6.Text = "Дата заселения";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(201, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 17);
			this.label7.TabIndex = 24;
			this.label7.Text = "Дата выселения";
			// 
			// tbArrivalDateEditPage
			// 
			this.tbArrivalDateEditPage.Controls.Add(this.tpAddUser);
			this.tbArrivalDateEditPage.Controls.Add(this.tpEdit);
			this.tbArrivalDateEditPage.Controls.Add(this.tpAboutHotel);
			this.tbArrivalDateEditPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbArrivalDateEditPage.Location = new System.Drawing.Point(0, 0);
			this.tbArrivalDateEditPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbArrivalDateEditPage.Name = "tbArrivalDateEditPage";
			this.tbArrivalDateEditPage.SelectedIndex = 0;
			this.tbArrivalDateEditPage.Size = new System.Drawing.Size(702, 433);
			this.tbArrivalDateEditPage.TabIndex = 25;
			// 
			// tpAddUser
			// 
			this.tpAddUser.Controls.Add(this.label15);
			this.tpAddUser.Controls.Add(this.label1);
			this.tpAddUser.Controls.Add(this.label7);
			this.tpAddUser.Controls.Add(this.dtbBirthDate);
			this.tpAddUser.Controls.Add(this.label6);
			this.tpAddUser.Controls.Add(this.tbName);
			this.tpAddUser.Controls.Add(this.label5);
			this.tpAddUser.Controls.Add(this.tbSurname);
			this.tpAddUser.Controls.Add(this.label4);
			this.tpAddUser.Controls.Add(this.tbGender);
			this.tpAddUser.Controls.Add(this.label3);
			this.tpAddUser.Controls.Add(this.mtbPassportSeries);
			this.tpAddUser.Controls.Add(this.label2);
			this.tpAddUser.Controls.Add(this.mtbPassportNumber);
			this.tpAddUser.Controls.Add(this.mtbPhoneNumber);
			this.tpAddUser.Controls.Add(this.nudRoomNumber);
			this.tpAddUser.Controls.Add(this.nudAmountOfResidents);
			this.tpAddUser.Controls.Add(this.cbWithChildren);
			this.tpAddUser.Controls.Add(this.dtpArrivalDate);
			this.tpAddUser.Controls.Add(this.bSaveUser);
			this.tpAddUser.Controls.Add(this.dtpDepartureDate);
			this.tpAddUser.Location = new System.Drawing.Point(4, 25);
			this.tpAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpAddUser.Name = "tpAddUser";
			this.tpAddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpAddUser.Size = new System.Drawing.Size(868, 546);
			this.tpAddUser.TabIndex = 0;
			this.tpAddUser.Text = "Добавить";
			this.tpAddUser.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(5, 2);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(310, 17);
			this.label15.TabIndex = 25;
			this.label15.Text = "Занесение нового постояльца в базу данных.";
			// 
			// tpEdit
			// 
			this.tpEdit.Controls.Add(this.cbChooseUser);
			this.tpEdit.Controls.Add(this.label16);
			this.tpEdit.Controls.Add(this.label8);
			this.tpEdit.Controls.Add(this.label9);
			this.tpEdit.Controls.Add(this.dtpBirthDateEditPage);
			this.tpEdit.Controls.Add(this.label10);
			this.tpEdit.Controls.Add(this.tbNameEditTab);
			this.tpEdit.Controls.Add(this.label11);
			this.tpEdit.Controls.Add(this.tbSurnameEditTab);
			this.tpEdit.Controls.Add(this.label12);
			this.tpEdit.Controls.Add(this.tbGenderEditTab);
			this.tpEdit.Controls.Add(this.label13);
			this.tpEdit.Controls.Add(this.mtbPassportSeriesEditTab);
			this.tpEdit.Controls.Add(this.label14);
			this.tpEdit.Controls.Add(this.mtbPassportNumberEditTab);
			this.tpEdit.Controls.Add(this.mtbPhoneNumberEditTab);
			this.tpEdit.Controls.Add(this.nudRoomNumberEditTab);
			this.tpEdit.Controls.Add(this.nudAmountOfResidentsEditTab);
			this.tpEdit.Controls.Add(this.cbWithChildrenEditTab);
			this.tpEdit.Controls.Add(this.dtpArrivalDateEditTab);
			this.tpEdit.Controls.Add(this.bSaveChanges);
			this.tpEdit.Controls.Add(this.dtpDepartureDateEditTab);
			this.tpEdit.Location = new System.Drawing.Point(4, 25);
			this.tpEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpEdit.Name = "tpEdit";
			this.tpEdit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpEdit.Size = new System.Drawing.Size(694, 404);
			this.tpEdit.TabIndex = 1;
			this.tpEdit.Text = "Редактировать";
			this.tpEdit.UseVisualStyleBackColor = true;
			// 
			// cbChooseUser
			// 
			this.cbChooseUser.FormattingEnabled = true;
			this.cbChooseUser.Location = new System.Drawing.Point(7, 37);
			this.cbChooseUser.Margin = new System.Windows.Forms.Padding(4);
			this.cbChooseUser.Name = "cbChooseUser";
			this.cbChooseUser.Size = new System.Drawing.Size(259, 24);
			this.cbChooseUser.TabIndex = 46;
			this.cbChooseUser.Text = "Выбор постояльца";
			this.cbChooseUser.SelectedValueChanged += new System.EventHandler(this.cbChooseUser_SelectedValueChanged);
			this.cbChooseUser.Click += new System.EventHandler(this.cbChooseUser_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(5, 2);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(238, 17);
			this.label16.TabIndex = 45;
			this.label16.Text = "Изменение существующей записи.";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 17);
			this.label8.TabIndex = 38;
			this.label8.Text = "Личные данные";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(207, 215);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 17);
			this.label9.TabIndex = 44;
			this.label9.Text = "Дата выселения";
			// 
			// dtpBirthDateEditPage
			// 
			this.dtpBirthDateEditPage.Location = new System.Drawing.Point(15, 331);
			this.dtpBirthDateEditPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpBirthDateEditPage.MaxDate = new System.DateTime(2003, 3, 5, 0, 0, 0, 0);
			this.dtpBirthDateEditPage.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtpBirthDateEditPage.Name = "dtpBirthDateEditPage";
			this.dtpBirthDateEditPage.Size = new System.Drawing.Size(200, 22);
			this.dtpBirthDateEditPage.TabIndex = 25;
			this.dtpBirthDateEditPage.Value = new System.DateTime(2003, 3, 5, 0, 0, 0, 0);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(207, 187);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(116, 17);
			this.label10.TabIndex = 43;
			this.label10.Text = "Дата заселения";
			// 
			// tbNameEditTab
			// 
			this.tbNameEditTab.ForeColor = System.Drawing.Color.Silver;
			this.tbNameEditTab.Location = new System.Drawing.Point(15, 132);
			this.tbNameEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbNameEditTab.Name = "tbNameEditTab";
			this.tbNameEditTab.ReadOnly = true;
			this.tbNameEditTab.Size = new System.Drawing.Size(119, 22);
			this.tbNameEditTab.TabIndex = 26;
			this.tbNameEditTab.Tag = "Имя";
			this.tbNameEditTab.Text = "Имя";
			this.tbNameEditTab.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbNameEditTab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			this.tbNameEditTab.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(11, 311);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(111, 17);
			this.label11.TabIndex = 42;
			this.label11.Text = "Дата рождения";
			// 
			// tbSurnameEditTab
			// 
			this.tbSurnameEditTab.ForeColor = System.Drawing.Color.Silver;
			this.tbSurnameEditTab.Location = new System.Drawing.Point(15, 160);
			this.tbSurnameEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbSurnameEditTab.Name = "tbSurnameEditTab";
			this.tbSurnameEditTab.ReadOnly = true;
			this.tbSurnameEditTab.Size = new System.Drawing.Size(119, 22);
			this.tbSurnameEditTab.TabIndex = 27;
			this.tbSurnameEditTab.Tag = "Фамилия";
			this.tbSurnameEditTab.Text = "Фамилия";
			this.tbSurnameEditTab.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbSurnameEditTab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			this.tbSurnameEditTab.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(207, 160);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(186, 17);
			this.label12.TabIndex = 41;
			this.label12.Text = "Количество заселяющихся";
			// 
			// tbGenderEditTab
			// 
			this.tbGenderEditTab.ForeColor = System.Drawing.Color.Silver;
			this.tbGenderEditTab.Location = new System.Drawing.Point(15, 187);
			this.tbGenderEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbGenderEditTab.Name = "tbGenderEditTab";
			this.tbGenderEditTab.Size = new System.Drawing.Size(119, 22);
			this.tbGenderEditTab.TabIndex = 28;
			this.tbGenderEditTab.Tag = "Гендер";
			this.tbGenderEditTab.Text = "Гендер";
			this.tbGenderEditTab.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbGenderEditTab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			this.tbGenderEditTab.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(207, 132);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(112, 17);
			this.label13.TabIndex = 40;
			this.label13.Text = "Номер комнаты";
			// 
			// mtbPassportSeriesEditTab
			// 
			this.mtbPassportSeriesEditTab.ForeColor = System.Drawing.Color.Silver;
			this.mtbPassportSeriesEditTab.Location = new System.Drawing.Point(15, 215);
			this.mtbPassportSeriesEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mtbPassportSeriesEditTab.Name = "mtbPassportSeriesEditTab";
			this.mtbPassportSeriesEditTab.ReadOnly = true;
			this.mtbPassportSeriesEditTab.Size = new System.Drawing.Size(119, 22);
			this.mtbPassportSeriesEditTab.TabIndex = 29;
			this.mtbPassportSeriesEditTab.Tag = "Серия паспорта";
			this.mtbPassportSeriesEditTab.Text = "Серия паспорта";
			this.mtbPassportSeriesEditTab.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
			this.mtbPassportSeriesEditTab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
			this.mtbPassportSeriesEditTab.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(207, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(93, 17);
			this.label14.TabIndex = 39;
			this.label14.Text = "О заселении";
			// 
			// mtbPassportNumberEditTab
			// 
			this.mtbPassportNumberEditTab.ForeColor = System.Drawing.Color.Silver;
			this.mtbPassportNumberEditTab.Location = new System.Drawing.Point(15, 244);
			this.mtbPassportNumberEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mtbPassportNumberEditTab.Name = "mtbPassportNumberEditTab";
			this.mtbPassportNumberEditTab.Size = new System.Drawing.Size(119, 22);
			this.mtbPassportNumberEditTab.TabIndex = 30;
			this.mtbPassportNumberEditTab.Tag = "Номер паспорта";
			this.mtbPassportNumberEditTab.Text = "Номер паспорта";
			this.mtbPassportNumberEditTab.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
			this.mtbPassportNumberEditTab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
			this.mtbPassportNumberEditTab.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
			// 
			// mtbPhoneNumberEditTab
			// 
			this.mtbPhoneNumberEditTab.ForeColor = System.Drawing.Color.Silver;
			this.mtbPhoneNumberEditTab.Location = new System.Drawing.Point(15, 272);
			this.mtbPhoneNumberEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mtbPhoneNumberEditTab.Name = "mtbPhoneNumberEditTab";
			this.mtbPhoneNumberEditTab.Size = new System.Drawing.Size(119, 22);
			this.mtbPhoneNumberEditTab.TabIndex = 31;
			this.mtbPhoneNumberEditTab.Tag = "Номер телефона";
			this.mtbPhoneNumberEditTab.Text = "Номер телефона";
			this.mtbPhoneNumberEditTab.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
			this.mtbPhoneNumberEditTab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
			this.mtbPhoneNumberEditTab.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
			// 
			// nudRoomNumberEditTab
			// 
			this.nudRoomNumberEditTab.Location = new System.Drawing.Point(411, 129);
			this.nudRoomNumberEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudRoomNumberEditTab.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
			this.nudRoomNumberEditTab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudRoomNumberEditTab.Name = "nudRoomNumberEditTab";
			this.nudRoomNumberEditTab.Size = new System.Drawing.Size(120, 22);
			this.nudRoomNumberEditTab.TabIndex = 37;
			this.nudRoomNumberEditTab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nudAmountOfResidentsEditTab
			// 
			this.nudAmountOfResidentsEditTab.Location = new System.Drawing.Point(411, 158);
			this.nudAmountOfResidentsEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudAmountOfResidentsEditTab.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudAmountOfResidentsEditTab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudAmountOfResidentsEditTab.Name = "nudAmountOfResidentsEditTab";
			this.nudAmountOfResidentsEditTab.Size = new System.Drawing.Size(120, 22);
			this.nudAmountOfResidentsEditTab.TabIndex = 32;
			this.nudAmountOfResidentsEditTab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cbWithChildrenEditTab
			// 
			this.cbWithChildrenEditTab.AutoSize = true;
			this.cbWithChildrenEditTab.Location = new System.Drawing.Point(544, 155);
			this.cbWithChildrenEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbWithChildrenEditTab.Name = "cbWithChildrenEditTab";
			this.cbWithChildrenEditTab.Size = new System.Drawing.Size(90, 21);
			this.cbWithChildrenEditTab.TabIndex = 36;
			this.cbWithChildrenEditTab.Text = "С детьми";
			this.cbWithChildrenEditTab.UseVisualStyleBackColor = true;
			// 
			// dtpArrivalDateEditTab
			// 
			this.dtpArrivalDateEditTab.Location = new System.Drawing.Point(331, 182);
			this.dtpArrivalDateEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpArrivalDateEditTab.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
			this.dtpArrivalDateEditTab.Name = "dtpArrivalDateEditTab";
			this.dtpArrivalDateEditTab.Size = new System.Drawing.Size(200, 22);
			this.dtpArrivalDateEditTab.TabIndex = 33;
			this.dtpArrivalDateEditTab.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
			this.dtpArrivalDateEditTab.ValueChanged += new System.EventHandler(this.dtpArrivalDateEditTab_ValueChanged);
			// 
			// bSaveChanges
			// 
			this.bSaveChanges.Location = new System.Drawing.Point(528, 340);
			this.bSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bSaveChanges.Name = "bSaveChanges";
			this.bSaveChanges.Size = new System.Drawing.Size(105, 30);
			this.bSaveChanges.TabIndex = 35;
			this.bSaveChanges.Text = "Сохранить";
			this.bSaveChanges.UseVisualStyleBackColor = true;
			this.bSaveChanges.Click += new System.EventHandler(this.bSaveChanges_Click);
			// 
			// dtpDepartureDateEditTab
			// 
			this.dtpDepartureDateEditTab.Location = new System.Drawing.Point(331, 210);
			this.dtpDepartureDateEditTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDepartureDateEditTab.MinDate = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
			this.dtpDepartureDateEditTab.Name = "dtpDepartureDateEditTab";
			this.dtpDepartureDateEditTab.Size = new System.Drawing.Size(200, 22);
			this.dtpDepartureDateEditTab.TabIndex = 34;
			this.dtpDepartureDateEditTab.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
			this.dtpDepartureDateEditTab.ValueChanged += new System.EventHandler(this.dtpArrivalDateEditTab_ValueChanged);
			// 
			// tpAboutHotel
			// 
			this.tpAboutHotel.Controls.Add(this.rtbUnoccupiedRooms);
			this.tpAboutHotel.Controls.Add(this.label19);
			this.tpAboutHotel.Controls.Add(this.rtbOccupiedRooms);
			this.tpAboutHotel.Controls.Add(this.label18);
			this.tpAboutHotel.Controls.Add(this.bSetRoomsNumber);
			this.tpAboutHotel.Controls.Add(this.nudRoomsNumber);
			this.tpAboutHotel.Controls.Add(this.label17);
			this.tpAboutHotel.Location = new System.Drawing.Point(4, 25);
			this.tpAboutHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpAboutHotel.Name = "tpAboutHotel";
			this.tpAboutHotel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpAboutHotel.Size = new System.Drawing.Size(868, 546);
			this.tpAboutHotel.TabIndex = 2;
			this.tpAboutHotel.Text = "Об отеле";
			this.tpAboutHotel.UseVisualStyleBackColor = true;
			this.tpAboutHotel.Enter += new System.EventHandler(this.tpAboutHotel_Enter);
			// 
			// rtbUnoccupiedRooms
			// 
			this.rtbUnoccupiedRooms.Location = new System.Drawing.Point(15, 306);
			this.rtbUnoccupiedRooms.Margin = new System.Windows.Forms.Padding(4);
			this.rtbUnoccupiedRooms.Name = "rtbUnoccupiedRooms";
			this.rtbUnoccupiedRooms.ReadOnly = true;
			this.rtbUnoccupiedRooms.Size = new System.Drawing.Size(388, 127);
			this.rtbUnoccupiedRooms.TabIndex = 6;
			this.rtbUnoccupiedRooms.Text = "";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(11, 276);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(180, 17);
			this.label19.TabIndex = 5;
			this.label19.Text = "Список свободных комнат";
			// 
			// rtbOccupiedRooms
			// 
			this.rtbOccupiedRooms.Location = new System.Drawing.Point(15, 128);
			this.rtbOccupiedRooms.Margin = new System.Windows.Forms.Padding(4);
			this.rtbOccupiedRooms.Name = "rtbOccupiedRooms";
			this.rtbOccupiedRooms.ReadOnly = true;
			this.rtbOccupiedRooms.Size = new System.Drawing.Size(388, 127);
			this.rtbOccupiedRooms.TabIndex = 4;
			this.rtbOccupiedRooms.Text = "";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(11, 97);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(164, 17);
			this.label18.TabIndex = 3;
			this.label18.Text = "Список занятых комнат";
			// 
			// bSetRoomsNumber
			// 
			this.bSetRoomsNumber.Location = new System.Drawing.Point(304, 26);
			this.bSetRoomsNumber.Margin = new System.Windows.Forms.Padding(4);
			this.bSetRoomsNumber.Name = "bSetRoomsNumber";
			this.bSetRoomsNumber.Size = new System.Drawing.Size(100, 28);
			this.bSetRoomsNumber.TabIndex = 2;
			this.bSetRoomsNumber.Text = "Задать";
			this.bSetRoomsNumber.UseVisualStyleBackColor = true;
			this.bSetRoomsNumber.Click += new System.EventHandler(this.bSetRoomsNumber_Click);
			// 
			// nudRoomsNumber
			// 
			this.nudRoomsNumber.Location = new System.Drawing.Point(215, 30);
			this.nudRoomsNumber.Margin = new System.Windows.Forms.Padding(4);
			this.nudRoomsNumber.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudRoomsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudRoomsNumber.Name = "nudRoomsNumber";
			this.nudRoomsNumber.Size = new System.Drawing.Size(56, 22);
			this.nudRoomsNumber.TabIndex = 1;
			this.nudRoomsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(11, 32);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(191, 17);
			this.label17.TabIndex = 0;
			this.label17.Text = "Количество комнат в отеле";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 433);
			this.Controls.Add(this.tbArrivalDateEditPage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegisterForm";
			this.Text = "Форма регистрации";
			((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).EndInit();
			this.tbArrivalDateEditPage.ResumeLayout(false);
			this.tpAddUser.ResumeLayout(false);
			this.tpAddUser.PerformLayout();
			this.tpEdit.ResumeLayout(false);
			this.tpEdit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRoomNumberEditTab)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidentsEditTab)).EndInit();
			this.tpAboutHotel.ResumeLayout(false);
			this.tpAboutHotel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRoomsNumber)).EndInit();
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
        private System.Windows.Forms.TabControl tbArrivalDateEditPage;
        private System.Windows.Forms.TabPage tpAddUser;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.TabPage tpAboutHotel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthDateEditPage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNameEditTab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSurnameEditTab;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbGenderEditTab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtbPassportSeriesEditTab;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtbPassportNumberEditTab;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumberEditTab;
        private System.Windows.Forms.NumericUpDown nudRoomNumberEditTab;
        private System.Windows.Forms.NumericUpDown nudAmountOfResidentsEditTab;
        private System.Windows.Forms.CheckBox cbWithChildrenEditTab;
        private System.Windows.Forms.DateTimePicker dtpArrivalDateEditTab;
        private System.Windows.Forms.Button bSaveChanges;
        private System.Windows.Forms.DateTimePicker dtpDepartureDateEditTab;
        private System.Windows.Forms.ComboBox cbChooseUser;
        private System.Windows.Forms.Button bSetRoomsNumber;
        private System.Windows.Forms.NumericUpDown nudRoomsNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rtbUnoccupiedRooms;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox rtbOccupiedRooms;
        private System.Windows.Forms.Label label18;
    }
}

