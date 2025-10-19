using AutoMapper;
using HotelProjectt.EntityLayer.Concrete;
using HotelProjectt.WebUI.Dtos.AboutDto;
using HotelProjectt.WebUI.Dtos.AppUserDto;
using HotelProjectt.WebUI.Dtos.BookingDto;
using HotelProjectt.WebUI.Dtos.GuestDto;
using HotelProjectt.WebUI.Dtos.LoginDto;
using HotelProjectt.WebUI.Dtos.RegisterDto;
using HotelProjectt.WebUI.Dtos.ServiceDto;
using HotelProjectt.WebUI.Dtos.StaffDto;
using HotelProjectt.WebUI.Dtos.SubscribeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectt.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
       public AutoMapperConfig()
        {
            {
                CreateMap<ResultServiceDto,Service>().ReverseMap();
                CreateMap<UpdateServiceDto,Service>().ReverseMap();
                CreateMap<CreateServiceDto,Service>().ReverseMap();

                CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
                CreateMap<LoginUserDto, AppUser>().ReverseMap();

                CreateMap<ResultAboutDto, About>().ReverseMap();
                CreateMap<UpdateAboutDto, About>().ReverseMap();

                CreateMap<ResultStaffDto, Staff>().ReverseMap();

                CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();


                CreateMap<CreateBookingDto, Booking>().ReverseMap();
                CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

                CreateMap<CreateGuestDto, Guest>().ReverseMap();
                CreateMap<UpdateGuestDto, Guest>().ReverseMap();

                CreateMap<ResultAppUserDto, AppUser>().ReverseMap();


            }
        }
    }
}
