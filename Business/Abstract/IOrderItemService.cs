using Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderItemService
    {
        IResult AddOrderItem(OrderItem orderitem);
        IResult UpdateOrderItem(OrderItem orderitem);
        IResult DeleteOrderItem(OrderItem orderitem);

        IDataResult<ICollection<OrderItem>> GetAllOrderItem();
        IDataResult<OrderItem> GetOrderItem(Guid id);
    }
}
