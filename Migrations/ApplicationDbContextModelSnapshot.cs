﻿// <auto-generated />
using System;
using ASM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASM.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASM.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "George Beekman",
                            CategoryId = 1,
                            ISBN = "1292021063",
                            Image = "https://m.media-amazon.com/images/I/41KpijH6OML._SX392_BO1,204,203,200_.jpg",
                            PublicationDate = new DateTime(2013, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Pearson",
                            Title = "Digital Planet: Pearson New International Edition: Tomorrow's Technology and You, Complete"
                        },
                        new
                        {
                            Id = 2,
                            Author = "ClydeBank Technology",
                            CategoryId = 1,
                            ISBN = "1945051086",
                            Image = "https://m.media-amazon.com/images/I/41p8fQ6kRfL._SX331_BO1,204,203,200_.jpg",
                            PublicationDate = new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = " ClydeBank Media LLC",
                            Title = "ITSM: QuickStart Guide - The Simplified Beginner's Guide to IT Service Management"
                        },
                        new
                        {
                            Id = 3,
                            Author = "James Bernstein",
                            CategoryId = 1,
                            ISBN = "1983154830",
                            Image = "https://m.media-amazon.com/images/I/41sSdMa14gL._SX348_BO1,204,203,200_.jpg",
                            PublicationDate = new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Independently published",
                            Title = "Computers Made Easy: From Dummy To Geek"
                        });
                });

            modelBuilder.Entity("ASM.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryDescription = "A Academic Book for academical uses",
                            CategoryName = "Academic"
                        });
                });

            modelBuilder.Entity("ASM.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("OrderPrice")
                        .HasColumnType("float");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "A",
<<<<<<< HEAD
                            ConcurrencyStamp = "c498bd45-c74e-4027-ab0b-89b410bdb2cf",
=======
                            ConcurrencyStamp = "f763332b-374a-4e38-9086-ba8077693039",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "B",
<<<<<<< HEAD
                            ConcurrencyStamp = "c02a52e1-0bf9-4083-81e6-0f247feba62d",
=======
                            ConcurrencyStamp = "bfc1ce6a-6dfc-41f2-a78c-0e4d49dd4fa1",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "C",
<<<<<<< HEAD
                            ConcurrencyStamp = "4d89a696-96b5-48e2-b944-c8dea5b6f5f9",
=======
                            ConcurrencyStamp = "7357cb27-d99a-41fd-b6a5-7d4068d46884",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            Name = "Staff",
                            NormalizedName = "Staff"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
<<<<<<< HEAD
                            ConcurrencyStamp = "1ff43160-eed8-42bd-94cf-87e6b1d25a56",
=======
                            ConcurrencyStamp = "18f3d524-50d0-4044-9e40-a2fdd5428fc5",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            Email = "admin@fpt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "admin@fpt.com",
<<<<<<< HEAD
                            PasswordHash = "AQAAAAEAACcQAAAAEBUxAjWTT8WN8zS81keSQ+6Ngq/oDtuOY7Y1tCuYtMBNnEeiOSB3JzeGoD+zcE993Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1aae312b-0a5a-4800-9d4e-2f56bce7ddef",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEEHSv3jgNve4S3UL/kdISlXJZHjdpuQVnXYHUxGncznY+XNohBjRt/5f2qYXAAWaJw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ec02c351-431e-46b8-9772-8211432328ff",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            TwoFactorEnabled = false,
                            UserName = "admin@fpt.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
<<<<<<< HEAD
                            ConcurrencyStamp = "617ab8d6-8859-43ba-8ffe-300b163013ea",
=======
                            ConcurrencyStamp = "4ab2d9fa-a21b-4950-99d1-d1659cf4d40e",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            Email = "customer@fpt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "customer@fpt.com",
<<<<<<< HEAD
                            PasswordHash = "AQAAAAEAACcQAAAAEC3kLgZ1OOPXpiIGHFT3F/7EBISvl3fFLz2b9tR7Uvp3qTikwDHwlOxltCI2Sw1MrA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b355005f-28ea-492a-8799-59a97c939894",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAED8075cUTvQv00LmRO31zbthOTg8+7i94PBpLh+Jx4gQsh8g6VWigheQDcRTAhvnQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "080104dc-ad91-461f-96cc-75055c88c4db",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            TwoFactorEnabled = false,
                            UserName = "customer@fpt.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
<<<<<<< HEAD
                            ConcurrencyStamp = "09c2988f-869e-48fc-b763-9e3b09c01c53",
=======
                            ConcurrencyStamp = "fadee8d5-be09-4f76-ada2-3e1ca9e114c8",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            Email = "staff@fpt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "staff@fpt.com",
<<<<<<< HEAD
                            PasswordHash = "AQAAAAEAACcQAAAAECWEJTL4Z6L4euMc6cR93N7tQSoLHM0kHQxEXOeuaPdLO8byV1UoPPnltTYVJhLacA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2bb4bad2-7fc6-4251-98ca-97e35741d92c",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEOsOHW3j5oW1xZT+WgM0gpVp0xeUk0O0yTeq5AE+mQQwBn1INTkCcCZuWOn0OWMtoA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9ef9f0a7-a178-419d-afdc-bb621ee462e4",
>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d
                            TwoFactorEnabled = false,
                            UserName = "staff@fpt.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "A"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "B"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "C"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ASM.Models.Book", b =>
                {
                    b.HasOne("ASM.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASM.Models.Order", b =>
                {
                    b.HasOne("ASM.Models.Book", "book")
                        .WithMany("Orders")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
