using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto
{
    public class WishListDto : IDto
    {
        public string ProductName { get; set; }
        public string UserName { get; set; }
     

    }
}
