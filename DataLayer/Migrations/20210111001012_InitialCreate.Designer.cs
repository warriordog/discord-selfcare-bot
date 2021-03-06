﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelfcareBot.DataLayer.context;

namespace SelfcareBot.DataLayer.Migrations
{
    [DbContext(typeof(SelfcareDbContext))]
    [Migration("20210111001012_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SelfcareBot.DataLayer.entities.KnownUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("DiscordId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasAlternateKey("DiscordId");

                    b.ToTable("KnownUsers");
                });

            modelBuilder.Entity("SelfcareBot.DataLayer.entities.UserScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("KnownUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KnownUserId");

                    b.ToTable("UserScores");
                });

            modelBuilder.Entity("SelfcareBot.DataLayer.entities.UserScore", b =>
                {
                    b.HasOne("SelfcareBot.DataLayer.entities.KnownUser", "KnownUser")
                        .WithMany("UserScores")
                        .HasForeignKey("KnownUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KnownUser");
                });

            modelBuilder.Entity("SelfcareBot.DataLayer.entities.KnownUser", b =>
                {
                    b.Navigation("UserScores");
                });
#pragma warning restore 612, 618
        }
    }
}
