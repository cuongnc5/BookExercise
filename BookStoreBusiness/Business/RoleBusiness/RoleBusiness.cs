using BookStoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
    public class RoleBusiness:IRoleBusiness
    {
        public List<RoleViewModel> GetAllRole()
        {
            throw new NotImplementedException();
        }

        public RoleViewModel GetRoleById(string roleId)
        {
            throw new NotImplementedException();
        }

        public bool CreateRole(RoleViewModel roleViewModel)
        {
            throw new NotImplementedException();
        }

        public bool EditRole(RoleViewModel roleViewModel)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRole(string roleId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mapping data from Role object to RoleViewModel object
        /// </summary>
        /// <param name="role">the Role object get from LibraryEntity.Role</param>
        /// <returns>RoleViewModel object</returns>
        public RoleViewModel MapToViewModel(Role role)
        {
            var roleViewModel = new RoleViewModel
            {
                Id = role.Id,
                RoleName = role.RoleName,
                DelFlag = role.DelFlag

            };

            return roleViewModel;
        }

        /// <summary>
        /// Mapping data from RoleViewModel object to Role object
        /// </summary>
        /// <param name="roleViewModel">the RoleViewModel object get from screen</param>
        /// <returns>Role object</returns>
        public Role MapToEntity(RoleViewModel roleViewModel)
        {
            var role = new Role
            {
                Id = roleViewModel.Id,
                RoleName = roleViewModel.RoleName,
                DelFlag = roleViewModel.DelFlag

            };

            return role;
        }
    }
}
