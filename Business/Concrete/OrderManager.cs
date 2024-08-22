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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult AddOrder(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult();
        }

        public IResult DeleteOrder(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult();

        }

        public IDataResult<ICollection<Order>> GetAllOrder()
        {
            return new SuccessDataResult<ICollection<Order>>(_orderDal.GetAll());
        }

        public IDataResult<Order> GetOrder(Guid id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(ord => ord.Id == id));
        }

        public IResult UpdateOrder(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult();

        }
    }
}
