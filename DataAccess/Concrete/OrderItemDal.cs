using Core.EfCore;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class OrderItemDal : EfEntityRepository<OrderItem, DbConnection>,IOrderItemDal
    {
        public OrderItemDal(DbConnection context) : base(context)
        {
        }
    }
}
