using _02._Recipes_Code_First_Demo.Models;

var db = new RecipesDbContext();

db.Database.EnsureCreated();

db.Recipes.Add(new Recipe 
{ 
    Name = "Cake",
    Ingredients = new List<Ingredient> 
    { 
        new Ingredient { Name = "Sugar", Amount = 50 },
        new Ingredient { Name = "Floar", Amount = 500 }
    }
});

db.SaveChanges();