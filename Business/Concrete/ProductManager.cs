using Business.Abstract;
using Business.Results;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidation))]
        public IResult AddProduct(Product product)
        {  
            _productDal.Add(product);
            return new SuccessResult();
        }

        public IResult DeleteProduct(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult();

        }

        public IDataResult<ICollection<Product>> GetAllProducts()
        {
            return new SuccessDataResult<ICollection<Product>>(_productDal.GetAll());

        }

        public IDataResult<Product> GetProduct(Guid id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id));
        }

        public IResult UpdateProduct(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
        }
    }
}
