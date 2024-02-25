﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MilesAhead.Components;

#nullable disable

namespace MilesAhead.Web.Migrations
{
    [DbContext(typeof(WireFramesDbContext))]
    partial class WireFramesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("render")
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MilesAhead.Components.DataField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("RenderDataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RenderDataId");

                    b.ToTable("DataField", "render");
                });

            modelBuilder.Entity("MilesAhead.Components.RenderData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DataSource")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("RenderData", "render");
                });

            modelBuilder.Entity("MilesAhead.Components.RenderDataItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("RenderDataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RenderDataId");

                    b.ToTable("RenderDataItem", "render");
                });

            modelBuilder.Entity("MilesAhead.Components.WireFrame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<bool>("IsOpenTag")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Segment")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<Guid?>("WireFrameId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DataId");

                    b.HasIndex("WireFrameId");

                    b.ToTable("WireFrames", "render");

                    b.HasDiscriminator<string>("Discriminator").HasValue("WireFrame");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MilesAhead.Components.WireFrameAttribute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Value")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<Guid?>("WireFrameId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WireFrameId");

                    b.ToTable("WireFrameAttribute", "render");
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

                    b.Property<string>("HeadScripts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MetaDataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RootName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("MetaDataId");

                    b.HasDiscriminator().HasValue("PrimeRoot");
                });

            modelBuilder.Entity("MilesAhead.Components.DataField", b =>
                {
                    b.HasOne("MilesAhead.Components.RenderData", null)
                        .WithMany("Parameters")
                        .HasForeignKey("RenderDataId");
                });

            modelBuilder.Entity("MilesAhead.Components.RenderDataItem", b =>
                {
                    b.HasOne("MilesAhead.Components.RenderData", null)
                        .WithMany("FallbackRenderData")
                        .HasForeignKey("RenderDataId");
                });

            modelBuilder.Entity("MilesAhead.Components.WireFrame", b =>
                {
                    b.HasOne("MilesAhead.Components.RenderData", "Data")
                        .WithMany()
                        .HasForeignKey("DataId");

                    b.HasOne("MilesAhead.Components.WireFrame", null)
                        .WithMany("Children")
                        .HasForeignKey("WireFrameId");

                    b.Navigation("Data");
                });

            modelBuilder.Entity("MilesAhead.Components.WireFrameAttribute", b =>
                {
                    b.HasOne("MilesAhead.Components.WireFrame", null)
                        .WithMany("Attributes")
                        .HasForeignKey("WireFrameId");
                });

            modelBuilder.Entity("MilesAhead.Components.PrimeRoot", b =>
                {
                    b.HasOne("MilesAhead.Components.WireFrame", "MetaData")
                        .WithMany()
                        .HasForeignKey("MetaDataId");

                    b.Navigation("MetaData");
                });

            modelBuilder.Entity("MilesAhead.Components.RenderData", b =>
                {
                    b.Navigation("FallbackRenderData");

                    b.Navigation("Parameters");
                });

            modelBuilder.Entity("MilesAhead.Components.WireFrame", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
