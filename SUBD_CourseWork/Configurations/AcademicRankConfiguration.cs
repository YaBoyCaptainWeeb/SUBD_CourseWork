using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUBD_CourseWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Configurations
{
    public class AcademicRankConfiguration : IEntityTypeConfiguration<AcademicRank>
    {
        public void Configure(EntityTypeBuilder<AcademicRank> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasIndex(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.AcademicRankType).IsRequired();
        }
    }
}
