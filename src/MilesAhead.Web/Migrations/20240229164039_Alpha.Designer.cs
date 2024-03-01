﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MilesAhead.WireFrames.Core;

#nullable disable

namespace MilesAhead.Web.Migrations
{
    [DbContext(typeof(WireFramesDbContext))]
    [Migration("20240229164039_Alpha")]
    partial class Alpha
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("render")
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MilesAhead.Components.WireFrame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Attributes")
                        .HasMaxLength(720)
                        .HasColumnType("nvarchar(720)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DataSource")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("FetchData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Segment")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("WireFrameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WireFrameId");

                    b.ToTable("WireFrames", "render");

                    b.HasDiscriminator<string>("Discriminator").HasValue("WireFrame");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MilesAhead.Components.PrimeRoot", b =>
                {
                    b.HasBaseType("MilesAhead.Components.WireFrame");

                    b.Property<string>("BodyScripts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalStyleSheets")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaviconUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadScripts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RootName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("RootName")
                        .IsUnique()
                        .HasFilter("[RootName] IS NOT NULL");

                    b.HasDiscriminator().HasValue("PrimeRoot");
                });

            modelBuilder.Entity("MilesAhead.Components.WireFrame", b =>
                {
                    b.HasOne("MilesAhead.Components.WireFrame", null)
                        .WithMany("Children")
                        .HasForeignKey("WireFrameId");
                });

            modelBuilder.Entity("MilesAhead.Components.WireFrame", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
