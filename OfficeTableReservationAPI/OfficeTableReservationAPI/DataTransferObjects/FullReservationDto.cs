using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.DataTransferObjects
{
    public class FullReservationDto
    {
        public int? Id { get; set; }
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string OfficeName { get; set; }
        public string Name { get; set; }
        public DateTime Datum_Reservierung { get; set; }
    }
}
