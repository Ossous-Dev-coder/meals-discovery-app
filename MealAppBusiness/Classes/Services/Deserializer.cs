using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using MealsApp.Classes;


namespace MealAppBusiness.Classes
{

    internal static class Deserializer
    {



		public static  T Deserialize<T>(string json)
		{

			try
			{

				return JsonConvert.DeserializeObject<T>(json);

			}
			catch(Exception ex) 
			{

				App.ErrorsLoggingService.Log(ex.ToString());

				return default;
			}


		}

		public static  MealsContainer<DetailedMeal> DeserializeDetailedMeal(string json)
		{
			if (string.IsNullOrWhiteSpace(json)) return default;

			try
			{
				var deserializedObject = JsonConvert.DeserializeObject<MealsContainer<DetailedMeal>>(json);

				if (deserializedObject != null) 

					deserializedObject.JsonObj = JObject.Parse(json);

				return deserializedObject;
			}
			catch (Exception ex)
			{

				App.ErrorsLoggingService.Log(ex.ToString());

				return default;
			}

		}

	}
}
