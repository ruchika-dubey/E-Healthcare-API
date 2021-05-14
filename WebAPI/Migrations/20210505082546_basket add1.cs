using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class basketadd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_CustomerBasket_CustomerBasketId",
                table: "Basket");

            migrationBuilder.DropTable(
                name: "CustomerBasket");

            migrationBuilder.DropIndex(
                name: "IX_Basket_CustomerBasketId",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "CustomerBasketId",
                table: "Basket");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerBasketId",
                table: "Basket",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerBasket",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBasket", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basket_CustomerBasketId",
                table: "Basket",
                column: "CustomerBasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_CustomerBasket_CustomerBasketId",
                table: "Basket",
                column: "CustomerBasketId",
                principalTable: "CustomerBasket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
