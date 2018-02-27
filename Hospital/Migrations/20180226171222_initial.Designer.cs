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
    [Migration("20180226171222_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hospital.Modules.Doctors_Profile.Models.LabReportRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("date");

                    b.Property<string>("description");

                    b.Property<int>("labNo");

                    b.Property<int>("nicNo");

                    b.Property<string>("patientName");

                    b.HasKey("Id");

                    b.ToTable("LabReportRequest");
                });
#pragma warning restore 612, 618
        }
    }
}
