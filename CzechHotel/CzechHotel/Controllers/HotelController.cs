using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CzechHotel.Controllers
{
    class HotelController
    {
        private DBController DbController;

        public int OccupiedRoomsNumber { get { return DbController.GetOccupiedRoomsNumber(); } }

        private int roomsNumber;
        public int RoomsNumber {
            set
            {
                if (value < OccupiedRoomsNumber || value < DbController.GetOccupiedRoomsBiggestNum()) return; //Предотвращаем удаление комнат, в которых живут постояльцы в данный момент
                else roomsNumber = value;
            }

            get { return roomsNumber; }
        }

        public int UnoccupiedRoomsNumber { get { return RoomsNumber - OccupiedRoomsNumber; } }


        public HotelController(DBController dbController)
        {
            DbController = dbController;
            RoomsNumber = 80;
        }
    }
}
