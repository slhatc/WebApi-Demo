﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantityPerUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("ReorderLevel")
                        .HasColumnType("smallint");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<short?>("UnitsInStock")
                        .HasColumnType("smallint");

                    b.Property<short?>("UnitsOnOrder")
                        .HasColumnType("smallint");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
