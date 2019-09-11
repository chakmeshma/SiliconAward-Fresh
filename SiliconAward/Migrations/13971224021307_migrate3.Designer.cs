﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiliconAward.Data;

namespace SiliconAward.Migrations
{
    [DbContext(typeof(EFDataContext))]
    [Migration("13971224021307_migrate3")]
    partial class migrate3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SiliconAward.Models.CompetitionBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetitionFieldId");

                    b.Property<DateTime?>("CreateTime");

                    b.Property<DateTime?>("LastUpdateTime");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompetitionFieldId");

                    b.ToTable("CompetitionBranchs");
                });

            modelBuilder.Entity("SiliconAward.Models.CompetitionField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<DateTime?>("LastUpdateTime");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CompetitionFields");
                });

            modelBuilder.Entity("SiliconAward.Models.CompetitionSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetitionBranchId");

                    b.Property<DateTime?>("CreateTime");

                    b.Property<DateTime?>("LastUpdateTime");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompetitionBranchId");

                    b.ToTable("CompetitionSubjects");
                });

            modelBuilder.Entity("SiliconAward.Models.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateTime");

                    b.Property<string>("DocumentType");

                    b.Property<string>("File");

                    b.Property<int?>("StatusId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("SiliconAward.Models.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AttachedFile");

                    b.Property<int>("CompetitionSubjectId");

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("LastStatusTime");

                    b.Property<DateTime?>("LastUpdateTime");

                    b.Property<int>("StatusId");

                    b.Property<string>("Subject");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionSubjectId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("SiliconAward.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateTime")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 48)))
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool?>("Editable");

                    b.Property<string>("LastUpdateTime")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 48)))
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("StatusId");

                    b.ToTable("Statues");
                });

            modelBuilder.Entity("SiliconAward.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("StatusId");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("SiliconAward.Models.TicketDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateTime")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("FileUrl")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("TicketId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("TicketDetails");
                });

            modelBuilder.Entity("SiliconAward.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<string>("CreateTime");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool?>("EmailConfirmed");

                    b.Property<string>("EmailVerifyCode");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastUpdateTime");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(14)");

                    b.Property<bool?>("PhoneNumberConfirmed");

                    b.Property<string>("PhoneNumberVerifyCode");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SiliconAward.Models.CompetitionBranch", b =>
                {
                    b.HasOne("SiliconAward.Models.CompetitionField", "CompetitionField")
                        .WithMany("CompetitionBranchs")
                        .HasForeignKey("CompetitionFieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiliconAward.Models.CompetitionSubject", b =>
                {
                    b.HasOne("SiliconAward.Models.CompetitionBranch", "CompetitionBranch")
                        .WithMany("CompetitionSubjects")
                        .HasForeignKey("CompetitionBranchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiliconAward.Models.Document", b =>
                {
                    b.HasOne("SiliconAward.Models.Status", "Status")
                        .WithMany("Documents")
                        .HasForeignKey("StatusId");

                    b.HasOne("SiliconAward.Models.User", "User")
                        .WithMany("Documents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiliconAward.Models.Participant", b =>
                {
                    b.HasOne("SiliconAward.Models.CompetitionSubject", "CompetitionSubject")
                        .WithMany("Participants")
                        .HasForeignKey("CompetitionSubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiliconAward.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiliconAward.Models.User", "User")
                        .WithMany("Participants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiliconAward.Models.Ticket", b =>
                {
                    b.HasOne("SiliconAward.Models.Status", "Status")
                        .WithMany("Tickets")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiliconAward.Models.User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SiliconAward.Models.TicketDetails", b =>
                {
                    b.HasOne("SiliconAward.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiliconAward.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
