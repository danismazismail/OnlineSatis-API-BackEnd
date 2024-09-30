﻿// <auto-generated />
using System;
using DataAccess.Context.ApplicationContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240812193545_UpdateSeedDatas")]
    partial class UpdateSeedDatas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Entites.Concrete.Company", b =>
                {
                    b.Property<long>("CompanyCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CompanyCode"));

                    b.Property<string>("AuthorizedPerson")
                        .HasColumnType("text");

                    b.Property<string>("CompanyEmail")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("CompanyPhone")
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserCode")
                        .HasColumnType("bigint");

                    b.HasKey("CompanyCode");

                    b.HasIndex("AuthorizedPerson")
                        .IsUnique();

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.HasIndex("TaxId")
                        .IsUnique();

                    b.HasIndex("UserCode");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.DailyForeignCurrencyPrice", b =>
                {
                    b.Property<long>("DailyForeignCurrencyPriceCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("DailyForeignCurrencyPriceCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("ForeignCurrencyCode")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ForeignCurrencyPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("DailyForeignCurrencyPriceCode");

                    b.HasIndex("ForeignCurrencyCode");

                    b.ToTable("DailyForeignCurrencyPrice");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.ForeignCurrency", b =>
                {
                    b.Property<long>("ForeignCurrencyCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ForeignCurrencyCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ForeignCurrencyLongName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ForeignCurrencyCode");

                    b.HasIndex("ForeignCurrencyCode")
                        .IsUnique();

                    b.ToTable("ForeignCurrency");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.Job", b =>
                {
                    b.Property<long>("JobCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("JobCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("JobDescription")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal>("JobPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("JobCode");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.Machine", b =>
                {
                    b.Property<long>("MachineCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("MachineCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("MachineCode");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.Role", b =>
                {
                    b.Property<string>("RoleCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RoleDescription")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("RoleCode");

                    b.HasIndex("RoleCode")
                        .IsUnique();

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.User", b =>
                {
                    b.Property<long>("UserCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserTypeCode")
                        .HasColumnType("bigint");

                    b.HasKey("UserCode");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("MobilePhone")
                        .IsUnique();

                    b.HasIndex("UserTypeCode");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserDetail", b =>
                {
                    b.Property<long>("UserDetailCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserDetailCode"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserCode")
                        .HasColumnType("bigint");

                    b.HasKey("UserDetailCode");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.HasIndex("UserCode")
                        .IsUnique();

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserJob", b =>
                {
                    b.Property<long>("UserJobCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserJobCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("JobCode")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("JobPriceWithSpecialDiscount")
                        .HasColumnType("numeric");

                    b.Property<int>("Piece")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserCode")
                        .HasColumnType("bigint");

                    b.HasKey("UserJobCode");

                    b.HasIndex("JobCode");

                    b.HasIndex("UserCode");

                    b.ToTable("UserJob");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserRole", b =>
                {
                    b.Property<long>("UserRoleCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserRoleCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RoleCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserCode")
                        .HasColumnType("bigint");

                    b.HasKey("UserRoleCode");

                    b.HasIndex("RoleCode");

                    b.HasIndex("UserCode");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserType", b =>
                {
                    b.Property<long>("UserTypeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserTypeCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserTypeDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("UserTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("UserTypeCode");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.Company", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.User", "User")
                        .WithMany("Companies")
                        .HasForeignKey("UserCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.DailyForeignCurrencyPrice", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.ForeignCurrency", "ForeignCurrency")
                        .WithMany("DailyForeignCurrencyPrices")
                        .HasForeignKey("ForeignCurrencyCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ForeignCurrency");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.User", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserDetail", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("Entities.Entites.Concrete.UserDetail", "UserCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserJob", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.Job", "Job")
                        .WithMany("UserJobs")
                        .HasForeignKey("JobCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entites.Concrete.User", "User")
                        .WithMany("UserJobs")
                        .HasForeignKey("UserCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserRole", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entites.Concrete.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.ForeignCurrency", b =>
                {
                    b.Navigation("DailyForeignCurrencyPrices");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.Job", b =>
                {
                    b.Navigation("UserJobs");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.User", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("UserDetail")
                        .IsRequired();

                    b.Navigation("UserJobs");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}