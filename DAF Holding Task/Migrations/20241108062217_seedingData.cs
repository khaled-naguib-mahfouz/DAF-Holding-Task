using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAF_Holding_Task.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "userProfiles",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateOnly(1990, 1, 1), "john.doe@example.com", "John", "Doe" },
                    { 2, new DateOnly(1985, 2, 10), "jane.smith@example.com", "Jane", "Smith" },
                    { 3, new DateOnly(1992, 3, 15), "alice.johnson@example.com", "Alice", "Johnson" },
                    { 4, new DateOnly(1993, 4, 20), "bob.brown@example.com", "Bob", "Brown" },
                    { 5, new DateOnly(1987, 5, 25), "carol.white@example.com", "Carol", "White" }
                });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "Id", "Content", "DatePosted", "Title", "UserProfileID" },
                values: new object[,]
                {
                    { 1, "Content of John's first post.", new DateOnly(2024, 1, 1), "John's First Post", 1 },
                    { 2, "Content of John's second post.", new DateOnly(2024, 1, 5), "John's Second Post", 1 },
                    { 3, "Content of Jane's first post.", new DateOnly(2024, 2, 10), "Jane's First Post", 2 },
                    { 4, "Content of Alice's first post.", new DateOnly(2024, 3, 15), "Alice's First Post", 3 },
                    { 5, "Content of Alice's second post.", new DateOnly(2024, 3, 20), "Alice's Second Post", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "userProfiles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "userProfiles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "userProfiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "userProfiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "userProfiles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
