using Microsoft.EntityFrameworkCore.Migrations;

namespace Candy_SUT21.Migrations
{
    public partial class AddedShoppingCartItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<string>(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartItemsId",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CandyId",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CandyId",
                table: "ShoppingCartItems",
                column: "CandyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Candies_CandyId",
                table: "ShoppingCartItems",
                column: "CandyId",
                principalTable: "Candies",
                principalColumn: "CandyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Candies_CandyId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_CandyId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "ShoppingCartItemsId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "CandyId",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<string>(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems1",
                columns: table => new
                {
                    ShoppingCartItemsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CandyId = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems1", x => x.ShoppingCartItemsId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems1_Candies_CandyId",
                        column: x => x.CandyId,
                        principalTable: "Candies",
                        principalColumn: "CandyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems1_ShoppingCartItems_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCartItems",
                        principalColumn: "ShoppingCartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems1_CandyId",
                table: "ShoppingCartItems1",
                column: "CandyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems1_ShoppingCartId",
                table: "ShoppingCartItems1",
                column: "ShoppingCartId");
        }
    }
}
