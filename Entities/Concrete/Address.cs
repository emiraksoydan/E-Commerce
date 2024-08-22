using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Adres { get; set; }
        public string PostalCode { get; set; }



    }
}
