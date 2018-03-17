﻿// <auto-generated />
using Hospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Hospital.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hospital.Modules.Doctors_Profile.Models.DoctorsLoginModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("password");

                    b.Property<string>("userName");

                    b.HasKey("Id");

                    b.ToTable("DoctorsLoginModel");
                });

            modelBuilder.Entity("Hospital.Modules.Doctors_Profile.Models.LabReportRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DoctorName")
                        .IsRequired();

                    b.Property<string>("DoctorStatus");

                    b.Property<string>("LabReport");

                    b.Property<string>("LabStatus");

                    b.Property<string>("LabType")
                        .IsRequired();

                    b.Property<string>("SpecialistName");

                    b.Property<DateTime>("date");

                    b.Property<string>("description");

                    b.Property<int>("labNo");

                    b.Property<int>("nicNo");

                    b.Property<string>("patientName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("LabReportRequest");
                });

            modelBuilder.Entity("Hospital.Modules.Doctors_Profile.Models.ReportCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.HasKey("Id");

                    b.ToTable("ReportCount");
                });

            modelBuilder.Entity("Hospital.Modules.Doctors_Profile.Models.RequestFacility", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Department");

                    b.Property<string>("Description");

                    b.Property<string>("DoctorName");

                    b.Property<string>("Topic");

                    b.HasKey("Id");

                    b.ToTable("RequestFacility");
                });

            modelBuilder.Entity("Hospital.Modules.LabManagement.Models.LabLogInModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("password");

                    b.Property<string>("userName");

                    b.HasKey("Id");

                    b.ToTable("LabLogInModel");
                });

            modelBuilder.Entity("Hospital.Modules.PatientManagement.Models.PatientDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("Date_Cin");

                    b.Property<string>("Email");

                    b.Property<string>("NicNo")
                        .IsRequired();

                    b.Property<string>("Wardno")
                        .IsRequired();

                    b.Property<string>("patientName")
                        .IsRequired();

                    b.Property<int>("telephone");

                    b.HasKey("Id");

                    b.ToTable("PatientDetails");
                });

            modelBuilder.Entity("Hospital.Modules.PatientManagement.Models.Wardassign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("date");

                    b.Property<int>("patientName");

                    b.Property<string>("wardnumb")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Wardassign");
                });

            modelBuilder.Entity("Hospital.Modules.StaffManagement.Models.EditProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("EditProfile");
                });

            modelBuilder.Entity("Hospital.Modules.StaffManagement.Models.LogInDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Position");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("LogInDetails");
                });

            modelBuilder.Entity("Hospital.Modules.StaffManagement.Models.Reminder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Topic");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Reminder");
                });
#pragma warning restore 612, 618
        }
    }
}
