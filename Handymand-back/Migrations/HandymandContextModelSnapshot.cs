﻿// <auto-generated />
using System;
using Handymand.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Handymand.Migrations
{
    [DbContext(typeof(HandymandContext))]
    partial class HandymandContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Handymand.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bucuresti"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Iasi"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cluj"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Timisoara"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Constanta"
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Craiova"
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Brasov"
                        },
                        new
                        {
                            Id = 8,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Galati"
                        },
                        new
                        {
                            Id = 9,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ploiesti"
                        },
                        new
                        {
                            Id = 10,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Oradea"
                        },
                        new
                        {
                            Id = 11,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Braila"
                        },
                        new
                        {
                            Id = 12,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Arad"
                        },
                        new
                        {
                            Id = 13,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Buzau"
                        },
                        new
                        {
                            Id = 14,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Botosani"
                        },
                        new
                        {
                            Id = 15,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Suceava"
                        },
                        new
                        {
                            Id = 16,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Drobeta-Turnu Severin"
                        },
                        new
                        {
                            Id = 17,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Slatina"
                        },
                        new
                        {
                            Id = 18,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Deva"
                        });
                });

            modelBuilder.Entity("Handymand.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdUser")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Handymand.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreationUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobOfferId")
                        .HasColumnType("int");

                    b.Property<double>("PaymentAmountPerHour")
                        .HasColumnType("float");

                    b.Property<int>("RefferedUserId")
                        .HasColumnType("int");

                    b.Property<bool>("Valid")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreationUserId");

                    b.HasIndex("JobOfferId")
                        .IsUnique();

                    b.HasIndex("RefferedUserId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Handymand.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreationUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FromClientToFreelancer")
                        .HasColumnType("bit");

                    b.Property<bool>("FromFreelancerToClient")
                        .HasColumnType("bit");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("JobOfferId")
                        .HasColumnType("int");

                    b.Property<int>("RefferedUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreationUserId");

                    b.HasIndex("JobOfferId")
                        .IsUnique();

                    b.HasIndex("RefferedUserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Handymand.Models.Freelancer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUser")
                        .IsUnique();

                    b.ToTable("Freelancers");
                });

            modelBuilder.Entity("Handymand.Models.FreelancersSkills", b =>
                {
                    b.Property<int>("IdFreelancer")
                        .HasColumnType("int");

                    b.Property<int>("IdSkill")
                        .HasColumnType("int");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.HasKey("IdFreelancer", "IdSkill");

                    b.HasIndex("IdSkill");

                    b.ToTable("FreelancersSkills");
                });

            modelBuilder.Entity("Handymand.Models.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CreationUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HighPriceRange")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LowPriceRange")
                        .HasColumnType("float");

                    b.Property<int?>("NoImages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("JobOffer");
                });

            modelBuilder.Entity("Handymand.Models.JobOffersSkills", b =>
                {
                    b.Property<int>("IdSkill")
                        .HasColumnType("int");

                    b.Property<int>("IdJobOffer")
                        .HasColumnType("int");

                    b.HasKey("IdSkill", "IdJobOffer");

                    b.HasIndex("IdJobOffer");

                    b.ToTable("JobOffersSkills");
                });

            modelBuilder.Entity("Handymand.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CreationUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobOfferId")
                        .HasColumnType("int");

                    b.Property<double>("PaymentAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CreationUserId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Handymand.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreationUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModificationUserId")
                        .HasColumnType("int");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreationUserId");

                    b.HasIndex("ModificationUserId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Handymand.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Blocked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WalletAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Handymand.Models.Client", b =>
                {
                    b.HasOne("Handymand.Models.User", "User")
                        .WithOne("ClientAccount")
                        .HasForeignKey("Handymand.Models.Client", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Handymand.Models.Contract", b =>
                {
                    b.HasOne("Handymand.Models.User", "CreationUser")
                        .WithMany("CreatedContracts")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Handymand.Models.JobOffer", "JobOffer")
                        .WithOne("Contract")
                        .HasForeignKey("Handymand.Models.Contract", "JobOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Handymand.Models.User", "RefferedUser")
                        .WithMany("AcceptedContracts")
                        .HasForeignKey("RefferedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreationUser");

                    b.Navigation("JobOffer");

                    b.Navigation("RefferedUser");
                });

            modelBuilder.Entity("Handymand.Models.Feedback", b =>
                {
                    b.HasOne("Handymand.Models.User", "CreationUser")
                        .WithMany("CreatedFeedbacks")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Handymand.Models.JobOffer", "JobOffer")
                        .WithOne("Feedback")
                        .HasForeignKey("Handymand.Models.Feedback", "JobOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Handymand.Models.User", "RefferedUser")
                        .WithMany("ReceivedFeedback")
                        .HasForeignKey("RefferedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreationUser");

                    b.Navigation("JobOffer");

                    b.Navigation("RefferedUser");
                });

            modelBuilder.Entity("Handymand.Models.Freelancer", b =>
                {
                    b.HasOne("Handymand.Models.User", "User")
                        .WithOne("FreelancerAccount")
                        .HasForeignKey("Handymand.Models.Freelancer", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Handymand.Models.FreelancersSkills", b =>
                {
                    b.HasOne("Handymand.Models.Freelancer", "Freelancer")
                        .WithMany("FreelancersSkills")
                        .HasForeignKey("IdFreelancer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Handymand.Models.Skill", "Skill")
                        .WithMany("FreelancersSkills")
                        .HasForeignKey("IdSkill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Freelancer");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Handymand.Models.JobOffer", b =>
                {
                    b.HasOne("Handymand.Models.City", "City")
                        .WithMany("JobOffers")
                        .HasForeignKey("CityId");

                    b.HasOne("Handymand.Models.User", "CreationUser")
                        .WithMany("CreatedJobOffers")
                        .HasForeignKey("CreationUserId");

                    b.Navigation("City");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Handymand.Models.JobOffersSkills", b =>
                {
                    b.HasOne("Handymand.Models.JobOffer", "JobOffer")
                        .WithMany("JobOffersSkills")
                        .HasForeignKey("IdJobOffer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Handymand.Models.Skill", "Skill")
                        .WithMany("JobOffersSkills")
                        .HasForeignKey("IdSkill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobOffer");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Handymand.Models.Offer", b =>
                {
                    b.HasOne("Handymand.Models.User", "CreationUser")
                        .WithMany()
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Handymand.Models.JobOffer", "JobOffer")
                        .WithMany("Offers")
                        .HasForeignKey("JobOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreationUser");

                    b.Navigation("JobOffer");
                });

            modelBuilder.Entity("Handymand.Models.Skill", b =>
                {
                    b.HasOne("Handymand.Models.User", "CreationUser")
                        .WithMany()
                        .HasForeignKey("CreationUserId");

                    b.HasOne("Handymand.Models.User", "ModificationUser")
                        .WithMany()
                        .HasForeignKey("ModificationUserId");

                    b.Navigation("CreationUser");

                    b.Navigation("ModificationUser");
                });

            modelBuilder.Entity("Handymand.Models.City", b =>
                {
                    b.Navigation("JobOffers");
                });

            modelBuilder.Entity("Handymand.Models.Freelancer", b =>
                {
                    b.Navigation("FreelancersSkills");
                });

            modelBuilder.Entity("Handymand.Models.JobOffer", b =>
                {
                    b.Navigation("Contract");

                    b.Navigation("Feedback");

                    b.Navigation("JobOffersSkills");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("Handymand.Models.Skill", b =>
                {
                    b.Navigation("FreelancersSkills");

                    b.Navigation("JobOffersSkills");
                });

            modelBuilder.Entity("Handymand.Models.User", b =>
                {
                    b.Navigation("AcceptedContracts");

                    b.Navigation("ClientAccount");

                    b.Navigation("CreatedContracts");

                    b.Navigation("CreatedFeedbacks");

                    b.Navigation("CreatedJobOffers");

                    b.Navigation("FreelancerAccount");

                    b.Navigation("ReceivedFeedback");
                });
#pragma warning restore 612, 618
        }
    }
}
