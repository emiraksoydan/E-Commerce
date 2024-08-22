using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cart : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
