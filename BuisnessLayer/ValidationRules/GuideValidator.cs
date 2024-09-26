using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter Name");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter Description");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please enter Image");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter Name");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Max Length 30!");
        }
    }
}
