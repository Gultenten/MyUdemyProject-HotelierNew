using HotelProjectt.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectt.BusinessLayer.Abstract
{
  public  interface IAppUserService:IGenericService<AppUser>
    {
        List<AppUser> TUserListWorkLocation();

        List<AppUser> TUserListWorkLocations();
        int TAppUserCount();
    }
}
