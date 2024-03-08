using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilesAhead.Web.Migrations
{
    /// <inheritdoc />
    public partial class Alpha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "render");

            migrationBuilder.CreateTable(
                name: "WireFrames",
                schema: "render",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    WireFrameId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaviconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalStyleSheets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadScripts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyScripts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Segment = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    IsBlazorComponent = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Attributes = table.Column<string>(type: "nvarchar(720)", maxLength: 720, nullable: true),
                    DataSource = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FetchData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WireFrames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WireFrames_WireFrames_WireFrameId",
                        column: x => x.WireFrameId,
                        principalSchema: "render",
                        principalTable: "WireFrames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WireFrames_WireFrameId",
                schema: "render",
                table: "WireFrames",
                column: "WireFrameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WireFrames",
                schema: "render");
        }
    }
}
