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
    public class EfMessageCategorydAL : GenericRepostory<MessageCategory>, IMessageCategoryDal
    {
        public EfMessageCategorydAL(Context context) : base(context)
        {

        }

       
    
     
    }
}
