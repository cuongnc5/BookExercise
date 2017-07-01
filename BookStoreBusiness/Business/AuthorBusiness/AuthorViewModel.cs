using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
   public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
        public Nullable<bool> DelFlag { get; set; }
    }
}
