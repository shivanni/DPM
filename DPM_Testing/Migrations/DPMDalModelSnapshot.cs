﻿// <auto-generated />
using System;
using DPM_Testing.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DPM_Testing.Migrations
{
    [DbContext(typeof(DPMDal))]
    partial class DPMDalModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DPM_Testing.Models.AddRuleModel", b =>
                {
                    b.Property<int>("AddRuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<float>("Alarm")
                        .HasColumnType("real");

                    b.Property<string>("Columns")
                        .HasColumnType("text");

                    b.Property<string>("Condition")
                        .HasColumnType("text");

                    b.Property<float>("Trigger")
                        .HasColumnType("real");

                    b.HasKey("AddRuleId");

                    b.ToTable("tbl_AddRuleModel");
                });

            modelBuilder.Entity("DPM_Testing.Models.ClassificationMaster", b =>
                {
                    b.Property<int>("ClassificationMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("ClassificationId")
                        .HasColumnType("integer");

                    b.Property<string>("Classifications")
                        .HasColumnType("text");

                    b.HasKey("ClassificationMasterId");

                    b.ToTable("tbl_ClassificationMaster");
                });

            modelBuilder.Entity("DPM_Testing.Models.compressuredetails", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("PD1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PD2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PS1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PS2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TD1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TD2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TS1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TS2")
                        .HasColumnType("numeric");

                    b.Property<int>("TenantId")
                        .HasColumnType("integer");

                    b.HasKey("BatchId");

                    b.ToTable("tbl_Compressuredetails");
                });

            modelBuilder.Entity("DPM_Testing.Models.compressurewithclassification", b =>
                {
                    b.Property<int>("CompClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("BatchId")
                        .HasColumnType("integer");

                    b.Property<string>("Classification")
                        .HasColumnType("text");

                    b.Property<int>("ClassificationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("PD1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PD2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PS1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PS2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TD1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TD2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TS1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TS2")
                        .HasColumnType("numeric");

                    b.Property<int>("TenantId")
                        .HasColumnType("integer");

                    b.HasKey("CompClassID");

                    b.ToTable("tbl_Compressurewithclassification");
                });
#pragma warning restore 612, 618
        }
    }
}
