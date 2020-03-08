using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfVisit",
                table: "Visit",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 6, 17, 39, 0, 507, DateTimeKind.Local).AddTicks(9628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 6, 17, 31, 43, 876, DateTimeKind.Local).AddTicks(7183));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfVisit",
                table: "Visit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 6, 17, 31, 43, 876, DateTimeKind.Local).AddTicks(7183),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 6, 17, 39, 0, 507, DateTimeKind.Local).AddTicks(9628));
        }
    }
}
