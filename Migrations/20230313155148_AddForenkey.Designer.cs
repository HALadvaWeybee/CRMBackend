﻿// <auto-generated />
using System;
using CRMBackend.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRMBackend.Migrations
{
    [DbContext(typeof(RMbackendContext))]
    [Migration("20230313155148_AddForenkey")]
    partial class AddForenkey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRMBackend.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountriesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.HasIndex("StatesId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ContactEvent", b =>
                {
                    b.Property<int>("ContactsId")
                        .HasColumnType("int");

                    b.Property<int>("ManageEventsId")
                        .HasColumnType("int");

                    b.HasKey("ContactsId", "ManageEventsId");

                    b.HasIndex("ManageEventsId");

                    b.ToTable("ContactEvent");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.Contacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhoneNo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhoneNo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ImportantDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImportantDateDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationORIndividualId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Person2Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Person2Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Person2Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Person2Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PersonBirthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonPhoneNo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonPhoneNo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonPinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationORIndividualId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("ManageCategory");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("ContactCount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationORIndividualId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationORIndividualId");

                    b.ToTable("ManageEvent");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationORIndividualId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationORIndividualId");

                    b.ToTable("ManageGroup");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageSubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ManageSubCategory");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.OrganizationORIndividual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrganizationORIndividual");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.RecipientsEmails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserEmailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserEmailId");

                    b.ToTable("RecipientsEmails");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.RecipientsPhoneNos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserSMSId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserSMSId");

                    b.ToTable("RecipientsPhoneNos");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.Reminder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationORIndividualId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationORIndividualId");

                    b.ToTable("Reminders");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.States", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContactsId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactsId");

                    b.ToTable("UserDocument");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationORIndividualId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationORIndividualId");

                    b.ToTable("UserEmails");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContactsId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactsId");

                    b.ToTable("UserNote");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContactsId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactsId");

                    b.ToTable("UserPhoto");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserSMS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationORIndividualId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationORIndividualId");

                    b.ToTable("UserSMSs");
                });

            modelBuilder.Entity("CRMBackend.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("OrganizationORIndividualId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("OrganizationORIndividualId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CRMBackend.Data.Models.City", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.Countries", "Countries")
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMBackend.Data.Models.States", "States")
                        .WithMany("Cities")
                        .HasForeignKey("StatesId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Countries");

                    b.Navigation("States");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ContactEvent", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.Contacts", "Contacts")
                        .WithMany("ContactEvent")
                        .HasForeignKey("ContactsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CRMBackend.Data.Models.ManageEvent", "ManageEvents")
                        .WithMany("ContactEvent")
                        .HasForeignKey("ManageEventsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Contacts");

                    b.Navigation("ManageEvents");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.Contacts", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.OrganizationORIndividual", "OrganizationORIndividual")
                        .WithMany()
                        .HasForeignKey("OrganizationORIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationORIndividual");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageCategory", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.ManageGroup", "Group")
                        .WithMany("Categories")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageEvent", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.OrganizationORIndividual", "OrganizationORIndividual")
                        .WithMany()
                        .HasForeignKey("OrganizationORIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationORIndividual");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageGroup", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.OrganizationORIndividual", "OrganizationORIndividual")
                        .WithMany()
                        .HasForeignKey("OrganizationORIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationORIndividual");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageSubCategory", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.ManageCategory", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.RecipientsEmails", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.UserEmail", "UserEmail")
                        .WithMany("Recipients")
                        .HasForeignKey("UserEmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEmail");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.RecipientsPhoneNos", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.UserSMS", "UserSMS")
                        .WithMany("Recipients")
                        .HasForeignKey("UserSMSId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserSMS");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.Reminder", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.OrganizationORIndividual", "OrganizationORIndividual")
                        .WithMany()
                        .HasForeignKey("OrganizationORIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationORIndividual");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.States", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.Countries", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserDocument", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.Contacts", "Contacts")
                        .WithMany()
                        .HasForeignKey("ContactsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserEmail", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.OrganizationORIndividual", "OrganizationORIndividual")
                        .WithMany()
                        .HasForeignKey("OrganizationORIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationORIndividual");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserNote", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.Contacts", "Contacts")
                        .WithMany("UserNotes")
                        .HasForeignKey("ContactsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserPhoto", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.Contacts", "Contacts")
                        .WithMany("UserPhotos")
                        .HasForeignKey("ContactsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserSMS", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.OrganizationORIndividual", "OrganizationORIndividual")
                        .WithMany()
                        .HasForeignKey("OrganizationORIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationORIndividual");
                });

            modelBuilder.Entity("CRMBackend.Models.ApplicationUser", b =>
                {
                    b.HasOne("CRMBackend.Data.Models.OrganizationORIndividual", "OrganizationORIndividual")
                        .WithMany()
                        .HasForeignKey("OrganizationORIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationORIndividual");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CRMBackend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CRMBackend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMBackend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CRMBackend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CRMBackend.Data.Models.Contacts", b =>
                {
                    b.Navigation("ContactEvent");

                    b.Navigation("UserNotes");

                    b.Navigation("UserPhotos");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.Countries", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageCategory", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageEvent", b =>
                {
                    b.Navigation("ContactEvent");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.ManageGroup", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.States", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserEmail", b =>
                {
                    b.Navigation("Recipients");
                });

            modelBuilder.Entity("CRMBackend.Data.Models.UserSMS", b =>
                {
                    b.Navigation("Recipients");
                });
#pragma warning restore 612, 618
        }
    }
}
