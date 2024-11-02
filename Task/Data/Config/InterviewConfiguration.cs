using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Entites;

namespace Task.Data.Config
{
    internal class InterviewConfiguration : IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            throw new NotImplementedException();
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .IsRequired();
            builder.Property(x => x.StartDate)
                .HasColumnType("datetime2");
            builder.Property(x => x.EndDate)
                .HasColumnType("datetime2");
            builder.Property(x => x.FeedBack)
                .HasColumnType("varchar");
            builder.Property(x => x.Score)
                .IsRequired();
            builder.Property(x => x.TracksId);

            builder.HasOne(x => x.track)
                .WithOne(x => x.interview)
                .HasForeignKey<Interview>(x => x.TracksId);

            builder.HasMany(x => x.Questions)
                .WithOne(x => x.Interview)
                .HasForeignKey(x => x.InterviewId);
            builder.ToTable("Interview");
                

        }
    }
}
