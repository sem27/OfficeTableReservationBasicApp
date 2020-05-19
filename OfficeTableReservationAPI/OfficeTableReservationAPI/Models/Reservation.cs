using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int TableId { get; set; }
        [ForeignKey(nameof(TableId))]
        public virtual Table Table { get; set; }
        public string Name { get; set; }
        public DateTime Datum_Reservierung { get; set; }
    }
}
