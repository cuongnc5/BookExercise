using System.Collections.Generic;

namespace BookStoreBusiness
{
    public interface IUserBusiness
    {
       /// <summary>
       /// Get all user
       /// </summary>
        /// <returns>List of UserViewModel</returns>
       List<UserViewModel> GetAllUser();

       /// <summary>
       /// Get User by Id
       /// </summary>
       /// <param name="userId">The UserId</param>
       /// <returns>UserViewModel object</returns>
       UserViewModel GetUserById(string userId);

       /// <summary>
       /// Create a user 
       /// </summary>
       /// <param name="userViewModel">UserViewModel object get from screen</param>
       /// <returns>True if success and vice versa</returns>
       bool CreateUser(UserViewModel userViewModel);

       /// <summary>
       /// Modify user
       /// </summary>
       /// <param name="userViewModel">UserViewModel object</param>
       /// <returns>True if success and vice versa</returns>
       bool EditUser(UserViewModel userViewModel);

       /// <summary>
       /// Delete a user
       /// </summary>
       /// <param name="userId">The userId</param>
       /// <returns>True if success and vice versa</returns>
       bool DeleteUser(string userId);
    }
}
