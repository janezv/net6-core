﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityApp.Data.Migrations
{
    public partial class Invoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyProperty = table.Column<double>(type: "float", nullable: false),
                    InoviceMonth = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice");
        }
    }
}
