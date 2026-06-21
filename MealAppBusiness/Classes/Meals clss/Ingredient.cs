using System.Collections.Generic;


namespace MealAppBusiness.Classes
{ 
	public class Ingredient
	{
		public string Name { get; set; }

		public string Measure { get; set; }

		private static string _thumbBaseUrl = Config.IngredientThumbBaseUrl;

		public string ThumbUrl => $"{_thumbBaseUrl}{Name}.{Config.IngThumbsExtentions}";

		public static bool operator ==(Ingredient ing1, Ingredient ing2)
		{
			return ing1.Name == ing2.Name && ing1.Measure == ing2.Measure;
		}

		public static bool operator !=(Ingredient ing1, Ingredient ing2)
		{
			return ing1.Name != ing2.Name && ing1.Measure != ing2.Measure;
		}

		public Ingredient(string Name, string Measure)
		{
			this.Name = Name;

			this.Measure = Measure; 
		}

		public bool AlreadyExists(List<Ingredient> list)
		{
			foreach (Ingredient ing in list)
			{
				if (ing == this)

					return true;
			}

			return false;
		}
	}
}
