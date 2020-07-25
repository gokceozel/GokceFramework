using FluentValidation;
using GokceFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Northwind.Business.ValidationRules.FluentValidation
{
   public class ProductValidatior :AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(x => x.CategoryId).NotEmpty();
            RuleFor(x => x.UnitPrice).GreaterThan(0);
            RuleFor(x => x.UnitPrice).GreaterThan(20).When(x => x.CategoryId == 1).WithMessage("Kategori idsi 1 olan ürünün fiyatı 20den büyük olmalı");
            RuleFor(x => x.ProductName).Must(startWithA);
            RuleFor(x => x.ProductName).Length(2, 20);
        }

        private bool startWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
