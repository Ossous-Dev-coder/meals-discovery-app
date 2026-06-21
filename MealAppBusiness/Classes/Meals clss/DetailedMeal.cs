using MealAppBusiness.Classes;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace MealsApp.Classes
{


	public class DetailedMeal : Meal
	{
		public string strCategory { get; set; }

		public string strInstructions { get; set; }

		public string strYoutube { get; set; }

		private JObject _jsonObj;

		public List<Ingredient> Ingredients { get; set; }


		public DetailedMeal()
		{
			Ingredients = new List<Ingredient>();
		}

		public void GetIngridents(JObject jsonObj)
		{
			_jsonObj = jsonObj;

			if (_jsonObj != null)
			{
				_getIngredients();
			}
		}


		private void _getIngredients()
		{
			Ingredients?.Clear();

			string ingredientName = null;

			string Measure = null;

			for (int i = 1; i < 20; i++)
			{
				ingredientName = (string)_jsonObj["meals"]?[0]?[$"strIngredient{i}"];

				if (string.IsNullOrEmpty(ingredientName)) continue;

				Measure = (string)_jsonObj["meals"]?[0]?[$"strMeasure{i}"];

				Ingredient ingredient = new Ingredient(ingredientName, Measure);

				if (ingredient.AlreadyExists(Ingredients)) continue;

				Ingredients.Add(ingredient);
			}
		}

	}
}
