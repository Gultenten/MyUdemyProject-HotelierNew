using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectt.WebUI.Dtos.FollowersDto
{
    public class ResultTwitterFollowersDto
    {
        public Data data { get; set; }


        public class Data
        {

            public Stats stats { get; set; }
        }

        public class Stats
        {
            public string following { get; set; }
            public string followers { get; set; }

        }
    }
}

