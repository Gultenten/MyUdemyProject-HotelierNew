using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiConsume3.Models
{
    public class ApiMovieViewModel
    {
        public int Rank { get; set; }
        public string Title { get; set; }
        public string rating { get; set; }
        public string imdb_link { get; set; }
    }
}
