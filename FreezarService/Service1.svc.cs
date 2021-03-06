﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        private static IList<Recipe_Ingredience>RecipeIngredients = new List<Recipe_Ingredience>();

        private static int _nextId = 100001;

        WebOperationContext webContext = WebOperationContext.Current;

        static Service1()
        {
            #region Recipes

            Recipe firstRecipe = new Recipe
            {
                RecipeId = 1,
                Title = "Lasagna",
                Category = "Main Dish",
                Cusine = "Italian",
                Description = "Great Lasagna recipe. Why use bottled stuff when you can make it yourself.",
                pic_url = "http://assets.kraftfoods.com/recipe_images/opendeploy/502447_1_1_retail-274041f785c231074b544b5a450fa55d9ad00cde_642x428.jpg"
            };
            Recipies.Add(firstRecipe);
            Recipies.Add(new Recipe
            {
                RecipeId = 2,
                Title = "Teriyaki Chicken",
                Category = "Main Dish",
                Cusine = "Japanese",
                SubCategory = "Grill and BBQ",
                Description = "Great basic Chicken Teriyaki recipe. Why use the bottled stuff when the make-it-yourself marinade is easy and so much tastier?",
                pic_url = "https://static01.nyt.com/images/2016/05/28/dining/28COOKING-CHICKEN-TERIYAKI1/28COOKING-CHICKEN-TERIYAKI1-videoSixteenByNineJumbo1600.jpg"
            });

            #endregion

            #region Ingredients

            Ingredient firstIngredient = new Ingredient
            {
                IngredientId = 1,
                DisplayIndex = 0,
                Department = "Asian",
                Expiry = 0,
                isHeading = false,
                IsStored = false,
                Name = "Soy Sauce",
                StoredAmount = 0,
                UsuallyOnHand = true
            };
            Ingredients.Add(firstIngredient);
            Ingredients.Add(new Ingredient
            {
                IngredientId = 2,
                DisplayIndex = 1,
                Department = "Oils",
                Expiry = 0,
                isHeading = false,
                IsStored = false,
                Name = "Vegetable Oil",
                StoredAmount = 0,
                UsuallyOnHand = true
            });
            Ingredients.Add(new Ingredient
            {
                IngredientId = 3,
                DisplayIndex = 2,
                Department = "Baking",
                Expiry = 0,
                isHeading = false,
                IsStored = false,
                Name = "Brown Sugar",
                StoredAmount = 0,
                UsuallyOnHand = true
            });
            Ingredients.Add(new Ingredient
            {
                IngredientId = 4,
                DisplayIndex = 3,
                Department = "Wines",
                Expiry = 0,
                isHeading = false,
                IsStored = false,
                Name = "Dry sherry",
                StoredAmount = 0,
                UsuallyOnHand = false
            });
            Ingredients.Add(new Ingredient
            {
                IngredientId = 5,
                DisplayIndex = 4,
                Department = "Produce",
                Expiry = 0,
                isHeading = false,
                IsStored = false,
                Name = "Fresh Ginger",
                StoredAmount = 0,
                UsuallyOnHand = false
            });
            Ingredients.Add(new Ingredient
            {
                IngredientId = 5,
                DisplayIndex = 4,
                Department = "Poultry",
                Expiry = 0,
                isHeading = false,
                IsStored = false,
                Name = "Boneless Chicken Breast Halves",
                StoredAmount = 0,
                UsuallyOnHand = false
            });
            Ingredients.Add(new Ingredient
            {
                IngredientId = 5,
                DisplayIndex = 4,
                Department = "Spices",
                Expiry = 0,
                isHeading = false,
                IsStored = false,
                Name = "Sesame seeds",
                StoredAmount = 0,
                UsuallyOnHand = false
            });
            Ingredients.Add(new Ingredient
            {
                IngredientId = 6,
                DisplayIndex = 5,
                Department = "Produce",
                Expiry = 0,
                isHeading = false,
                IsStored = false,
                Name = "Scallions",
                StoredAmount = 0,
                UsuallyOnHand = false
            });

            #endregion

            #region Recipe Ingrediences

            Recipe_Ingredience firstRecipeIngredience = new Recipe_Ingredience
            {
                id = 1,
                RecipeId = 2,
                IngredientId = 1,
                DisplayQuantity = "1/3",
                Unit = "cup",
                MetricDisplayQuantity = 79,
                MetricQuantity = 79,
                Quantity = 0.333,
                MetricUnit = "ml"
            };
            RecipeIngredients.Add(firstRecipeIngredience);
            RecipeIngredients.Add(new Recipe_Ingredience
            {
                id = 2,
                RecipeId = 2,
                IngredientId = 2,
                DisplayQuantity = "1/4",
                Unit = "cup",
                MetricDisplayQuantity = 59,
                MetricQuantity = 59,
                Quantity = 0.25,
                MetricUnit = "ml"
            });
            RecipeIngredients.Add(new Recipe_Ingredience
            {
                id = 3,
                RecipeId = 2,
                IngredientId = 3,
                DisplayQuantity = "1/3",
                Unit = "cup",
                MetricDisplayQuantity = 79,
                MetricQuantity = 79,
                Quantity = 0.333,
                MetricUnit = "ml"
            });
            RecipeIngredients.Add(new Recipe_Ingredience
            {
                id = 4,
                RecipeId = 3,
                IngredientId = 4,
                DisplayQuantity = "1 1/2",
                Unit = "cup",
                MetricDisplayQuantity = 22,
                MetricQuantity = 22,
                Quantity = 1.5,
                MetricUnit = "ml"
            });
            RecipeIngredients.Add(new Recipe_Ingredience
            {
                id = 5,
                RecipeId = 4,
                IngredientId = 5,
                DisplayQuantity = "1",
                Unit = "cup",
                MetricDisplayQuantity = 15,
                MetricQuantity = 15,
                Quantity = 1,
                MetricUnit = "ml"
            });
            RecipeIngredients.Add(new Recipe_Ingredience
            {
                id = 6,
                RecipeId = 5,
                IngredientId = 6,
                DisplayQuantity = "4",
                Unit = null,
                MetricDisplayQuantity = 4,
                MetricQuantity = 4,
                Quantity = 1,
                MetricUnit = ""
            });
            RecipeIngredients.Add(new Recipe_Ingredience
            {
                id = 7,
                RecipeId = 6,
                IngredientId = 7,
                DisplayQuantity = null,
                Unit = null,
                MetricDisplayQuantity = 0,
                MetricQuantity = 0,
                Quantity = 1,
                MetricUnit = ""
            });

            #endregion
        }

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
            int idNumber = int.Parse(id);
            Recipe exsistingRecipe = Recipies.FirstOrDefault(b => b.RecipeId == idNumber);
            if (exsistingRecipe == null) webContext.OutgoingResponse.StatusCode = HttpStatusCode.NotFound;
            exsistingRecipe.Title = recipe.Title;
            exsistingRecipe.Category = recipe.Category;
            exsistingRecipe.Cusine = recipe.Cusine;
            exsistingRecipe.SubCategory = recipe.SubCategory;

            return exsistingRecipe;
        }

        public Ingredient UpdateIngredient(string id, Ingredient ingredient)
        {
            int idNumber = int.Parse(id);
            Ingredient exsistIngredient = Ingredients.FirstOrDefault(b => b.IngredientId == idNumber);
            if(exsistIngredient == null)webContext.OutgoingResponse.StatusCode = HttpStatusCode.NotFound;
            exsistIngredient.IsStored = ingredient.IsStored;
            exsistIngredient.Name = ingredient.Name;
            exsistIngredient.Department = ingredient.Department;
            exsistIngredient.DisplayIndex = ingredient.DisplayIndex;
            exsistIngredient.Expiry = ingredient.Expiry;
            exsistIngredient.StoredAmount = ingredient.StoredAmount;
            exsistIngredient.UsuallyOnHand = ingredient.UsuallyOnHand;

            return exsistIngredient;
        }


        public Recipe DeleteRecipe(string id)
        {
            Recipe recipe = GetRecipe(id);
            if(recipe == null) webContext.OutgoingResponse.StatusCode = HttpStatusCode.NotFound;
            bool removed = Recipies.Remove(recipe);
            if(removed) return recipe;
            return null;
        }

        public Ingredient DeleteIngredient(string id)
        {
            Ingredient ingredient = GetIngredient(id);
            if(ingredient== null) webContext.OutgoingResponse.StatusCode = HttpStatusCode.NotFound;
            bool removed = Ingredients.Remove(ingredient);
            if(removed) return ingredient;
            return null;
        }
    }
}
