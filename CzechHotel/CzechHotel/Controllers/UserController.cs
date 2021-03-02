using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CzechHotel.Models;

namespace CzechHotel.Controllers
{
    class UserController
    {
        public UserController()
        { }

        public void Save(UserModel _user)
        { }

        List<UserModel> GetUsersData()
        {
            return null;
        }

        void SetNewUserData(string _genderName, DateTime _birthDate,
            int _passportSeries, string _phoneNumber, int _roomNumber,
            bool _withChildren, int _amountOfResidents, DateTime _arrivalDate,
            DateTime _departureDate)
        { }

        private class DBController
        {
            DBController()
            { }
        }
    }
}
