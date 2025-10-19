using HotelProjectt.DataAccessLayer.Abstract;
using HotelProjectt.DataAccessLayer.Concrete;
using HotelProjectt.DataAccessLayer.Repostories;
using HotelProjectt.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectt.DataAccessLayer.EntityFrameWork
{
    public class EfSendMessageDal : GenericRepostory<SendMessage>, ISendMessageDal
    {

        public EfSendMessageDal(Context context) : base(context)
        {

        }

        public int GetSendMessageCount()
        {
            var context = new Context();
            return context.sendMessages.Count();
        }
    }
}
