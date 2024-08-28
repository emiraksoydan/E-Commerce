using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProcutcAttributeValidation : AbstractValidator<ProductAttributes>
    {
        public ProcutcAttributeValidation()
        {
            RuleFor(pa=>pa.AttributeName).NotEmpty().WithMessage("AttributeName is required");
            RuleFor(pa => pa.AttributeValue).NotEmpty().WithMessage("AttributeValue is required");

        }
    }
}
