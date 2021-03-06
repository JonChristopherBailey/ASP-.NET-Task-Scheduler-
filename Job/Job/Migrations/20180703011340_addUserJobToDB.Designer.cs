﻿// <auto-generated />
using Job.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Job.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180703011340_addUserJobToDB")]
    partial class addUserJobToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Job.Model.Tasks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TaskDescription");

                    b.Property<string>("TaskName");

                    b.Property<int>("TaskSchedule");

                    b.HasKey("ID");

                    b.ToTable("TaskItems");
                });
#pragma warning restore 612, 618
        }
    }
}
