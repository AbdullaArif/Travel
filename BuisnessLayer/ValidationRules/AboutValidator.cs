using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Description Not Empty!!!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please choose Photo!!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Please enter maximum 50 character!");
            RuleFor(x => x.Description).MaximumLength(1550).WithMessage("Please enter minimum 1550 character!");
        }
    }
}
