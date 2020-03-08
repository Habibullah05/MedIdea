using System;
using System.Linq;
using Core.Models;
using FluentValidation;

namespace Core.Validation
{
    class ClientCartValidator : AbstractValidator<ClientCart>
    {
        public ClientCartValidator()
        {
            RuleFor(c => c.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{ProportyName} is Empty")
                .Length(2, 25).WithMessage("Length({TotalLengh})  of {ProportyName} Invalid")
                .Must(IsValidName).WithMessage("Invalid {ProportyName}");
            RuleFor(c => c.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{ProportyName} is Empty")
                .Length(2, 25).WithMessage("Length({TotalLengh})  of {ProportyName} Invalid")
                .Must(IsValidName).WithMessage("Invalid {ProportyName}");
            RuleFor(c => c.MiddleName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Length(2, 25).WithMessage("Length({TotalLengh})  of {ProportyName} Invalid")
                .Must(IsValidName).WithMessage("Invalid {ProportyName}");

        }

        protected bool IsValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("/", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }

        protected bool IsValidAge(DateTime date)
        {
            
            if (DateTime.Now.Date > date&& DateTime.Now.Date.Year<(date.Date.Year-120))
            {
                return true;

            }
            return false;
        }
        //public void Configure(EntityTypeBuilder<ClientCart> builder)
        //{
        //    builder.HasKey(c => c.Id);
        //    builder.Property(c => c.FullName)
        //           .IsRequired()
        //           .HasMaxLength(100);
        //    builder.Property(c => c.Gender)
        //           .IsRequired();
        //    builder.HasMany(c => c.Visits)
        //           .WithOne(v => v.Client);
        //}
    }
}
