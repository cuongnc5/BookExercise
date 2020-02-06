using BookStoreEntity;
using BookStoreEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
    public class AuthorBusiness:IAuthorBusiness
    {
        private AuthorRepository mAuthorRepository;

        public AuthorBusiness()
        {
            IUnitOfWork iUnitOfWork = new UnitOfWork();
            mAuthorRepository = new AuthorRepository(iUnitOfWork);
        }
        public List<AuthorViewModel> GetAllAuthor()
        {
            List<AuthorViewModel> lstAuthorViewModel = mAuthorRepository.GetAll().Select(author => new AuthorViewModel
            {
                Id = author.Id,
                Name = author.Name,
                Cover = author.Cover,
                Description = author.Description,
                CreateTime = author.CreateTime,
                LastUpdateTime = author.LastUpdateTime,
                DelFlag = author.DelFlag
            }).Where(x=>x.DelFlag==false).OrderByDescending(x=>x.CreateTime).ToList();

            return lstAuthorViewModel;
        }

        public AuthorViewModel GetAuthorById(int authorId)
        {
            AuthorViewModel authorViewModel=null;
            Author author = mAuthorRepository.SingleOrDefault(authorId);
            if (author != null)
            {
                authorViewModel = MapToViewModel(author);
            }
            return authorViewModel;
        }

        public bool CreateAuthor(AuthorViewModel authorViewModel)
        {
            try
            {
                Author author = MapToEntity(authorViewModel);
                mAuthorRepository.Insert(author);
            }
            catch (Exception)
            {
                return false;               
            }
            return true;
          
        }

        public bool EditAuthor(AuthorViewModel authorViewModel)
        {
            try
            {
                Author author = MapToEntity(authorViewModel);
                mAuthorRepository.Update(author);                
            }
            catch (Exception ex)
            {

                return false;
                throw ex;
                
            }
            return true;
            
        }

        public bool DeleteAuthor(int authorId)
        {
            try
            {
                Author author = mAuthorRepository.Single(authorId);
                int result = mAuthorRepository.Delete(author);
            }
            catch (Exception)
            {
                return false;
              
            }

            return true;           
            
        }

        /// <summary>
        /// Mapping data from Author object to AuthorViewModel object
        /// </summary>
        /// <param name="author">the Author object get from LibraryEntity.Author</param>
        /// <returns>AuthorViewModel object</returns>
        public static AuthorViewModel MapToViewModel(Author author)
        {
            var authorViewModel = new AuthorViewModel
            {
                Id = author.Id,
                Name = author.Name,
                Cover = author.Cover,
                Description = author.Description,
                CreateTime = author.CreateTime,
                LastUpdateTime = author.LastUpdateTime,
                DelFlag = author.DelFlag
            };

            return authorViewModel;
        }

        /// <summary>
        /// Mapping data from AuthorViewModel object to Author object
        /// </summary>
        /// <param name="authorViewModel">then AuthorViewModel get from screen</param>
        /// <returns>Author object</returns>
        public static Author MapToEntity(AuthorViewModel authorViewModel)
        {
            Author author = new Author
            {
                Id = authorViewModel.Id,
                Name = authorViewModel.Name,
                Cover = authorViewModel.Cover,
                Description = authorViewModel.Description,
                CreateTime = authorViewModel.CreateTime,
                LastUpdateTime = authorViewModel.LastUpdateTime,
                DelFlag = authorViewModel.DelFlag
            };

            return author;
        }


        /// <summary>
        /// Get maxid from database
        /// </summary>
        /// <returns></returns>
        public int GetMaxId()
        {
            var lstAuthor = mAuthorRepository.GetAll();
            return lstAuthor!=null&&lstAuthor.Count() == 0 ? 0 : lstAuthor.Max(m => m.Id);
        }
    }
}
