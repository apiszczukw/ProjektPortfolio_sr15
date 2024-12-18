using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektPortfolio_czw15.Migrations
{
    public partial class poprawkiNaDanych : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 1,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=1");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 2,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=2");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 3,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=3");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 4,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=4");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 5,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=5");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 6,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=6");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 7,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=7");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 8,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=8");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 9,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=9");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 10,
                column: "Obrazek",
                value: "https://picsum.photos/200/300?random=10");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 1,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2015/05/31/10/55/wordpress-791503_960_720.jpg");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 2,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2016/03/31/19/56/checklist-1295319_960_720.png");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 3,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2016/11/29/09/08/ecommerce-1869227_960_720.jpg");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 4,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2015/05/31/10/55/wordpress-791503_960_720.jpg");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 5,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2017/01/18/18/14/weather-1991841_960_720.png");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 6,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2017/01/31/19/15/quiz-2024320_960_720.png");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 7,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2016/06/13/09/57/chat-1456545_960_720.png");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 8,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2016/11/29/09/08/ecommerce-1869227_960_720.jpg");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 9,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2017/01/31/19/15/quiz-2024320_960_720.png");

            migrationBuilder.UpdateData(
                table: "Projekty",
                keyColumn: "ProjektId",
                keyValue: 10,
                column: "Obrazek",
                value: "https://cdn.pixabay.com/photo/2016/06/13/09/57/chat-1456545_960_720.png");
        }
    }
}
