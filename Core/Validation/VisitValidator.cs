using Core.Models;
using FluentValidation;
using System;

namespace Core.Validation
{
    public class VisitValidator : AbstractValidator<Visit>
    {
        public VisitValidator()
        {
            RuleFor(v => v.Diagnosis)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{ProportyName} is Empty")
               .Length(2, 50).WithMessage("Length({TotalLengh})  of {ProportyName} Invalid");


            RuleFor(v => v.TypeVisit)
                .Cascade(CascadeMode.StopOnFirstFailure).NotNull().WithMessage("{ProportyName} is Empty");



        }
        //public void Configure(EntityTypeBuilder<Visit> builder)
        //{
        //    builder.HasKey(v => v.Id);
        //    builder.Property(v => v.Diagnosis)
        //           .IsRequired()
        //           .HasMaxLength(100);
        //    builder.Property(v => v.TypeVisit)
        //           .IsRequired();
        //    builder.Property(v => v.DateOfVisit).HasDefaultValue(DateTime.Now);
        //}
    }
}
