using MealAppBusiness.Classes;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MealsApp.Classes
{
    public class InternetService
    {
        public static async Task<bool> CheckForConnection()
        {
			try
			{
				using (HttpClient client = new HttpClient())
				{
					client.Timeout = TimeSpan.FromSeconds(2);

					HttpResponseMessage response = await client.GetAsync(Config.CategoriesUrl);

					return response.IsSuccessStatusCode;
				}
			}
			catch
			{
				return false;
			}

		}
    }
}
