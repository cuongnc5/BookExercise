using System.Collections.Generic;

namespace BookStoreBusiness
{
    public interface IBookBusiness
    {
        /// <summary>
        /// Get all book
        /// </summary>
        /// <returns>List of BookViewModel</returns>
        List<BookViewModel> GetAll();

        /// <summary>
        /// Get Book by Id
        /// </summary>
        /// <param name="bookId">The bookId</param>
        /// <returns>BookViewModel object</returns>
        BookViewModel GetById(int bookId);
       
        /// <summary>
        /// Create a book 
        /// </summary>
        /// <param name="BookViewModel">BookViewModel object get from screen</param>
        /// <returns>True if success and vice versa</returns>
        bool Create(BookViewModel BookViewModel);

        /// <summary>
        /// Modify book
        /// </summary>
        /// <param name="BookViewModel">BookViewModel object</param>
        /// <returns>True if success and vice versa</returns>
        bool Edit(BookViewModel bookViewModel);

        /// <summary>
        /// Delete a book
        /// </summary>
        /// <param name="bookId">The bookId</param>
        /// <returns>True if success and vice versa</returns>
        bool Delete(int bookId);

       /// <summary>
       /// Get max id
       /// </summary>
       /// <returns></returns>
        int GetMaxId();

       /// <summary>
        /// The method Search book by searchkey, category, author, year
        /// </summary>
        /// <param name="searchKey">Search key = Name or Description</param>
        /// <param name="categoryId">Category selected value</param>
        /// <param name="authorId">Author selected value</param>
        /// <param name="year">year</param>
        /// <returns> List of BookViewModel</returns>
        List<BookViewModel> SearchBook(string searchKey, int categoryId, int authorId, int year);
    }
}
