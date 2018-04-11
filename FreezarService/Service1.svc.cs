using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FreezarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static IList<Recipe> Recipies = new List<Recipe>();
        private static IList<Ingredient> Ingredients = new List<Ingredient>();
        private static IList<Ingredient> Storages = new List<Ingredient>();

        private static int _nextId = 100001;

        WebOperationContext webContext = WebOperationContext.Current;

        public IList<Recipe> GetRecipes()
        {
            return Recipies;
        }

        public Recipe GetRecipe(string id)
        {
            int idNumber = int.Parse(id);
            return Recipies.FirstOrDefault(recipe => recipe.RecipeId == idNumber);
        }

        public string GetRecipeName(string id)
        {
            Recipe recipe = GetRecipe(id);
            if (recipe == null) return null;
            return recipe.Title;
        }

        public IList<Ingredient> GetIngredients()
        {
            return Ingredients;
        }

        public Ingredient GetIngredient(string id)
        {
            int idNumber = int.Parse(id);
            return Ingredients.FirstOrDefault(ingredient => ingredient.IngredientId == idNumber);
        }

        public string GetIngredientName(string id)
        {
            Ingredient ingredient = GetIngredient(id);
            if (ingredient == null) return null;
            return ingredient.Name;
        }

        public IList<Ingredient> GetStorages()
        {
            GetIngredients();
            foreach (Ingredient ing in Ingredients)
            {
                if (ing.IsStored)
                {
                    Storages.Add(ing);
                }
            }
            return Storages;
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            recipe.RecipeId = _nextId;
            Recipies.Add(recipe);
            return recipe;
        }

        public Ingredient AddIngredient(Ingredient ingredient)
        {
            ingredient.IngredientId = _nextId;
            Ingredients.Add(ingredient);
            return ingredient;
        }

        public Recipe UpdateRecipe(string id, Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Ingredient UpdateIngredient(string id, Ingredient ingredient)
        {
            throw new NotImplementedException();
        }


        public Recipe DeleteRecipe(string id, Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Ingredient DeleteIngredient(string id, Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public Storage DeleteStorage(string id, Storage storage)
        {
            throw new NotImplementedException();
        }
    }
}
