using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using RapidApiConsume3.Models;

namespace RapidApiConsume3.Controllers
{
    public class BookingController : Controller
    {
        public async Task<IActionResult> Index()
        {

			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?checkout_date=2026-02-01&filter_by_currency=EUR&order_by=popularity&dest_id=-1456928&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&locale=en-gb&dest_type=city&units=metric&include_adjacency=true&children_number=2&room_number=1&adults_number=2&page_number=0&checkin_date=2026-01-31"),
				Headers =
	{
		{ "x-rapidapi-key", "b6a2186dccmshc0f77fbb57fe6ddp14f507jsn35e94c157718" },
		{ "x-rapidapi-host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);

				return View(values.results.ToList());
			}

		}
		}
    }



