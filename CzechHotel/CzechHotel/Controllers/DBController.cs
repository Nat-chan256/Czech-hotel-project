using CzechHotel.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CzechHotel.Controllers
{
    class DBController
    {
        private static string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string pathToExe = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
        private static string pathToDB = pathToExe + "CzechHotel\\Database\\CzechHotel.mdb";
        private string connectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={pathToDB};";
        private OleDbConnection connection;


        //Геттеры
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
                        int.Parse(reader[10].ToString()), /*amountOfResidents*/
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

        public List<int> GetOccupiedRoomsList()
        {
            List<int> result = new List<int>();
            string query = $"SELECT RoomNumber FROM Users WHERE ArrivalDate < Now() And Now() < DepartureDate";
            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
                result.Add(int.Parse(reader[0].ToString()));

            reader.Close();

            return result;
        }

        //Возвращает наибольший номер комнаты из всех занятых комнат
        public int GetOccupiedRoomsBiggestNum()
        {
            string query = $"SELECT Max(RoomNumber) FROM Users WHERE ArrivalDate < Now() And Now() < DepartureDate";
            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            reader.Read();
            int result = 0;

            try
            {
                result = int.Parse(reader[0].ToString());
            }
            catch (Exception ex)
            {
                return result;
            }
            finally 
            {
                reader.Close();
            }


            return result;
        }

        //Возвращает количество занятых на данный момент номеров
        public int GetOccupiedRoomsNumber()
        {
            string query = $"SELECT Count(*) FROM Users WHERE ArrivalDate < Now() And Now() < DepartureDate";
            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            reader.Read();
            int result = int.Parse(reader[0].ToString());
            reader.Close();

            return result;
        }




        public void CloseConnection()
        {
            connection.Close();
        }

        //Удаление записей годовой и более давности
        private void DeleteOldRecords()
        {
            string query = "DELETE FROM Users WHERE DateDiff(\'d\', DepartureDate, Now()) >= 366";

            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }

        //Открытие соединения
        public void OpenConnection()
        {
            connection = new OleDbConnection(connectionString);
            connection.Open();

            //Удаление "устаревших" записей
            DeleteOldRecords();
        }

        public void SaveUser(UserModel user)
        {
            string query = $"INSERT INTO Users (ClientName, ClientSurname, Gender, BirthDate, PassportSeries, PassportNumber, PhoneNumber, RoomNumber, WithChildren, " +
                $"AmountOfResidents, ArrivalDate, DepartureDate) VALUES('{user.Name}', '{user.Surname}', '{user.Gender.Name}', '{user.BirthDate.ToString()}', " +
                $"{user.PassportSeries}, {user.PassportNumber}, {user.PhoneNumber}, '{user.RoomNumber}',{Convert.ToInt32(user.WithChildren)}, {user.AmountOfResidents}, '{user.ArrivalDate.Date.ToString()}', " +
                $"'{user.DepartureDate.Date.ToString()}')";

            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public void UpdateUser(UserModel user, string previousPassportNumber)
        {
            string query = $"UPDATE Users SET Gender = '{user.Gender.Name}', " +
                $"BirthDate = '{user.BirthDate.ToString()}', " +
                $"PassportNumber = {user.PassportNumber.ToString()}," +
                $"PhoneNumber = '{user.PhoneNumber}', " +
                $"RoomNumber = {user.RoomNumber.ToString()}, " +
                $"WithChildren = {Convert.ToInt32(user.WithChildren).ToString()}," +
                $"AmountOfResidents = {user.AmountOfResidents.ToString()}," +
                $"ArrivalDate = '{user.ArrivalDate.ToString()}'," +
                $"DepartureDate = '{user.DepartureDate.ToString()}' " +
                $"WHERE PassportSeries = {user.PassportSeries} And " +
                $"PassportNumber = {int.Parse(previousPassportNumber)}";

            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }
    }
}