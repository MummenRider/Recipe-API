# Recipe API
A web API for food recipes
## Category
|API endpoint | Description | Request body | Request response |
| :----- | :----- | :----- |:----- |
| GET/api/categories  | Get all categories | None | Array of categories |
| POST/api/categories  | Add new category | CategoryName | Category name |
| PUT/api/categories/{categoryId}  | Update existing category | Category name | Category name |
| Delete/api/categories/{categoryId}  | Delete existing category | none | Category id and name |

## Recipe
|API endpoint | Description | Request body | Request response |
| :----- | :----- | :----- |:----- |
| GET/api/recipes  | Get all recipes | None | Array of recipes |
| POST/api/recipes  | Add new recipe | Recipe item | Recipe |
| PUT/api/recipes/{recipeId}  | Update existing recipe | Recipe item | Recipe |
| Delete/api/recipes/{recipeId}  | Delete existing recipe | none | Recipe |
