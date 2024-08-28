using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderItemValidation : AbstractValidator<OrderItem>
    {
        public OrderItemValidation() {
        
                RuleFor(ordi=>ordi.UnitPrice).NotEmpty().WithMessage("order unit price is required");
                RuleFor(ordi => ordi.Amount).NotEmpty().WithMessage("order unit price is required");
                RuleFor(ordi => ordi.Quantity).NotEmpty().WithMessage("order unit price is required");

                RuleFor(ordi => ordi.UnitPrice).GreaterThanOrEqualTo(0).WithMessage("order unit price is greater or equal than 0");
                RuleFor(ordi => ordi.Amount).GreaterThanOrEqualTo(0).WithMessage("order amount is greater or equal than 0");
                RuleFor(ordi => ordi.Quantity).GreaterThanOrEqualTo(0).WithMessage("order quantity is greater or equal than 0");

        }
    }
}
