using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;
using FluentValidation;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Must not be empty!");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Must not be empty!");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Must not be empty!");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Must not be empty!");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Must not be empty!");

            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Unit price must be greater than 0!");
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2).WithMessage("Condiments unit price must be greater than 10!");

            RuleFor(p => p.ProductName).Must(StartWithUpper).
                WithMessage("The first letter of the product you add must be capitalized!");
        }

        private bool StartWithUpper(string arg)
        {
            char character = arg[0];
            if (char.IsUpper(character))
            {
                return true;
            }
            else
                return false;
        }
    }
}
