using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Core.Validation
{
    public class VisitConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Diagnosis)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(v => v.TypeVisit)
                   .IsRequired();
            builder.HasOne(v=>v.TypeVisit).WithMany(t=>t.Visits);
            //  builder.Property(v => v.DateOfVisit).HasDefaultValue(DateTime.Now);
        }
       

       
    }
}
