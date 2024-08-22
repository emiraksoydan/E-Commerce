using Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductAttribute
    {
        IResult AddProductAttribute(ProductAttributes productAttributes);
        IResult UpdateProductAttribute(ProductAttributes productAttributes);
        IResult DeleteProductAttribute(ProductAttributes productAttributes);

        IDataResult<ICollection<ProductAttributes>> GetAllProductAttribute();
        IDataResult<ProductAttributes> GetProductAttribute(Guid id);
    }
}
