using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using PClement.Club.Models;

namespace PClement.Club.Migrations.ClubDb
{
    [DbContext(typeof(ClubDbContext))]
    [Migration("20151220202310_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PClement.Club.Models.Club", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");
                });
        }
    }
}
