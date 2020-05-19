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

namespace tableTableReservationAPI.Controllers
{
    [Route("api/table")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private ITableRepository _tableRepository;
        private IMapper _mapper;

        public TableController(ITableRepository tableRepository
            , IMapper mapper)
        {
            _tableRepository = tableRepository;
            _mapper = mapper;
        }

        // GET: api/table
        [Route("Get")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IEnumerable<Table> tables = _tableRepository.GetAllInOffice(id);
            var tablesResult = _mapper.Map<IEnumerable<TableDto>>(tables);
            return Ok(tablesResult);
        }
    }
}