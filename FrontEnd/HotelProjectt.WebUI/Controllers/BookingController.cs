using HotelProjectt.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectt.WebUI.Controllers
{
    [AllowAnonymous]
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddBooking()
        {
            {
                return View();
            }

        }
        [HttpPost]
        public  async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            {
                createBookingDto.Status = "Onay Bekliyor";
                var client = _httpClientFactory.CreateClient();
                var jsondata = JsonConvert.SerializeObject(createBookingDto);
                StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
                await client.PostAsync("http://localhost:3423/api/Booking", stringContent);

                return RedirectToAction("Index", "Default");

            }
        }

        }
    }

