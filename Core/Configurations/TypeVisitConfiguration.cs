using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Configurations
{
   public class TypeVisitConfiguration : IEntityTypeConfiguration<TypeVisit>
    {
        public void Configure(EntityTypeBuilder<TypeVisit> builder)
        {
            builder
                 .Property(x => x.Title)
                 .IsRequired()
                 .HasMaxLength(100);

            builder.HasData(new List<TypeVisit>
            {
            new TypeVisit{Id=1,Title="Primary" },
            new TypeVisit{Id=2,Title="Secondary" },
          
            });
           
        }
    }
}
