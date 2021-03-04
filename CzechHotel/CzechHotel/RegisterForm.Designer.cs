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
			((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// dtbBirthDate
			// 
			this.dtbBirthDate.Location = new System.Drawing.Point(15, 263);
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
			this.tbName.Location = new System.Drawing.Point(15, 47);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(118, 22);
			this.tbName.TabIndex = 4;
			this.tbName.Text = "Имя";
			this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// tbSurname
			// 
			this.tbSurname.ForeColor = System.Drawing.Color.Silver;
			this.tbSurname.Location = new System.Drawing.Point(15, 75);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(118, 22);
			this.tbSurname.TabIndex = 5;
			this.tbSurname.Text = "Фамилия";
			this.tbSurname.Enter += new System.EventHandler(this.tbSurname_Enter);
			this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress);
			this.tbSurname.Leave += new System.EventHandler(this.tbSurname_Leave);
			// 
			// tbGender
			// 
			this.tbGender.ForeColor = System.Drawing.Color.Silver;
			this.tbGender.Location = new System.Drawing.Point(15, 103);
			this.tbGender.Name = "tbGender";
			this.tbGender.Size = new System.Drawing.Size(118, 22);
			this.tbGender.TabIndex = 6;
			this.tbGender.Text = "Гендер";
			this.tbGender.Enter += new System.EventHandler(this.tbGender_Enter);
			this.tbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGender_KeyPress);
			this.tbGender.Leave += new System.EventHandler(this.tbGender_Leave);
			// 
			// mtbPassportSeries
			// 
			this.mtbPassportSeries.ForeColor = System.Drawing.Color.Silver;
			this.mtbPassportSeries.Location = new System.Drawing.Point(15, 131);
			this.mtbPassportSeries.Name = "mtbPassportSeries";
			this.mtbPassportSeries.Size = new System.Drawing.Size(118, 22);
			this.mtbPassportSeries.TabIndex = 7;
			this.mtbPassportSeries.Text = "Серия паспорта";
			this.mtbPassportSeries.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
			this.mtbPassportSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
			this.mtbPassportSeries.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
			// 
			// mtbPassportNumber
			// 
			this.mtbPassportNumber.ForeColor = System.Drawing.Color.Silver;
			this.mtbPassportNumber.Location = new System.Drawing.Point(15, 159);
			this.mtbPassportNumber.Name = "mtbPassportNumber";
			this.mtbPassportNumber.Size = new System.Drawing.Size(118, 22);
			this.mtbPassportNumber.TabIndex = 8;
			this.mtbPassportNumber.Text = "Номер паспорта";
			this.mtbPassportNumber.Enter += new System.EventHandler(this.mtbPassportNumber_Enter);
			this.mtbPassportNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportNumber_KeyPress);
			this.mtbPassportNumber.Leave += new System.EventHandler(this.mtbPassportNumber_Leave);
			// 
			// mtbPhoneNumber
			// 
			this.mtbPhoneNumber.ForeColor = System.Drawing.Color.Silver;
			this.mtbPhoneNumber.Location = new System.Drawing.Point(15, 187);
			this.mtbPhoneNumber.Name = "mtbPhoneNumber";
			this.mtbPhoneNumber.Size = new System.Drawing.Size(118, 22);
			this.mtbPhoneNumber.TabIndex = 9;
			this.mtbPhoneNumber.Tag = "";
			this.mtbPhoneNumber.Text = "Номер телефона";
			this.mtbPhoneNumber.Enter += new System.EventHandler(this.mtbPhoneNumber_Enter);
			this.mtbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPhoneNumber_KeyPress);
			this.mtbPhoneNumber.Leave += new System.EventHandler(this.mtbPhoneNumber_Leave);
			// 
			// nudAmountOfResidents
			// 
			this.nudAmountOfResidents.Location = new System.Drawing.Point(412, 73);
			this.nudAmountOfResidents.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudAmountOfResidents.Name = "nudAmountOfResidents";
			this.nudAmountOfResidents.Size = new System.Drawing.Size(120, 22);
			this.nudAmountOfResidents.TabIndex = 12;
			// 
			// dtpArrivalDate
			// 
			this.dtpArrivalDate.Location = new System.Drawing.Point(332, 98);
			this.dtpArrivalDate.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
			this.dtpArrivalDate.Name = "dtpArrivalDate";
			this.dtpArrivalDate.Size = new System.Drawing.Size(200, 22);
			this.dtpArrivalDate.TabIndex = 13;
			this.dtpArrivalDate.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
			this.dtpArrivalDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
			// 
			// dtpDepartureDate
			// 
			this.dtpDepartureDate.Location = new System.Drawing.Point(331, 126);
			this.dtpDepartureDate.MinDate = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
			this.dtpDepartureDate.Name = "dtpDepartureDate";
			this.dtpDepartureDate.Size = new System.Drawing.Size(200, 22);
			this.dtpDepartureDate.TabIndex = 14;
			this.dtpDepartureDate.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
			this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpDepartureDate_ValueChanged);
			// 
			// bSaveUser
			// 
			this.bSaveUser.Location = new System.Drawing.Point(529, 255);
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
			this.cbWithChildren.Location = new System.Drawing.Point(544, 71);
			this.cbWithChildren.Name = "cbWithChildren";
			this.cbWithChildren.Size = new System.Drawing.Size(90, 21);
			this.cbWithChildren.TabIndex = 16;
			this.cbWithChildren.Text = "С детьми";
			this.cbWithChildren.UseVisualStyleBackColor = true;
			// 
			// nudRoomNumber
			// 
			this.nudRoomNumber.Location = new System.Drawing.Point(412, 45);
			this.nudRoomNumber.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
			this.nudRoomNumber.Name = "nudRoomNumber";
			this.nudRoomNumber.Size = new System.Drawing.Size(120, 22);
			this.nudRoomNumber.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Личные данные";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(207, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 19;
			this.label2.Text = "О заселении";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(207, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 17);
			this.label3.TabIndex = 20;
			this.label3.Text = "Номер комнаты";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(207, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 17);
			this.label4.TabIndex = 21;
			this.label4.Text = "Количество заселяющихся";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 17);
			this.label5.TabIndex = 22;
			this.label5.Text = "Дата рождения";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(207, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 17);
			this.label6.TabIndex = 23;
			this.label6.Text = "Дата заселения";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(207, 131);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 17);
			this.label7.TabIndex = 24;
			this.label7.Text = "Дата выселения";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 293);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudRoomNumber);
			this.Controls.Add(this.cbWithChildren);
			this.Controls.Add(this.bSaveUser);
			this.Controls.Add(this.dtpDepartureDate);
			this.Controls.Add(this.dtpArrivalDate);
			this.Controls.Add(this.nudAmountOfResidents);
			this.Controls.Add(this.mtbPhoneNumber);
			this.Controls.Add(this.mtbPassportNumber);
			this.Controls.Add(this.mtbPassportSeries);
			this.Controls.Add(this.tbGender);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.dtbBirthDate);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegisterForm";
			this.Text = "Форма регистрации";
			((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}

