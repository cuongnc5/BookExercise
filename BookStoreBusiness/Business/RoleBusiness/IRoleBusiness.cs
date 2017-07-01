using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
   public interface IRoleBusiness
    {
        /// <summary>
        /// Get all role of user
        /// </summary>
        /// <returns>List of RoleViewModel</returns>
        List<RoleViewModel> GetAllRole();

        /// <summary>
        /// Get Role by Id
        /// </summary>
        /// <param name="roleId">The RoleId</param>
        /// <returns>RoleViewModel object</returns>
        RoleViewModel GetRoleById(string roleId);

        /// <summary>
        /// Create a role of user 
        /// </summary>
        /// <param name="roleViewModel">RoleViewModel object get from screen</param>
        /// <returns>True if success and vice versa</returns>
        bool CreateRole(RoleViewModel roleViewModel);

        /// <summary>
        /// Modify user
        /// </summary>
        /// <param name="roleViewModel">RoleViewModel object</param>
        /// <returns>True if success and vice versa</returns>
        bool EditRole(RoleViewModel roleViewModel);

        /// <summary>
        /// Delete a role of user
        /// </summary>
        /// <param name="userId">The roleId</param>
        /// <returns>True if success and vice versa</returns>
        bool DeleteRole(string roleId);
    }
}
