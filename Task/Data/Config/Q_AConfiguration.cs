using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Task.Entites;

namespace Task.Data.Config
{
    internal class Q_AConfiguration : IEntityTypeConfiguration<Q_A>
    {
        public void Configure(EntityTypeBuilder<Q_A> builder)
        {
            throw new NotImplementedException();
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Question);
            builder.Property(x => x.Answer);
            builder.Property(i => i.level)
                .HasConversion<string>();

            builder.Property(x => x.Question)
            .HasConversion(
            tags => string.Join(",", tags),         // Convert List<string> to a comma-separated string
            tags => tags.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList());
            builder.Property(x => x.Answer)
            .HasConversion(
            tags => string.Join(",", tags),         // Convert List<string> to a comma-separated string
            tags => tags.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList()); // Convert comma-separated string back to List<string>
           
            builder.ToTable("Q_A");
        
        }
    }
    }
}
