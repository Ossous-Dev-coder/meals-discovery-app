using System.Collections.Generic;
using MealAppBusiness.Classes;

namespace MealsApp
{
	public class CategoriesContainer
	{
		public List<Category> categories { get; set; }

		public List<Category> CategoriesList => categories;

	}
}
