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
    public class IndividualPlanConfiguration : IEntityTypeConfiguration<IndividualPlan>
    {
        public void Configure(EntityTypeBuilder<IndividualPlan> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.plannedForFallSemestre).IsRequired();
            builder.Property(x => x.factForFallSemestre).IsRequired();
            builder.Property(x => x.plannedForSpringSemestre).IsRequired();
            builder.Property(x => x.factForSpringSemestre).IsRequired();
        }
    }
}
