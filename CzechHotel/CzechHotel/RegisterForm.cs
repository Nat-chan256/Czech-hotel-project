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

        public RegisterForm()
        {
            InitializeComponent();
            dtbBirthDate.MinDate = DateTime.Now.AddYears(-125);
            dtbBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpArrivalDate.MinDate = DateTime.Now;
            dtpArrivalDate.MaxDate = DateTime.Now.AddMonths(1);
            dtpDepartureDate.MinDate = dtpArrivalDate.Value.AddDays(1);
            dtpDepartureDate.MaxDate = DateTime.Now.AddMonths(6);

            UsrController = new UserController();
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Имя" && tbName.ForeColor == Color.Silver)
            {
                tbName.Text = "";
                tbName.ForeColor = Color.Black;
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.Text = "Имя";
                tbName.ForeColor = Color.Silver;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void tbSurname_Enter(object sender, EventArgs e)
        {
            if (tbSurname.Text == "Фамилия" && tbSurname.ForeColor == Color.Silver)
            {
                tbSurname.Text = "";
                tbSurname.ForeColor = Color.Black;
            }
        }

        private void tbSurname_Leave(object sender, EventArgs e)
        {
            if (tbSurname.Text == "")
            {
                tbSurname.Text = "Фамилия";
                tbSurname.ForeColor = Color.Silver;
            }
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void tbGender_Enter(object sender, EventArgs e)
        {
            if (tbGender.Text == "Гендер" && tbGender.ForeColor == Color.Silver)
            {
                tbGender.Text = "";
                tbGender.ForeColor = Color.Black;
            }
        }

        private void tbGender_Leave(object sender, EventArgs e)
        {
            if (tbGender.Text == "")
            {
                tbGender.Text = "Гендер";
                tbGender.ForeColor = Color.Silver;
            }
        }

        private void tbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void mtbPassportSeries_Enter(object sender, EventArgs e)
        {
            if (mtbPassportSeries.Text == "Серия паспорта" && mtbPassportSeries.ForeColor == Color.Silver)
            {
                mtbPassportSeries.Text = "";
                mtbPassportSeries.ForeColor = Color.Black;
                mtbPassportSeries.PasswordChar = '*';
            }
        }

        private void mtbPassportSeries_Leave(object sender, EventArgs e)
        {
            if (mtbPassportSeries.Text == "")
            {
                mtbPassportSeries.Text = "Серия паспорта";
                mtbPassportSeries.ForeColor = Color.Silver;
                mtbPassportSeries.PasswordChar = '\0';
            }
        }

        private void mtbPassportSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void mtbPassportNumber_Enter(object sender, EventArgs e)
        {
            if (mtbPassportNumber.Text == "Номер паспорта" && mtbPassportNumber.ForeColor == Color.Silver)
            {
                mtbPassportNumber.Text = "";
                mtbPassportNumber.ForeColor = Color.Black;
                mtbPassportNumber.PasswordChar = '*';
            }
        }

        private void mtbPassportNumber_Leave(object sender, EventArgs e)
        {
            if (mtbPassportNumber.Text == "")
            {
                mtbPassportNumber.Text = "Номер паспорта";
                mtbPassportNumber.ForeColor = Color.Silver;
                mtbPassportNumber.PasswordChar = '\0';
            }
        }

        private void mtbPassportNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void mtbPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (mtbPhoneNumber.Text == "Номер телефона" && mtbPhoneNumber.ForeColor == Color.Silver)
            {
                mtbPhoneNumber.Text = "";
                mtbPhoneNumber.ForeColor = Color.Black;
                mtbPhoneNumber.PasswordChar = '*';
            }
        }

        private void mtbPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (mtbPhoneNumber.Text == "")
            {
                mtbPhoneNumber.Text = "Номер телефона";
                mtbPhoneNumber.ForeColor = Color.Silver;
                mtbPhoneNumber.PasswordChar = '\0';
            }
        }

        private void mtbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dtpArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpArrivalDate.Value >= dtpDepartureDate.Value)
                dtpDepartureDate.Value = dtpArrivalDate.Value.AddDays(1);
        }

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpArrivalDate.Value >= dtpDepartureDate.Value)
                dtpDepartureDate.Value = dtpArrivalDate.Value.AddDays(1);
        }


        private bool areAllFieldsFilled()
        {
            if (tbName.ForeColor != Color.Black || tbSurname.ForeColor != Color.Black || tbGender.ForeColor != Color.Black || mtbPassportSeries.ForeColor != Color.Black
                || mtbPassportNumber.ForeColor != Color.Black || mtbPhoneNumber.ForeColor != Color.Black)
                return false;
            return true;
        }


        private void bSaveUser_Click(object sender, EventArgs e)
		{
            //Проверка заполненности всех полей
            if (areAllFieldsFilled() == false)
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
	}
}
