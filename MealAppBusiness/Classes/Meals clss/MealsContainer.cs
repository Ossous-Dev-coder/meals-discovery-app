using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MealAppBusiness
{

	public class MealsContainer<T>
	{

		public List<T> meals;

		public JObject JsonObj { get; set; }
	}

}
