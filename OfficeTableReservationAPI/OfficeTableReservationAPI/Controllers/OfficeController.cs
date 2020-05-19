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
    [Route("api/office")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private IDataRepository<Office> _officeRepository;
        private IMapper _mapper;

        public OfficeController(IDataRepository<Office> officeRepository
            , IMapper mapper)
        {
            _officeRepository = officeRepository;
            _mapper = mapper;
        }

        // GET: api/office
        [HttpGet("{id}")]
        public IActionResult Get()
        {
            IEnumerable<Office> offices = _officeRepository.GetAll();
            var officesResult = _mapper.Map<IEnumerable<OfficeDto>>(offices);
            return Ok(officesResult);
        }
    }
}