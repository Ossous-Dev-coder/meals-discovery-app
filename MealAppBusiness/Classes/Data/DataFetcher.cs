using MealAppBusiness;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MealAppBusiness.Classes;
using MealsApp.Classes;


namespace MealsApp
{
	 
	public static class DataFetcher
	{
		static readonly HttpClient httpClient = new HttpClient();

		public static async Task<CategoriesContainer> Fetch(string url)
		{
			try
			{
				var response = await httpClient.GetAsync($"{url}");

				if (response.IsSuccessStatusCode)
				{
					string json = await response.Content.ReadAsStringAsync();

					if (string.IsNullOrWhiteSpace(json)) return default;

					return Deserializer.Deserialize<CategoriesContainer>(json);
				}
				else
				{
					App.ErrorsLoggingService.Log($"HTTP request to {url} failed: {response.StatusCode}");
				}

			}
			catch (Exception ex)
			{
				App.ErrorsLoggingService.Log(ex.ToString());
			}

			return default;
		}

		public static async Task<MealsContainer<Meal>> Fetch(string url, string Category) 
		{
			try
			{
				var response = await httpClient.GetAsync($"{url}{Category}");

				if (response.IsSuccessStatusCode)
				{
					string json = await response.Content.ReadAsStringAsync();

					if (string.IsNullOrWhiteSpace(json)) return default;

					return Deserializer.Deserialize<MealsContainer<Meal>>(json);
				}
				else
				{
					App.ErrorsLoggingService.Log($"HTTP request to {url} failed: {response.StatusCode}");
				}

			}
			catch (Exception ex)
			{
				App.ErrorsLoggingService.Log(ex.ToString()); 
			}

			return default;
		} 

		public static async Task<MealsContainer<DetailedMeal>> FetchDetailedMeal(string url, string meal)
		{
			try
			{
				var response = await httpClient.GetAsync($"{url}{meal}");

				if (response.IsSuccessStatusCode)
				{
					string json = await response.Content.ReadAsStringAsync();

					if (string.IsNullOrWhiteSpace(json))
					
						return default;
					

					return Deserializer.DeserializeDetailedMeal(json);
				}
				else
				{
					App.ErrorsLoggingService.Log($"HTTP request to {url} failed: {response.StatusCode}");
				}

			}
			catch (Exception ex)
			{
				App.ErrorsLoggingService.Log(ex.ToString());
			}

			return default;
		}

	}
    
}
