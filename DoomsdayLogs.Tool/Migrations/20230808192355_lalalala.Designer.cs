﻿// <auto-generated />
using System;
using DoomsdayLogs.Tool.Infrastructure.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoomsdayLogs.Tool.Migrations
{
    [DbContext(typeof(DoomsdayLogsDbContext))]
    [Migration("20230808192355_lalalala")]
    partial class lalalala
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoomsdayLogs.Tool.Domain.LogModule.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LogClassName")
                        .HasColumnType("NVARCHAR(200)");

                    b.Property<string>("LogData")
                        .HasColumnType("NTEXT");

                    b.Property<string>("LogDataName")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<DateTime?>("LogDateTime")
                        .HasColumnType("DATETIME");

                    b.Property<string>("LogDescription")
                        .HasColumnType("NVARCHAR(350)");

                    b.Property<string>("LogName")
                        .HasColumnType("NVARCHAR(150)");

                    b.Property<string>("LogType")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<byte[]>("LogTypeImage")
                        .HasColumnType("IMAGE");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("LogDB");
                });

            modelBuilder.Entity("DoomsdayLogs.Tool.Domain.ProjectModule.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectName")
                        .HasColumnType("NVARCHAR(150)");

                    b.Property<string>("ProjectVersion")
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("ProjectDB");
                });

            modelBuilder.Entity("DoomsdayLogs.Tool.Domain.LogModule.Log", b =>
                {
                    b.HasOne("DoomsdayLogs.Tool.Domain.ProjectModule.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
