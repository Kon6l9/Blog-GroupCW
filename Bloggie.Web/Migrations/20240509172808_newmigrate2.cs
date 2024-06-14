using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations
{
    /// <inheritdoc />
    public partial class newmigrate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e24865d3-e205-4cf3-9026-1bcfeaf92d8d", "AQAAAAIAAYagAAAAELlvZE/S8gwPnu0df2AQA6j6IP8fOtuJi9wECW7NaJOvkDTtAggsjXkCd7HVWSBJqQ==", "4eb55e12-102c-43fe-95ea-fd16b9336e6c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78296481-f22c-450e-97a3-b4b0d074c0db", "AQAAAAIAAYagAAAAEFeVRb6P9Mdslz83kVw30WahSQi1sOiJ5/cWIztZrbZDPyGfIjEHIVwb3OTWDDjZTg==", "9eb549c9-82ec-4ded-9ffa-e8a6f750be93" });
        }
    }
}
