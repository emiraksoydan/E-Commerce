using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator ,object entity)
        {
            var validresult = new ValidationContext<object>(entity);
            var prresult = validator.ValidateAsync(validresult);
            if (!prresult.Result.IsValid)
            {
                throw new ValidationException(prresult.Result.Errors);
            }
        }
    }
}
