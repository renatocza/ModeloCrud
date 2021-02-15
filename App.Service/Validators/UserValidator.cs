using FluentValidation;
using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Service.Validators
{
    public class UserValidator : AbstractValidator<Usuario>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("Is necessary to inform the CPF.")
                .NotNull().WithMessage("Is necessary to inform the CPF.");

            RuleFor(c => c.DtNasc)
                .NotEmpty().WithMessage("Is necessary to inform the birth date.")
                .NotNull().WithMessage("Is necessary to inform the birth date.");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Is necessary to inform the name.")
                .NotNull().WithMessage("Is necessary to inform the name.");
        }
    }
}
