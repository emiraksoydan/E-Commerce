using Business.Results;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWishListService
    {
        IResult AddWishList(WishList wishitem);
        IResult UpdateWishList(WishList wishitem);
        IResult DeleteWishList(WishList wishitem);

        IDataResult<ICollection<WishList>> GetAllWishList();
        IDataResult<ICollection<WishListDto>> GetAllWishListDto();

        IDataResult<WishList> GetWishList(Guid id);
    }
}
