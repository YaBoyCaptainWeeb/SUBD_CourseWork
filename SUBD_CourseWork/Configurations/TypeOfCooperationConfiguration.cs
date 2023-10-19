using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUBD_CourseWork.Entities;


namespace SUBD_CourseWork.Configurations
{
    public class TypeOfCooperationConfiguration : IEntityTypeConfiguration<TypeOfCooperation>
    {
        public void Configure(EntityTypeBuilder<TypeOfCooperation> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.CoopType).IsRequired();
            builder.Property(t => t.CoopType).HasDefaultValue(CooperationType.Неизвестно);
        }
    }
}
