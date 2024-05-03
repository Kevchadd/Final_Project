﻿// <auto-generated />
using Final_Tooling_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_Project.Migrations
{
    [DbContext(typeof(ToolDbContext))]
    [Migration("20240503231409_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Final_Tooling_Project.Models.Tool", b =>
                {
                    b.Property<int>("ToolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("InService")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ToolClub")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ToolName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ToolId");

                    b.ToTable("Tools");
                });
#pragma warning restore 612, 618
        }
    }
}
