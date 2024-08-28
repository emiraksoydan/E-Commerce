using Business.Abstract;
using Business.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult AddCategory(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult();


        }

        public IDataResult<ICollection<Category>> GetAllCategory()
        {
            return new SuccessDataResult<ICollection<Category>>(_categoryDal.GetAll());

        }

        public IDataResult<Category> GetCategory(Guid id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(ctg => ctg.Id == id));
        }

        public IResult UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();

        }
    }
}
