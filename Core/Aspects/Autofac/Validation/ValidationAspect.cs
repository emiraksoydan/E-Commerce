using Castle.DynamicProxy;
using Core.CrossCuttingConcerns;
using Core.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatortype;
        public ValidationAspect(Type validatortype) {

            if (!typeof(IValidator).IsAssignableFrom(validatortype))
            {
                throw new SystemException("doğrulama sınıfı değil");
            }
            _validatortype = validatortype;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatortype);
            var entityType = _validatortype.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(ar => ar.GetType() == entityType);
            foreach (var item in entities)
            {
                ValidationTool.Validate(validator, item);
            }

           
        }
    }
}
