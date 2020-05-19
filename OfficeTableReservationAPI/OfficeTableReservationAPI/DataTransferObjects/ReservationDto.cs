using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.DataTransferObjects
{
    public class ReservationDto
    {
        public int? Id { get; set; }
        public int TableId { get; set; }
        public string Name { get; set; }
        public DateTime? Datum_Reservierung { get; set; }
    }
}
