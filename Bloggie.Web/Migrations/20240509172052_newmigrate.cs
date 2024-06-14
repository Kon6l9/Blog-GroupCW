using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations
{
    /// <inheritdoc />
    public partial class newmigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78296481-f22c-450e-97a3-b4b0d074c0db", "AQAAAAIAAYagAAAAEFeVRb6P9Mdslz83kVw30WahSQi1sOiJ5/cWIztZrbZDPyGfIjEHIVwb3OTWDDjZTg==", "9eb549c9-82ec-4ded-9ffa-e8a6f750be93" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30f2eae6-5086-4eaa-8197-bf7182c26bee", "AQAAAAIAAYagAAAAEJ+kXB4lvyMybfWyGHs6USMXOfS4qU6anaQhGbt+eu5g/A21BYzbYAphzHbWBqACbw==", "a6c2f43a-e063-4ab8-be35-6c995574a6c5" });
        }
    }
}
