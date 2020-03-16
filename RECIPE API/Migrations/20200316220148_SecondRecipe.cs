using Microsoft.EntityFrameworkCore.Migrations;

namespace RECIPE_API.Migrations
{
    public partial class SecondRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Recipes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Recipes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "ImageUrl", "Ingridients", "Summary", "Title" },
                values: new object[] { 1000, 100, "https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Filipino-Chicken-Adobo_EXPS_THAM18_212833_C11_09_8b.jpg", "8 skinless chicken drumsticks, on the bone,1/3 cup low sodium soy sauce, use gluten-free soy sauce for GF and coconut aminos for Paleo,1 / 3 cup apple cider vinegar,1 small head of garlic, crushed,6 ground peppercorns,4 bay leaves,1 jalapeño, chopped(optional)", "Chicken braised in vinegar and soy sauce with lots of garlic. This easy, savory chicken dish has become a staple in my home. As this simmers, your kitchen fills with an intoxicating sweet and sour aroma that will leave you anxious to eat.", "Chicken Adobo" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "ImageUrl", "Ingridients", "Summary", "Title" },
                values: new object[] { 1001, 100, "https://i.pinimg.com/originals/1d/96/84/1d96844b21a7e547cb4a433cb41c1b4f.jpg", "2 lbs chicken cut into serving pieces,2 tablespoons ginger minced,2 tablespoons garlic minced,3/4 cup lemongrass chopped,1 cup coconut vinegar,1/2 cup lemon or calamansi juice,1 tablespoon salt,1/4 cup brown sugar,1 cup lemon soda softdrink,1/2 tablespoon ground black pepper", "Chicken Inasal is a grilled chicken dish and one of the well known Ilonggo dishes. This is done by marinating chicken pieces in a unique blend of spices and grilling them until done.", "Chicken Inasal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1001);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "ImageUrl", "Ingridients", "Summary", "Title" },
                values: new object[] { 100, 100, "https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Filipino-Chicken-Adobo_EXPS_THAM18_212833_C11_09_8b.jpg", "8 skinless chicken drumsticks, on the bone,1/3 cup low sodium soy sauce, use gluten-free soy sauce for GF and coconut aminos for Paleo,1 / 3 cup apple cider vinegar,1 small head of garlic, crushed,6 ground peppercorns,4 bay leaves,1 jalapeño, chopped(optional)", "Chicken braised in vinegar and soy sauce with lots of garlic. This easy, savory chicken dish has become a staple in my home. As this simmers, your kitchen fills with an intoxicating sweet and sour aroma that will leave you anxious to eat.", "Chicken Adobo" });
        }
    }
}
