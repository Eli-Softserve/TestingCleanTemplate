﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Property<int>("iStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("bIsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("dtAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dtEdited")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("gGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("iGrade")
                        .HasColumnType("int");

                    b.Property<string>("strAddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strEdited")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strStudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strStudentSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iStudentId");

                    b.ToTable("tblStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
