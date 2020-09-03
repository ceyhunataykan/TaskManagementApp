using CA.TaskManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.TaskManagement.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Ad).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Soyad).HasMaxLength(100).IsRequired(false);
            builder.Property(I => I.Tel).HasMaxLength(50);
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();

            builder.HasMany(I => I.Calismalar).WithOne(I => I.Kullanici).HasForeignKey(I => I.KullaniciId);

        }
    }
}
