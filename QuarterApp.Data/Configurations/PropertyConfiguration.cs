using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuarterApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Data.Configurations
{
    class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(25).IsRequired(true);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.MonthlyPrice).HasColumnType("decimal(18,2)");
            builder.Property(x => x.WeeklyPrice).HasColumnType("decimal(18,2)");
            builder.Property(x => x.DailyPrice).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");

        }
      
    }
}
