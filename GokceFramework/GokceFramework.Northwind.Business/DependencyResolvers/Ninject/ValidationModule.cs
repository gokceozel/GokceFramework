using FluentValidation;
using GokceFramework.Northwind.Business.ValidationRules.FluentValidation;
using GokceFramework.Northwind.Entities.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class ValidationModule :NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidatior>().InSingletonScope();
        }
    }
}
