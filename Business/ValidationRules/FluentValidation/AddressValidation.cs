using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation()
        {
            RuleFor(ad=>ad.Adres).NotEmpty().WithMessage("Adres is required");
            RuleFor(ad => ad.City).NotEmpty().WithMessage("City is required");
            RuleFor(ad => ad.PostalCode).Matches(@"^\d{5}(-\d{4})?$").WithMessage("Invalid ZIP code.");
            RuleFor(ad => ad.District).NotEmpty().WithMessage("District is required");
            RuleFor(ad => ad.Country).NotEmpty().WithMessage("Country is required");
        }
    }
}
