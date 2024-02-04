﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Context;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(MyDbConText))]
    partial class MyDbConTextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Server.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("cost")
                        .HasColumnType("float");

                    b.Property<string>("detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("discount")
                        .HasColumnType("tinyint");

                    b.Property<int?>("idType")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.HasIndex("idType");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Server.Entities.TypeEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("Server.Entities.ProductEntity", b =>
                {
                    b.HasOne("Server.Entities.TypeEntity", "type")
                        .WithMany("productEntities")
                        .HasForeignKey("idType");

                    b.Navigation("type");
                });

            modelBuilder.Entity("Server.Entities.TypeEntity", b =>
                {
                    b.Navigation("productEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
