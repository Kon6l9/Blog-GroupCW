using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations
{
    /// <inheritdoc />
    public partial class newmigrate8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a0c53c-b6ba-44ff-9520-711485e9da6c", "AQAAAAIAAYagAAAAENCSaDPODRfDPCMsIGaxyoh7Eb0SQXEqhwcY9K2p71gzJPaIWWgbxT3i3rmlXHvFuA==", "4520d32e-6cec-439b-ac85-2452d277269e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebf053f5-9976-4b97-810e-3bb3987286c8", "AQAAAAIAAYagAAAAEEh+FYVZcGCfPVxmcOaRg4Fiv1Nm62e5Gc7HEFgh/nreu+gcH5OEudGD01vI5hcHoA==", "53f5d472-d166-46a4-b767-a1ccdc4d5cef" });
        }
    }
}
