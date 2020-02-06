using BookStoreEntity;
using BookStoreEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreBusiness
{
    public class CategoryBusiness:ICategoryBusiness
    {
        private CategoryRepository mCategoryRepository;

        public CategoryBusiness()
        {
            IUnitOfWork iUnitOfWork = new UnitOfWork();
            mCategoryRepository = new CategoryRepository(iUnitOfWork);
        }


        public List<CategoryViewModel> GetAll()
        {
            List<CategoryViewModel> lstAuthorViewModel = mCategoryRepository.GetAll().Select(category => new CategoryViewModel
            {
                Id = category.Id,
                Title = category.Title,                
                Description = category.Description,
                CreateTime = category.CreateTime??DateTime.MinValue,
                LastUpdateTime = category.LastUpdateTime??DateTime.MinValue,
                DelFlag = category.DelFlag
            }).Where(x => x.DelFlag == false).OrderByDescending(x => x.CreateTime).ToList();

            return lstAuthorViewModel;
        }

        public CategoryViewModel GetById(int categoryId)
        {
            CategoryViewModel categoryViewModel = null;
            Category category = mCategoryRepository.SingleOrDefault(categoryId);
            if (category != null)
            {
                categoryViewModel = MapToViewModel(category);
            }
            return categoryViewModel;
        }

        public bool Create(CategoryViewModel categoryViewModel)
        {
            try
            {
                Category category = MapToEntity(categoryViewModel);
                mCategoryRepository.Insert(category);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Edit(CategoryViewModel categoryViewModel)
        {
            try
            {
                Category category = MapToEntity(categoryViewModel);
                mCategoryRepository.Update(category);
            }
            catch (Exception ex)
            {

                return false;
                
            }
            return true;
        }

        public bool Delete(int categoryId)
        {
            try
            {
                Category category = mCategoryRepository.Single(categoryId);
                int result = mCategoryRepository.Delete(category);
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
            var lstCategory = mCategoryRepository.GetAll();
            return lstCategory != null && lstCategory.Count() == 0 ? 0 : lstCategory.Max(m => m.Id);


        }


        /// <summary>
        /// Mapping data from Category object to CategoryViewModel object
        /// </summary>
        /// <param name="category">the Category object get from LibraryEntity.Category</param>
        /// <returns>CategoryViewModel object</returns>
        public  CategoryViewModel MapToViewModel(Category category)
        {
            var categoryViewModel = new CategoryViewModel
            {
                Id = category.Id,
                Title = category.Title,
                Description = category.Description,
                LastUpdateTime = category.LastUpdateTime??DateTime.MinValue,
                CreateTime = category.CreateTime ?? DateTime.MinValue,
                DelFlag = category.DelFlag
            };

            return categoryViewModel;
        }

        /// <summary>
        /// Mapping data from CategoryViewModel object to Category object 
        /// </summary>
        /// <param name="categoryViewModel">the Category object get from screen</param>
        /// <returns>Category object</returns>
        public  Category MapToEntity(CategoryViewModel categoryViewModel)
        {
            var category = new Category
            {
                Id = categoryViewModel.Id,
                Title = categoryViewModel.Title,
                Description = categoryViewModel.Description,
                LastUpdateTime = categoryViewModel.LastUpdateTime,
                CreateTime = categoryViewModel.CreateTime ,
                DelFlag = categoryViewModel.DelFlag
            };

            return category;
        }
    }
}
