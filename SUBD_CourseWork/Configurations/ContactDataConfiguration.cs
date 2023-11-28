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
    public class ContactDataConfiguration : IEntityTypeConfiguration<ContactData>
    {
        public void Configure(EntityTypeBuilder<ContactData> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            //builder.Property(x => x.EmailAdresses).IsRequired();
            //builder.Property(x => x.PhoneNumbers).IsRequired();
        }
    }
}
