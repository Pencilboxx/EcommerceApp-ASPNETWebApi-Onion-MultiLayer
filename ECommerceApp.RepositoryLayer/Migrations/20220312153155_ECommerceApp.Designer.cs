﻿// <auto-generated />
using ECommerceApp.RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerceApp.RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220312153155_ECommerceApp")]
    partial class ECommerceApp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerceApp.DomainLayer.Model.Customer", b =>
                {
                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerName");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
