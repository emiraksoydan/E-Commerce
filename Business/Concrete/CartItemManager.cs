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
    public class CartItemManager : ICartItemsService
    {
        ICartItem _cartItem;
        public CartItemManager(ICartItem cartItem)
        {
            _cartItem = cartItem;
        }

        public IResult AddCartItem(CartItem cartitem)
        {
            _cartItem.Add(cartitem);
            return new SuccessResult();
        }

        public IResult DeleteCartItem(CartItem cartitem)
        {
            _cartItem.Delete(cartitem);
            return new SuccessResult();


        }

        public IDataResult<ICollection<CartItem>> GetAllCartItem()
        {
            return new  SuccessDataResult<ICollection<CartItem>>(_cartItem.GetAll());

        }

        public IDataResult<CartItem> GetCartItem(Guid id)
        {
            return new SuccessDataResult<CartItem>(_cartItem.Get(crt=>crt.Id == id));
        }

        public IResult UpdateCartItem(CartItem cartitem)
        {
            _cartItem.Update(cartitem);
            return new SuccessResult();

        }
    }
}
