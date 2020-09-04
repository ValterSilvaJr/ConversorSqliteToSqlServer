using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseEFcore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false),
                    image = table.Column<string>(type: "varchar(255)", nullable: false),
                    title = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "points",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false),
                    image = table.Column<string>(type: "varchar(255)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false),
                    email = table.Column<string>(type: "varchar(255)", nullable: false),
                    whatsapp = table.Column<string>(type: "varchar(255)", nullable: false),
                    latitude = table.Column<double>(type: "float", nullable: false),
                    longitude = table.Column<double>(type: "float", nullable: false),
                    city = table.Column<string>(type: "varchar(255)", nullable: false),
                    uf = table.Column<string>(type: "varchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_points", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "points_items",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false),
                    point_id = table.Column<long>(nullable: false),
                    item_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_points_items", x => x.id);
                    table.ForeignKey(
                        name: "FK_points_items_items_item_id",
                        column: x => x.item_id,
                        principalTable: "items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_points_items_points_point_id",
                        column: x => x.point_id,
                        principalTable: "points",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_points_items_item_id",
                table: "points_items",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_points_items_point_id",
                table: "points_items",
                column: "point_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "points_items");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "points");
        }
    }
}
