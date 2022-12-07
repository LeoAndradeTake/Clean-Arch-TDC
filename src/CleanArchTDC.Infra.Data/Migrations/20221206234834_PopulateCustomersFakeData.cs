using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchTDC.Infra.Data.Migrations
{
    public partial class PopulateCustomersFakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Gender = table.Column<string>(type: "Char(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "BirthDate", "Gender", "Name" },
                values: new object[] { new Guid("259876dc-6853-487f-acdc-d9dfa427fd5e"), new DateTime(1955, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Maria da Silva" });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "BirthDate", "Gender", "Name" },
                values: new object[] { new Guid("b0b0a691-b3a6-4520-a5f0-7b13a734bd18"), new DateTime(1983, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "José Luiz" });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "BirthDate", "Gender", "Name" },
                values: new object[] { new Guid("49f5beb3-f25c-40de-a13f-50100187332b"), new DateTime(2000, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Flávia Maia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
