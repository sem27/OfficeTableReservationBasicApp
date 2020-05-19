using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeTableReservationAPI.DataTransferObjects;
using OfficeTableReservationAPI.Models;
using OfficeTableReservationAPI.Repository;

namespace OfficeTableReservationAPI.Controllers
{
    [Route("api/reservation")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private IDataRepository<Reservation> _reservationRepository;
        private IMapper _mapper;

        public ReservationController(IDataRepository<Reservation> reservationRepository
            , IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        // GET: api/reservation
        [HttpGet(Name = "Get")]
        public IActionResult Get()
        {
            IEnumerable<Reservation> reservations = _reservationRepository.GetAll();
            var reservationsResult = _mapper.Map<IEnumerable<FullReservationDto>>(reservations);
            return Ok(reservationsResult);
        }

        // POST: api/reservation
        [HttpPost]
        [Route("new")]
        public IActionResult New([FromBody] ReservationDto reservation)
        {
            if (reservation == null)
            {
                return BadRequest("Reservation ist null.");
            }

            try
            {
                var reservationEntity = _mapper.Map<Reservation>(reservation);
                if (_reservationRepository.Add(reservationEntity))
                {
                    var reservationResult = _mapper.Map<ReservationDto>(reservationEntity);
                    return Ok(reservationResult);
                }
                else
                    return BadRequest("Tisch bereits gebucht! Wählen Sie ein anderes Datum oder ein anderen Tisch aus!");
            }
            catch (Exception)
            {
                return BadRequest("Ein Fehler ist aufgetreten!");
            }
        }
    }
}