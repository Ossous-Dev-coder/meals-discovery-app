using System;
using System.Configuration;

namespace MealAppBusiness.Classes
{
	public static class Config
	{
		static public string LoggingSource => GetSittig("AppName");

		static public string CategoriesUrl => GetSittig("CategoriesUrl");

		static public string MealsUrl => GetSittig("MealsUrl");

		static public string SingleMealUrl => GetSittig("singleMealUrl");

		static public string IngredientThumbBaseUrl => GetSittig("IngredientThumbUrl");

		static public string IngThumbsExtentions => GetSittig("IngThumbsExtentions");

		private static string GetSittig(string key)
		{
			string value = ConfigurationManager.AppSettings[key];

			if (string.IsNullOrWhiteSpace(value))
			{
				throw new Exception($"Missing App Sitting Key {value}");
			}

			return value;
		}

	}
}
