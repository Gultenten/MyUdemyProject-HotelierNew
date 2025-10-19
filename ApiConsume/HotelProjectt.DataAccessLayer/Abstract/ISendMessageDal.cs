using HotelProjectt.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectt.DataAccessLayer.Abstract
{
    public interface ISendMessageDal:IGenericDal<SendMessage>
    {
        public int GetSendMessageCount();
    }
}
