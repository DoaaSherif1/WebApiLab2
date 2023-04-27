﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketSystem.DAL.Data.Context;

#nullable disable

namespace TicketSystem.DAL.Migrations
{
    [DbContext(typeof(TicketContext))]
    [Migration("20230427210137_addData")]
    partial class addData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeveloperTicket", b =>
                {
                    b.Property<int>("DevelopersId")
                        .HasColumnType("int");

                    b.Property<int>("TicketsId")
                        .HasColumnType("int");

                    b.HasKey("DevelopersId", "TicketsId");

                    b.HasIndex("TicketsId");

                    b.ToTable("DeveloperTicket");
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Diabetes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hypertension"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Asthma"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Depression"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Arthritis"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Allergy"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Flu"
                        });
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Developers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Doaa"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Emy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rowan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Miriam"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Yasmeen "
                        },
                        new
                        {
                            Id = 6,
                            Name = "Rosy= 1 "
                        },
                        new
                        {
                            Id = 7,
                            Name = "Andrew "
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ammar "
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tasha"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Max"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Bridge 2 "
                        },
                        new
                        {
                            Id = 12,
                            Name = "Juan"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Krysta 10 "
                        },
                        new
                        {
                            Id = 14,
                            Name = "Erma"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Orland 6 "
                        },
                        new
                        {
                            Id = 16,
                            Name = "Leen "
                        },
                        new
                        {
                            Id = 17,
                            Name = "Lama"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Joe"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Youmna8 "
                        },
                        new
                        {
                            Id = 20,
                            Name = "Ola "
                        },
                        new
                        {
                            Id = 21,
                            Name = "Sophy= 6 "
                        },
                        new
                        {
                            Id = 22,
                            Name = "Erenie"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Bamba"
                        },
                        new
                        {
                            Id = 24,
                            Name = "amal= 7 "
                        },
                        new
                        {
                            Id = 25,
                            Name = "Gamal= 2 "
                        },
                        new
                        {
                            Id = 26,
                            Name = "Jeje"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Michael= 6 "
                        },
                        new
                        {
                            Id = 28,
                            Name = "Maggie "
                        },
                        new
                        {
                            Id = 29,
                            Name = "Sally"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Karim"
                        });
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 5,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 6,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 7,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 5,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 7,
                            Description = "Doaa",
                            Title = "Hematology"
                        },
                        new
                        {
                            Id = 10,
                            DepartmentId = 3,
                            Description = "Doaa",
                            Title = "Hematology"
                        });
                });

            modelBuilder.Entity("DeveloperTicket", b =>
                {
                    b.HasOne("TicketSystem.DAL.Data.Models.Developer", null)
                        .WithMany()
                        .HasForeignKey("DevelopersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketSystem.DAL.Data.Models.Ticket", null)
                        .WithMany()
                        .HasForeignKey("TicketsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Ticket", b =>
                {
                    b.HasOne("TicketSystem.DAL.Data.Models.Department", "Department")
                        .WithMany("Tickets")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Department", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
