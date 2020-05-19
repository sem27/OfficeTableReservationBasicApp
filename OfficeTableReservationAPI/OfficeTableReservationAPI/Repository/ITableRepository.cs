using OfficeTableReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.Repository
{
    public interface ITableRepository : IDataRepository<Table>
    {
        IEnumerable<Table> GetAllInOffice(int officeId);
    }
}
