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
        private List<UserModel> Users;
        private UserModel CurrentUser;
        private bool IsNewUser = true;
        private DBController DbController;

        public UserController()
        {
            DbController = new DBController();
        }
        
        List<UserModel> GetUsersData()
        {
            Users = DbController.GetAllUsersData();
            return Users;
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
            Users = DbController.GetAllUsersData();
            if (InUsersList(user))
                return;

            DbController.SaveUser(user);
        }


        private class DBController
        {
            private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CzechHotel.mdb;";
            private OleDbConnection connection;

            public DBController()
            {
                OpenConnection();
            }

            public List<UserModel> GetAllUsersData()
            {
                List<UserModel> result = new List<UserModel>();

                string query = "SELECT * FROM Users";

                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();

                //Отдельный запрос для дат
                string datesQuery = "SELECT FORMAT(BirthDate, 'yyyy/mm/dd'), FORMAT(ArrivalDate, 'yyyy/mm/dd'), FORMAT(DepartureDate, 'yyyy/mm/dd') FROM Users";

                OleDbCommand selectDatesCommand = new OleDbCommand(datesQuery, connection);

                OleDbDataReader datesReader = selectDatesCommand.ExecuteReader();


                //Перебираем записи в reader
                while (reader.Read())
                {
                    datesReader.Read();
                    try
                    {
                        bool withChildren = (int.Parse(reader[9].ToString()) == 0) ? false : true;
                        result.Add(new UserModel(reader[1].ToString(), /*name*/
                            reader[2].ToString(), /*surname*/
                            reader[3].ToString(), /*genderName*/
                            DateTime.Parse(datesReader[0].ToString()), /*birthDate*/
                            int.Parse(reader[5].ToString()), /*passportSeries*/
                            int.Parse(reader[6].ToString()), /*passportNumber*/
                            reader[7].ToString(), /*phoneNumber*/
                            int.Parse(reader[8].ToString()), /*roomNumber*/
                            withChildren, /*withChildren*/
                            int.Parse(reader[9].ToString()), /*amountOfResidents*/
                            DateTime.Parse(datesReader[1].ToString()), /*arrivalDate*/
                            DateTime.Parse(datesReader[2].ToString()))); /*departureDate*/

                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        continue;
                    }
                }

                reader.Close();

                return result;
            }

            public void CloseConnection()
            {
                connection.Close();
            }

            public void OpenConnection()
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
            }

            public void SaveUser(UserModel user)
            {
                string query = $"INSERT INTO Users (ClientName, ClientSurname, Gender, BirthDate, PassportSeries, PassportNumber, PhoneNumber, RoomNumber, WithChildren, " +
                    $"AmountOfResidents, ArrivalDate, DepartureDate) VALUES('{user.Name}', '{user.Surname}', '{user.Gender.getName()}', '{user.BirthDate.ToString()}', " +
                    $"{user.PassportSeries}, {user.PassportNumber}, {user.PhoneNumber}, '{user.RoomNumber}',{Convert.ToInt32(user.WithChildren)}, {user.AmountOfResidents}, '{user.ArrivalDate.Date.ToString()}', " +
                    $"'{user.DepartureDate.Date.ToString()}')";

                OleDbCommand command = new OleDbCommand(query, connection);

                command.ExecuteNonQuery();
            }

           
        }
    }
}
