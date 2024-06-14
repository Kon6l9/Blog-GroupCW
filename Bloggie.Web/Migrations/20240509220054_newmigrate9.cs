using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations
{
    /// <inheritdoc />
    public partial class newmigrate9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "BlogPosts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "618ae98c-bfe1-4bf3-879e-f4b0d23b8c7e", "AQAAAAIAAYagAAAAEJjQk0VHcj2PhXbtNY6qd5ML/i5qaHPIpdpzBHd9E0kbEEFsT93ClL6BrED5tP/3Cw==", "c1db5c87-5b61-4fe9-9bbc-fecef4fb781c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a0c53c-b6ba-44ff-9520-711485e9da6c", "AQAAAAIAAYagAAAAENCSaDPODRfDPCMsIGaxyoh7Eb0SQXEqhwcY9K2p71gzJPaIWWgbxT3i3rmlXHvFuA==", "4520d32e-6cec-439b-ac85-2452d277269e" });
        }
    }
}
