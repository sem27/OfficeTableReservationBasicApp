using OfficeTableReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.Repository
{
    public class OfficeRepository : IDataRepository<Office>
    {
        readonly DatabaseContext _databaseContext;
        public OfficeRepository(DatabaseContext context)
        {
            _databaseContext = context;
        }
        public bool Add(Office entity)
        {
            _databaseContext.Office.Add(entity);
            _databaseContext.SaveChanges();
            return true;
        }

        public void Delete(Office entity)
        {
            throw new NotImplementedException();
        }

        public Office Get(long id)
        {
            return _databaseContext.Office
                 .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Office> GetAll()
        {
            return _databaseContext.Office.ToList();
        }

        public void Update(Office dbEntity, Office entity)
        {
            throw new NotImplementedException();
        }
    }
}
