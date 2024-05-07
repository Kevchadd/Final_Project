﻿// <auto-generated />
using Final_Tooling_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_Project.Migrations
{
    [DbContext(typeof(ToolDbContext))]
    partial class ToolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Final_Tooling_Project.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocationDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ToolID")
                        .HasColumnType("INTEGER");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Final_Tooling_Project.Models.Tool", b =>
                {
                    b.Property<int>("ToolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("InService")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ToolClub")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ToolName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ToolId");

                    b.HasIndex("LocationId");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("Final_Tooling_Project.Models.Tool", b =>
                {
                    b.HasOne("Final_Tooling_Project.Models.Location", "Location")
                        .WithMany("Tools")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Final_Tooling_Project.Models.Location", b =>
                {
                    b.Navigation("Tools");
                });
#pragma warning restore 612, 618
        }
    }
}
