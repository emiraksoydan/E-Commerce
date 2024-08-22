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
    public class AddressManager : IAddressService
    {
        IAdressDal _adressDal;

        public AddressManager(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public IResult AddAddress(Address address)
        {
            _adressDal.Add(address);
            return new SuccessResult();
            
        }

        public IResult DeleteAddress(Address address)
        {
            _adressDal.Delete(address);
            return new SuccessResult();

        }

        public IDataResult<Address> GetAddress(Guid id)
        {
            return new SuccessDataResult<Address>(_adressDal.Get(adrd=>adrd.Id == id));
        }

        public IDataResult<ICollection<Address>> GetAllAddress()
        {
            return new SuccessDataResult<ICollection<Address>>(_adressDal.GetAll());
        }

        public IResult UpdateAddress(Address address)
        {
            _adressDal.Update(address);
            return new SuccessResult();
        }
    }
}
