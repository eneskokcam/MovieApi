using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApi.Persistence.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Duration kolonunu sil
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Movies");

            // 2. Duration kolonunu int olarak tekrar ekle
            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Geri dönerken int kolonu sil
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Movies");

            // datetime2 olarak tekrar ekle
            migrationBuilder.AddColumn<DateTime>(
                name: "Duration",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }
    }
}
