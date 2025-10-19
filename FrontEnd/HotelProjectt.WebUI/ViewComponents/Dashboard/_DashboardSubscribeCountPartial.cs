using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using HotelProjectt.WebUI.Dtos.FollowersDto;
using Newtonsoft.Json;

namespace HotelProjectt.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile-information-api.p.rapidapi.com/hepsiburada"),
                Headers =
    {
        { "x-rapidapi-key", "b6a2186dccmshc0f77fbb57fe6ddp14f507jsn35e94c157718" },
        { "x-rapidapi-host", "instagram-profile-information-api.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagramFollowersDtos.followers;
                ViewBag.v2 = resultInstagramFollowersDtos.following;
                // return View(resultInstagramFollowersDtos);apiden çekerken aşagıdaki viewi kapat
                return View();
           
            }
            //twitter kısmı
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/profile?username=gultenkarabayir"),
                Headers =
    {
        { "x-rapidapi-key", "b6a2186dccmshc0f77fbb57fe6ddp14f507jsn35e94c157718" },
        { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.v3 = resultTwitterFollowersDto.data.stats.followers.Count();
                ViewBag.v4 = resultTwitterFollowersDto.data.stats.following.Count();
            }
            return View();
        }
    }
}




