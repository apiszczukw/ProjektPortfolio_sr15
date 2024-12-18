﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektPortfolio_czw15.DAL;

#nullable disable

namespace ProjektPortfolio_czw15.Migrations
{
    [DbContext(typeof(ProjektyContext))]
    [Migration("20241218143742_poprawkiNaDanych")]
    partial class poprawkiNaDanych
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjektPortfolio_czw15.Models.Projekt", b =>
                {
                    b.Property<int>("ProjektId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjektId"), 1L, 1);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obrazek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technologie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjektId");

                    b.ToTable("Projekty");

                    b.HasData(
                        new
                        {
                            ProjektId = 1,
                            Nazwa = "Portfolio Web Developer",
                            Obrazek = "https://picsum.photos/200/300?random=1",
                            Opis = "Strona internetowa prezentująca moje umiejętności, projekty i doświadczenie.",
                            Technologie = "HTML, CSS, JavaScript, React"
                        },
                        new
                        {
                            ProjektId = 2,
                            Nazwa = "Task Manager App",
                            Obrazek = "https://picsum.photos/200/300?random=2",
                            Opis = "Aplikacja do zarządzania zadaniami z funkcjami tworzenia i śledzenia zadań.",
                            Technologie = "C#, .NET, Entity Framework, SQL Server"
                        },
                        new
                        {
                            ProjektId = 3,
                            Nazwa = "E-commerce Platform",
                            Obrazek = "https://picsum.photos/200/300?random=3",
                            Opis = "Platforma e-commerce umożliwiająca przeglądanie i zakup produktów.",
                            Technologie = "JavaScript, Node.js, MongoDB, Express.js"
                        },
                        new
                        {
                            ProjektId = 4,
                            Nazwa = "Blogging Platform",
                            Obrazek = "https://picsum.photos/200/300?random=4",
                            Opis = "Aplikacja do prowadzenia bloga z możliwością komentowania postów.",
                            Technologie = "Python, Flask, SQLite, Bootstrap"
                        },
                        new
                        {
                            ProjektId = 5,
                            Nazwa = "Weather Dashboard",
                            Obrazek = "https://picsum.photos/200/300?random=5",
                            Opis = "Dashboard pogodowy wyświetlający prognozy na podstawie API.",
                            Technologie = "JavaScript, React, OpenWeather API, TailwindCSS"
                        },
                        new
                        {
                            ProjektId = 6,
                            Nazwa = "Online Quiz System",
                            Obrazek = "https://picsum.photos/200/300?random=6",
                            Opis = "System quizowy z możliwością generowania raportów wyników.",
                            Technologie = "C#, .NET, Razor Pages, PostgreSQL"
                        },
                        new
                        {
                            ProjektId = 7,
                            Nazwa = "Chat Application",
                            Obrazek = "https://picsum.photos/200/300?random=7",
                            Opis = "Aplikacja do komunikacji w czasie rzeczywistym.",
                            Technologie = "JavaScript, Vue.js, Firebase, CSS"
                        },
                        new
                        {
                            ProjektId = 8,
                            Nazwa = "Fitness Tracker",
                            Obrazek = "https://picsum.photos/200/300?random=8",
                            Opis = "Aplikacja do śledzenia treningów i monitorowania postępów.",
                            Technologie = "Kotlin, Android Studio, SQLite, Material Design"
                        },
                        new
                        {
                            ProjektId = 9,
                            Nazwa = "Smart Home Dashboard",
                            Obrazek = "https://picsum.photos/200/300?random=9",
                            Opis = "Dashboard do zarządzania urządzeniami inteligentnego domu.",
                            Technologie = "Python, Django, REST API, Vue.js"
                        },
                        new
                        {
                            ProjektId = 10,
                            Nazwa = "Digital Art Gallery",
                            Obrazek = "https://picsum.photos/200/300?random=10",
                            Opis = "Wirtualna galeria sztuki pozwalająca na przeglądanie dzieł w 3D.",
                            Technologie = "C#, Unity, Blender, ARKit"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
