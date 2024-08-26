using Business.Abstract;
using Business.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WishListManager : IWishListService
    {
        IWishList _wishList;

        public WishListManager(IWishList wishList)
        {
            _wishList = wishList;
        }

        public IResult AddWishList(WishList wishitem)
        {
            _wishList.Add(wishitem);
            return new SuccessResult();

        }

        public IResult DeleteWishList(WishList wishitem)
        {
            _wishList.Delete(wishitem);
            return new SuccessResult();

        }

        public IDataResult<ICollection<WishList>> GetAllWishList()
        {
            return new SuccessDataResult<ICollection<WishList>>(_wishList.GetAll());
        }

        public IDataResult<ICollection<WishListDto>> GetAllWishListDto()
        {
            return new SuccessDataResult<ICollection<WishListDto>>(_wishList.GetAllWishListDto());
        }

        public IDataResult<WishList> GetWishList(Guid id)
        {
            return new SuccessDataResult<WishList>(_wishList.Get(w=>w.Id == id));
        }

        public IResult UpdateWishList(WishList wishitem)
        {
            _wishList.Update(wishitem);
            return new SuccessResult();
        }
    }
}
