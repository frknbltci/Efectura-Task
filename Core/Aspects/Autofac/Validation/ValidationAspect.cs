using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //defensive codin --> savunma odaklı kod yapısı typeof kısmı
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            //reflection kodu
            var validator = (IValidator)Activator.CreateInstance(_validatorType); 
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; //abstrackvalidator'un 0.sının "tipini" yakala dedik
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//Mehod'un parametrelerini gez
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
