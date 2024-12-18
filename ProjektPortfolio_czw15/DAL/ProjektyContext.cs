using Microsoft.EntityFrameworkCore;
using ProjektPortfolio_czw15.Models;

namespace ProjektPortfolio_czw15.DAL
{
	public class ProjektyContext : DbContext
	{

        public DbSet<Projekt> Projekty { get; set; }
        public ProjektyContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			List<Projekt> projekty = new List<Projekt>
		{
			new Projekt
			{
				ProjektId = 1,
				Nazwa = "Portfolio Web Developer",
				Obrazek = "https://picsum.photos/200/300?random=1",
				Opis = "Strona internetowa prezentująca moje umiejętności, projekty i doświadczenie.",
				Technologie = "HTML, CSS, JavaScript, React"
			},
			new Projekt
			{
				ProjektId = 2,
				Nazwa = "Task Manager App",
				Obrazek = "https://picsum.photos/200/300?random=2",
				Opis = "Aplikacja do zarządzania zadaniami z funkcjami tworzenia i śledzenia zadań.",
				Technologie = "C#, .NET, Entity Framework, SQL Server"
			},
			new Projekt
			{
				ProjektId = 3,
				Nazwa = "E-commerce Platform",
				Obrazek = "https://picsum.photos/200/300?random=3",
				Opis = "Platforma e-commerce umożliwiająca przeglądanie i zakup produktów.",
				Technologie = "JavaScript, Node.js, MongoDB, Express.js"
			},
			new Projekt
			{
				ProjektId = 4,
				Nazwa = "Blogging Platform",
				Obrazek = "https://picsum.photos/200/300?random=4",
				Opis = "Aplikacja do prowadzenia bloga z możliwością komentowania postów.",
				Technologie = "Python, Flask, SQLite, Bootstrap"
			},
			new Projekt
			{
				ProjektId = 5,
				Nazwa = "Weather Dashboard",
				Obrazek = "https://picsum.photos/200/300?random=5",
				Opis = "Dashboard pogodowy wyświetlający prognozy na podstawie API.",
				Technologie = "JavaScript, React, OpenWeather API, TailwindCSS"
			},
			new Projekt
			{
				ProjektId = 6,
				Nazwa = "Online Quiz System",
				Obrazek = "https://picsum.photos/200/300?random=6",
				Opis = "System quizowy z możliwością generowania raportów wyników.",
				Technologie = "C#, .NET, Razor Pages, PostgreSQL"
			},
			new Projekt
			{
				ProjektId = 7,
				Nazwa = "Chat Application",
				Obrazek = "https://picsum.photos/200/300?random=7",
				Opis = "Aplikacja do komunikacji w czasie rzeczywistym.",
				Technologie = "JavaScript, Vue.js, Firebase, CSS"
			},
			new Projekt
			{
				ProjektId = 8,
				Nazwa = "Fitness Tracker",
				Obrazek = "https://picsum.photos/200/300?random=8",
				Opis = "Aplikacja do śledzenia treningów i monitorowania postępów.",
				Technologie = "Kotlin, Android Studio, SQLite, Material Design"
			},
			new Projekt
			{
				ProjektId = 9,
				Nazwa = "Smart Home Dashboard",
				Obrazek = "https://picsum.photos/200/300?random=9",
				Opis = "Dashboard do zarządzania urządzeniami inteligentnego domu.",
				Technologie = "Python, Django, REST API, Vue.js"
			},
			new Projekt
			{
				ProjektId = 10,
				Nazwa = "Digital Art Gallery",
				Obrazek = "https://picsum.photos/200/300?random=10",
				Opis = "Wirtualna galeria sztuki pozwalająca na przeglądanie dzieł w 3D.",
				Technologie = "C#, Unity, Blender, ARKit"
			}
		};

			modelBuilder.Entity<Projekt>().HasData(projekty);
		}
	}
}
