using Microsoft.EntityFrameworkCore.Migrations;

namespace RECIPE_API.Migrations
{
    public partial class SeededRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "ImageUrl", "Ingridients", "Summary", "Title" },
                values: new object[] { 100, 100, "https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Filipino-Chicken-Adobo_EXPS_THAM18_212833_C11_09_8b.jpg", "8 skinless chicken drumsticks, on the bone,1/3 cup low sodium soy sauce, use gluten-free soy sauce for GF and coconut aminos for Paleo,1 / 3 cup apple cider vinegar,1 small head of garlic, crushed,6 ground peppercorns,4 bay leaves,1 jalapeño, chopped(optional)", "Chicken braised in vinegar and soy sauce with lots of garlic. This easy, savory chicken dish has become a staple in my home. As this simmers, your kitchen fills with an intoxicating sweet and sour aroma that will leave you anxious to eat.", "Chicken Adobo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 100);
        }
    }
}
