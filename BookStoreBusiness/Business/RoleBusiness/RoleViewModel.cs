using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
   public class RoleViewModel
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public Nullable<bool> DelFlag { get; set; }
    }
}
