using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporationXYZ.Main.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "159d751b-2776-42b6-936c-6f60d27246ef", "67d156ef-5faf-478f-82c7-fd47c1502801", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9013422a-ff00-4426-8721-ae93cebb77d9", "62ac4126-b3ed-450a-84cd-2f74ddb21d6d", "Consumer", "CONSUMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "903d1679-3c2b-4970-b8b2-29d1028f0271", "2c819f80-8b24-42f3-892f-3ff61f774831", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159d751b-2776-42b6-936c-6f60d27246ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9013422a-ff00-4426-8721-ae93cebb77d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "903d1679-3c2b-4970-b8b2-29d1028f0271");
        }
    }
}
