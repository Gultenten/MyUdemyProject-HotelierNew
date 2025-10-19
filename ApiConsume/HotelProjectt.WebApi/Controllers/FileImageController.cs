using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        //public class FileUpload
        //{
        //    public IFormFile File { get; set; }
        //}
        //[Consumes("multipart/form-data")]

        [HttpPost]
        //[Consumes("multipart/form-data")]


        public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "images/" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
            return Created("", file);



            //if (file == null || file.Length == 0)
            //     return BadRequest("Dosya seçilmedi.");

            // var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            // var path = Path.Combine(Directory.GetCurrentDirectory(), "images", fileName);

            // using var stream = new FileStream(path, FileMode.Create);
            // await file.CopyToAsync(stream);

            // return Created("", new { fileName });
        }


    }
    }

