using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidation : AbstractValidator<Order>
    {
        public OrderValidation() {

            RuleFor(ord => ord.CreatedDate).NotEmpty().WithMessage("order created date is required");
            RuleFor(ord => ord.DeliveryDate).NotEmpty().WithMessage("order delivery date is required");
            RuleFor(ord => ord.TotalPrice).NotEmpty().WithMessage("order total price is required");
            RuleFor(ord => ord.TotalPrice).GreaterThanOrEqualTo(0).WithMessage("order total price is greater or equal than 0");
            RuleFor(ord => ord.Status).NotEmpty().WithMessage("order status is required");

        }
    }
}
