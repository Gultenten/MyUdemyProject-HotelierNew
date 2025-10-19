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
 public  class EfStaffDal:GenericRepostory<Staff>,IStaffDal
    {
        public EfStaffDal(Context context):base (context)
        {

        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var value = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return value;
        }
    }
}
