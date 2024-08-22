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
    public class OrderItemManager : IOrderItemService
    {
        IOrderItemDal _orderItemDal;

        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }

        public IResult AddOrderItem(OrderItem orderitem)
        {
            _orderItemDal.Add(orderitem);
            return new SuccessResult();

        }

        public IResult DeleteOrderItem(OrderItem orderitem)
        {
           _orderItemDal.Delete(orderitem);
            return new SuccessResult();

        }

        public IDataResult<ICollection<OrderItem>> GetAllOrderItem()
        {
            return new SuccessDataResult<ICollection<OrderItem>>(_orderItemDal.GetAll());
        }

        public IDataResult<OrderItem> GetOrderItem(Guid id)
        {
            return new SuccessDataResult<OrderItem>(_orderItemDal.Get(ord=>ord.Id == id));
        }

        public IResult UpdateOrderItem(OrderItem orderitem)
        {
            _orderItemDal.Update(orderitem);
            return new SuccessResult();
        }
    }
}
