using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Data.Migrations
{
    public partial class Seed_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 56, 53, 540, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 56, 53, 542, DateTimeKind.Utc));

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "Code", "CreateDate", "Deleted", "Name" },
                values: new object[] { 1, "Tr", new DateTime(2019, 11, 28, 17, 56, 53, 542, DateTimeKind.Utc), false, "Türkiye" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Deleted", "Email", "Gender", "Name", "NationalityId", "Password", "Surname", "Username" },
                values: new object[] { 1, new DateTime(1992, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 28, 17, 56, 53, 542, DateTimeKind.Utc), false, "gozdecanki@gmail.com", 1, "Gözde", 1, "12345678", "Yılmaz", "gozde" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 38, 57, 626, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 38, 57, 628, DateTimeKind.Utc));
        }
    }
}
