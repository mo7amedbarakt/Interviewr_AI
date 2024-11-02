using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Entites;

namespace Task.Data.Config
{
    public class TrackConfiguration : IEntityTypeConfiguration<Tracks>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tracks> builder)
        {
            throw new NotImplementedException();
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);

        }
    }
}
