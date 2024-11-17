﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCSASystem.Blazor.EmployeeManagement.Data;

#nullable disable

namespace TCSASystem.Blazor.EmployeeManagement.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241111111356_Employee")]
    partial class Employee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("TCSASystem.Blazor.EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/924.jpg",
                            Name = "Callie Lehner",
                            Position = 10,
                            Salary = 80047m,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1138.jpg",
                            Name = "Tara Bartoletti",
                            Position = 1,
                            Salary = 40840m,
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/752.jpg",
                            Name = "Lauren Rolfson",
                            Position = 5,
                            Salary = 65763m,
                            Type = 3
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/913.jpg",
                            Name = "Retta Kuvalis",
                            Position = 9,
                            Salary = 49806m,
                            Type = 2
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/649.jpg",
                            Name = "Cristobal Crist",
                            Position = 7,
                            Salary = 60593m,
                            Type = 3
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1128.jpg",
                            Name = "Marielle Fay",
                            Position = 2,
                            Salary = 32115m,
                            Type = 0
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/784.jpg",
                            Name = "Ole Boyle",
                            Position = 10,
                            Salary = 63018m,
                            Type = 2
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1212.jpg",
                            Name = "Annabell Baumbach",
                            Position = 2,
                            Salary = 50241m,
                            Type = 2
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1232.jpg",
                            Name = "Gilberto Ondricka",
                            Position = 6,
                            Salary = 65872m,
                            Type = 0
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/255.jpg",
                            Name = "Arvilla Wehner",
                            Position = 5,
                            Salary = 42135m,
                            Type = 3
                        },
                        new
                        {
                            Id = 11,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/335.jpg",
                            Name = "Renee Erdman",
                            Position = 5,
                            Salary = 51199m,
                            Type = 0
                        },
                        new
                        {
                            Id = 12,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/180.jpg",
                            Name = "Madelynn Dicki",
                            Position = 2,
                            Salary = 30350m,
                            Type = 3
                        },
                        new
                        {
                            Id = 13,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1128.jpg",
                            Name = "Beverly Schumm",
                            Position = 9,
                            Salary = 98717m,
                            Type = 1
                        },
                        new
                        {
                            Id = 14,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/421.jpg",
                            Name = "Joaquin Toy",
                            Position = 7,
                            Salary = 58587m,
                            Type = 1
                        },
                        new
                        {
                            Id = 15,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/829.jpg",
                            Name = "Elouise Spinka",
                            Position = 2,
                            Salary = 89389m,
                            Type = 4
                        },
                        new
                        {
                            Id = 16,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/825.jpg",
                            Name = "Deion Lehner",
                            Position = 1,
                            Salary = 48781m,
                            Type = 1
                        },
                        new
                        {
                            Id = 17,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/469.jpg",
                            Name = "Kyle Lang",
                            Position = 1,
                            Salary = 75729m,
                            Type = 1
                        },
                        new
                        {
                            Id = 18,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/423.jpg",
                            Name = "Kenna Grady",
                            Position = 2,
                            Salary = 57957m,
                            Type = 0
                        },
                        new
                        {
                            Id = 19,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1214.jpg",
                            Name = "Carmel Ankunding",
                            Position = 0,
                            Salary = 63328m,
                            Type = 3
                        },
                        new
                        {
                            Id = 20,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1229.jpg",
                            Name = "Miles Oberbrunner",
                            Position = 3,
                            Salary = 95030m,
                            Type = 3
                        },
                        new
                        {
                            Id = 21,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/63.jpg",
                            Name = "Richie McDermott",
                            Position = 1,
                            Salary = 85453m,
                            Type = 1
                        },
                        new
                        {
                            Id = 22,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/916.jpg",
                            Name = "Libbie Barton",
                            Position = 3,
                            Salary = 50786m,
                            Type = 3
                        },
                        new
                        {
                            Id = 23,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/556.jpg",
                            Name = "Malinda Wunsch",
                            Position = 4,
                            Salary = 93884m,
                            Type = 4
                        },
                        new
                        {
                            Id = 24,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1192.jpg",
                            Name = "Shea Dietrich",
                            Position = 4,
                            Salary = 56575m,
                            Type = 4
                        },
                        new
                        {
                            Id = 25,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1131.jpg",
                            Name = "Ariel Upton",
                            Position = 5,
                            Salary = 59242m,
                            Type = 1
                        },
                        new
                        {
                            Id = 26,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/603.jpg",
                            Name = "Derrick Rowe",
                            Position = 6,
                            Salary = 58489m,
                            Type = 0
                        },
                        new
                        {
                            Id = 27,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1043.jpg",
                            Name = "Savanah Gorczany",
                            Position = 7,
                            Salary = 84625m,
                            Type = 2
                        },
                        new
                        {
                            Id = 28,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/573.jpg",
                            Name = "Joany Crona",
                            Position = 7,
                            Salary = 47295m,
                            Type = 2
                        },
                        new
                        {
                            Id = 29,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/587.jpg",
                            Name = "Caleb Dicki",
                            Position = 1,
                            Salary = 37664m,
                            Type = 3
                        },
                        new
                        {
                            Id = 30,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/845.jpg",
                            Name = "Antone Ullrich",
                            Position = 3,
                            Salary = 42624m,
                            Type = 3
                        },
                        new
                        {
                            Id = 31,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/623.jpg",
                            Name = "Mylene Kohler",
                            Position = 3,
                            Salary = 58377m,
                            Type = 0
                        },
                        new
                        {
                            Id = 32,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/691.jpg",
                            Name = "Kennedi Hackett",
                            Position = 2,
                            Salary = 68555m,
                            Type = 4
                        },
                        new
                        {
                            Id = 33,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/459.jpg",
                            Name = "Josiah Hane",
                            Position = 5,
                            Salary = 74361m,
                            Type = 2
                        },
                        new
                        {
                            Id = 34,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1059.jpg",
                            Name = "Norberto Leffler",
                            Position = 0,
                            Salary = 75770m,
                            Type = 1
                        },
                        new
                        {
                            Id = 35,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1033.jpg",
                            Name = "Matteo Collins",
                            Position = 6,
                            Salary = 53194m,
                            Type = 0
                        },
                        new
                        {
                            Id = 36,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/852.jpg",
                            Name = "Rahul Reilly",
                            Position = 8,
                            Salary = 53185m,
                            Type = 1
                        },
                        new
                        {
                            Id = 37,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/542.jpg",
                            Name = "Kelvin Kiehn",
                            Position = 1,
                            Salary = 83489m,
                            Type = 3
                        },
                        new
                        {
                            Id = 38,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/987.jpg",
                            Name = "Vincenza Casper",
                            Position = 3,
                            Salary = 64008m,
                            Type = 3
                        },
                        new
                        {
                            Id = 39,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/446.jpg",
                            Name = "Enrique Zboncak",
                            Position = 8,
                            Salary = 47440m,
                            Type = 0
                        },
                        new
                        {
                            Id = 40,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/274.jpg",
                            Name = "Mossie Bartoletti",
                            Position = 0,
                            Salary = 91729m,
                            Type = 1
                        },
                        new
                        {
                            Id = 41,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/662.jpg",
                            Name = "Joshuah Prohaska",
                            Position = 8,
                            Salary = 58956m,
                            Type = 0
                        },
                        new
                        {
                            Id = 42,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1233.jpg",
                            Name = "Kian Sipes",
                            Position = 8,
                            Salary = 56553m,
                            Type = 2
                        },
                        new
                        {
                            Id = 43,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/915.jpg",
                            Name = "Glenda Watsica",
                            Position = 9,
                            Salary = 60298m,
                            Type = 0
                        },
                        new
                        {
                            Id = 44,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/524.jpg",
                            Name = "Cassie Jenkins",
                            Position = 2,
                            Salary = 91989m,
                            Type = 4
                        },
                        new
                        {
                            Id = 45,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/804.jpg",
                            Name = "Lucio Mosciski",
                            Position = 10,
                            Salary = 64199m,
                            Type = 0
                        },
                        new
                        {
                            Id = 46,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/596.jpg",
                            Name = "Shanon Conn",
                            Position = 0,
                            Salary = 39958m,
                            Type = 4
                        },
                        new
                        {
                            Id = 47,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1161.jpg",
                            Name = "Karelle Gleason",
                            Position = 7,
                            Salary = 66441m,
                            Type = 0
                        },
                        new
                        {
                            Id = 48,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/843.jpg",
                            Name = "Weston Carroll",
                            Position = 3,
                            Salary = 80148m,
                            Type = 3
                        },
                        new
                        {
                            Id = 49,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/372.jpg",
                            Name = "Brock Hoppe",
                            Position = 6,
                            Salary = 36610m,
                            Type = 2
                        },
                        new
                        {
                            Id = 50,
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/85.jpg",
                            Name = "Maya Swift",
                            Position = 8,
                            Salary = 99714m,
                            Type = 3
                        });
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
