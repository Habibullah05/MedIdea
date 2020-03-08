using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Configurations
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder
                 .Property(x => x.Title)
                 .IsRequired()
                 .HasMaxLength(100);

            builder.HasData(new List<Gender>
            {

            new Gender{Id=1,Title="Male" },
            new Gender{Id=2,Title="Female" },
            new Gender{Id=3,Title="Other" },

            });
            }
    }
}
