using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilesAhead.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "render");

            migrationBuilder.CreateTable(
                name: "FetchData",
                schema: "render",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FetchData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataField",
                schema: "render",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FetchDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataField_FetchData_FetchDataId",
                        column: x => x.FetchDataId,
                        principalSchema: "render",
                        principalTable: "FetchData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WireFrames",
                schema: "render",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    WireFrameId = table.Column<int>(type: "int", nullable: true),
                    RootName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MetaDataId = table.Column<int>(type: "int", nullable: true),
                    ExternalStyleSheets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadScripts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyScripts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Segment = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DataSource = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FetchContentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WireFrames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WireFrames_FetchData_FetchContentId",
                        column: x => x.FetchContentId,
                        principalSchema: "render",
                        principalTable: "FetchData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WireFrames_WireFrames_MetaDataId",
                        column: x => x.MetaDataId,
                        principalSchema: "render",
                        principalTable: "WireFrames",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WireFrames_WireFrames_WireFrameId",
                        column: x => x.WireFrameId,
                        principalSchema: "render",
                        principalTable: "WireFrames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WireFrameAttribute",
                schema: "render",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    WireFrameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WireFrameAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WireFrameAttribute_WireFrames_WireFrameId",
                        column: x => x.WireFrameId,
                        principalSchema: "render",
                        principalTable: "WireFrames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataField_FetchDataId",
                schema: "render",
                table: "DataField",
                column: "FetchDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WireFrameAttribute_WireFrameId",
                schema: "render",
                table: "WireFrameAttribute",
                column: "WireFrameId");

            migrationBuilder.CreateIndex(
                name: "IX_WireFrames_FetchContentId",
                schema: "render",
                table: "WireFrames",
                column: "FetchContentId");

            migrationBuilder.CreateIndex(
                name: "IX_WireFrames_MetaDataId",
                schema: "render",
                table: "WireFrames",
                column: "MetaDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WireFrames_RootName",
                schema: "render",
                table: "WireFrames",
                column: "RootName",
                unique: true,
                filter: "[RootName] IS NOT NULL");

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
                name: "DataField",
                schema: "render");

            migrationBuilder.DropTable(
                name: "WireFrameAttribute",
                schema: "render");

            migrationBuilder.DropTable(
                name: "WireFrames",
                schema: "render");

            migrationBuilder.DropTable(
                name: "FetchData",
                schema: "render");
        }
    }
}
