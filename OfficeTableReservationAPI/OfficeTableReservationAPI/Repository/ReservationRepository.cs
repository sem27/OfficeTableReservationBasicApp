using Microsoft.EntityFrameworkCore.Storage;
using OfficeTableReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTableReservationAPI.Repository
{
    public class ReservationRepository : IDataRepository<Reservation>
    {
        readonly DatabaseContext _databaseContext;

        public ReservationRepository(DatabaseContext context)
        {
            _databaseContext = context;
        }
        public bool Add(Reservation entity)
        {
            var isTaken = _databaseContext.Reservation.Where(x => x.Datum_Reservierung.Date == entity.Datum_Reservierung.Date && x.TableId == entity.TableId).Any();

            if(!isTaken)
            {
                _databaseContext.Reservation.Add(entity);
                _databaseContext.SaveChanges();
                return true;
            }

            return false;
        }

        public void Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation Get(long id)
        {
            return _databaseContext.Reservation
                 .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Reservation> GetAll()
        {
            return _databaseContext.Reservation.ToList();
        }

        public void Update(Reservation dbEntity, Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
