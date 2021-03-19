﻿// <auto-generated />
using Emission_backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Emission_backend.Migrations
{
    [DbContext(typeof(EmissionDbContext))]
    [Migration("20210316200127_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Emission_backend.Emission", b =>
                {
                    b.Property<int>("emissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("end")
                        .HasColumnType("INTEGER");

                    b.Property<string>("reason")
                        .HasColumnType("TEXT");

                    b.Property<long>("start")
                        .HasColumnType("INTEGER");

                    b.HasKey("emissionId");

                    b.ToTable("emission");
                });
#pragma warning restore 612, 618
        }
    }
}