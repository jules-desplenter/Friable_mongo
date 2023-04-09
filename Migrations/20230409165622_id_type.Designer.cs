﻿// <auto-generated />
using System;
using Friable_mongo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Friable_mongo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230409165622_id_type")]
    partial class id_type
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Friable_mongo.InfoModels.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdentificationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentificationId")
                        .IsUnique();

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.CollectionMark", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdentificationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentificationId");

                    b.ToTable("CollectionMarks");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Date", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdentificationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentificationId")
                        .IsUnique();

                    b.ToTable("Dates");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Identification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Bottom")
                        .HasColumnType("int");

                    b.Property<string>("Framed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InvetoryNumber")
                        .HasColumnType("int");

                    b.Property<int?>("Left")
                        .HasColumnType("int");

                    b.Property<string>("MaterialsSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Right")
                        .HasColumnType("int");

                    b.Property<string>("Support")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechniquesSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleDutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Top")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationID")
                        .IsUnique();

                    b.ToTable("Identifications");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Inscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdentificationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentificationId");

                    b.ToTable("Inscriptions");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Mounting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Assemblage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConditionRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamageSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Surface")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationID")
                        .IsUnique();

                    b.ToTable("Mountings");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.PrimaryPictorial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DamageSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fixative")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FriableMediaSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherMediaSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemarksCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemarksDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SupportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechniquesSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SupportId")
                        .IsUnique();

                    b.ToTable("Pictorials");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.PrimarySupport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Assemblage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamageSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperType1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperType2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperType3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pinholed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RectoVerso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RemarksCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemarksDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Watermark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WatermarkDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WatermarkLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationID")
                        .IsUnique();

                    b.ToTable("Supports");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Registration", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Function")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.SecondaryPictorial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DamageSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fixative")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FriableMediaSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherMediaSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemarksCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemarksDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SupportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechniquesSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SupportId")
                        .IsUnique();

                    b.ToTable("SecondaryPictorial");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.SecondarySupport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Assemblage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamageSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperType1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperType2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperType3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pinholed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RectoVerso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RemarksCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemarksDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Watermark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WatermarkDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WatermarkLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationID")
                        .IsUnique();

                    b.ToTable("SecondarySupport");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Signature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdentificationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentificationId")
                        .IsUnique();

                    b.ToTable("Signatures");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Storage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationNumber")
                        .HasColumnType("int");

                    b.Property<string>("MaterialSerialized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StorageType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationID")
                        .IsUnique();

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Artist", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Identification", "Identification")
                        .WithOne("Artist")
                        .HasForeignKey("Friable_mongo.InfoModels.Artist", "IdentificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identification");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.CollectionMark", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Identification", "Identification")
                        .WithMany("CollectionMarks")
                        .HasForeignKey("IdentificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identification");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Date", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Identification", "Identification")
                        .WithOne("Date")
                        .HasForeignKey("Friable_mongo.InfoModels.Date", "IdentificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identification");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Identification", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Registration", "Registration")
                        .WithOne("Identification")
                        .HasForeignKey("Friable_mongo.InfoModels.Identification", "RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Inscription", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Identification", "Identification")
                        .WithMany("Inscriptions")
                        .HasForeignKey("IdentificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identification");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Mounting", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Registration", "Registration")
                        .WithOne("Mounting")
                        .HasForeignKey("Friable_mongo.InfoModels.Mounting", "RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.PrimaryPictorial", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.PrimarySupport", "Support")
                        .WithOne("Pictorial")
                        .HasForeignKey("Friable_mongo.InfoModels.PrimaryPictorial", "SupportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Support");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.PrimarySupport", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Registration", "Registration")
                        .WithOne("PrimarySupport")
                        .HasForeignKey("Friable_mongo.InfoModels.PrimarySupport", "RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.SecondaryPictorial", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.SecondarySupport", "Support")
                        .WithOne("Pictorial")
                        .HasForeignKey("Friable_mongo.InfoModels.SecondaryPictorial", "SupportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Support");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.SecondarySupport", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Registration", "Registration")
                        .WithOne("SecondarySupport")
                        .HasForeignKey("Friable_mongo.InfoModels.SecondarySupport", "RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Signature", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Identification", "Identification")
                        .WithOne("Signature")
                        .HasForeignKey("Friable_mongo.InfoModels.Signature", "IdentificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identification");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Storage", b =>
                {
                    b.HasOne("Friable_mongo.InfoModels.Registration", "Registration")
                        .WithOne("Storage")
                        .HasForeignKey("Friable_mongo.InfoModels.Storage", "RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Identification", b =>
                {
                    b.Navigation("Artist");

                    b.Navigation("CollectionMarks");

                    b.Navigation("Date");

                    b.Navigation("Inscriptions");

                    b.Navigation("Signature");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.PrimarySupport", b =>
                {
                    b.Navigation("Pictorial");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.Registration", b =>
                {
                    b.Navigation("Identification");

                    b.Navigation("Mounting");

                    b.Navigation("PrimarySupport");

                    b.Navigation("SecondarySupport");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("Friable_mongo.InfoModels.SecondarySupport", b =>
                {
                    b.Navigation("Pictorial");
                });
#pragma warning restore 612, 618
        }
    }
}
