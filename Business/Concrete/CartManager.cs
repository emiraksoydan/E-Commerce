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
    public class CartManager : ICartService
    {
        ICartDal _cartDal;
        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public IResult AddCart(Cart cart)
        {
            _cartDal.Add(cart);
            return new SuccessResult();
        }

        public IResult DeleteCart(Cart cart)
        {
            _cartDal.Delete(cart);
            return new SuccessResult();

        }

        public IDataResult<Cart>  GetCart(Guid id)
        {
            return new SuccessDataResult<Cart>(_cartDal.Get(cr=>cr.Id == id));

        }

        public IResult UpdateCart(Cart cart)
        {
            _cartDal.Update(cart);
            return new SuccessResult();


        }
    }
}
