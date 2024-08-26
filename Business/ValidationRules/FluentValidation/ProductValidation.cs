using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {

            RuleFor(pr => pr.Price).NotEmpty();
            RuleFor(pr => pr.Price).GreaterThan(0);
            RuleFor(pr => pr.Name).NotEmpty();
            RuleFor(pr => pr.Name).Length(4, 50);
            RuleFor(pr => pr.Description).NotEmpty();
            RuleFor(pr => pr.Description).Length(1, 500);
            RuleFor(pr => pr.Name).MustAsync(DontStartWithG).WithMessage("Ürün adı Ğ ile başlayamaz");
        }

        private async Task<bool> DontStartWithG(string arg1, CancellationToken token)
        {
            return arg1.StartsWith("Ğ") ? false : true;
        }
    }
}
