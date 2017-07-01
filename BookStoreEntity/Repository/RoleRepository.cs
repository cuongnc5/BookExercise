using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreEntity.Repository
{
   public class RoleRepository:BaseRepository<Role>
    {
        private readonly IUnitOfWork _workUnit;
        internal DbSet<Role> DbSet;
        public RoleRepository(IUnitOfWork unit)
            : base(unit)
        {
            if (unit == null) throw new ArgumentNullException("unit");
            _workUnit = unit;
            DbSet = _workUnit.Db.Set<Role>();
        }
    }
}
