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
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Name" && tbName.ForeColor == Color.Silver)
			{
                tbName.Text = "";
                tbName.ForeColor = Color.Black;
			}
        }

		private void tbName_Leave(object sender, EventArgs e)
		{
            if (tbName.Text == "")
            {
                tbName.Text = "Name";
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
            if (tbSurname.Text == "Surname" && tbSurname.ForeColor == Color.Silver)
            {
                tbSurname.Text = "";
                tbSurname.ForeColor = Color.Black;
            }
        }

		private void tbSurname_Leave(object sender, EventArgs e)
		{
            if (tbSurname.Text == "")
            {
                tbSurname.Text = "Surname";
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
            if (tbGender.Text == "Gender" && tbGender.ForeColor == Color.Silver)
            {
                tbGender.Text = "";
                tbGender.ForeColor = Color.Black;
            }
        }

		private void tbGender_Leave(object sender, EventArgs e)
		{
            if (tbGender.Text == "")
            {
                tbGender.Text = "Gender";
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
            if (mtbPassportSeries.Text == "Passport Series" && mtbPassportSeries.ForeColor == Color.Silver)
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
                mtbPassportSeries.Text = "Passport Series";
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
            if (mtbPassportNumber.Text == "Passport Number" && mtbPassportNumber.ForeColor == Color.Silver)
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
                mtbPassportNumber.Text = "Passport Number";
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
            if (mtbPhoneNumber.Text == "Phone Number" && mtbPhoneNumber.ForeColor == Color.Silver)
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
                mtbPhoneNumber.Text = "Phone Number";
                mtbPhoneNumber.ForeColor = Color.Silver;
                mtbPhoneNumber.PasswordChar = '\0';
            }
        }

		private void mtbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

		
	}
}
