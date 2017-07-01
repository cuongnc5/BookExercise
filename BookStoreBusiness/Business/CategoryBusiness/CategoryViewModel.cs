using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
   public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public Nullable<bool> DelFlag { get; set; }
    }
}
