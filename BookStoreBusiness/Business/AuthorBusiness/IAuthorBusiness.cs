using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
   public interface IAuthorBusiness
    {
        /// <summary>
        /// Get all author
        /// </summary>
        /// <returns>List of AuthorViewModel</returns>
        List<AuthorViewModel> GetAllAuthor();

        /// <summary>
        /// Get author by Id
        /// </summary>
        /// <param name="authorId">The authorId</param>
        /// <returns>AuthorViewModel object</returns>
        AuthorViewModel GetAuthorById(int authorId);

        /// <summary>
        /// Create a author 
        /// </summary>
        /// <param name="AuthorViewModel">AuthorViewModel object get from screen</param>
        /// <returns>True if success and vice versa</returns>
        bool CreateAuthor(AuthorViewModel AuthorViewModel);

        /// <summary>
        /// Modify author
        /// </summary>
        /// <param name="AuthorViewModel">AuthorViewModel object</param>
        /// <returns>True if success and vice versa</returns>
        bool EditAuthor(AuthorViewModel AuthorViewModel);

        /// <summary>
        /// Delete a author
        /// </summary>
        /// <param name="authorId">The authorId</param>
        /// <returns>True if success and vice versa</returns>
        bool DeleteAuthor(int authorId);

       /// <summary>
       /// Get maxId
       /// </summary>
       /// <returns></returns>
        int GetMaxId();
    }
}
