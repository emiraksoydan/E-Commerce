using Core.EfCore;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductDal : EfEntityRepository<Product,DbConnection>,IProductDal
    {
        public ProductDal(DbConnection context) : base(context)
        {
        }
    }
}
