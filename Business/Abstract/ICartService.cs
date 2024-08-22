using Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService
    {
        IResult AddCart(Cart cart);
        IResult UpdateCart(Cart cart);
        IResult DeleteCart(Cart cart);

        IDataResult<Cart> GetCart(Guid id);
    }
}
