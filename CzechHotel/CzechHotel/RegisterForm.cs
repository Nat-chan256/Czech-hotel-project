using CzechHotel.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CzechHotel.Models;

namespace CzechHotel
{
    public partial class RegisterForm : Form
    {
        UserController UsrController;
        HotelController HtlController;

        public RegisterForm()
        {
            InitializeComponent();

            //Вкладка "Добавить"
            dtbBirthDate.MinDate = DateTime.Now.AddYears(-125);
            dtbBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpArrivalDate.MinDate = DateTime.Now;
            dtpArrivalDate.MaxDate = DateTime.Now.AddMonths(1);
            dtpDepartureDate.MinDate = dtpArrivalDate.Value.AddDays(1);
            dtpDepartureDate.MaxDate = DateTime.Now.AddMonths(6);

            //Контроллеры
            DBController dbController = new DBController();
            UsrController = new UserController(dbController);
            UsrController.OpenConnection();
            HtlController = new HotelController(dbController);

            // Макс. номер комнаты
            nudRoomNumber.Maximum = HtlController.RoomsNumber;

            //Вкладка "Редактировать"
            FillUsersComboBox();
            //Вкладка "Об отеле"
            nudRoomsNumber.Minimum = HtlController.GetOccupiedRoomsBiggestNum();
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            TextBox tbName = (TextBox)sender;
            if (tbName.Text == (string)tbName.Tag && tbName.ForeColor == Color.Silver)
            {
                tbName.Text = "";
                tbName.ForeColor = Color.Black;
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            TextBox tbName = (TextBox)sender;
            if (tbName.Text == "")
            {
                tbName.Text = (string)tbName.Tag;
                tbName.ForeColor = Color.Silver;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void mtbPassportSeries_Enter(object sender, EventArgs e)
        {
            MaskedTextBox mtbPassportSeries = (MaskedTextBox)sender;
            if (mtbPassportSeries.Text == (string)mtbPassportSeries.Tag && mtbPassportSeries.ForeColor == Color.Silver)
            {
                mtbPassportSeries.Text = "";
                mtbPassportSeries.ForeColor = Color.Black;
                mtbPassportSeries.PasswordChar = '*';
            }
        }

        private void mtbPassportSeries_Leave(object sender, EventArgs e)
        {
            MaskedTextBox mtbPassportSeries = (MaskedTextBox)sender;
            if (mtbPassportSeries.Text == "")
            {
                mtbPassportSeries.Text = (string)mtbPassportSeries.Tag;
                mtbPassportSeries.ForeColor = Color.Silver;
                mtbPassportSeries.PasswordChar = '\0';
            }
        }

        private void mtbPassportSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dtpArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpArrivalDate.Value >= dtpDepartureDate.Value)
                dtpDepartureDate.Value = dtpArrivalDate.Value.AddDays(1);
        }
        
        //Проверяет, заполнены ли все поля на странице page
        private bool AreAllFieldsFilled(TabPage page)
        {
            foreach (Object child in page.Controls)
                if (child is TextBoxBase)
                {
                    if (((TextBoxBase)child).ForeColor != Color.Black)
                        return false;
                }
                
            return true;
        }


        private void bSaveUser_Click(object sender, EventArgs e)
		{
            //Проверка заполненности всех полей
            if (AreAllFieldsFilled(tpAddUser) == false)
            {
                MessageBox.Show("Не все поля заполнены.");
                return;
            }

            try
            {
                UsrController.Save(new UserModel(tbName.Text, tbSurname.Text, tbGender.Text, dtbBirthDate.Value,
                    int.Parse(mtbPassportSeries.Text), int.Parse(mtbPassportNumber.Text), mtbPhoneNumber.Text, (int)nudRoomNumber.Value,
                    cbWithChildren.Checked, (int)nudAmountOfResidents.Value, dtpArrivalDate.Value, dtpDepartureDate.Value));
                MessageBox.Show("Постоялец успешно сохранен в базу данных.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить пользователя в базу данных.");
            }
		}

        private void dtpArrivalDateEditTab_ValueChanged(object sender, EventArgs e)
        {
            if (dtpArrivalDateEditTab.Value >= dtpDepartureDateEditTab.Value)
                dtpDepartureDateEditTab.Value = dtpArrivalDateEditTab.Value.AddDays(1);
        }

        //Изменение выбранного в comboBox-е пользователя
        private void cbChooseUser_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] chosenUser = ((ComboBox)sender).SelectedItem.ToString().Split();
            List<UserModel> users = UsrController.Users;
            foreach (UserModel user in users)
                if (chosenUser[2] == user.PassportSeries.ToString() && chosenUser[3] == user.PassportNumber.ToString())
                    fillFieldsWithUserData(user);
        }


        //Заполнение полей вкладки "Редактировать" данными о пользователе user
        private void fillFieldsWithUserData(UserModel user)
        {
            //Задаеи значения полей
            tbNameEditTab.Text = user.Name;
            tbSurnameEditTab.Text = user.Surname;
            tbGenderEditTab.Text = user.Gender.Name;
            mtbPassportSeriesEditTab.Text = user.PassportSeries.ToString();
            mtbPassportNumberEditTab.Text = user.PassportNumber.ToString();
            mtbPhoneNumberEditTab.Text = user.PhoneNumber.ToString();
            dtpBirthDateEditPage.Value = user.BirthDate;
            nudRoomNumberEditTab.Value = user.RoomNumber;
            nudAmountOfResidentsEditTab.Value = user.AmountOfResidents;
            dtpArrivalDateEditTab.Value = user.ArrivalDate;
            dtpDepartureDateEditTab.Value = user.DepartureDate;
            cbWithChildrenEditTab.Checked = user.WithChildren;

            //Меняем цвет текста полей
            foreach (Object child in tpEdit.Controls)
                if (child is TextBox)
                    ((TextBox)child).ForeColor = Color.Black;
                else if (child is MaskedTextBox)
                    ((MaskedTextBox)child).ForeColor = Color.Black;
        }

        //Обновление содержимого ComboBox-а
        private void cbChooseUser_Click(object sender, EventArgs e)
        {
            FillUsersComboBox();
        }

        private void FillUsersComboBox()
        {
            cbChooseUser.Items.Clear();
            List<UserModel> users = UsrController.GetUsersData();
            foreach (UserModel user in users) //Заполняем комбобокс пользователями
            {
                cbChooseUser.Items.Add($"{user.Name} {user.Surname} {user.PassportSeries} {user.PassportNumber}");
            }
        }

        //Переход на вкладку "Об отеле"
        private void tpAboutHotel_Enter(object sender, EventArgs e)
        {
            //Количество комнат в отеле
            nudRoomsNumber.Minimum = HtlController.GetOccupiedRoomsBiggestNum();

            //Вывод списка занятых комнат
            UpdateRoomsListOutput();
        }

        //Обновление списков занятых и свободных комнат во вкладке "Об отеле"
        private void UpdateRoomsListOutput()
        {
            List<int> occupiedRooms = HtlController.GetOccupiedRoomsList();
            int roomsNum = HtlController.RoomsNumber;

            rtbOccupiedRooms.Clear();
            rtbUnoccupiedRooms.Clear();

            for (int i = 1; i <= roomsNum; ++i)
                if (occupiedRooms.Contains(i))
                    rtbOccupiedRooms.Text += $"{i} ";
                else
                    rtbUnoccupiedRooms.Text += $"{i} ";
        }

        private void bSetRoomsNumber_Click(object sender, EventArgs e)
        {
            HtlController.RoomsNumber = (int)nudRoomsNumber.Value;

            if (HtlController.RoomsNumber == (int)nudRoomsNumber.Value)
            {
                MessageBox.Show("Количество комнат успешно изменено.");
                UpdateRoomsListOutput();
            }
        }

        //Возвращает пользователя, выбранного через комбобокс во вкладке "Редактировать"
        private UserModel GetCurrentUserOnEditPage()
        {
            string[] chosenUser = cbChooseUser.SelectedItem.ToString().Split();
            List<UserModel> users = UsrController.Users;
            foreach (UserModel user in users)
                if (chosenUser[2] == user.PassportSeries.ToString() && chosenUser[3] == user.PassportNumber.ToString())
                    return user;
            return null;
        }

        private void bSaveChanges_Click(object sender, EventArgs e)
        {
            //Проверка заполненности всех полей
            if (AreAllFieldsFilled(tpEdit) == false)
            {
                MessageBox.Show("Не все поля заполнены.");
                return;
            }

            try
            {
                UserModel user = GetCurrentUserOnEditPage();
                UsrController.SetNewUserData(user, tbGenderEditTab.Text, dtpBirthDateEditPage.Value, 
                    int.Parse(mtbPassportNumberEditTab.Text), mtbPhoneNumberEditTab.Text, (int)nudRoomNumberEditTab.Value, 
                    cbWithChildrenEditTab.Checked, (int)nudAmountOfResidentsEditTab.Value, dtpArrivalDateEditTab.Value, 
                    dtpDepartureDateEditTab.Value);
                MessageBox.Show("Данные о постояльце успешно отредактированы.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось отредактировать данные о постольце.");
            }
        }

		private void cbWithChildren_CheckedChanged(object sender, EventArgs e)
		{
            if (cbWithChildren.Checked)
                nudAmountOfResidents.Minimum = 2;
            else
                nudAmountOfResidents.Minimum = 1;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UsrController.CloseConnection();
        }
    }
}