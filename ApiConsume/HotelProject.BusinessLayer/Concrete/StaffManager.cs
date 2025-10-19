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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffdal;

        public StaffManager(IStaffDal staffdal)
        {
            _staffdal = staffdal;
        }

        public void TDelete(Staff t)
        {
            _staffdal.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return _staffdal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staffdal.GetList();
        }

        public int TGetStaffCount()
        {
            return _staffdal.GetStaffCount();
        }

        public void TInsert(Staff t)
        {
            _staffdal.Insert(t);
        }

        public List<Staff> TLast4Staff()
        {
            return _staffdal.Last4Staff();
        }

        public void TUpdate(Staff t)
        {
            _staffdal.Update(t);
        }

        
    }
}
