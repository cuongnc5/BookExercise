using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
   public interface ICategoryBusiness
    {
        /// <summary>
        /// Get all category
        /// </summary>
        /// <returns>List of CategoryViewModel</returns>
        List<CategoryViewModel> GetAll();

        /// <summary>
        /// Get Category by Id
        /// </summary>
        /// <param name="categoryId">The CategoryId</param>
        /// <returns>CategoryViewModel object</returns>
        CategoryViewModel GetById(int categoryId);

        /// <summary>
        /// Create a category 
        /// </summary>
        /// <param name="categoryViewModel">CategoryViewModel object get from screen</param>
        /// <returns>True if success and vice versa</returns>
        bool Create(CategoryViewModel categoryViewModel);

        /// <summary>
        /// Modify category
        /// </summary>
        /// <param name="categoryViewModel">CategoryViewModel object</param>
        /// <returns>True if success and vice versa</returns>
        bool Edit(CategoryViewModel categoryViewModel);

        /// <summary>
        /// Delete a category
        /// </summary>
        /// <param name="categoryId">The categoryId</param>
        /// <returns>True if success and vice versa</returns>
        bool Delete(int categoryId);


        /// <summary>
        /// Get maxId
        /// </summary>
        /// <returns></returns>
        int GetMaxId();
    }
}
