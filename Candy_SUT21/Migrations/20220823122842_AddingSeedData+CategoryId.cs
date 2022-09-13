using Microsoft.EntityFrameworkCore.Migrations;

namespace Candy_SUT21.Migrations
{
    public partial class AddingSeedDataCategoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candies_Categories_CategoryId",
                table: "Candies");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Candies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Chocolate Candy" },
                    { 2, null, "Friut Candy" },
                    { 3, null, "Gummy Candy" },
                    { 4, null, "Halloween Candy" },
                    { 5, null, "Hard Candy" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, 1, "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum", "\\Images\\thumbnails\\chocolateCandy-small.jpg", "\\Images\\chocolateCandy.jpg", true, true, "Assorted Chocolate Candy", 4.95m });

            migrationBuilder.AddForeignKey(
                name: "FK_Candies_Categories_CategoryId",
                table: "Candies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candies_Categories_CategoryId",
                table: "Candies");

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Candies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Candies_Categories_CategoryId",
                table: "Candies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
