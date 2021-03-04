using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CzechHotel
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            dtbBirthDate.MinDate = DateTime.Now.AddYears(-125);
            dtbBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpArrivalDate.MinDate = DateTime.Now;
            dtpArrivalDate.MaxDate = DateTime.Now.AddMonths(1);
            dtpDepartureDate.MinDate = dtpArrivalDate.Value.AddDays(1);
            dtpDepartureDate.MaxDate = DateTime.Now.AddMonths(6);
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

		private void bSaveUser_Click(object sender, EventArgs e)
		{

		}
	}
}
