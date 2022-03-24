using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Msg.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Msg.Infrastucture
{
    //Add-Migration qianzhu
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options)
    : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserInfo>(entity => { entity.Property(t => t.Password).HasDefaultValue("123456"); });
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName("SF_" + entity.GetTableName());
            }
        }


        public DbSet<UserInfo> Users { get; set; }
        public DbSet<UserInfo2> Users2 { get; set; }


    }
}
