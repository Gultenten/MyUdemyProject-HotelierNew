using HotelProjectt.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {

        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

    //    [HttpGet]
    //    public IActionResult UserListWithWorkLocation() olması gereken isim
    ////public IActionResult AppUserListWithWorkLocation()
    //    {
    //        var values = _appUserService.TUserListWorkLocation();
    //        return Ok(values);
    //    }

        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUserService.TGetList();
            return Ok(values);

        }
    }
}
