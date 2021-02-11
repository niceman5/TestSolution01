using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;

namespace ConsoleFluentValidation
{
    class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName}은  Empty입니다.")
                .Length(2, 50).WithMessage("길이는 ({TotalLength}) {PropertyName} ")
                .Must(BeAValidName).WithMessage("{PropertyName}에 잘못된 문자가 들어가 있습니다.");

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName}은  Empty입니다.")
                .Length(2, 50).WithMessage("길이는 ({TotalLength}) {PropertyName} ")
                .Must(BeAValidName).WithMessage("{PropertyName}에 잘못된 문자가 들어가 있습니다.");

            RuleFor(p => p.DateofBirth)
                .Must(BeAValidAge).WithName("Invalid {PropertyName}");
        }

        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            //숫자형 안됨 
            return name.All(Char.IsLetter);
        }

        protected bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int inYear = date.Year;

            if (inYear <= currentYear && inYear > (currentYear - 120))
            {
                return true;
            }

            return false;
        }
    }
}
