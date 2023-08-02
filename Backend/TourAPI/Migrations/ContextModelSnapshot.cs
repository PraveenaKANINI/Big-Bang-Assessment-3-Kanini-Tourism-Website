﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourAPI.Models;

#nullable disable

namespace TourAPI.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TourAPI.Models.Exclusions", b =>
                {
                    b.Property<int>("ExclusionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExclusionId"), 1L, 1);

                    b.Property<string>("ExclusionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExclusionId");

                    b.ToTable("Exclusions");
                });

            modelBuilder.Entity("TourAPI.Models.Inclusions", b =>
                {
                    b.Property<int>("InclusionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InclusionId"), 1L, 1);

                    b.Property<string>("InclusionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InclusionId");

                    b.ToTable("Inclusions");
                });

            modelBuilder.Entity("TourAPI.Models.Tour", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourId"), 1L, 1);

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<int>("MinCapacity")
                        .HasColumnType("int");

                    b.Property<int>("NoOfDays")
                        .HasColumnType("int");

                    b.Property<int>("NoOfNights")
                        .HasColumnType("int");

                    b.Property<string>("TourDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TourImages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TourName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TourPrice")
                        .HasColumnType("real");

                    b.Property<string>("TourState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TourType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TourId");

                    b.ToTable("Tour");
                });

            modelBuilder.Entity("TourAPI.Models.TourDates", b =>
                {
                    b.Property<int>("TourDateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourDateId"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("TourDateId");

                    b.HasIndex("TourId");

                    b.ToTable("TourDates");
                });

            modelBuilder.Entity("TourAPI.Models.TourExclusions", b =>
                {
                    b.Property<int>("TourExclusionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourExclusionId"), 1L, 1);

                    b.Property<int>("ExclusionId")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("TourExclusionId");

                    b.HasIndex("ExclusionId");

                    b.HasIndex("TourId");

                    b.ToTable("TourExclusions");
                });

            modelBuilder.Entity("TourAPI.Models.TourInclusions", b =>
                {
                    b.Property<int>("TourInclusionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourInclusionId"), 1L, 1);

                    b.Property<int>("InclusionId")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("TourInclusionId");

                    b.HasIndex("InclusionId");

                    b.HasIndex("TourId");

                    b.ToTable("TourInclusions");
                });

            modelBuilder.Entity("TourAPI.Models.TourItinerary", b =>
                {
                    b.Property<int>("TourDestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourDestinationId"), 1L, 1);

                    b.Property<DateTime>("ArivalTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepatureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinationActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("TourDestinationId");

                    b.HasIndex("TourId");

                    b.ToTable("TourItinerary");
                });

            modelBuilder.Entity("TourAPI.Models.TourDates", b =>
                {
                    b.HasOne("TourAPI.Models.Tour", "Tour")
                        .WithMany("TourDates")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("TourAPI.Models.TourExclusions", b =>
                {
                    b.HasOne("TourAPI.Models.Exclusions", "Exclusions")
                        .WithMany()
                        .HasForeignKey("ExclusionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourAPI.Models.Tour", "Tour")
                        .WithMany("TourExclusions")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exclusions");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("TourAPI.Models.TourInclusions", b =>
                {
                    b.HasOne("TourAPI.Models.Inclusions", "Inclusions")
                        .WithMany()
                        .HasForeignKey("InclusionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourAPI.Models.Tour", "Tour")
                        .WithMany("TourInclusions")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inclusions");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("TourAPI.Models.TourItinerary", b =>
                {
                    b.HasOne("TourAPI.Models.Tour", "Tour")
                        .WithMany("TourItinerary")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("TourAPI.Models.Tour", b =>
                {
                    b.Navigation("TourDates");

                    b.Navigation("TourExclusions");

                    b.Navigation("TourInclusions");

                    b.Navigation("TourItinerary");
                });
#pragma warning restore 612, 618
        }
    }
}
