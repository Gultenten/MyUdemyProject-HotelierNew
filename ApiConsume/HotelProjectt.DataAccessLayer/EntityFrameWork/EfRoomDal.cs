using HotelProjectt.DataAccessLayer.Abstract;
using HotelProjectt.DataAccessLayer.Concrete;
using HotelProjectt.DataAccessLayer.Repostories;
using HotelProjectt.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectt.DataAccessLayer.EntityFrameWork
{
    public class EfRoomDal:GenericRepostory<Room>,IRoomDal
    {
        public EfRoomDal(Context context):base (context)
        {

        }

        public int RoomCount()
        {
            var context = new Context();
            var value = context.Rooms.Count();
            return value;
        }
    }
}
