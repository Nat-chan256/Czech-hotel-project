using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CzechHotel.Controllers;
using System.Collections.Generic;
using CzechHotel.Models;

namespace CzechHotelProjectTests
{
    [TestClass]
    public class DBControllerTest
    {
        private DBController dbController;

        [TestMethod]
        public void GetAllUsersFromDB()
        {
            InitializeDBController();

            //Получаем пользователей, которые уже есть в БД
            List<UserModel> allUsers = dbController.GetAllUsersData();

            //Добавляем в БД новых пользователей
            UserModel rebecca = new UserModel("Ребекка", "Уилсон", "Бигендер", new DateTime(1999, 4, 1), 3231, 789123, "19872322323", 17,
                false, 1, new DateTime(2021, 3, 19), new DateTime(2021, 3, 22));
            UserModel jessica = new UserModel("Джессика", "Миллер", "Женщина", new DateTime(1997, 5, 23), 3232, 786143, "198755566677", 24,
                false, 1, new DateTime(2021, 3, 17), new DateTime(2021, 3, 21));
            UserModel john = new UserModel("Джон", "Дэвис", "Мужчина", new DateTime(1988, 4, 4), 5111, 789023, "12325345334", 3,
                true, 4, new DateTime(2021, 3, 19), new DateTime(2021, 3, 25));

            dbController.SaveUser(rebecca);
            dbController.SaveUser(john);
            dbController.SaveUser(jessica);

            //Добавляем новых пользователей в ожидаемый список
            allUsers.Add(rebecca);
            allUsers.Add(john);
            allUsers.Add(jessica);

            //Ожидание : реальность
            Assert.AreEqual(allUsers, dbController.GetAllUsersData());

            dbController.CloseConnection();
        }

        //Вызывается в начале каждого тестового метода
        private void InitializeDBController()
        {
            dbController = new DBController();
            dbController.OpenConnection();
        }
    }
}
