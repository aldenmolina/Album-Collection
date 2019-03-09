using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class AddedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "Name", "RunTime" },
                values: new object[,]
                {
                    { 13, 1, "The Glorious Nosebleed", "3:12" },
                    { 14, 1, "Meet Me in Montauk", "14:39" },
                    { 15, 2, "Swan Soup", "4:01" },
                    { 16, 2, "Pounce Bounce", "2:26" },
                    { 17, 3, "Topanga", "3:35" },
                    { 18, 3, "Love Scars 3", "2:09" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 18);
        }
    }
}
