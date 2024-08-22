using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid AddressId {  get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int TotalPrice { get; set; } 
        public bool Status { get; set; }

    }
}
