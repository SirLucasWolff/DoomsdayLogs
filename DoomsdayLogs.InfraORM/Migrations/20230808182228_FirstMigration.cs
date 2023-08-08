using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoomsdayLogs.InfraORM.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    ProjectVersion = table.Column<string>(type: "NVARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    LogDescription = table.Column<string>(type: "NVARCHAR(350)", nullable: true),
                    LogDateTime = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    LogType = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    LogTypeImage = table.Column<byte[]>(type: "IMAGE", nullable: false),
                    LogClassName = table.Column<string>(type: "NVARCHAR(200)", nullable: true),
                    LogDataName = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    LogData = table.Column<string>(type: "NTEXT", nullable: true),
                    ProjectId = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogDB_ProjectDB_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectDB",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LogDB_ProjectId",
                table: "LogDB",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogDB");

            migrationBuilder.DropTable(
                name: "ProjectDB");
        }
    }
}
