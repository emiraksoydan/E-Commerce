using Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartItemsService
    {
        IResult AddCartItem(CartItem cartitem);
        IResult UpdateCartItem(CartItem cartitem);
        IResult DeleteCartItem(CartItem cartitem);

        IDataResult<ICollection<CartItem>> GetAllCartItem();
        IDataResult<CartItem> GetCartItem(Guid id);

    }
}
