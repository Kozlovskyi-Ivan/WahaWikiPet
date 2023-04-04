﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WahaWikiAPI.Database;

#nullable disable

namespace WahaWikiAPI.Migrations
{
    [DbContext(typeof(WahaDbContext))]
    [Migration("20221024181337_wTypeFix")]
    partial class wTypeFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WahaWikiAPI.Models.StatLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Attacks")
                        .HasColumnType("int");

                    b.Property<int>("BS")
                        .HasColumnType("int");

                    b.Property<int>("Leadership")
                        .HasColumnType("int");

                    b.Property<int>("MaxNumber")
                        .HasColumnType("int");

                    b.Property<int>("MinNumber")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Move")
                        .HasColumnType("int");

                    b.Property<int>("PointPrice")
                        .HasColumnType("int");

                    b.Property<int>("SavingThrows")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("Toughness")
                        .HasColumnType("int");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.Property<int>("WS")
                        .HasColumnType("int");

                    b.Property<int>("Wounds")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("StatLines");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<int>("UnitTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.UnitAbilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("UnitAbilities");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UnitTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitTypes");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Damage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfShot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Range")
                        .HasColumnType("int");

                    b.Property<string>("Strength")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.HasIndex("WeaponTypeId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.WeaponAbilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WeaponId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WeaponId");

                    b.ToTable("WeaponAbilities");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.WeaponType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WeaponTypes");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.StatLine", b =>
                {
                    b.HasOne("WahaWikiAPI.Models.Unit", null)
                        .WithMany("StatLineList")
                        .HasForeignKey("UnitId");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.Unit", b =>
                {
                    b.HasOne("WahaWikiAPI.Models.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitType");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.UnitAbilities", b =>
                {
                    b.HasOne("WahaWikiAPI.Models.Unit", null)
                        .WithMany("UnitAbilities")
                        .HasForeignKey("UnitId");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.Weapon", b =>
                {
                    b.HasOne("WahaWikiAPI.Models.Unit", null)
                        .WithMany("WeaponList")
                        .HasForeignKey("UnitId");

                    b.HasOne("WahaWikiAPI.Models.WeaponType", "WeaponType")
                        .WithMany()
                        .HasForeignKey("WeaponTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeaponType");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.WeaponAbilities", b =>
                {
                    b.HasOne("WahaWikiAPI.Models.Weapon", null)
                        .WithMany("Abilities")
                        .HasForeignKey("WeaponId");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.Unit", b =>
                {
                    b.Navigation("StatLineList");

                    b.Navigation("UnitAbilities");

                    b.Navigation("WeaponList");
                });

            modelBuilder.Entity("WahaWikiAPI.Models.Weapon", b =>
                {
                    b.Navigation("Abilities");
                });
#pragma warning restore 612, 618
        }
    }
}
