﻿// <auto-generated />
using System;
using JobSeek.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobSeek.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230206161432_make-parent-jobcategory-without-parent")]
    partial class makeparentjobcategorywithoutparent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobSeek.Api.Models.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Advantages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ExpireDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("IndustryType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("JobStatus")
                        .HasColumnType("int");

                    b.Property<int>("MaxSalary")
                        .HasColumnType("int");

                    b.Property<int>("MinSalary")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("PositionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeniorityLevel")
                        .HasColumnType("int");

                    b.Property<int>("TypeCooperation")
                        .HasColumnType("int");

                    b.Property<decimal>("WorkExperience")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Workplace")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.HasIndex("JobCategoryId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.JobCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobCategories");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.JobEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CvCheckStatus")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobId");

                    b.ToTable("JobEmployees");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("JobSeek.Api.Models.TestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestEntities");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.Employee", b =>
                {
                    b.HasBaseType("JobSeek.Api.Models.Entities.User");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MajoringIn")
                        .HasColumnType("int");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<int>("MilitaryService")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.Employer", b =>
                {
                    b.HasBaseType("JobSeek.Api.Models.Entities.User");

                    b.Property<int>("CompanyEmployerNumber")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAddressUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobField")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Employer");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.Job", b =>
                {
                    b.HasOne("JobSeek.Api.Models.Entities.Employer", "Employer")
                        .WithMany("Jobs")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JobSeek.Api.Models.Entities.JobCategory", "JobCategory")
                        .WithMany()
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employer");

                    b.Navigation("JobCategory");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.JobEmployee", b =>
                {
                    b.HasOne("JobSeek.Api.Models.Entities.Employee", "Employee")
                        .WithMany("JobEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JobSeek.Api.Models.Entities.Job", "Job")
                        .WithMany("JobEmployees")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.Job", b =>
                {
                    b.Navigation("JobEmployees");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.Employee", b =>
                {
                    b.Navigation("JobEmployees");
                });

            modelBuilder.Entity("JobSeek.Api.Models.Entities.Employer", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
