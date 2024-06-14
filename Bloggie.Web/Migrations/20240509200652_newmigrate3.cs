using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations
{
    /// <inheritdoc />
    public partial class newmigrate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "eaf87711-0d77-44c0-aa07-5ced154ece87", "AQAAAAIAAYagAAAAEER5d5dWnzqlvn+pEdF1t51RHRF95ihhpFdYUiV1Eva1IKn2HPaoKcrCQQg5TY3YmQ==", "0551dc31-6378-4abd-ab18-56ac65cb2ac5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "BlogPosts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e24865d3-e205-4cf3-9026-1bcfeaf92d8d", "AQAAAAIAAYagAAAAELlvZE/S8gwPnu0df2AQA6j6IP8fOtuJi9wECW7NaJOvkDTtAggsjXkCd7HVWSBJqQ==", "4eb55e12-102c-43fe-95ea-fd16b9336e6c" });
        }
    }
}
