﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebASPCorePremiereApp.Models;

namespace WebASPCorePremiereApp.Migrations
{
    [DbContext(typeof(LivreDbContext))]
    [Migration("20211104113045_LivresAuteur")]
    partial class LivresAuteur
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuteurLivre", b =>
                {
                    b.Property<int>("AuteursId")
                        .HasColumnType("int");

                    b.Property<int>("LivresId")
                        .HasColumnType("int");

                    b.HasKey("AuteursId", "LivresId");

                    b.HasIndex("LivresId");

                    b.ToTable("AuteurLivre");
                });

            modelBuilder.Entity("WebASPCorePremiereApp.Models.Auteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("WebASPCorePremiereApp.Models.Livre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Annee")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThemeId")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("Livres");
                });

            modelBuilder.Entity("WebASPCorePremiereApp.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("AuteurLivre", b =>
                {
                    b.HasOne("WebASPCorePremiereApp.Models.Auteur", null)
                        .WithMany()
                        .HasForeignKey("AuteursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebASPCorePremiereApp.Models.Livre", null)
                        .WithMany()
                        .HasForeignKey("LivresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebASPCorePremiereApp.Models.Livre", b =>
                {
                    b.HasOne("WebASPCorePremiereApp.Models.Theme", "Theme")
                        .WithMany("Livres")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("WebASPCorePremiereApp.Models.Theme", b =>
                {
                    b.Navigation("Livres");
                });
#pragma warning restore 612, 618
        }
    }
}
