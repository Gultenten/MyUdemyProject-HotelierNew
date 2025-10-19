using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectt.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet ikon linki giriniz")]
        public string? ServiceIcon { get; set; }
        [Required(ErrorMessage ="Hizmet başlığı giriniz")]
        [StringLength(100,ErrorMessage ="En fazla 100 karakter veri girişi yapılabilir")]
        public string? Title { get; set; }
        public string Description { get; set; }
    }
}
