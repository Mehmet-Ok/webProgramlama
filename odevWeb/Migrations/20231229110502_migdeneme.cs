using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace odevWeb.Migrations
{
    public partial class migdeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anaBilimDalis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anaBilimDalis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "doktors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    poliklinikID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doktors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "hastas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hastas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "kayitliRandevus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    randevuID = table.Column<int>(type: "int", nullable: false),
                    hastaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kayitliRandevus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "polikliniks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anaBilimDaliID = table.Column<int>(type: "int", nullable: false),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_polikliniks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "randevus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    randevuTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    doktorID = table.Column<int>(type: "int", nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_randevus", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anaBilimDalis");

            migrationBuilder.DropTable(
                name: "doktors");

            migrationBuilder.DropTable(
                name: "hastas");

            migrationBuilder.DropTable(
                name: "kayitliRandevus");

            migrationBuilder.DropTable(
                name: "polikliniks");

            migrationBuilder.DropTable(
                name: "randevus");
        }
    }
}
