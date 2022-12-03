﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Passel.Models;

namespace Passel.Migrations
{
    [DbContext(typeof(PasselContext))]
    [Migration("20221203231228_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Passel.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountID = 1,
                            Email = "test@test.comm",
                            Password = "test"
                        },
                        new
                        {
                            AccountID = 2,
                            Email = "test1@test.com",
                            Password = "test1"
                        });
                });

            modelBuilder.Entity("Passel.Models.Change", b =>
                {
                    b.Property<int>("ChangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangeAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChangeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChangeID");

                    b.ToTable("Changes");

                    b.HasData(
                        new
                        {
                            ChangeID = 1,
                            ChangeAuthor = "Ayden Masters",
                            ChangeDate = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ChangeDescription = "Added new look to home page.",
                            ChangeType = "Add Feature"
                        },
                        new
                        {
                            ChangeID = 2,
                            ChangeAuthor = "Ayden Masters",
                            ChangeDate = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ChangeDescription = "Added new Change Log page to the site.",
                            ChangeType = "Add Feature"
                        },
                        new
                        {
                            ChangeID = 3,
                            ChangeAuthor = "Ayden Masters",
                            ChangeDate = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ChangeDescription = "Added new Add Application page to the site.",
                            ChangeType = "Add Feature"
                        },
                        new
                        {
                            ChangeID = 4,
                            ChangeAuthor = "Ayden Masters",
                            ChangeDate = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ChangeDescription = "Started working on implementing the login page.",
                            ChangeType = "Add Feature"
                        });
                });

            modelBuilder.Entity("Passel.Models.Media", b =>
                {
                    b.Property<int>("MediaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MediaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaID");

                    b.ToTable("Medias");

                    b.HasData(
                        new
                        {
                            MediaID = 1,
                            MediaName = "YouTube",
                            MediaType = "Entertainment",
                            MediaURL = "https://www.youtube.com/"
                        },
                        new
                        {
                            MediaID = 2,
                            MediaName = "Netflix",
                            MediaType = "Entertainment",
                            MediaURL = "https://www.netflix.com/"
                        },
                        new
                        {
                            MediaID = 3,
                            MediaName = "Hulu",
                            MediaType = "Entertainment",
                            MediaURL = "https://www.hulu.com/"
                        },
                        new
                        {
                            MediaID = 4,
                            MediaName = "Twitter",
                            MediaType = "Social Media",
                            MediaURL = "https://twitter.com/"
                        },
                        new
                        {
                            MediaID = 5,
                            MediaName = "Facebook",
                            MediaType = "Social Media",
                            MediaURL = "https://www.facebook.com/"
                        },
                        new
                        {
                            MediaID = 6,
                            MediaName = "Reddit",
                            MediaType = "Social Media",
                            MediaURL = "https://www.reddit.com/"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
