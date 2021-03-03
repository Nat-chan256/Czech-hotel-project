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
			this.cbRoomNumber = new System.Windows.Forms.ComboBox();
			this.nudAmountOfResidents = new System.Windows.Forms.NumericUpDown();
			this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
			this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
			this.bSaveUser = new System.Windows.Forms.Button();
			this.cbWithChildren = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidents)).BeginInit();
			this.SuspendLayout();
			// 
			// dtbBirthDate
			// 
			this.dtbBirthDate.Location = new System.Drawing.Point(13, 100);
			this.dtbBirthDate.Name = "dtbBirthDate";
			this.dtbBirthDate.Size = new System.Drawing.Size(200, 22);
			this.dtbBirthDate.TabIndex = 3;
			// 
			// tbName
			// 
			this.tbName.ForeColor = System.Drawing.Color.Silver;
			this.tbName.Location = new System.Drawing.Point(13, 13);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(117, 22);
			this.tbName.TabIndex = 4;
			this.tbName.Text = "Name";
			this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// tbSurname
			// 
			this.tbSurname.ForeColor = System.Drawing.Color.Silver;
			this.tbSurname.Location = new System.Drawing.Point(13, 42);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(117, 22);
			this.tbSurname.TabIndex = 5;
			this.tbSurname.Text = "Surname";
			this.tbSurname.Enter += new System.EventHandler(this.tbSurname_Enter);
			this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress);
			this.tbSurname.Leave += new System.EventHandler(this.tbSurname_Leave);
			// 
			// tbGender
			// 
			this.tbGender.ForeColor = System.Drawing.Color.Silver;
			this.tbGender.Location = new System.Drawing.Point(13, 71);
			this.tbGender.Name = "tbGender";
			this.tbGender.Size = new System.Drawing.Size(117, 22);
			this.tbGender.TabIndex = 6;
			this.tbGender.Text = "Gender";
			this.tbGender.Enter += new System.EventHandler(this.tbGender_Enter);
			this.tbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGender_KeyPress);
			this.tbGender.Leave += new System.EventHandler(this.tbGender_Leave);
			// 
			// mtbPassportSeries
			// 
			this.mtbPassportSeries.ForeColor = System.Drawing.Color.Silver;
			this.mtbPassportSeries.Location = new System.Drawing.Point(13, 129);
			this.mtbPassportSeries.Name = "mtbPassportSeries";
			this.mtbPassportSeries.Size = new System.Drawing.Size(117, 22);
			this.mtbPassportSeries.TabIndex = 7;
			this.mtbPassportSeries.Text = "Passport Series";
			this.mtbPassportSeries.Enter += new System.EventHandler(this.mtbPassportSeries_Enter);
			this.mtbPassportSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportSeries_KeyPress);
			this.mtbPassportSeries.Leave += new System.EventHandler(this.mtbPassportSeries_Leave);
			// 
			// mtbPassportNumber
			// 
			this.mtbPassportNumber.ForeColor = System.Drawing.Color.Silver;
			this.mtbPassportNumber.Location = new System.Drawing.Point(13, 158);
			this.mtbPassportNumber.Name = "mtbPassportNumber";
			this.mtbPassportNumber.Size = new System.Drawing.Size(117, 22);
			this.mtbPassportNumber.TabIndex = 8;
			this.mtbPassportNumber.Text = "Passport Number";
			this.mtbPassportNumber.Enter += new System.EventHandler(this.mtbPassportNumber_Enter);
			this.mtbPassportNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPassportNumber_KeyPress);
			this.mtbPassportNumber.Leave += new System.EventHandler(this.mtbPassportNumber_Leave);
			// 
			// mtbPhoneNumber
			// 
			this.mtbPhoneNumber.ForeColor = System.Drawing.Color.Silver;
			this.mtbPhoneNumber.Location = new System.Drawing.Point(13, 187);
			this.mtbPhoneNumber.Name = "mtbPhoneNumber";
			this.mtbPhoneNumber.Size = new System.Drawing.Size(117, 22);
			this.mtbPhoneNumber.TabIndex = 9;
			this.mtbPhoneNumber.Tag = "";
			this.mtbPhoneNumber.Text = "Phone Number";
			this.mtbPhoneNumber.Enter += new System.EventHandler(this.mtbPhoneNumber_Enter);
			this.mtbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPhoneNumber_KeyPress);
			this.mtbPhoneNumber.Leave += new System.EventHandler(this.mtbPhoneNumber_Leave);
			// 
			// cbRoomNumber
			// 
			this.cbRoomNumber.FormattingEnabled = true;
			this.cbRoomNumber.Location = new System.Drawing.Point(13, 216);
			this.cbRoomNumber.Name = "cbRoomNumber";
			this.cbRoomNumber.Size = new System.Drawing.Size(121, 24);
			this.cbRoomNumber.TabIndex = 10;
			// 
			// nudAmountOfResidents
			// 
			this.nudAmountOfResidents.Location = new System.Drawing.Point(13, 278);
			this.nudAmountOfResidents.Name = "nudAmountOfResidents";
			this.nudAmountOfResidents.Size = new System.Drawing.Size(120, 22);
			this.nudAmountOfResidents.TabIndex = 12;
			// 
			// dtpArrivalDate
			// 
			this.dtpArrivalDate.Location = new System.Drawing.Point(13, 307);
			this.dtpArrivalDate.Name = "dtpArrivalDate";
			this.dtpArrivalDate.Size = new System.Drawing.Size(200, 22);
			this.dtpArrivalDate.TabIndex = 13;
			// 
			// dtpDepartureDate
			// 
			this.dtpDepartureDate.Location = new System.Drawing.Point(13, 336);
			this.dtpDepartureDate.Name = "dtpDepartureDate";
			this.dtpDepartureDate.Size = new System.Drawing.Size(200, 22);
			this.dtpDepartureDate.TabIndex = 14;
			// 
			// bSaveUser
			// 
			this.bSaveUser.Location = new System.Drawing.Point(13, 365);
			this.bSaveUser.Name = "bSaveUser";
			this.bSaveUser.Size = new System.Drawing.Size(75, 23);
			this.bSaveUser.TabIndex = 15;
			this.bSaveUser.Text = "Save";
			this.bSaveUser.UseVisualStyleBackColor = true;
			// 
			// cbWithChildren
			// 
			this.cbWithChildren.AutoSize = true;
			this.cbWithChildren.Location = new System.Drawing.Point(13, 246);
			this.cbWithChildren.Name = "cbWithChildren";
			this.cbWithChildren.Size = new System.Drawing.Size(114, 21);
			this.cbWithChildren.TabIndex = 16;
			this.cbWithChildren.Text = "With Children";
			this.cbWithChildren.UseVisualStyleBackColor = true;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 433);
			this.Controls.Add(this.cbWithChildren);
			this.Controls.Add(this.bSaveUser);
			this.Controls.Add(this.dtpDepartureDate);
			this.Controls.Add(this.dtpArrivalDate);
			this.Controls.Add(this.nudAmountOfResidents);
			this.Controls.Add(this.cbRoomNumber);
			this.Controls.Add(this.mtbPhoneNumber);
			this.Controls.Add(this.mtbPassportNumber);
			this.Controls.Add(this.mtbPassportSeries);
			this.Controls.Add(this.tbGender);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.dtbBirthDate);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			((System.ComponentModel.ISupportInitialize)(this.nudAmountOfResidents)).EndInit();
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
		private System.Windows.Forms.ComboBox cbRoomNumber;
		private System.Windows.Forms.NumericUpDown nudAmountOfResidents;
		private System.Windows.Forms.DateTimePicker dtpArrivalDate;
		private System.Windows.Forms.DateTimePicker dtpDepartureDate;
		private System.Windows.Forms.Button bSaveUser;
		private System.Windows.Forms.CheckBox cbWithChildren;
	}
}

