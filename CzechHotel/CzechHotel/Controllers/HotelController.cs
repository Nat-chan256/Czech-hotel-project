using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CzechHotel.Controllers
{
    class HotelController
    {
        private DBController DbController;

        private const string HOTEL_INFO_FILE_PATH = @"..\..\Database\HotelInfo.txt";

        public int OccupiedRoomsNumber { get { return DbController.GetOccupiedRoomsNumber(); } }

        private int roomsNumber;
        public int RoomsNumber {
            set
            {
                if (value < OccupiedRoomsNumber || value < DbController.GetOccupiedRoomsBiggestNum() || value <= 0) throw new Exception(); //Предотвращаем удаление комнат, в которых живут постояльцы в данный момент
                else
                {
                    roomsNumber = value;
                    SaveRoomsNumberToFile();
                }
            }

            get { return roomsNumber; }
        }


        public HotelController(DBController dbController)
        {
            DbController = dbController;
            ReadRoomsNumberFromFile();
        }


        //Геттеры
        public int GetOccupiedRoomsBiggestNum()
        {
            return DbController.GetOccupiedRoomsBiggestNum();
        }

        public List<int> GetOccupiedRoomsList()
        {
            return DbController.GetOccupiedRoomsList();
        }

        //Считывает количество комнат в отеле из файла
        //Если по каким-то причинам не удается установить значение из файла
        //то по умолчанию задается номер наибольшей из занятых комнат
        private void ReadRoomsNumberFromFile()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(HOTEL_INFO_FILE_PATH))
                {
                    int roomsNum = int.Parse(streamReader.ReadLine());
                    RoomsNumber = roomsNum;
                }
            }
            catch (Exception e)
            {
                int biggestNum = DbController.GetOccupiedRoomsBiggestNum();
                if (biggestNum == 0)
                    biggestNum = 1;
                RoomsNumber = biggestNum;
            }
        }

        private void SaveRoomsNumberToFile()
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(HOTEL_INFO_FILE_PATH, false, System.Text.Encoding.Default))
                {
                    streamWriter.WriteLine(RoomsNumber.ToString());
                }
            }
            catch (Exception e)
            {
            }
        }

        public int UnoccupiedRoomsNumber { get { return RoomsNumber - OccupiedRoomsNumber; } }

    }
}
