﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Voetbalploegen;

#nullable disable

namespace Voetbalploegen.Migrations
{
    [DbContext(typeof(VoetbalploegenContext))]
    [Migration("20220216235121_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Voetbalploegen.Club", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Aansluitingsjaar")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bijnamen")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Budget")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Opgericht")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sponsors")
                        .HasColumnType("TEXT");

                    b.Property<string>("Stadion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefoon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Voetbalploegen.Speler", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AantalGeleKaarten")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AantalGespeeldeMinuten")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AantalKeerTitularis")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AantalKeerVervangen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AantalRodeKaarten")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Assists")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClubId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("TEXT");

                    b.Property<int>("Goals")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nationaliteit")
                        .HasColumnType("TEXT");

                    b.Property<string>("Positie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Rechtsvoetig")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Wedstrijden")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Spelers");
                });

            modelBuilder.Entity("Voetbalploegen.Wedstrijd", b =>
                {
                    b.Property<string>("ThuisploegId")
                        .HasColumnType("TEXT");

                    b.Property<string>("BezoekersId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ThuisploegScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BezoekersScore")
                        .HasColumnType("INTEGER");

                    b.HasKey("ThuisploegId", "BezoekersId", "ThuisploegScore", "BezoekersScore");

                    b.HasIndex("BezoekersId");

                    b.ToTable("Wedstrijden");
                });

            modelBuilder.Entity("Voetbalploegen.Speler", b =>
                {
                    b.HasOne("Voetbalploegen.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("Voetbalploegen.Wedstrijd", b =>
                {
                    b.HasOne("Voetbalploegen.Club", "Bezoekers")
                        .WithMany()
                        .HasForeignKey("BezoekersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voetbalploegen.Club", "Thuisploeg")
                        .WithMany()
                        .HasForeignKey("ThuisploegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bezoekers");

                    b.Navigation("Thuisploeg");
                });
#pragma warning restore 612, 618
        }
    }
}