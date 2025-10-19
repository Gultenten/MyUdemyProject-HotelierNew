using HotelProjectt.BusinessLayer.Abstract;
using HotelProjectt.DataAccessLayer.Abstract;
using HotelProjectt.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectt.BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
        
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        void IGenericService<Guest>.TDelete(Guest t)
        {
            _guestDal.Delete(t);
        }

        Guest IGenericService<Guest>.TGetByID(int id)
        {
            return _guestDal.GetByID(id);
        }

        List<Guest> IGenericService<Guest>.TGetList()
        {
            return _guestDal.GetList();
        }

        void IGenericService<Guest>.TInsert(Guest t)
        {
            _guestDal.Insert(t);
        }

        void IGenericService<Guest>.TUpdate(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
