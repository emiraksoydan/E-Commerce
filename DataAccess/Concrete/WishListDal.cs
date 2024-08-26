using Core.EfCore;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class WishListDal : EfEntityRepository<WishList, DbConnection>, IWishList
    {
        public WishListDal(DbConnection context) : base(context)
        {
        }
        public ICollection<WishListDto> GetAllWishListDto()
        {
            throw new NotImplementedException();
        }
    }
}
