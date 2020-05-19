using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.DataTransferObjects
{
    public class TableDto
    {
        public int? Id { get; set; }
        public int OfficeId { get; set; }
        public string Tischnummer { get; set; }
    }
}
