using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations
{
    /// <inheritdoc />
    public partial class newmigrate7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebf053f5-9976-4b97-810e-3bb3987286c8", "AQAAAAIAAYagAAAAEEh+FYVZcGCfPVxmcOaRg4Fiv1Nm62e5Gc7HEFgh/nreu+gcH5OEudGD01vI5hcHoA==", "53f5d472-d166-46a4-b767-a1ccdc4d5cef" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cbafbcd-5ca9-4149-98da-9a3aec3177f8", "AQAAAAIAAYagAAAAEKvcJ9D+OeMWHJ2uptSEIHewKXZZongGLr8w7tVvNy7Y7rJuNTijZqbQUiaKFbZLyA==", "788955fd-c78e-42d0-852d-79a07a85c1b1" });
        }
    }
}
