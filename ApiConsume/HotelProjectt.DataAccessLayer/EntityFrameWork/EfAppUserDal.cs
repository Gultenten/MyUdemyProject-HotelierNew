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
   public class EfAppUserDal : GenericRepostory<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {

        }

        public int AppUserCount()
        {
            var context = new Context();
            var value = context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWorkLocation()
        {
            var context = new Context();
            return context.Users.Include(x => x.workLocation).ToList();

        }

        List<AppUser> IAppUserDal.UserListWorkLocations()
        {
            var context = new Context();
            var values = context.Users.Include(x => x.workLocation).ToList();
            return values;
        }
    }
}
