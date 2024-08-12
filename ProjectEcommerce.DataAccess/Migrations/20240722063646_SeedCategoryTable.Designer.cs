﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectEcommerce.DataAccess.Data;

#nullable disable

namespace ProjectEcommerce.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240722063646_SeedCategoryTable")]
    partial class SeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectEcommerce.Models.CategoryModel", b =>
                {
                    b.Property<int>("CategoeyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoeyID"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.HasKey("CategoeyID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoeyID = 1,
                            CategoryDescription = "All of Clothing",
                            CategoryName = "Dress",
                            DisplayOrder = 1
                        },
                        new
                        {
                            CategoeyID = 2,
                            CategoryDescription = "All of Clothing",
                            CategoryName = "Skirt",
                            DisplayOrder = 2
                        },
                        new
                        {
                            CategoeyID = 3,
                            CategoryDescription = "All of Clothing",
                            CategoryName = "Cost",
                            DisplayOrder = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
