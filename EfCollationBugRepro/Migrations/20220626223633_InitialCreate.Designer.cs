﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCollationBugRepro.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220626223633_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyEntity", b =>
                {
                    b.Property<string>("KeyCol1")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("Latin1_General_100_BIN2");

                    b.Property<int>("KeyCol2")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KeyCol2"), 1L, 1);

                    b.HasKey("KeyCol1", "KeyCol2");

                    b.ToTable("MyEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
