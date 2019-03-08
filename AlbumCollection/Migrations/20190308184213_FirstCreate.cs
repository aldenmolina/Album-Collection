using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ArtistName = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "ArtistName", "ImgPath", "Name" },
                values: new object[] { 1, "Circa Survive", "/Images/OnLettingGo.jpg", "On Letting Go" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "ArtistName", "ImgPath", "Name" },
                values: new object[] { 2, "Dance Gavin Dance", "/Images/DowntownBattleMountain2.jpg", "Downtown Battle Mountain II" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "ArtistName", "ImgPath", "Name" },
                values: new object[] { 3, "Trippie Redd", "/Images/LoveScars3", "Love Scars 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
