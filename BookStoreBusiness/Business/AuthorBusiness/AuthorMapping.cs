using BookStoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness
{
    public class AuthorMapping
    {

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
                DelFlag=author.DelFlag
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
            var author = new Author
            {
                Id = authorViewModel.Id,
                Name = authorViewModel.Name,
                Cover = authorViewModel.Cover,
                Description = authorViewModel.Description,
                CreateTime = authorViewModel.CreateTime,
                LastUpdateTime = authorViewModel.LastUpdateTime,
                DelFlag=authorViewModel.DelFlag
            };

            return author;
        }
    }


}
