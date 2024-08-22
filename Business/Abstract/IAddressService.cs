using Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IResult AddAddress(Address address);
        IResult UpdateAddress(Address address);
        IResult DeleteAddress(Address address);

        IDataResult<ICollection<Address>> GetAllAddress();
        IDataResult<Address> GetAddress(Guid id);
    }
}
