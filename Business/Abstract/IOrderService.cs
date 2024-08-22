using Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IResult AddOrder(Order order);
        IResult UpdateOrder(Order order);
        IResult DeleteOrder(Order order);

        IDataResult<ICollection<Order>> GetAllOrder();
        IDataResult<Order> GetOrder(Guid id);
    }
}
