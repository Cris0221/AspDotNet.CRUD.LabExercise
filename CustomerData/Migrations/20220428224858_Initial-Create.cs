using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
