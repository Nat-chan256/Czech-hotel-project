using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CzechHotel.Models;

namespace CzechHotel.Controllers
{
    class UserController
    {
        private List<UserModel> users;
        public List<UserModel> Users 
        { 
            get 
            {
                if (users == null)
                    users = DbController.GetAllUsersData();
                return users; 
            } 
        }
        private DBController DbController;

        public UserController(DBController dbController)
        {
            DbController = dbController;
        }
        
        public List<UserModel> GetUsersData()
        {
            users = DbController.GetAllUsersData();
            return users;
        }

        void SetNewUserData(string _genderName, DateTime _birthDate,
           int _passportSeries, string _phoneNumber, int _roomNumber,
           bool _withChildren, int _amountOfResidents, DateTime _arrivalDate,
           DateTime _departureDate)
        { }

        public void CloseConnection()
        {
            DbController.CloseConnection();
        }

        // Проверяет совпадение паспортных данных пользователя user с паспортными данными одного из пользователей из списка Users
        private bool InUsersList(UserModel user)
        {
            foreach (UserModel userInList in Users)
                if (userInList.PassportSeries == user.PassportSeries && userInList.PassportNumber == user.PassportNumber)
                    return true;
            return false;
        }

        public void OpenConnection()
        {
            DbController.OpenConnection();
        }

        public void Save(UserModel user)
        {
            // Предотвращаем добавление уже существующего пользователя
            users = DbController.GetAllUsersData();
            if (InUsersList(user))
                return;

            DbController.SaveUser(user);
            users.Add(user);
        }
    }
}
