using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).NotEmpty();//boş geçilemez
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.ColorId == 1);
            RuleFor(p => p.CarName).Must(StartWhithA).WithMessage(" a harfi ile başlamalı");
        }
        private bool StartWhithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
