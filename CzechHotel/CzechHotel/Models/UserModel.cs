using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CzechHotel.Models
{
    class UserModel
    {
        public UserModel(string _name, string _surname, int _passportSeries, bool _withChildren)
        { }

        public UserModel(string _name, string _surname, string _genderName,
            DateTime _birthDate, int _passportSeries, int _passportNumber,
            string _phoneNumber, bool _withChildren, int _amountOfResidents,
            DateTime _arrivalDate, DateTime _departureDate)
        { }

        private class GenderModel
        {
            public GenderModel(string _name)
            { }
        }
    }
}
