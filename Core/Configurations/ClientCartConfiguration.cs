using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Validation
{
    public class ClientCartConfiguration : IEntityTypeConfiguration<ClientCart>
    {
        public void Configure(EntityTypeBuilder<ClientCart> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.FirstName)
                   .IsRequired()
                   .HasMaxLength(25);
            builder.Property(c => c.FirstName)
                  .IsRequired()
                  .HasMaxLength(25);
            builder.Property(c => c.FirstName)
                  .IsRequired()
                  .HasMaxLength(25);
            //builder.Property(c => c.Gender)
            //       .IsRequired();
            builder.Property(c => c.BirthDay).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(15);
            builder.Property(c => c.Address).HasMaxLength(50);
            builder.HasMany(c => c.Visits)
                   .WithOne(v => v.Client);
        }
        
    }
}
