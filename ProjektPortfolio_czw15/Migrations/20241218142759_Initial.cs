using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektPortfolio_czw15.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projekty",
                columns: table => new
                {
                    ProjektId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Obrazek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technologie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekty", x => x.ProjektId);
                });

            migrationBuilder.InsertData(
                table: "Projekty",
                columns: new[] { "ProjektId", "Nazwa", "Obrazek", "Opis", "Technologie" },
                values: new object[,]
                {
                    { 1, "Portfolio Web Developer", "https://cdn.pixabay.com/photo/2015/05/31/10/55/wordpress-791503_960_720.jpg", "Strona internetowa prezentująca moje umiejętności, projekty i doświadczenie.", "HTML, CSS, JavaScript, React" },
                    { 2, "Task Manager App", "https://cdn.pixabay.com/photo/2016/03/31/19/56/checklist-1295319_960_720.png", "Aplikacja do zarządzania zadaniami z funkcjami tworzenia i śledzenia zadań.", "C#, .NET, Entity Framework, SQL Server" },
                    { 3, "E-commerce Platform", "https://cdn.pixabay.com/photo/2016/11/29/09/08/ecommerce-1869227_960_720.jpg", "Platforma e-commerce umożliwiająca przeglądanie i zakup produktów.", "JavaScript, Node.js, MongoDB, Express.js" },
                    { 4, "Blogging Platform", "https://cdn.pixabay.com/photo/2015/05/31/10/55/wordpress-791503_960_720.jpg", "Aplikacja do prowadzenia bloga z możliwością komentowania postów.", "Python, Flask, SQLite, Bootstrap" },
                    { 5, "Weather Dashboard", "https://cdn.pixabay.com/photo/2017/01/18/18/14/weather-1991841_960_720.png", "Dashboard pogodowy wyświetlający prognozy na podstawie API.", "JavaScript, React, OpenWeather API, TailwindCSS" },
                    { 6, "Online Quiz System", "https://cdn.pixabay.com/photo/2017/01/31/19/15/quiz-2024320_960_720.png", "System quizowy z możliwością generowania raportów wyników.", "C#, .NET, Razor Pages, PostgreSQL" },
                    { 7, "Chat Application", "https://cdn.pixabay.com/photo/2016/06/13/09/57/chat-1456545_960_720.png", "Aplikacja do komunikacji w czasie rzeczywistym.", "JavaScript, Vue.js, Firebase, CSS" },
                    { 8, "Fitness Tracker", "https://cdn.pixabay.com/photo/2016/11/29/09/08/ecommerce-1869227_960_720.jpg", "Aplikacja do śledzenia treningów i monitorowania postępów.", "Kotlin, Android Studio, SQLite, Material Design" },
                    { 9, "Smart Home Dashboard", "https://cdn.pixabay.com/photo/2017/01/31/19/15/quiz-2024320_960_720.png", "Dashboard do zarządzania urządzeniami inteligentnego domu.", "Python, Django, REST API, Vue.js" },
                    { 10, "Digital Art Gallery", "https://cdn.pixabay.com/photo/2016/06/13/09/57/chat-1456545_960_720.png", "Wirtualna galeria sztuki pozwalająca na przeglądanie dzieł w 3D.", "C#, Unity, Blender, ARKit" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projekty");
        }
    }
}
