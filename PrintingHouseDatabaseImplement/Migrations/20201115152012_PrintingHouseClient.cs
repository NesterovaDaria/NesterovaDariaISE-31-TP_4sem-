using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintingHouseDatabaseImplement.Migrations
{
    public partial class PrintingHouseClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrintingProductComponents_Components_ComponentId",
                table: "PrintingProductComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintingProductComponents_PrintingProducts_PrintingProductId",
                table: "PrintingProductComponents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrintingProductComponents",
                table: "PrintingProductComponents");

            migrationBuilder.DropIndex(
                name: "IX_PrintingProductComponents_PrintingProductId",
                table: "PrintingProductComponents");

            migrationBuilder.RenameTable(
                name: "PrintingProductComponents",
                newName: "PrintingComponents");

            migrationBuilder.RenameIndex(
                name: "IX_PrintingProductComponents_ComponentId",
                table: "PrintingComponents",
                newName: "IX_PrintingComponents_ComponentId");

            migrationBuilder.AddColumn<string>(
                name: "ClientFIO",
                table: "Orders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrintingComponents",
                table: "PrintingComponents",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(nullable: false),
                    Login = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_PrintingComponents_PrintingProductId",
                table: "PrintingComponents",
                column: "PrintingProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrintingComponents_Components_ComponentId",
                table: "PrintingComponents",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrintingComponents_PrintingProducts_PrintingProductId",
                table: "PrintingComponents",
                column: "PrintingProductId",
                principalTable: "PrintingProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintingComponents_Components_ComponentId",
                table: "PrintingComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintingComponents_PrintingProducts_PrintingProductId",
                table: "PrintingComponents");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrintingComponents",
                table: "PrintingComponents");

            migrationBuilder.DropIndex(
                name: "IX_PrintingComponents_PrintingProductId",
                table: "PrintingComponents");

            migrationBuilder.DropColumn(
                name: "ClientFIO",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "PrintingComponents",
                newName: "PrintingProductComponents");

            migrationBuilder.RenameIndex(
                name: "IX_PrintingComponents_ComponentId",
                table: "PrintingProductComponents",
                newName: "IX_PrintingProductComponents_ComponentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrintingProductComponents",
                table: "PrintingProductComponents",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PrintingProductComponents_PrintingProductId",
                table: "PrintingProductComponents",
                column: "PrintingProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrintingProductComponents_Components_ComponentId",
                table: "PrintingProductComponents",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrintingProductComponents_PrintingProducts_PrintingProductId",
                table: "PrintingProductComponents",
                column: "PrintingProductId",
                principalTable: "PrintingProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
