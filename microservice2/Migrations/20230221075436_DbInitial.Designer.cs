﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using microservice2.Models;

namespace microservice2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230221075436_DbInitial")]
    partial class DbInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("microservice2.Models.Product", b =>
                {
                    b.Property<int>("pro_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("pro_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pro_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pro_id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
