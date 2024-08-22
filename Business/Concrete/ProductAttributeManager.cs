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
    public class ProductAttributeManager : IProductAttribute
    {
        IProductAttributeDal _productAttributeDal;

        public ProductAttributeManager(IProductAttributeDal productAttributeDal)
        {
            _productAttributeDal = productAttributeDal;
        }

        public IResult AddProductAttribute(ProductAttributes productAttributes)
        {
            _productAttributeDal.Add(productAttributes);
            return new SuccessResult();
        }

        public IResult DeleteProductAttribute(ProductAttributes productAttributes)
        {
            _productAttributeDal.Update(productAttributes);
            return new SuccessResult();


        }

        public IDataResult<ICollection<ProductAttributes>>  GetAllProductAttribute()
        {
            return new SuccessDataResult<ICollection<ProductAttributes>>(_productAttributeDal.GetAll());
        }

        public IDataResult<ProductAttributes> GetProductAttribute(Guid id)
        {
            return new SuccessDataResult<ProductAttributes>(_productAttributeDal.Get(pr=>pr.Id == id));  
        }

        public IResult UpdateProductAttribute(ProductAttributes productAttributes)
        {
            _productAttributeDal.Delete(productAttributes);
            return new SuccessResult();


        }
    }
}
