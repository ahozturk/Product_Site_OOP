using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter a name!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name can't be less than 3 character!");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("You must enter stock value!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("You must enter price value!");
        }
    }
}
