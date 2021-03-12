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

        public void SetNewUserData(UserModel user, string genderName, DateTime birthDate,
           int passportNumber, string phoneNumber, int roomNumber,
           bool withChildren, int amountOfResidents, DateTime arrivalDate,
           DateTime departureDate)
        {
            string passNum = user.PassportNumber.ToString();
            user.Gender = new UserModel.GenderModel(genderName);
            user.BirthDate = birthDate;
            user.PassportNumber = passportNumber;
            user.PhoneNumber = phoneNumber;
            user.RoomNumber = roomNumber;
            user.WithChildren = withChildren;
            user.AmountOfResidents = amountOfResidents;
            user.ArrivalDate = arrivalDate;
            user.DepartureDate = departureDate;
            DbController.UpdateUser(user, passNum);
        }

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
