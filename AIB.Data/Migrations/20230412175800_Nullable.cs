﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AIB.Data.Migrations
{
    public partial class Nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraOtherfields",
                table: "Sales");

            migrationBuilder.AlterColumn<decimal>(
                name: "SaleCommission",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "5a4d479d-4ffb-4a16-b855-e2b2896def1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a09f6ef2-a76f-4384-9cc9-f503aa090aac", "AQAAAAEAACcQAAAAEFql2FT85B9reLw3zOa24x5m/VMIPrdh95bkEQohcTMX06Vsst1QFVfaFOrvDeKQHA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SaleCommission",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraOtherfields",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

          

           
        }
    }
}
