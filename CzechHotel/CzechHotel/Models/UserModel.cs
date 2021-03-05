using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CzechHotel.Models
{
    class UserModel
    {
        public String Name { get; }
        public String Surname { get; }
        public GenderModel Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int PassportSeries { get; }
        public int PassportNumber { get; set; }
        public int Age { 
            get {
                DateTime now = DateTime.Today;
                int age = now.Year - BirthDate.Year;
                if (BirthDate > now.AddYears(-age)) age--;
                return age;
            } 
        }
        public String PhoneNumber { get; set; }
        public int RoomNumber { get; set; }
        public bool WithChildren { get; } = false;
        public int AmountOfResidents { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }

        public UserModel(string name, string surname, int passportSeries, bool withChildren)
        {
            Name = name;
            Surname = surname;
            PassportSeries = passportSeries;
            WithChildren = withChildren;
        }

        public UserModel(string name, string surname, string genderName,
            DateTime birthDate, int passportSeries, int passportNumber,
            string phoneNumber, bool withChildren, int amountOfResidents,
            DateTime arrivalDate, DateTime departureDate) 
            : this(name, surname, passportSeries, withChildren)
        {
            Gender = new GenderModel(genderName);
            BirthDate = birthDate;
            PassportNumber = passportNumber;
            PhoneNumber = phoneNumber;
            AmountOfResidents = amountOfResidents;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
        }

        public class GenderModel
        {
            private String Name { get; }
            public GenderModel(string name)
            {
                Name = name;
            }
        }
    }
}
