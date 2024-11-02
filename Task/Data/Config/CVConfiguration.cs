using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Entites;

namespace Task.Data.Config
{
    public class CVConfiguration : IEntityTypeConfiguration<CV>
    {
        public void Configure(EntityTypeBuilder<CV> builder)
        {
            throw new NotImplementedException();

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);

            builder.Property(x => x.Title)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            builder.HasMany(x => x.projects)
                .WithOne(x => x.cv)
                .HasForeignKey(x => x.cv.Id);

            builder.ToTable("CV");

        }
    }
}
