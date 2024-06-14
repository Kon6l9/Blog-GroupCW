using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations
{
    /// <inheritdoc />
    public partial class newmigrate11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4680cce-30ec-418c-be4a-3186521441d8", "AQAAAAIAAYagAAAAECCkdrxi/alk5GttZoAz5/78LKj3c0OI736ktNLhUIkXxik2xclcemA75+PqK6G3WA==", "e9a7436a-1a03-4f4a-acc4-59cf7ebb0545" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "618ae98c-bfe1-4bf3-879e-f4b0d23b8c7e", "AQAAAAIAAYagAAAAEJjQk0VHcj2PhXbtNY6qd5ML/i5qaHPIpdpzBHd9E0kbEEFsT93ClL6BrED5tP/3Cw==", "c1db5c87-5b61-4fe9-9bbc-fecef4fb781c" });
        }
    }
}
