using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using RapidApiConsume3.Models;
using Newtonsoft.Json;

namespace RapidApiConsume3.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityname)
        {
            if (!string.IsNullOrEmpty(cityname))
            {
				List<BookingApiLocationSearchViewModel> model = new List<BookingApiLocationSearchViewModel>();

				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityname}&locale=en-gb"),
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
					model = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
					return View(model.Take(1).ToList());
				}

			}
            else
            {
				List<BookingApiLocationSearchViewModel> model = new List<BookingApiLocationSearchViewModel>();

				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=paris&locale=en-gb"),
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
					model = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
					return View(model.Take(1).ToList());
				}
			}
		}
    }
}
 