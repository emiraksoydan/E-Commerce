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
    public class CartDal : EfEntityRepository<Cart,DbConnection>,ICartDal
    {
        public CartDal(DbConnection context) : base(context)
        {
        }
    }
}
