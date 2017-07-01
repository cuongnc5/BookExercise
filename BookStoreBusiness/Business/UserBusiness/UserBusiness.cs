using BookStoreEntity;
using BookStoreEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
    public class UserBusiness:IUserBusiness
    {
        private readonly UserRepository m_UserRepository;

        public UserBusiness()
        {
            IUnitOfWork iUnitOfWork = new UnitOfWork();
            m_UserRepository = new UserRepository(iUnitOfWork);
        }

        public List<UserViewModel> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetUserById(string userId)
        {
            User user = m_UserRepository.Single(userId);
            return user!=null?MapToViewModel(user):null;
        }

        public bool CreateUser(UserViewModel userViewModel)
        {
            throw new NotImplementedException();
        }

        public bool EditUser(UserViewModel userViewModel)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mapping data from User object to UserViewModel object
        /// </summary>
        /// <param name="user">the User object get from LibraryEntity.User</param>
        /// <returns>UserViewModel object</returns>
        public UserViewModel MapToViewModel(User user)
        {
            var userViewModel = new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = user.Role,
                DelFlag = user.DelFlag
            };

            return userViewModel;
        }

        /// <summary>
        /// Mapping data from AuthorViewModel object to User object
        /// </summary>
        /// <param name="userViewModel">then UserViewModel get from screen</param>
        /// <returns>Author object</returns>
        public User MapToEntity(UserViewModel userViewModel)
        {
            var user = new User
            {
                Id = userViewModel.Id,
                Email = userViewModel.Email,
                Password = userViewModel.Password,
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Role = userViewModel.Role,
                DelFlag = userViewModel.DelFlag
            };

            return user;
        }

    }
}
