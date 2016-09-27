using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WeiXinCore.Data;

namespace WeiXinCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("WeiXinCore.Models.VERB", b =>
                {
                    b.Property<string>("memberID")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<string>("Token")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<DateTime?>("modDate");

                    b.HasKey("memberID");

                    b.ToTable("VERB");
                });
        }
    }
}
