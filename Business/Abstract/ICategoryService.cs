using Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult AddCategory(Categories category);
        IResult UpdateCategory(Categories category);
        IResult DeleteCategory(Categories category);

        IDataResult<ICollection<Categories>> GetAllCategory();
        IDataResult<Categories> GetCategory(Guid id);
    }
}
