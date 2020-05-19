using OfficeTableReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.Repository
{
    public class TableRepository : ITableRepository
    {
        readonly DatabaseContext _databaseContext;
        public TableRepository(DatabaseContext context)
        {
            _databaseContext = context;
        }
        public bool Add(Table entity)
        {
            _databaseContext.Table.Add(entity);
            _databaseContext.SaveChanges();
            return true;
        }

        public void Delete(Table entity)
        {
            throw new NotImplementedException();
        }

        public Table Get(long id)
        {
            return _databaseContext.Table
                 .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Table> GetAll()
        {
            return _databaseContext.Table.ToList();
        }

        public void Update(Table dbEntity, Table entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Table> ITableRepository.GetAllInOffice(int officeId)
        {
            return _databaseContext.Table.Where(x => x.OfficeId == officeId).ToList();
        }
    }
}
