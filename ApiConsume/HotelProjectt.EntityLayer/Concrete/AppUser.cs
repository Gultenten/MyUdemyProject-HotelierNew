using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectt.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Şehir { get; set; }
        public string ImageURL { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }

        public WorkLocation workLocation { get; set; }




    }
}
