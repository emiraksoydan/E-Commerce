using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CartItemValidation : AbstractValidator<CartItem>
    {
        public CartItemValidation()
        {
            RuleFor(ct => ct.UnitPrice).NotEmpty().WithMessage("Unit price is required");
            RuleFor(ct => ct.Quantity).NotEmpty().WithMessage("Quantity is required");
            RuleFor(ct => ct.Amount).NotEmpty().WithMessage("Amount is required");
            RuleFor(ct => ct.UnitPrice).GreaterThanOrEqualTo(0).WithMessage("Unit price is greater or equal 0");
            RuleFor(ct => ct.Quantity).GreaterThanOrEqualTo(0).WithMessage("Quantity is greater or equal 0");
            RuleFor(ct => ct.Amount).GreaterThanOrEqualTo(0).WithMessage("Amount is greater or equal 0");
        }
    }
}
