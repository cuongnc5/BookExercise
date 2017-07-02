using BookStoreEntity;
using BookStoreEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
    public class BookBusiness : IBookBusiness
    {
        private BookRepository mBookRepository;

        public BookBusiness()
        {
            IUnitOfWork iUnitOfWork = new UnitOfWork();
            mBookRepository = new BookRepository(iUnitOfWork);
        }


        public List<BookViewModel> GetAll()
        {
            List<BookViewModel> lstBookViewModel = mBookRepository.GetAll().Select(book => new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                CreateTime = book.CreateTime,
                Author = book.Author,
                Cover = book.Cover,
                Publisher = book.Publisher,
                Year = book.Year,
                LastUpdateTime = book.LastUpdateTime ?? DateTime.MinValue,
                Category=book.Category,
                DelFlag=book.DelFlag
            }).Where(book => book.DelFlag == false).OrderByDescending(x => x.CreateTime).ToList();

            return lstBookViewModel;
        }

        public BookViewModel GetById(int bookId)
        {
            BookViewModel bookViewModel = null;
            Book book = mBookRepository.SingleOrDefault(bookId);
            if (book != null)
            {
                bookViewModel = MapToViewModel(book);
            }
            return bookViewModel;
        }

        public bool Create(BookViewModel bookViewModel)
        {
            try
            {
                Book book = MapToEntity(bookViewModel);
                mBookRepository.Insert(book);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Edit(BookViewModel bookViewModel)
        {
            try
            {
                Book book = MapToEntity(bookViewModel);
                mBookRepository.Update(book);
            }
            catch (Exception)
            {

                return false;

            }
            return true;
        }

        public bool Delete(int bookId)
        {
            try
            {
                Book book = mBookRepository.Single(bookId);
                int result = mBookRepository.Delete(book);
            }
            catch (Exception)
            {
                return false;

            }

            return true;
        }

        /// <summary>
        /// Get maxid from database
        /// </summary>
        /// <returns></returns>
        public int GetMaxId()
        {
            var lstCategory = mBookRepository.GetAll();
            return lstCategory != null && lstCategory.Count() == 0 ? 0 : lstCategory.Max(m => m.Id);


        }

        /// <summary>
        /// The method Search book by searchkey, category, author, year
        /// </summary>
        /// <param name="searchKey">Search key = Name or Description</param>
        /// <param name="categoryId">Category selected value</param>
        /// <param name="authorId">Author selected value</param>
        /// <param name="year">year</param>
        /// <returns> List of BookViewModel</returns>
        public List<BookViewModel> SearchBook(string searchKey, int categoryId, int authorId, int year)
        {
            IEnumerable<BookViewModel> lstBookViewModel = mBookRepository.GetAll().Select(book => new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                CreateTime = book.CreateTime,
                Author = book.Author,
                Category=book.Category,
                Cover = book.Cover,
                Publisher = book.Publisher,
                Year = book.Year,
                LastUpdateTime = book.LastUpdateTime ?? DateTime.MinValue,
                DelFlag=book.DelFlag
            }).Where(book => book.DelFlag == false);

            //filter by key
            if (string.IsNullOrEmpty(searchKey.Trim()))
            {
                lstBookViewModel = lstBookViewModel.Where(x => x.Title.Contains(searchKey) || x.Description.Contains(searchKey));
            }

            //filter by category
            if (categoryId >0)
            {
                lstBookViewModel = lstBookViewModel.Where(x => x.Category == categoryId);
            }

            //filter by author
            if (authorId > 0)
            {
                lstBookViewModel = lstBookViewModel.Where(x => x.Author == authorId);
            }

            //filter by year
            if (year > 0)
            {
                lstBookViewModel = lstBookViewModel.Where(x => x.Year == year);
            }

            return lstBookViewModel.OrderByDescending(x => x.CreateTime).ToList();
        }

        /// <summary>
        /// Mapping data from Book object to BookViewModel object
        /// </summary>
        /// <param name="book">the Book object get from LibraryEntity.Book</param>
        /// <returns>BookViewModel object</returns>
        public BookViewModel MapToViewModel(Book book)
        {
            BookViewModel bookViewModel = new BookViewModel
             {
                 Id = book.Id,
                 Title = book.Title,
                 Author = book.Author,
                 Cover = book.Cover,
                 Description = book.Description,
                 Publisher = book.Publisher,
                 Year = book.Year,
                 CreateTime = book.CreateTime,
                 LastUpdateTime = book.LastUpdateTime,
                 Category = book.Category,
                 DelFlag = book.DelFlag
             };

            return bookViewModel;
        }

        /// <summary>
        /// Mapping data from BookViewModel object to Book object
        /// </summary>
        /// <param name="bookViewModel">then BookViewModel get from screen</param>
        /// <returns>Book object</returns>
        public Book MapToEntity(BookViewModel bookViewModel)
        {
            Book book = new Book
            {
                Id = bookViewModel.Id,
                Title = bookViewModel.Title,
                Author = bookViewModel.Author,
                Cover = bookViewModel.Cover,
                Description = bookViewModel.Description,
                Publisher = bookViewModel.Publisher,
                Year = bookViewModel.Year,
                CreateTime = bookViewModel.CreateTime,
                LastUpdateTime = bookViewModel.LastUpdateTime,
                Category = bookViewModel.Category,
                DelFlag = bookViewModel.DelFlag
            };

            return book;
        }
    }
}
