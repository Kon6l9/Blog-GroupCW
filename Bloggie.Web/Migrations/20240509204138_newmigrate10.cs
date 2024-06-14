using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations
{
    /// <inheritdoc />
    public partial class newmigrate10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cbafbcd-5ca9-4149-98da-9a3aec3177f8", "AQAAAAIAAYagAAAAEKvcJ9D+OeMWHJ2uptSEIHewKXZZongGLr8w7tVvNy7Y7rJuNTijZqbQUiaKFbZLyA==", "788955fd-c78e-42d0-852d-79a07a85c1b1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaf87711-0d77-44c0-aa07-5ced154ece87", "AQAAAAIAAYagAAAAEER5d5dWnzqlvn+pEdF1t51RHRF95ihhpFdYUiV1Eva1IKn2HPaoKcrCQQg5TY3YmQ==", "0551dc31-6378-4abd-ab18-56ac65cb2ac5" });
        }
    }
}
