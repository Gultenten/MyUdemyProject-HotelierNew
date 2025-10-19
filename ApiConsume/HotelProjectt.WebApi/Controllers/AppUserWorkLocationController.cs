using HotelProjectt.BusinessLayer.Abstract;
using HotelProjectt.DataAccessLayer.Concrete;
using HotelProjectt.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProjectt.EntityLayer.Concrete;


namespace HotelProjectt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        public AppUserWorkLocationController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var values = _appUserService.TUserListWorkLocations();
            Context context = new Context();
            var values = context.Users.Include(x => x.workLocation).Select(y => new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                SurName = y.Surname,
                WorkLocationID = y.WorkLocationID,
                WorkLocationName = y.workLocation.WorkLocationName,
               City=y.Şehir,
               Country=y.Country,
               Gender=y.Gender,
               ImageUrl=y.ImageURL



            }).ToList();
            
            return Ok(values);

        }
    }
}
