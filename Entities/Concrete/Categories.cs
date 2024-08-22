using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Categories : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
    }
}
