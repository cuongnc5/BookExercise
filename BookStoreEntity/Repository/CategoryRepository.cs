using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreEntity.Repository
{
   public class CategoryRepository:BaseRepository<Category>
    {
        private readonly IUnitOfWork _workUnit;
        internal DbSet<Category> DbSet;
        public CategoryRepository(IUnitOfWork unit)
            : base(unit)
        {
            if (unit == null) throw new ArgumentNullException("unit");
            _workUnit = unit;
            DbSet = _workUnit.Db.Set<Category>();
        }
    }
}
