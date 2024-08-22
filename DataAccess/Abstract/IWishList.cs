using Core.EfCore;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IWishList : IEntityRepository<WishList>
    {
        ICollection<WishListDto> GetAllWishListDto();
    }
}
