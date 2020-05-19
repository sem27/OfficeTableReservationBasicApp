using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.Models
{
    [Table("Table")]
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public int OfficeId { get; set; }
        [ForeignKey(nameof(OfficeId))]
        public virtual Office Office { get; set; }
        public string Tischnummer { get; set; }
        public virtual ICollection<Reservation> ReservationList { get; set; }
    }
}
