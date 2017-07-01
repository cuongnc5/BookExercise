using Castle.Windsor;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{

    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {          
            Bind(typeof(IUserBusiness)).To(typeof(UserBusiness));
            Bind(typeof(IRoleBusiness)).To(typeof(RoleBusiness));
            Bind(typeof(IBookBusiness)).To(typeof(BookBusiness));
            Bind(typeof(ICategoryBusiness)).To(typeof(CategoryBusiness));
            Bind(typeof(AuthorBusiness)).To(typeof(AuthorBusiness));
         
        }
    }

}
