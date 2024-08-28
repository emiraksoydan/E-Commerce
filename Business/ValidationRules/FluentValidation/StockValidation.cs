using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class StockValidation : AbstractValidator<Stock>
    {
        public StockValidation() { 
            RuleFor(st=>st.LastUpdated).NotEmpty().WithMessage("Stock updated is required");
            RuleFor(st => st.Quantity).NotEmpty().WithMessage("Stock quantity is required");
            RuleFor(st => st.Quantity).GreaterThanOrEqualTo(0).WithMessage("Stock quantity is greater or equal than 0");
        }
    }
}
