﻿using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("Users");

            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.MemberSince).HasConversion(typeof(DateTime)).HasDefaultValue(DateTime.Now);

            builder.HasMany(u => u.Orders)
               .WithOne(o => o.AppUser)
               .HasForeignKey(o => o.AppUserId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.AppUserAddress).WithOne(x => x.appUser).HasForeignKey(x => x.AppUserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
