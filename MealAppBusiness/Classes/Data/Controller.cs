using MealAppBusiness;
using MealAppBusiness.Classes;
using System.Threading.Tasks;
using MealsApp.Classes;


namespace MealsApp
{
    public static class Controller
    {

        public static async Task FetchCategories()
        {

            CategoriesContainer categoriesObj = await DataFetcher.Fetch(Config.CategoriesUrl);

            if (categoriesObj?.CategoriesList != null)
            {
                App.dataStore.categories.Clear();

                App.dataStore.categories = categoriesObj.CategoriesList;
            }

            else
                App.ErrorsLoggingService.Log("Categories Object was null !");
        }

		public static async Task FetchMeals(string Category)
		{

			MealsContainer<Meal> mealsObj = await DataFetcher.Fetch(Config.MealsUrl, Category);

            if (mealsObj?.meals != null)
            {
                App.dataStore.meals.Clear();

                App.dataStore.meals = mealsObj.meals;
            }

            else
                App.ErrorsLoggingService.Log("Meals Object was null !");
		}

		public static async Task<MealsContainer<DetailedMeal>> FetchMeal(string mealName)
		{

			MealsContainer<DetailedMeal> mealObj = await DataFetcher.FetchDetailedMeal(Config.SingleMealUrl, mealName);

            return mealObj;
		}


	}
}
