using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(ct=>ct.Status).NotEmpty();
            RuleFor(ct =>ct.Name).NotEmpty();
            RuleFor(ct => ct.Description).NotEmpty();
            RuleFor(ct => ct.Name).Length(4,20);
            RuleFor(ct => ct.Description).Length(1,200);

        }
    }
}
