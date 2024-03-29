﻿// <auto-generated />
using System;
using Hybrid.Prem.Client.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hybrid.Prem.Client.Migrations
{
    [DbContext(typeof(InsuranceContext))]
    [Migration("20191023152338_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hybrid.Prem.Client.Model.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<string>("Description");

                    b.Property<int>("InsuranceId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceId");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("Hybrid.Prem.Client.Model.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.HasKey("Id");

                    b.ToTable("Insurance");
                });

            modelBuilder.Entity("Hybrid.Prem.Client.Model.Claim", b =>
                {
                    b.HasOne("Hybrid.Prem.Client.Model.Insurance", "Insurance")
                        .WithMany("Claims")
                        .HasForeignKey("InsuranceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
