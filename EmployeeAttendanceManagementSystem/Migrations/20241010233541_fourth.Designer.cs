﻿// <auto-generated />
using System;
using EmployeeAttendanceManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeAttendanceManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241010233541_fourth")]
    partial class fourth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeAttendanceManagementSystem.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"));

                    b.Property<TimeSpan>("CheckInTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("CheckOutTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("AttendanceId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("EmployeeAttendanceManagementSystem.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeAttendanceManagementSystem.Models.Attendance", b =>
                {
                    b.HasOne("EmployeeAttendanceManagementSystem.Models.Employee", "Employees")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
