using AutoMapper;
using OfficeTableReservationAPI.DataTransferObjects;
using OfficeTableReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Reservation, FullReservationDto>()
            .ForMember(dest => dest.OfficeName, opt => opt.MapFrom(src => src.Table.Office.Name))
            .ForMember(dest => dest.TableName, opt => opt.MapFrom(src => src.Table.Tischnummer));

            CreateMap<ReservationDto, Reservation>();
            CreateMap<Reservation, ReservationDto>();
            CreateMap<OfficeDto, Office>();
            CreateMap<Office, OfficeDto>();
            CreateMap<Table, TableDto>();
            CreateMap<TableDto, Table>();
        }
    }
}
